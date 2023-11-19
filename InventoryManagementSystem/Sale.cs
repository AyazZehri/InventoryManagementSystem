using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }

        float rate, quantity, total, dues, paid, net;

        private void LoadDataCustomers()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(General.ConString());

                con.Open();

                string sql = "SELECT * FROM `Customers` ORDER BY CustomerID DESC;";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    CustomersGridView.DataSource = dt;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Re Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadDataProductsAsync()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    await con.OpenAsync();
                    string sql = "SELECT * FROM products ORDER BY ID DESC;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        await adapter.FillAsync(dt);

                        if (dt.Rows.Count > 0)
                        {
                            ItemList.SuspendLayout(); // Suspend layout for bulk updates

                            ItemList.Controls.Clear();

                            foreach (DataRow dr in dt.Rows)
                            {
                                ItemCard item = new ItemCard
                                {
                                    ID = dr[0].ToString(),
                                    ItemName = dr[1].ToString(),
                                    Type = dr[2].ToString(),
                                    Quality = dr[3].ToString(),
                                    Quantity = dr[4].ToString(),
                                    Price = dr[5].ToString()
                                };
                                item.Click += onClickItem;

                                ItemList.Controls.Add(item);
                            }

                            ItemList.ResumeLayout(); // Resume layout after bulk updates
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }


        private ItemCard selectedCard;

        private void onClickItem(object sender, EventArgs e)
        {
            if (sender is ItemCard clickedItem)
            {
                if (selectedCard != null)
                {
                    selectedCard.BackColor = SystemColors.Control;
                }

                clickedItem.BackgroundColor = Color.LightSlateGray;

                selectedCard = clickedItem;

                ProductIDLabel.Text = clickedItem.ID;
                ProductNameBox.Text = clickedItem.ItemName;
                TypeBox.Text = clickedItem.Type;
                QualityBox.Text = clickedItem.Quality;
                QuantityBox.Text = clickedItem.Quantity;
                RateBox.Text = clickedItem.Price;


            }
        }

        private void CustomersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIDLabel.Text = CustomersGridView.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameBox.Text = CustomersGridView.SelectedRows[0].Cells[1].Value.ToString();

        }

        private async void Sale_Load(object sender, EventArgs e)
        {
            LoadDataCustomers();
            await LoadDataProductsAsync();
        }

        private void ProductsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void QuantityBox_ValueChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void PaidAmountBox_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        void calculate()
        {
            rate = General.ConvertToInt(RateBox.Text);
            quantity = General.ConvertToInt(QuantityBox.Text);

            paid = General.ConvertToInt(PaidAmountBox.Text);
            /* dues = General.ConvertToInt(DuesBox.Text);*/

            total = rate * quantity;

            dues = total - paid;

            net = total - dues;

            TotalAmountBox.Text = total.ToString();

            DuesBox.Text = dues.ToString();

            NetAmountBox.Text = net.ToString();


        }

        private void Query()
        {
            /* try
             {*/
            using (MySqlConnection con = new MySqlConnection(General.ConString()))
            {
                con.Open();

                string sqlQuery = "INSERT INTO `sale_ledger` (`Ref_No`, `Date`, `Customer_Name`, `Customer_ID`, `Product_Name`, `Product_ID`, `Type`, `Quality`, `Quantity`, `Price_Per_Unit`, `Total_Price`, `Dues`, `Net_Amount`) VALUES " +
                                                             "(@Ref_No , @Date, @Customer_Name , @Customer_ID , @Product_Name , @Product_ID , @Type , @Quality , @Quantity , @Price_Per_Unit , @Total_Price , @Dues , @Net_Amount );";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@Ref_No", (GetLastRef() + 1));
                cmd.Parameters.AddWithValue("@Date", DatePicker.Value);
                cmd.Parameters.AddWithValue("@Customer_Name", CustomerNameBox.Text);
                cmd.Parameters.AddWithValue("@@Customer_ID", CustomerIDLabel.Text);
                cmd.Parameters.AddWithValue("@Product_Name", ProductNameBox.Text);
                cmd.Parameters.AddWithValue("@Product_ID", ProductIDLabel.Text);
                cmd.Parameters.AddWithValue("@Type", TypeBox.Text);
                cmd.Parameters.AddWithValue("@Quality", QualityBox.Text);
                cmd.Parameters.AddWithValue("@Quantity", QuantityBox.Text);
                cmd.Parameters.AddWithValue("@Price_Per_Unit", RateBox.Text);
                cmd.Parameters.AddWithValue("@Total_Price", TotalAmountBox.Text);
                cmd.Parameters.AddWithValue("@Dues", TotalAmountBox.Text);
                cmd.Parameters.AddWithValue("@Net_Amount", NetAmountBox.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Details Have been Saved to Database");
            }

            /* }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
        }

        private int GetLastRef()
        {
            int lastRef = 0;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(General.ConString()))
                {
                    connection.Open();

                    string Refsql = $"SELECT Ref_No FROM sale_ledger ORDER BY Ref_No DESC LIMIT 1";


                    MySqlCommand cmd = new MySqlCommand(Refsql, connection);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        lastRef = Convert.ToInt16(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return lastRef;
        }
    }
}
