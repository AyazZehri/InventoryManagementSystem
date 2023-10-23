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
                    ProductsGridView.DataSource = dt;
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
    }
}
