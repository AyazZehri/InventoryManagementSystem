using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace InventoryManagementSystem
{
    public partial class ItemSalePanel : Form
    {
        public ItemSalePanel()
        {
            InitializeComponent();
        }
        int quantity, pricePerUnit, Total;


        public string ItemName
        {
            get { return NameBox.Text; }
            set { NameBox.Text = value; }

        }

        public string Type
        {
            get { return TypeBox.Text; }
            set { TypeBox.Text = value; }

        }

        public string Quality
        {
            get { return QualityBox.Text; }
            set { QualityBox.Text = value; }

        }

        public string Quantity
        {
            get { return QuantityBox.Text; }
            set { QuantityBox.Text = value; }

        }

        public string Price
        {
            get { return PricePUnitBox.Text; }
            set { PricePUnitBox.Text = value; }
        }

        private void QuantityBox_TextChanged(object sender, EventArgs e)
        {
            quantity = General.ConvertToInt(QuantityBox.Text);
            pricePerUnit = General.ConvertToInt(PricePUnitBox.Text);

            Total = quantity * pricePerUnit;

            TotalBox.Text = Total.ToString("C");
        }
    }
}
