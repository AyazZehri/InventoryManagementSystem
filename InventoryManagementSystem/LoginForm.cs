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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static string username;

        private void Login()
        {

            if (UserTextBox.Text == string.Empty || PasswordTextBox.Text == string.Empty)
            {
                MessageBox.Show("All Fields Are Required", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    MySqlConnection con = new MySqlConnection(General.ConString());

                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE Username=@Username", con);
                    cmd.Parameters.AddWithValue("@Username", UserTextBox.Text);


                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Invalid Username", "Caution!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        reader.Read();
                        string passFromDatabase = reader.GetString("Password");

                        if (PasswordTextBox.Text == passFromDatabase)
                        {
                            MainForm main = new MainForm();
                            username = UserTextBox.Text;
                          
                            this.Hide();
                            main.Show();

                        }
                        else
                        {
                            MessageBox.Show("Invalid Password", "Caution!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Run Xampp Services or " + ex.Message);
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void PasswordTextBox_OnIconRightClick(object sender, EventArgs e)
        {

        }
    }
}
