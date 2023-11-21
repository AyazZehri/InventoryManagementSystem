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
    public partial class SaleLedger : Form
    {
        public SaleLedger()
        {
            InitializeComponent();
        }

        private void SaleLedger_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();

                    string sqlQuery = "SELECT * FROM sale_ledger ORDER BY Date";

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        SaleLedgerGrid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void SearchBox_OnIconRightClick(object sender, EventArgs e)
        {
            string x = "";
            if (RadioCustomer.Checked)
            {
                x = "Customer_Name";
            }
            else { x = "Product_Name"; }
            string query = $"SELECT * FROM sale_ledger WHERE {x} LIKE '{SearchBox.Text}%'";
            DataTable dt = new DataTable();

            General.SearchControl(dt, query, SearchBox.Text, $"@{x}");

            if (dt.Rows.Count > 0)
            {
                SaleLedgerGrid.DataSource = dt;
            }
            else { LoadData(); }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == string.Empty)
            {
                LoadData();
            }
        }
    }
}
