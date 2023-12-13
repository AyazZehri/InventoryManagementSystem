using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class StockRefill : Form
    {
       
        public StockRefill()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(QuantityRBox.Text != string.Empty )
            {
                if (!Regex.IsMatch(QuantityRBox.Text, "[a-zA-Z]"))
                {
                    Refill();
                    DialogResult = DialogResult.OK;
                    MessageBox.Show($"The Product {Item_Name} Quantity has been Updated");
                }
                else { MessageBox.Show($"Invalid Input"); }
            }
        }

        public string Item_Name;
        public string Quantity
        {
            get { return QuantityRBox.Text; }
            set { QuantityRBox.Text = value; }

        }

        public string ID;

        private void Refill()
        {
            try
            {
                using(MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();

                    string query = $"UPDATE products SET Quantity = Quantity + {Quantity} WHERE ID = {ID};";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Product Stock is Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MsgText_Click(object sender, EventArgs e)
        {

        }

        private void StockRefill_Load(object sender, EventArgs e)
        {
            MsgText.Text = $"Do you want to Update the Quantity of Product {Item_Name}?";
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
