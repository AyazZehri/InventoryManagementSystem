using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();

        }

        int price, total, quantity, id;

        private void AddButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<=50;i++)
            {
                Query();
            }
            
        }

        string Refsql;

        private int GetLastID()
        {
            int lastID = 0;

            try
            {

                using (MySqlConnection connection = new MySqlConnection(General.ConString()))
                {
                    connection.Open();

                    Refsql = $"SELECT ID FROM Products ORDER BY ID DESC LIMIT 1";


                    MySqlCommand cmd = new MySqlCommand(Refsql, connection);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        lastID = Convert.ToInt16(result);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Get Last ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lastID;
        }
        private void Query()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(General.ConString());
                con.Open();
                string query = "INSERT INTO Products (ID,Name,Type,Quality,Quantity,Price_Per_Unit,Total_Amount) VALUES (@ID,@Name,@Type,@Quality,@Quantity,@Price_Per_Unit,@Total_Amount)";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("ID", (GetLastID() + 1));
                cmd.Parameters.AddWithValue("Name", NameBox.Text);
                cmd.Parameters.AddWithValue("Type", TypeBox.Text);
                cmd.Parameters.AddWithValue("Quality", QualityBox.Text);
                cmd.Parameters.AddWithValue("Quantity", QuantityBox.Text);
                cmd.Parameters.AddWithValue("Price_Per_Unit", PriceBox.Text);
                cmd.Parameters.AddWithValue("Total_Amount", total);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Product Successfully Added to Inventory", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //LoadData();
            }
        }

       

        private void LoadData()
        {
            List<ItemCard> cards = new List<ItemCard>();
            
            try
            {
                MySqlConnection con = new MySqlConnection(General.ConString());

                con.Open();

                string sql = "SELECT * FROM `products` ORDER BY ID DESC;";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);


                if (dt.Rows.Count > 0)
                {

                    ItemList.Controls.Clear();

                    foreach (DataRow dr in dt.Rows)
                    {
                        ItemCard item = new ItemCard();
                        item.ID = dr[0].ToString();
                        item.ItemName = dr[1].ToString();
                        item.Type = dr[2].ToString();
                        item.Quality = dr[3].ToString();
                        item.Quantity = dr[4].ToString();
                        item.Price = dr[5].ToString();
                        item.Click += onClickItem;
                        cards.Add(item);
                        //ItemList.Controls.Add(item);
                       
                    }
                    ItemList.Controls.AddRange(cards.ToArray());
                    //ProductsGridView.DataSource = dt;
                }

                clearBox();
                id = (GetLastID() + 1);
                idLabel.Text = id.ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Re Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Product_Load(object sender, EventArgs e)
        {
            
            LoadData();
            idLabel.Text = (GetLastID() + 1).ToString();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            
        }
        private ItemCard selectedCard;

        void onClickItem(object sender, EventArgs e)
        {
            if (sender is ItemCard clickedItem)
            {

                // Revert color of the previously selected item
                if (selectedCard != null)
                {
                    selectedCard.BackColor = SystemColors.Control;
                }

                clickedItem.BackgroundColor = Color.LightSlateGray;

                selectedCard = clickedItem;

                id = Convert.ToInt16(clickedItem.ID);
                NameBox.Text = clickedItem.ItemName;
                TypeBox.Text = clickedItem.Type;
                QualityBox.Text = clickedItem.Quality;
                QuantityBox.Text = clickedItem.Quantity;
                PriceBox.Text = clickedItem.Price;

                idLabel.Text = clickedItem.ID;

            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (id <= 0) { MessageBox.Show("Please Select any Item to Update"); return; }


                MySqlConnection con = new MySqlConnection(General.ConString());
                con.Open();

                string MySqlCommand = "UPDATE  products  SET  Name  = @Name,  Type  = @Type,  Quality  = @Quality, Quantity = @Quantity,  Price_Per_Unit  = @Price_Per_Unit, Total_Amount = @Total_Amount WHERE  products . ID  = @ID;";

                MySqlCommand cmd = new MySqlCommand(MySqlCommand, con);
                cmd.Parameters.AddWithValue("@ID", id.ToString());
                cmd.Parameters.AddWithValue("@Name", NameBox.Text);
                cmd.Parameters.AddWithValue("@Type", TypeBox.Text);
                cmd.Parameters.AddWithValue("@Quality", QualityBox.Text);
                cmd.Parameters.AddWithValue("@Quantity", QuantityBox.Text);
                cmd.Parameters.AddWithValue("@Price_Per_Unit", PriceBox.Text);
                cmd.Parameters.AddWithValue("@Total_Amount", TotalBox.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Updated Successfully", "Update ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadData();
        }

        private void ProductsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* NameBox.Text = ProductsGridView.SelectedRows[0].Cells[1].Value.ToString();
             TypeBox.Text = ProductsGridView.SelectedRows[0].Cells[2].Value.ToString();
             QualityBox.Text = ProductsGridView.SelectedRows[0].Cells[3].Value.ToString();
             QuantityBox.Text = ProductsGridView.SelectedRows[0].Cells[4].Value.ToString();
             PriceBox.Text = ProductsGridView.SelectedRows[0].Cells[5].Value.ToString();*/
        }



        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (id <= 0) { MessageBox.Show("Please Select an Item to Remove"); return; }
                string ID = id.ToString();

                MySqlConnection conn = new MySqlConnection(General.ConString());
                conn.Open();

                string MySqlQuery = "DELETE FROM products WHERE `ID` = @ID ";

                MySqlCommand cmd = new MySqlCommand(MySqlQuery, conn);

                cmd.Parameters.AddWithValue("ID", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            clearBox();
            id = (GetLastID() + 1);
            idLabel.Text = id.ToString();
        }

        private void TotalBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void PriceBox_TextChanged(object sender, EventArgs e)
        {
            price = General.ConvertToInt(PriceBox.Text);
            quantity = General.ConvertToInt(QuantityBox.Text);

            total = price * quantity;

            TotalBox.Text = total.ToString("C");
        }

        void clearBox()
        {

            BunifuTextBox[] boxes = { NameBox, TypeBox, PriceBox, QualityBox, QuantityBox, TotalBox };

            foreach (BunifuTextBox box in boxes)
            {
                box.Clear();
            }
        }
    }
}
