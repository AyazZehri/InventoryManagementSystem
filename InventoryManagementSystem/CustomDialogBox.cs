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
    public partial class CustomDialogBox : Form
    {
        public CustomDialogBox()
        {
            InitializeComponent();
        }

       public string MessageText
        {
            get { return MsgText.Text; }
            set { MsgText.Text = value; }
        }
        
        public string MessageTitle
        {
            get { return MsgHeader.Text; }
            set { MsgHeader.Text = value; }
        }

        public Image MessageIcon
        {
            get { return MsgIcon.Image; }
            set { MsgIcon.Image = value; }
        }


        private void CustomDialogBox_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
          Close();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Yes;
            Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.No;
            Close();
        }
    }
}
