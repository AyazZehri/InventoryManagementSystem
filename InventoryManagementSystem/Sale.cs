using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        int rate, quantity, total, dues, paid, net, maxQuantity;
        //bool hasRows = false;


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
                else
                {
                    MessageBox.Show("No Data Found");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Re Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductsSearchBox_OnIconRightClick(object sender, EventArgs e)
        {
            DataTable productsTable = new DataTable();
            string query = "SELECT * FROM products WHERE Name LIKE " + "'" + ProductsSearchBox.Text + "%'";
            General.SearchControl(productsTable, query, ProductsSearchBox.Text, "@Name");

            if (productsTable.Rows.Count > 0)
            {

                ItemList.Controls.Clear();


                foreach (DataRow dr in productsTable.Rows)
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
            }
            else
            {
                MessageBox.Show($"No Data Like {CustomerSearchBox.Text} found");
                LoadDataProducts();
            }


        }

        private void LoadDataProducts()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();
                    string sql = "SELECT * FROM products ORDER BY ID DESC;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    DataTable dt = new DataTable();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {

                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {

                            ItemList.Controls.Clear();
                            ItemList.SuspendLayout();

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
                            ItemList.ResumeLayout(true);
                            ItemList.PerformLayout();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                maxQuantity = Convert.ToInt32(clickedItem.Quantity);
                RateBox.Text = clickedItem.Price;

                QuantityBox.Maximum = maxQuantity;


            }
        }

        private void CustomersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }
       
        private void Sale_Load(object sender, EventArgs e)
        {
           
            LoadDataCustomers();
            LoadDataProducts();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Query();
            OrderQuery();
            quantityRemoveQuery();
        }

        bool maxValueZeroHandle = false;
        private void QuantityBox_ValueChanged(object sender, EventArgs e)
        {
            if (maxQuantity == 0)
            {
                if (!maxValueZeroHandle)
                {
                    maxValueZeroHandle = true;
                    QuantityBox.Value = 0;
                    MessageBox.Show($"Please Select any Product");
                }

            }
            else
            {
                maxValueZeroHandle = false;

                calculate();
                if (QuantityBox.Value == QuantityBox.Maximum)
                {
                    MessageBox.Show($"Maximum Quantity of {ProductNameBox.Text} is {maxQuantity}");
                    QuantityBox.Value = QuantityBox.Maximum;
                    calculate();
                }
               
            }

            maxValueZeroHandle = false;

            if(QuantityBox.Value == QuantityBox.Maximum)
            {

            }
        }


        private void CustomerSearchBox_OnIconRightClick(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "Select * FROM Customers WHERE Name LIKE " + "'" + CustomerSearchBox.Text + "%'";
            General.SearchControl(dt, query, CustomerSearchBox.Text, "@Name");
            if (dt.Rows.Count > 0)
            {
                CustomersGridView.DataSource = dt;
            }
            else { LoadDataCustomers(); }
        }

        private void CustomerSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomerSearchBox.Text == string.Empty)
            {
                LoadDataCustomers();
            }
        }



        private void ProductsSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (ProductsSearchBox.Text == string.Empty)
            {
                LoadDataProducts();
            }
        }

        private void CustomersGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIDLabel.Text = CustomersGridView.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameBox.Text = CustomersGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

      
        private void InvoiceBtn_Click(object sender, EventArgs e)
        {
            using(PrintForm print = new PrintForm())
            {
                print.date = DatePicker.Value.ToString();
                print.Ref = "Ref_No: " + (GetLastRef() + 1).ToString();
                print.Product = ProductNameBox.Text;
                print.Customer = CustomerNameBox.Text;
                print.Type = CustomerNameBox.Text;
                print.Quality = QualityBox.Text;
                print.Quantity = QuantityBox.Text;
                print.UnitPrice = RateBox.Text;
                print.TotalAmount = TotalAmountBox.Text;
                print.PaidAmount = PaidAmountBox.Text;
                print.Dues = DuesBox.Text;
                print.NetAmount = NetAmountBox.Text;
                print.ShowDialog();
            }
        }

        private void PaidAmountBox_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        void calculate()
        {
            rate = General.ConvertToInt(RateBox.Text);
            /*if (quantity <= maxQuantity - 1)
            { quantity = General.ConvertToInt(QuantityBox.Text); }*/
            QuantityBox.Maximum = maxQuantity;

            quantity = (int)QuantityBox.Value;

            paid = General.ConvertToInt(PaidAmountBox.Text);
            /* dues = General.ConvertToInt(DuesBox.Text);*/

            total = rate * quantity;

            dues = total - paid;

            net = total - dues;

            /*if (quantity > maxQuantity - 1)
            {
                quantity = maxQuantity;
                MessageBox.Show("Max Quantity is " + maxQuantity);
                QuantityBox.Text = maxQuantity.ToString();
            }*/
            TotalAmountBox.Text = total.ToString();

            DuesBox.Text = dues.ToString();

            NetAmountBox.Text = net.ToString();


        }

        private void quantityRemoveQuery()
        {
            try
            {
                using(MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();
                    string sql = $"Update products SET Quantity= Quantity-{QuantityBox.Value} WHERE ID = {ProductIDLabel.Text}";
                    MySqlCommand cmd = new MySqlCommand(sql,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"{QuantityBox.Value} items Has been Removed From Product: {ProductNameBox.Text} Stock");

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                cmd.Parameters.AddWithValue("@Customer_ID", CustomerIDLabel.Text);
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
                
                MessageBox.Show("Records Have been Saved to Ledger");
            }

            /* }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
        }

        private void OrderQuery()
        {
            /* try
             {*/

            string status = "In Progress";
            using (MySqlConnection con = new MySqlConnection(General.ConString()))
            {
                con.Open();

                string sqlQuery = "INSERT INTO `orders` (`Order_No`, `Date`, `Customer_Name`,  `Product_Name`, `Type`, `Quality`, `Quantity`, `Price_Per_Unit`, `Total_Amount`, `Dues`, `Net_Amount`,`Status`) VALUES " +
                                                             "(@Order_No , @Date, @Customer_Name , @Product_Name , @Type , @Quality , @Quantity , @Price_Per_Unit , @Total_Amount , @Dues , @Net_Amount,@Status );";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@Order_No", (GetLastOrderNo() + 1));
                cmd.Parameters.AddWithValue("@Date", DatePicker.Value);
                cmd.Parameters.AddWithValue("@Customer_Name", CustomerNameBox.Text);
                cmd.Parameters.AddWithValue("@Product_Name", ProductNameBox.Text);
                cmd.Parameters.AddWithValue("@Type", TypeBox.Text);
                cmd.Parameters.AddWithValue("@Quality", QualityBox.Text);
                cmd.Parameters.AddWithValue("@Quantity", QuantityBox.Text);
                cmd.Parameters.AddWithValue("@Price_Per_Unit", RateBox.Text);
                cmd.Parameters.AddWithValue("@Total_Amount", TotalAmountBox.Text);
                cmd.Parameters.AddWithValue("@Dues", TotalAmountBox.Text);
                cmd.Parameters.AddWithValue("@Net_Amount", NetAmountBox.Text);
                cmd.Parameters.AddWithValue("@Status", status);


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

        private int GetLastOrderNo()
        {
            int lastOrderNo = 0;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(General.ConString()))
                {
                    connection.Open();

                    string Refsql = $"SELECT Order_No FROM orders ORDER BY Order_No DESC LIMIT 1";


                    MySqlCommand cmd = new MySqlCommand(Refsql, connection);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        lastOrderNo = Convert.ToInt16(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return lastOrderNo;
        }
    }
}
