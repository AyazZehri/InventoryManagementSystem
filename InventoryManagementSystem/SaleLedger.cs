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
                        DataGridViewImageColumn button = new DataGridViewImageColumn();
                        button.Name = "Delete";
                        button.HeaderText = "Delete";
                        button.Width = 25;
                     
                        button.ImageLayout = DataGridViewImageCellLayout.Zoom;


                        if (!SaleLedgerGrid.Columns.Contains("Delete"))
                        {
                            SaleLedgerGrid.Columns.Add(button);
                        }
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

        private void Remove(string Ref_No)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();
                   
                    string removeQuery = "DELETE FROM sale_Ledger WHERE Ref_No = @Ref_No";
                    MySqlCommand cmd = new MySqlCommand(removeQuery, con);

                    
                    cmd.Parameters.AddWithValue("@Ref_No", Ref_No);
                   

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove From Ledger");
            }
        }
        private void SaleLedgerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Ref_No = SaleLedgerGrid.SelectedRows[0].Cells[1].Value.ToString();
            if (e.ColumnIndex == SaleLedgerGrid.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (Convert.ToInt16(Ref_No) == 1000)
                { MessageBox.Show("Cannot Remove Last Entry"); return;}
                Remove(Ref_No);
                LoadData();
                //int rowIndexToDelete = e.RowIndex;
                //OrdersDataGrid.Rows.RemoveAt(rowIndexToDelete);
            }
        }

        private void SaleLedgerGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row in SaleLedgerGrid.Rows)
            {
                row.Cells["Delete"].Value = Properties.Resources.Close;
            }
        }
    }
}
