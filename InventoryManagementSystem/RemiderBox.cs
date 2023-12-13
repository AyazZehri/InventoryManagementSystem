using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace InventoryManagementSystem
{
    public partial class ReminderBox : Form
    {
        public ReminderBox()
        {
            InitializeComponent();
        }

        public string ID;

        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(General.ConString()))
                {
                    connection.Open();

                    string query = "SELECT Name, Phone FROM customers WHERE CustomerID = @CustomerID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", ID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                NameBox.Text = reader["Name"].ToString();
                                PhoneBox.Text = reader["Phone"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Customer not found");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReminderBox_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }

        private void SendReminder()
        {
            string MyUsername = "userxxx"; //Your Username At Sendpk.com 
            string MyPassword = "92***"; //Your Password At Sendpk.com 
            string toNumber = PhoneBox.Text; //Recepient cell phone number with country code 
            string Masking = "Al-Makkah Marble Shop"; //Your Company Brand Name 
            string MessageText = MsgBox.Text;
            string jsonResponse = SendSMS(Masking, toNumber, MessageText, MyUsername, MyPassword);
            Console.Write(jsonResponse);
        }

        public static string SendSMS(string Masking, string toNumber, string MessageText, string MyUsername, string MyPassword)
        {
            String URI = "http://sendpk.com" +
            "/api/sms.php?" +
            "username=" + MyUsername +
            "&password=" + MyPassword +
            "&sender=" + Masking +
            "&mobile=" + toNumber +
            "&message=" + Uri.UnescapeDataString(MessageText); // Visual Studio 10-15
            try
            {
                WebRequest req = WebRequest.Create(URI);
                WebResponse resp = req.GetResponse();
                var sr = new System.IO.StreamReader(resp.GetResponseStream());
                return sr.ReadToEnd().Trim();
            }
            catch (WebException ex)
            {
                var httpWebResponse = ex.Response as HttpWebResponse;
                if (httpWebResponse != null)
                {
                    switch (httpWebResponse.StatusCode)
                    {
                        case HttpStatusCode.NotFound:
                            return "404:URL not found :" + URI;
                            break;
                        case HttpStatusCode.BadRequest:
                            return "400:Bad Request";
                            break;
                        default:
                            return httpWebResponse.StatusCode.ToString();
                    }
                }
            }
            return null;
        }
    }
}
