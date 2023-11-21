using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    internal class General
    {
        public static string ConString()
        {
            return "server=localhost;Database=inventory_management_system;Uid=root;Pwd=''";
        }


        public static void DataGridTheme(DataGridView grid, Color color, Color rowColor)
        {
            grid.ColumnHeadersDefaultCellStyle.BackColor = color;
            grid.EnableHeadersVisualStyles = false;
            grid.DefaultCellStyle.SelectionBackColor = rowColor;
            grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = color;

        }


        public static int ConvertToInt(string str)
        {
            int value = 0;

            if (str == null)
            {
                value = 0;
            }
            else
            {
                if (int.TryParse(str, out value))
                {
                    return value;
                }
                else { return 0; }
            }

            return value;
        }

        public static void SearchControl(DataTable table, string query, string value, string name)
        {
            using (MySqlConnection con = new MySqlConnection(ConString()))
            {
                con.Open();

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = query;
                cmd.Parameters.AddWithValue(value, name);

                MySqlDataReader reader = cmd.ExecuteReader();



                table.Load(reader);


            }
        }
    }
}
