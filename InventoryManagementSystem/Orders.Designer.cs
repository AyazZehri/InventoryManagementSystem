namespace InventoryManagementSystem
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.OrdersDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.SearchBox = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Bebas", 18F);
            this.bunifuLabel1.Location = new System.Drawing.Point(26, 27);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(61, 30);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Orders";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // OrdersDataGrid
            // 
            this.OrdersDataGrid.AllowCustomTheming = false;
            this.OrdersDataGrid.AllowUserToAddRows = false;
            this.OrdersDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.OrdersDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrdersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OrdersDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.OrdersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrdersDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrdersDataGrid.ColumnHeadersHeight = 40;
            this.OrdersDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.OrdersDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.OrdersDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.OrdersDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.OrdersDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.OrdersDataGrid.CurrentTheme.BackColor = System.Drawing.Color.Crimson;
            this.OrdersDataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.OrdersDataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.OrdersDataGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.OrdersDataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrdersDataGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.OrdersDataGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.OrdersDataGrid.CurrentTheme.Name = null;
            this.OrdersDataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.OrdersDataGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.OrdersDataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.OrdersDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.OrdersDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrdersDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrdersDataGrid.EnableHeadersVisualStyles = false;
            this.OrdersDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.OrdersDataGrid.HeaderBackColor = System.Drawing.Color.Crimson;
            this.OrdersDataGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.OrdersDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.OrdersDataGrid.Location = new System.Drawing.Point(26, 91);
            this.OrdersDataGrid.Name = "OrdersDataGrid";
            this.OrdersDataGrid.ReadOnly = true;
            this.OrdersDataGrid.RowHeadersVisible = false;
            this.OrdersDataGrid.RowTemplate.Height = 40;
            this.OrdersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDataGrid.Size = new System.Drawing.Size(848, 647);
            this.OrdersDataGrid.TabIndex = 8;
            this.OrdersDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Crimson;
            this.OrdersDataGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.OrdersDataGrid_RowPrePaint);
            // 
            // SearchBox
            // 
            this.SearchBox.AcceptsReturn = false;
            this.SearchBox.AcceptsTab = false;
            this.SearchBox.AnimationSpeed = 200;
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBox.BackgroundImage")));
            this.SearchBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.SearchBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SearchBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SearchBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.SearchBox.BorderRadius = 25;
            this.SearchBox.BorderThickness = 1;
            this.SearchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.SearchBox.DefaultText = "";
            this.SearchBox.FillColor = System.Drawing.Color.White;
            this.SearchBox.HideSelection = true;
            this.SearchBox.IconLeft = null;
            this.SearchBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.IconPadding = 5;
            this.SearchBox.IconRight = global::InventoryManagementSystem.Properties.Resources.Search;
            this.SearchBox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBox.Lines = new string[0];
            this.SearchBox.Location = new System.Drawing.Point(607, 17);
            this.SearchBox.MaxLength = 32767;
            this.SearchBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.SearchBox.Modified = false;
            this.SearchBox.Multiline = false;
            this.SearchBox.Name = "SearchBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SearchBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchBox.OnIdleState = stateProperties4;
            this.SearchBox.Padding = new System.Windows.Forms.Padding(3);
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.SearchBox.PlaceholderText = "Enter text";
            this.SearchBox.ReadOnly = false;
            this.SearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchBox.SelectedText = "";
            this.SearchBox.SelectionLength = 0;
            this.SearchBox.SelectionStart = 0;
            this.SearchBox.ShortcutsEnabled = true;
            this.SearchBox.Size = new System.Drawing.Size(267, 40);
            this.SearchBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.SearchBox.TabIndex = 9;
            this.SearchBox.TabStop = false;
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchBox.TextMarginBottom = 0;
            this.SearchBox.TextMarginLeft = 3;
            this.SearchBox.TextMarginTop = 0;
            this.SearchBox.TextPlaceholder = "Enter text";
            this.SearchBox.UseSystemPasswordChar = false;
            this.SearchBox.WordWrap = true;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.OnIconRightClick += new System.EventHandler(this.SearchBox_OnIconRightClick);
            // 
            // Orders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.OrdersDataGrid);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox SearchBox;
        private Bunifu.UI.WinForms.BunifuDataGridView OrdersDataGrid;
    }
}