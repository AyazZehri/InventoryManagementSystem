using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ItemCard : Bunifu.UI.WinForms.BunifuUserControl
    {

        public ItemCard()
        {
            InitializeComponent();
        }

        private void InititalizeButton()
        {

        }
        public bool isActive;
        public string ItemName
        {
            get { return NameLabel.Text; }
            set { NameLabel.Text = value; }

        }

        public string Type
        {
            get { return TypeLabel.Text; }
            set { TypeLabel.Text = value; }

        }

        public string Quality
        {
            get { return QualityLabel.Text; }
            set { QualityLabel.Text = value; }

        }

        public string Quantity
        {
            get { return QuantityLabel.Text; }
            set { QuantityLabel.Text = value; }

        }

        public string Price
        {
            get { return PriceLabel.Text; }
            set { PriceLabel.Text = value; }

        }

        public string ID
        {
            get { return IDLabel.Text; }
            set { IDLabel.Text = value; }

        }

        public void IsActiveButtons()
        {

        }

        public event EventHandler ButtonClick;
        private void CustomButton_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void ItemCard_MouseHover(object sender, EventArgs e)
        {

        }

        private void ItemCard_MouseLeave(object sender, EventArgs e)
        {
            BackgroundColor = Color.LightSkyBlue;
        }

        private void ItemCard_MouseEnter(object sender, EventArgs e)
        {
            BackgroundColor = Color.FromArgb(230, 247, 255);
        }

        private void ItemCard_Click(object sender, EventArgs e)
        {

        }

        private void ItemCard_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
