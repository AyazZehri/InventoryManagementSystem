namespace InventoryManagementSystem
{
    partial class StockRefill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockRefill));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.MsgText = new Bunifu.UI.WinForms.BunifuLabel();
            this.AddButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.MsgHeader = new Bunifu.UI.WinForms.BunifuLabel();
            this.CloseButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.NoButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.QuantityRBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsgText
            // 
            this.MsgText.AllowParentOverrides = false;
            this.MsgText.AutoEllipsis = false;
            this.MsgText.AutoSize = false;
            this.MsgText.Cursor = System.Windows.Forms.Cursors.Default;
            this.MsgText.CursorType = System.Windows.Forms.Cursors.Default;
            this.MsgText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MsgText.Location = new System.Drawing.Point(13, 43);
            this.MsgText.Name = "MsgText";
            this.MsgText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MsgText.Size = new System.Drawing.Size(256, 78);
            this.MsgText.TabIndex = 15;
            this.MsgText.Text = "Do you want to Refill the Quantity of Prodcut {Product_Name}?";
            this.MsgText.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.MsgText.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MsgText.Click += new System.EventHandler(this.MsgText_Click);
            // 
            // AddButton
            // 
            this.AddButton.AllowAnimations = true;
            this.AddButton.AllowMouseEffects = true;
            this.AddButton.AllowToggling = false;
            this.AddButton.AnimationSpeed = 200;
            this.AddButton.AutoGenerateColors = false;
            this.AddButton.AutoRoundBorders = false;
            this.AddButton.AutoSizeLeftIcon = true;
            this.AddButton.AutoSizeRightIcon = true;
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddButton.ButtonText = "Proceed";
            this.AddButton.ButtonTextMarginLeft = 0;
            this.AddButton.ColorContrastOnClick = 45;
            this.AddButton.ColorContrastOnHover = 45;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.AddButton.CustomizableEdges = borderEdges1;
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AddButton.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AddButton.IconMarginLeft = 11;
            this.AddButton.IconPadding = 10;
            this.AddButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AddButton.IconSize = 25;
            this.AddButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.AddButton.IdleBorderRadius = 15;
            this.AddButton.IdleBorderThickness = 1;
            this.AddButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.AddButton.IdleIconLeftImage = null;
            this.AddButton.IdleIconRightImage = null;
            this.AddButton.IndicateFocus = false;
            this.AddButton.Location = new System.Drawing.Point(13, 188);
            this.AddButton.Name = "AddButton";
            this.AddButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddButton.OnDisabledState.BorderRadius = 15;
            this.AddButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddButton.OnDisabledState.BorderThickness = 1;
            this.AddButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddButton.OnDisabledState.IconLeftImage = null;
            this.AddButton.OnDisabledState.IconRightImage = null;
            this.AddButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AddButton.onHoverState.BorderRadius = 15;
            this.AddButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddButton.onHoverState.BorderThickness = 1;
            this.AddButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AddButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AddButton.onHoverState.IconLeftImage = null;
            this.AddButton.onHoverState.IconRightImage = null;
            this.AddButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.AddButton.OnIdleState.BorderRadius = 15;
            this.AddButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddButton.OnIdleState.BorderThickness = 1;
            this.AddButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.AddButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AddButton.OnIdleState.IconLeftImage = null;
            this.AddButton.OnIdleState.IconRightImage = null;
            this.AddButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddButton.OnPressedState.BorderRadius = 15;
            this.AddButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddButton.OnPressedState.BorderThickness = 1;
            this.AddButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AddButton.OnPressedState.IconLeftImage = null;
            this.AddButton.OnPressedState.IconRightImage = null;
            this.AddButton.Size = new System.Drawing.Size(103, 39);
            this.AddButton.TabIndex = 13;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddButton.TextMarginLeft = 0;
            this.AddButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.AddButton.UseDefaultRadiusAndThickness = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Black;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 25;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.MsgHeader);
            this.bunifuPanel1.Controls.Add(this.CloseButton);
            this.bunifuPanel1.Location = new System.Drawing.Point(1, 1);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(275, 36);
            this.bunifuPanel1.TabIndex = 12;
            // 
            // MsgHeader
            // 
            this.MsgHeader.AllowParentOverrides = false;
            this.MsgHeader.AutoEllipsis = false;
            this.MsgHeader.CursorType = null;
            this.MsgHeader.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MsgHeader.ForeColor = System.Drawing.Color.Black;
            this.MsgHeader.Location = new System.Drawing.Point(12, 7);
            this.MsgHeader.Name = "MsgHeader";
            this.MsgHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MsgHeader.Size = new System.Drawing.Size(0, 0);
            this.MsgHeader.TabIndex = 11;
            this.MsgHeader.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.MsgHeader.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CloseButton
            // 
            this.CloseButton.ActiveImage = global::InventoryManagementSystem.Properties.Resources.Close;
            this.CloseButton.AllowAnimations = true;
            this.CloseButton.AllowBuffering = false;
            this.CloseButton.AllowToggling = false;
            this.CloseButton.AllowZooming = true;
            this.CloseButton.AllowZoomingOnFocus = false;
            this.CloseButton.BackColor = System.Drawing.Color.Black;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.ErrorImage")));
            this.CloseButton.FadeWhenInactive = false;
            this.CloseButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.CloseButton.Image = global::InventoryManagementSystem.Properties.Resources.Close;
            this.CloseButton.ImageActive = global::InventoryManagementSystem.Properties.Resources.Close;
            this.CloseButton.ImageLocation = null;
            this.CloseButton.ImageMargin = 0;
            this.CloseButton.ImageSize = new System.Drawing.Size(29, 29);
            this.CloseButton.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.CloseButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.InitialImage")));
            this.CloseButton.Location = new System.Drawing.Point(238, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Rotation = 0;
            this.CloseButton.ShowActiveImage = true;
            this.CloseButton.ShowCursorChanges = true;
            this.CloseButton.ShowImageBorders = true;
            this.CloseButton.ShowSizeMarkers = false;
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.ToolTipText = "";
            this.CloseButton.WaitOnLoad = false;
            this.CloseButton.Zoom = 0;
            this.CloseButton.ZoomSpeed = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // NoButton
            // 
            this.NoButton.AllowAnimations = true;
            this.NoButton.AllowMouseEffects = true;
            this.NoButton.AllowToggling = false;
            this.NoButton.AnimationSpeed = 200;
            this.NoButton.AutoGenerateColors = false;
            this.NoButton.AutoRoundBorders = false;
            this.NoButton.AutoSizeLeftIcon = true;
            this.NoButton.AutoSizeRightIcon = true;
            this.NoButton.BackColor = System.Drawing.Color.Transparent;
            this.NoButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.NoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NoButton.BackgroundImage")));
            this.NoButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.NoButton.ButtonText = "Cancel";
            this.NoButton.ButtonTextMarginLeft = 0;
            this.NoButton.ColorContrastOnClick = 45;
            this.NoButton.ColorContrastOnHover = 45;
            this.NoButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.NoButton.CustomizableEdges = borderEdges2;
            this.NoButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.NoButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.NoButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.NoButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.NoButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.NoButton.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoButton.ForeColor = System.Drawing.Color.White;
            this.NoButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NoButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.NoButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.NoButton.IconMarginLeft = 11;
            this.NoButton.IconPadding = 10;
            this.NoButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NoButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.NoButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.NoButton.IconSize = 25;
            this.NoButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.NoButton.IdleBorderRadius = 15;
            this.NoButton.IdleBorderThickness = 1;
            this.NoButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.NoButton.IdleIconLeftImage = null;
            this.NoButton.IdleIconRightImage = null;
            this.NoButton.IndicateFocus = false;
            this.NoButton.Location = new System.Drawing.Point(166, 188);
            this.NoButton.Name = "NoButton";
            this.NoButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.NoButton.OnDisabledState.BorderRadius = 15;
            this.NoButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.NoButton.OnDisabledState.BorderThickness = 1;
            this.NoButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.NoButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.NoButton.OnDisabledState.IconLeftImage = null;
            this.NoButton.OnDisabledState.IconRightImage = null;
            this.NoButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.NoButton.onHoverState.BorderRadius = 15;
            this.NoButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.NoButton.onHoverState.BorderThickness = 1;
            this.NoButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.NoButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.NoButton.onHoverState.IconLeftImage = null;
            this.NoButton.onHoverState.IconRightImage = null;
            this.NoButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.NoButton.OnIdleState.BorderRadius = 15;
            this.NoButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.NoButton.OnIdleState.BorderThickness = 1;
            this.NoButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.NoButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.NoButton.OnIdleState.IconLeftImage = null;
            this.NoButton.OnIdleState.IconRightImage = null;
            this.NoButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.NoButton.OnPressedState.BorderRadius = 15;
            this.NoButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.NoButton.OnPressedState.BorderThickness = 1;
            this.NoButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.NoButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.NoButton.OnPressedState.IconLeftImage = null;
            this.NoButton.OnPressedState.IconRightImage = null;
            this.NoButton.Size = new System.Drawing.Size(103, 39);
            this.NoButton.TabIndex = 14;
            this.NoButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.NoButton.TextMarginLeft = 0;
            this.NoButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.NoButton.UseDefaultRadiusAndThickness = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Bebas", 15.75F);
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 136);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(72, 25);
            this.bunifuLabel1.TabIndex = 16;
            this.bunifuLabel1.Text = "Quantity:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // QuantityRBox
            // 
            this.QuantityRBox.AcceptsReturn = false;
            this.QuantityRBox.AcceptsTab = false;
            this.QuantityRBox.AnimationSpeed = 200;
            this.QuantityRBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.QuantityRBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.QuantityRBox.BackColor = System.Drawing.Color.Transparent;
            this.QuantityRBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuantityRBox.BackgroundImage")));
            this.QuantityRBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.QuantityRBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.QuantityRBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.QuantityRBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.QuantityRBox.BorderRadius = 15;
            this.QuantityRBox.BorderThickness = 1;
            this.QuantityRBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.QuantityRBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityRBox.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityRBox.DefaultText = "";
            this.QuantityRBox.FillColor = System.Drawing.Color.White;
            this.QuantityRBox.HideSelection = true;
            this.QuantityRBox.IconLeft = null;
            this.QuantityRBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityRBox.IconPadding = 10;
            this.QuantityRBox.IconRight = null;
            this.QuantityRBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityRBox.Lines = new string[0];
            this.QuantityRBox.Location = new System.Drawing.Point(92, 127);
            this.QuantityRBox.MaxLength = 32767;
            this.QuantityRBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.QuantityRBox.Modified = false;
            this.QuantityRBox.Multiline = false;
            this.QuantityRBox.Name = "QuantityRBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.QuantityRBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.QuantityRBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.QuantityRBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.QuantityRBox.OnIdleState = stateProperties4;
            this.QuantityRBox.Padding = new System.Windows.Forms.Padding(3);
            this.QuantityRBox.PasswordChar = '\0';
            this.QuantityRBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.QuantityRBox.PlaceholderText = "Enter text";
            this.QuantityRBox.ReadOnly = false;
            this.QuantityRBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuantityRBox.SelectedText = "";
            this.QuantityRBox.SelectionLength = 0;
            this.QuantityRBox.SelectionStart = 0;
            this.QuantityRBox.ShortcutsEnabled = true;
            this.QuantityRBox.Size = new System.Drawing.Size(176, 42);
            this.QuantityRBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.QuantityRBox.TabIndex = 17;
            this.QuantityRBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.QuantityRBox.TextMarginBottom = 0;
            this.QuantityRBox.TextMarginLeft = 3;
            this.QuantityRBox.TextMarginTop = 0;
            this.QuantityRBox.TextPlaceholder = "Enter text";
            this.QuantityRBox.UseSystemPasswordChar = false;
            this.QuantityRBox.WordWrap = true;
            // 
            // StockRefill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(280, 236);
            this.Controls.Add(this.QuantityRBox);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.MsgText);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockRefill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StockRefill";
            this.Load += new System.EventHandler(this.StockRefill_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel MsgText;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddButton;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel MsgHeader;
        private Bunifu.UI.WinForms.BunifuImageButton CloseButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton NoButton;
        private Bunifu.UI.WinForms.BunifuTextBox QuantityRBox;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}