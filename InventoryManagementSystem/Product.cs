using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();

        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuShadowPanel6_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Query();
        }

        string Refsql;

        private float GetLastID()
        {
            int lastID = 0;

            try
            {

                MySqlConnection connection = new MySqlConnection(General.ConString());
                connection.Open();

                Refsql = $"SELECT ID FROM Products ORDER BY ID DESC LIMIT 1";


                MySqlCommand cmd = new MySqlCommand(Refsql, connection);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    lastID = Convert.ToInt16(result);
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
                string query = "INSERT INTO Products (ID,Name,Type,Quality,Quantity,Price) VALUES (@ID,@Name,@Type,@Quality,@Quantity,@Price)";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("ID", GetLastID() + 1);
                cmd.Parameters.AddWithValue("Name", NameBox.Text);
                cmd.Parameters.AddWithValue("Type", TypeBox.Text);
                cmd.Parameters.AddWithValue("Quality", QualityBox.Text);
                cmd.Parameters.AddWithValue("Quantity", QuantityBox.Text);
                cmd.Parameters.AddWithValue("Price", PriceBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added to Inventory", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(General.ConString());

                con.Open();

                string sql = "SELECT * From products";

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
                        ItemList.Controls.Add(item);
                    }


                    //ProductsGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Re Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            /*  try
              {
                  string ID = ProductsGridView.SelectedRows[0].Cells[0].Value.ToString();

                  MySqlConnection con = new MySqlConnection(General.ConString());
                  con.Open();

                  string MySqlCommand = "UPDATE `products` SET `ID` = '@ID', `Name` = '@Name', `Type` = '@Type', `Quality` = '@Quality', `Quantity` = '@Quantity', `Price` = '@Price' WHERE `products`.`ID` = @ID;";

                  MySqlCommand cmd = new MySqlCommand(MySqlCommand, con);
                  cmd.Parameters.AddWithValue("@ID", ID);
                  cmd.Parameters.AddWithValue("@Name", NameBox.Text);
                  cmd.Parameters.AddWithValue("@Type", TypeBox.Text);
                  cmd.Parameters.AddWithValue("@Quality", QualityBox.Text);
                  cmd.Parameters.AddWithValue("@Quantity", QuantityBox.Text);
                  cmd.Parameters.AddWithValue("@Price", PriceBox.Text);

                  cmd.ExecuteNonQuery();

                  MessageBox.Show("Data Updated Successfully", "Update ", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }*/
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
                /*string ID = ProductsGridView.SelectedRows[0].Cells[0].Value.ToString();

                MySqlConnection conn = new MySqlConnection(General.ConString());
                conn.Open();

                string MySqlQuery = "DELETE FROM products WHERE `products`.`ID` = @ID ";

                MySqlCommand cmd = new MySqlCommand(MySqlQuery, conn);

                cmd.Parameters.AddWithValue("ID", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();*/

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
