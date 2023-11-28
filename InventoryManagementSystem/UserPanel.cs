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
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }


        void Query()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();
                    string SqlQuery = "INSERT INTO Users (UserID,Username, Password) VALUES (@UserID,@Username,@Password);";

                    MySqlCommand cmd = new MySqlCommand(SqlQuery, con);

                    cmd.Parameters.AddWithValue("@UserID", (getLastID() + 1));
                    cmd.Parameters.AddWithValue("@Username", UsernameBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PassBox.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Data Inserted Successfly", "Caution!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                if (ex.Message.Contains($"Duplicate entry '{UsernameBox.Text}' for key 'Name'"))
                {
                    MessageBox.Show("This Name is Already been Registered", "Caution!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ex.Message.Contains($"Duplicate entry '{PassBox.Text}' for key 'Phone'"))
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


        void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(General.ConString()))
            {
                conn.Open();

                string mySql = "SELECT * FROM users ORDER BY UserID DESC;";

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

        private int getLastID()
        {
            int lastID = 0;
            try
            {

                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();
                    string sqlQuery = "SELECT UserID from users ORDER BY UserID DESC LIMIT 1; ";

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text != string.Empty && PassBox.Text != string.Empty && ConfirmBox.Text != string.Empty)
            {
                if (PassBox.Text == ConfirmBox.Text)
                {
                    Query();
                }
                else { MessageBox.Show("Password and Confirm Password Does not Match"); }

            }
            else { MessageBox.Show("Please Fill All the Boxes to Continue"); }
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void UpdateData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();

                    string query = "UPDATE users SET Username = @Username, Password = @Password WHERE UserID = @UserID";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@UserID", CustomersDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@Username", UsernameBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PassBox.Text);

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
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text != string.Empty && PassBox.Text != string.Empty && ConfirmBox.Text != string.Empty)
            {
                if (PassBox.Text == ConfirmBox.Text)
                {
                    UpdateData();
                }
                else { MessageBox.Show("Password and Confirm Password Does not Match"); }

            }
            else { MessageBox.Show("Please Fill All the Boxes to Continue"); }
            
        }

        void Remove()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();

                    string query = "DELETE FROM users WHERE UserID = @UserID";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@UserID", CustomersDataGridView.SelectedRows[0].Cells[0].Value.ToString());

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

        private void RemoveButton_Click(object sender, EventArgs e)
        {

           Remove();
        }

        void ClearBox()
        {
            UsernameBox.Clear();
            PassBox.Clear();
            ConfirmBox.Clear();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearBox();
        }
    }
}
