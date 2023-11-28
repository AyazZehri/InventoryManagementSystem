using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(NameBox.Text == string.Empty && PhoneBox.Text == string.Empty) { MessageBox.Show("Please Fill the Boxes to Add Data"); return; }
            Query();
        }
        //DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();


        void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(General.ConString()))
            {
                conn.Open();

                string mySql = "SELECT * FROM customers ORDER BY CustomerID DESC;";

                MySqlCommand cmd = new MySqlCommand(mySql, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    CustomersDataGridView.DataSource = dt;
                }
            }
        }

        void Query()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();
                    string SqlQuery = "INSERT INTO Customers (CustomerID,Name, Phone) VALUES (@CustomerID,@Name,@Phone);";

                    MySqlCommand cmd = new MySqlCommand(SqlQuery, con);

                    cmd.Parameters.AddWithValue("@CustomerID", (getLastID() + 1));
                    cmd.Parameters.AddWithValue("@Name", NameBox.Text);
                    cmd.Parameters.AddWithValue("@Phone", PhoneBox.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains($"Duplicate entry '{NameBox.Text}' for key 'Name'"))
                {
                    MessageBox.Show("This Name is Already been Registered", "Caution!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ex.Message.Contains($"Duplicate entry '{PhoneBox.Text}' for key 'Phone'"))
                {
                    MessageBox.Show("This Phone No. is Already been Registered", "Caution!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message, "Customer Query", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally { LoadData(); }
        }

        private int getLastID()
        {
            int lastID = 0;
            try
            {

                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();
                    string sqlQuery = "SELECT CustomerID from Customers ORDER BY CustomerID DESC LIMIT 1; ";

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        lastID = Convert.ToInt32(result);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Get Last ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lastID;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CustomersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();

                    string query = "UPDATE Customers SET Name = @Name, Phone = @Phone WHERE CustomerID = @CustomerID";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@CustomerID", CustomersDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@Name", NameBox.Text);
                    cmd.Parameters.AddWithValue("@Phone", PhoneBox.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully", "Update ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void CustomersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NameBox.Text = CustomersDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            PhoneBox.Text = CustomersDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();

                    string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@CustomerID", CustomersDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Customer '{CustomersDataGridView.SelectedRows[0].Cells[1].Value}' Data Removed Successfully", "Remove ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameBox.Clear();
            PhoneBox.Clear();
        }

        private void SearchBox_OnIconRightClick(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "Select * FROM Customers WHERE Name LIKE " + "'" + SearchBox.Text + "%'";
            General.SearchControl(dt, query, SearchBox.Text, "@Name");
            if (dt.Rows.Count > 0)
            {
                CustomersDataGridView.DataSource = dt;
            }
            else { LoadData(); }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == string.Empty)
                LoadData();
        }
    }
}
