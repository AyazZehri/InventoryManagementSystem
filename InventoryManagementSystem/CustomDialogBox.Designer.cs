namespace InventoryManagementSystem
{
    partial class CustomDialogBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDialogBox));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MsgText = new Bunifu.UI.WinForms.BunifuLabel();
            this.MsgIcon = new System.Windows.Forms.PictureBox();
            this.YesButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.NoButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.MsgHeader = new Bunifu.UI.WinForms.BunifuLabel();
            this.CloseButton = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.MsgIcon)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MsgText
            // 
            this.MsgText.AllowParentOverrides = false;
            this.MsgText.AutoEllipsis = false;
            this.MsgText.AutoSize = false;
            this.MsgText.Cursor = System.Windows.Forms.Cursors.Default;
            this.MsgText.CursorType = System.Windows.Forms.Cursors.Default;
            this.MsgText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MsgText.Location = new System.Drawing.Point(12, 48);
            this.MsgText.Name = "MsgText";
            this.MsgText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MsgText.Size = new System.Drawing.Size(181, 70);
            this.MsgText.TabIndex = 11;
            this.MsgText.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.MsgText.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MsgIcon
            // 
            this.MsgIcon.Image = global::InventoryManagementSystem.Properties.Resources.asterisk;
            this.MsgIcon.Location = new System.Drawing.Point(211, 48);
            this.MsgIcon.Name = "MsgIcon";
            this.MsgIcon.Size = new System.Drawing.Size(70, 70);
            this.MsgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MsgIcon.TabIndex = 12;
            this.MsgIcon.TabStop = false;
            // 
            // YesButton
            // 
            this.YesButton.AllowAnimations = true;
            this.YesButton.AllowMouseEffects = true;
            this.YesButton.AllowToggling = false;
            this.YesButton.AnimationSpeed = 200;
            this.YesButton.AutoGenerateColors = false;
            this.YesButton.AutoRoundBorders = false;
            this.YesButton.AutoSizeLeftIcon = true;
            this.YesButton.AutoSizeRightIcon = true;
            this.YesButton.BackColor = System.Drawing.Color.Transparent;
            this.YesButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.YesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YesButton.BackgroundImage")));
            this.YesButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.YesButton.ButtonText = "Yes";
            this.YesButton.ButtonTextMarginLeft = 0;
            this.YesButton.ColorContrastOnClick = 45;
            this.YesButton.ColorContrastOnHover = 45;
            this.YesButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.YesButton.CustomizableEdges = borderEdges1;
            this.YesButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.YesButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.YesButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.YesButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.YesButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.YesButton.Font = new System.Drawing.Font("Bebas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesButton.ForeColor = System.Drawing.Color.White;
            this.YesButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.YesButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.YesButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.YesButton.IconMarginLeft = 11;
            this.YesButton.IconPadding = 10;
            this.YesButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.YesButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.YesButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.YesButton.IconSize = 25;
            this.YesButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.YesButton.IdleBorderRadius = 15;
            this.YesButton.IdleBorderThickness = 1;
            this.YesButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.YesButton.IdleIconLeftImage = null;
            this.YesButton.IdleIconRightImage = null;
            this.YesButton.IndicateFocus = false;
            this.YesButton.Location = new System.Drawing.Point(12, 128);
            this.YesButton.Name = "YesButton";
            this.YesButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.YesButton.OnDisabledState.BorderRadius = 15;
            this.YesButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.YesButton.OnDisabledState.BorderThickness = 1;
            this.YesButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.YesButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.YesButton.OnDisabledState.IconLeftImage = null;
            this.YesButton.OnDisabledState.IconRightImage = null;
            this.YesButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.YesButton.onHoverState.BorderRadius = 15;
            this.YesButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.YesButton.onHoverState.BorderThickness = 1;
            this.YesButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.YesButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.YesButton.onHoverState.IconLeftImage = null;
            this.YesButton.onHoverState.IconRightImage = null;
            this.YesButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.YesButton.OnIdleState.BorderRadius = 15;
            this.YesButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.YesButton.OnIdleState.BorderThickness = 1;
            this.YesButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.YesButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.YesButton.OnIdleState.IconLeftImage = null;
            this.YesButton.OnIdleState.IconRightImage = null;
            this.YesButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.YesButton.OnPressedState.BorderRadius = 15;
            this.YesButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.YesButton.OnPressedState.BorderThickness = 1;
            this.YesButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.YesButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.YesButton.OnPressedState.IconLeftImage = null;
            this.YesButton.OnPressedState.IconRightImage = null;
            this.YesButton.Size = new System.Drawing.Size(103, 39);
            this.YesButton.TabIndex = 9;
            this.YesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YesButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.YesButton.TextMarginLeft = 0;
            this.YesButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.YesButton.UseDefaultRadiusAndThickness = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
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
            this.NoButton.ButtonText = "No";
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
            this.NoButton.Location = new System.Drawing.Point(181, 128);
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
            this.NoButton.TabIndex = 10;
            this.NoButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.NoButton.TextMarginLeft = 0;
            this.NoButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.NoButton.UseDefaultRadiusAndThickness = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
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
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(292, 36);
            this.bunifuPanel1.TabIndex = 0;
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
            this.CloseButton.Location = new System.Drawing.Point(257, 3);
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
            // CustomDialogBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(293, 179);
            this.Controls.Add(this.MsgIcon);
            this.Controls.Add(this.MsgText);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StatusCheck";
            this.Load += new System.EventHandler(this.CustomDialogBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MsgIcon)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuImageButton CloseButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton YesButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton NoButton;
        private Bunifu.UI.WinForms.BunifuLabel MsgText;
        private Bunifu.UI.WinForms.BunifuLabel MsgHeader;
        private System.Windows.Forms.PictureBox MsgIcon;
    }
}