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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        bool temp=true;

        private void Orders_Load(object sender, EventArgs e)
        {
            LoadData();
            OrdersDataGrid.CellClick += OrdersDataGrid_CellClick;
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();

                    string sqlQuery = "SELECT * FROM orders ORDER BY Date";

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        OrdersDataGrid.DataSource = dt;

                        if (!temp)
                            return;

                        temp = false;
                        DataGridViewImageColumn button = new DataGridViewImageColumn();
                        button.Name = "Check";
                        button.HeaderText = "Check";
                        button.ImageLayout = DataGridViewImageCellLayout.Normal;


                        if (!OrdersDataGrid.Columns.Contains("Check"))
                        {
                            OrdersDataGrid.Columns.Add(button);
                        }

                        

                       

                        /*DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                        deleteButtonColumn.Name = "Check";
                        deleteButtonColumn.HeaderText = "";
                        deleteButtonColumn.Text = "Complete";
                        deleteButtonColumn.UseColumnTextForButtonValue = true;
                        OrdersDataGrid.Columns.Add(deleteButtonColumn);*/
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Load Data");

            }


        }

        private void OrderStatus(string orderNo)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();
                    string status = "";

                    string removeQuery = "UPDATE Orders SET Status = @Status WHERE Order_No = @Order_No";
                    MySqlCommand cmd = new MySqlCommand(removeQuery, con);

                    if (OrdersDataGrid.SelectedRows[0].Cells["Status"].Value.ToString() == "Complete") 
                    {
                        status = "In Progress";
                    }
                    else { status = "Complete"; }
                    cmd.Parameters.AddWithValue("@Order_No", orderNo);
                    cmd.Parameters.AddWithValue("@Status", status);

                    cmd.ExecuteNonQuery();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Complete");
            }
        }

        private void OrdersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string orderNo = OrdersDataGrid.SelectedRows[0].Cells[1].Value.ToString(); 
            if (e.ColumnIndex == OrdersDataGrid.Columns["Check"].Index && e.RowIndex >= 0)
            {
                
                OrderStatus(orderNo);
                LoadData();
                //int rowIndexToDelete = e.RowIndex;
                //OrdersDataGrid.Rows.RemoveAt(rowIndexToDelete);
            }
        }

        private void OrdersDataGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row in OrdersDataGrid.Rows)
            {
                row.Cells["Check"].Value = Properties.Resources.check;
                if (row.Cells["Status"].Value.ToString() == "Complete")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(43, 196, 138);
                    row.Cells["Check"].Value = Properties.Resources.uncheck;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.Cells["Check"].Value = Properties.Resources.check;
                }
            }
        }

        private void SearchBox_OnIconRightClick(object sender, EventArgs e)
        {
            string query=$"SELECT * FROM orders WHERE Customer_Name LIKE '{SearchBox.Text}%' ";
            DataTable dt = new DataTable();
            General.SearchControl(dt, query, SearchBox.Text, "@Customer_Name");

            if (dt.Rows.Count <= 0)
            { MessageBox.Show("Could Not Find"); return; }


            OrdersDataGrid.DataSource = dt;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if(SearchBox.Text == "")  
                LoadData();
        }
    }
}
