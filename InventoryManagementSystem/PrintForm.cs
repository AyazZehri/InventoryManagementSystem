using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        public string date
        {
            get { return DateLabel.Text; }
            set { DateLabel.Text = value; }
        }

        public string Ref
        {
            get { return RefLabel.Text; }
            set { RefLabel.Text = value; }
        }

        public string Customer
        {
            get { return CustomerLabel.Text; }
            set { CustomerLabel.Text = value; }
        }

        public string Product
        {
            get { return ProductLabel.Text; }
            set { ProductLabel.Text = value; }
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

        public string UnitPrice
        {
            get { return PricePerUnitLabel.Text; }
            set { PricePerUnitLabel.Text = value; }
        }

        public string TotalAmount
        {
            get { return TotalAmountLabel.Text; }
            set { TotalAmountLabel.Text = value; }
        }

        public string PaidAmount
        {
            get { return PaidAmountLabel.Text; }
            set { PaidAmountLabel.Text = value; }
        }

        public string Dues
        {
            get { return DuesLabel.Text; }
            set { DuesLabel.Text = value; }
        }

        public string NetAmount
        {
            get { return NetAmountLabel.Text; }
            set { NetAmountLabel.Text = value; }
        }


        int h, w;
        private void PrintButton_Click(object sender, EventArgs e)
        {
            Invoice();
        }

       /* private void Invoice()
        {
           PrintPreviewDialog dialog = new PrintPreviewDialog();

            dialog.Document = printDocument1;

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("pprnm", 285, 480);

            dialog.ShowDialog();

        }*/

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void width_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //e.Graphics.DrawLine(new Pen(Color.Black,10),new Point(10,2) , new Point(180, 2));
            e.Graphics.DrawString(TitleLable.Text, TitleLable.Font, Brushes.Black, new Point(w, h));
            e.Graphics.DrawString(CustomerLabel.Text, CustomerLabel.Font, Brushes.Black, new Point(170, 100));
            e.Graphics.DrawString(CustomerLabel.Text, CustomerLabel.Font, Brushes.Black, new Point(170, 100));
        }

        public void Invoice()
        {
            // Create a PrintDocument for printing
            PrintDocument printDocument1 = new PrintDocument();

            // Define the A5 page size
            PaperSize A5PageSize = new PaperSize("pprnm", 285, 480); // 419x595 pixels for 300 DPI

            // Set the paper size for the A5 receipt
            printDocument1.DefaultPageSettings.PaperSize = A5PageSize;

            // Set the print page event handler
            printDocument1.PrintPage += (s, e) =>
            {
                // Calculate the scaling factor to fit the receipt on the A5 page without distortion
                float scaleX = (float)A5PageSize.Width / Receipt.Width * 6f; // Increase the scale factor as needed
                float scaleY = (float)A5PageSize.Height / Receipt.Height * 6f; // Increase the scale factor as needed
                float scale = Math.Min(scaleX, scaleY);

                // Calculate the centered position for the receipt on the A5 page
                int left = (A5PageSize.Width - (int)(Receipt.Width * scaleX)) / 500;
                int top = (A5PageSize.Height - (int)(Receipt.Height * scaleY)) / 500;

                // Create a bitmap to render the receipt content at the A5 size
                using (Bitmap bitmap = new Bitmap(A5PageSize.Width, A5PageSize.Height))
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        // Set the higher resolution (300 DPI)
                        graphics.PageUnit = GraphicsUnit.Pixel;
                        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                        // Scale the receipt to fit the A5 page without distortion
                        graphics.ScaleTransform(scale, scale);

                        // Draw the receipt content onto the bitmap
                        Receipt.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, Receipt.Width, Receipt.Height));
                    }

                    // Set the print page resolution (300 DPI)
                    e.Graphics.PageUnit = GraphicsUnit.Pixel;

                    // Draw the receipt content onto the page at the A5 size
                    e.Graphics.DrawImage(bitmap, new System.Drawing.Rectangle(left, top, (int)(Receipt.Width * scaleX), (int)(Receipt.Height * scaleY)));
                }
            };

            // Specify the page orientation (portrait or landscape)
            printDocument1.DefaultPageSettings.Landscape = false; // Set to true for landscape orientation

            using (PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog())
            {
                printPreviewDialog.Document = printDocument1;

                // Perform your printing and preview setup here
                // ...

                // Show the print preview dialog
                printPreviewDialog.ShowDialog();
            }


        }
    }
}
