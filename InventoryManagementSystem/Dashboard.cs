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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        bool temp = true;
        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadValues();
            LoadOrders();
            LoadDues();
            LoadProducts();
            
        }

        private void LoadProducts()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();

                    string sqlQuery = "SELECT ID,Name, Type, Quality,Quantity FROM products WHERE Quantity <10;";

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        ProductsDataGrid.DataSource = dt;


                        DataGridViewImageColumn btn = new DataGridViewImageColumn();
                        btn.Name = "Add";
                        btn.HeaderText = "Add";
                        btn.ImageLayout = DataGridViewImageCellLayout.Normal;
                        btn.Image = Properties.Resources.Add;
                        ProductsDataGrid.Columns.Add(btn);


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Data");

            }
        }
        private void LoadDues()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();

                    string sqlQuery = "SELECT  Customer_ID, Customer_Name,Dues FROM sale_ledger WHERE Dues >0;";

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        CustomersDataGridView.DataSource = dt;

                       
                        DataGridViewImageColumn btn = new DataGridViewImageColumn();
                        btn.Name = "Msg";
                        btn.HeaderText = "Msg";
                        btn.ImageLayout = DataGridViewImageCellLayout.Normal;
                        btn.Image =Properties.Resources.message;
                        CustomersDataGridView.Columns.Add(btn);

                       /* DataGridViewImageColumn Clearbtn = new DataGridViewImageColumn();
                        Clearbtn.Name = "Clear";
                        Clearbtn.HeaderText = "Clear";
                        Clearbtn.ImageLayout = DataGridViewImageCellLayout.Normal;
                        Clearbtn.Image = Properties.Resources.bill;
                        CustomersDataGridView.Columns.Add(Clearbtn);*/
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Data");

            }
        }

        private void LoadOrders()
        {
            
            OrdersDataGrid.CellClick += OrdersDataGrid_CellClick;

            try
            {
                using (MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();

                    string sqlQuery = "SELECT * FROM orders WHERE Status = 'In Progress';";

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
                MessageBox.Show(ex.Message, "Load Data");

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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Complete");
            }
        }
        private void OrdersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string orderNo = OrdersDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            if (e.ColumnIndex == OrdersDataGrid.Columns["Check"].Index && e.RowIndex >= 0)
            {
               CustomDialogBox customDialogBox = new CustomDialogBox();
                customDialogBox.MessageText = "Do You Want to Remove Order Details?";
                customDialogBox.MessageTitle = "Caution!!!";
                customDialogBox.MessageIcon = Properties.Resources.Question;
               DialogResult a = customDialogBox.ShowDialog();
             
                if(a==DialogResult.Yes)
                { OrderStatus(orderNo); LoadOrders(); customDialogBox.Dispose(); }
               
            }
        }
        private void ProductsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = ProductsDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            string name = ProductsDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            if (e.ColumnIndex == ProductsDataGrid.Columns["Add"].Index && e.RowIndex>=0)
            {
                StockRefill refill = new StockRefill();
                refill.ID = id;
                refill.Item_Name = name;
                refill.ShowDialog();
                if(refill.DialogResult == DialogResult.OK)
                {
                    LoadProducts();
                }
            }

        }

        private void CustomersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = CustomersDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            if (e.ColumnIndex == CustomersDataGridView.Columns["Msg"].Index && e.RowIndex >= 0)
            {
                ReminderBox reminder = new ReminderBox();
                reminder.ID = id;
                reminder.Show();
            }

           /* if (e.ColumnIndex == CustomersDataGridView.Columns["Clear"].Index && e.RowIndex >= 0)
            {
                CustomDialogBox customDialogBox1 = new CustomDialogBox();
                customDialogBox1.MessageText = id;
                customDialogBox1.MessageTitle = "Bill Settlement";
                customDialogBox1.ShowDialog();
            }*/
        }
        private void OrdersDataGrid_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
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


        private void  LoadValues()
        {
            int totalProducts=0, totalSale=0, totalPurchase=0, totalDues=0;
             
            try
            {
                using(MySqlConnection con = new MySqlConnection(General.ConString()))
                {
                    con.Open();

                    // ---- Prodcuts
                    string totalProductsQuery = "SELECT COUNT(*)-1 AS Total_Prodcuts FROM products;";

                    MySqlCommand TP_cmd = new MySqlCommand(totalProductsQuery, con);

                    object result = TP_cmd.ExecuteScalar();
                    if(result != null && result != DBNull.Value)
                    {
                        totalProducts = Convert.ToInt32(result);
                    }
                    //-----Sale
                    string totalSaleQuery = "SELECT SUM(Net_Amount) FROM sale_ledger;";

                    MySqlCommand TS_cmd = new MySqlCommand(totalSaleQuery, con);

                    object resultSale = TS_cmd.ExecuteScalar();
                    if (resultSale != null && resultSale != DBNull.Value)
                    {
                        totalSale = Convert.ToInt32(resultSale);
                    }
                    //-----Purchase
                    string totalPurchaseQuery = "SELECT SUM(Total_Amount) FROM products;";

                    MySqlCommand TPrch_cmd = new MySqlCommand(totalPurchaseQuery, con);

                    object resultPurchase = TPrch_cmd.ExecuteScalar();
                    if (resultPurchase != null && resultPurchase != DBNull.Value)
                    {
                        totalPurchase = Convert.ToInt32(resultPurchase);
                    }

                    //------Dues
                    string totalDuesQuery = "SELECT SUM(Dues) FROM sale_ledger;";

                    MySqlCommand TD_cmd = new MySqlCommand(totalDuesQuery, con);

                    object resultDues = TD_cmd.ExecuteScalar();
                    if (resultDues != null && resultDues != DBNull.Value)
                    {
                        totalDues = Convert.ToInt32( resultDues);
                    }

                    ProdcutsLabel.Text = totalProducts.ToString();
                    TotalSaleLabel.Text = totalSale.ToString("C");
                    PurchaseLabel.Text = totalPurchase.ToString("C");
                    DuesLabel.Text = totalDues.ToString("C");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
