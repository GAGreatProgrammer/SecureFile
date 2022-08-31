
namespace SecureFile
{
    partial class SecureFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecureFile));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cboProcedure = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cboAction = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel13 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.bgwEncrypt = new System.ComponentModel.BackgroundWorker();
            this.bgwDecrypt = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnRun = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnGeneratePassword = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnUpload = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.FilesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ScrollBar = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sbMessage = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.Loader = new Bunifu.UI.WinForms.BunifuLoader();
            this.bgwGetHASHEncrypted = new System.ComponentModel.BackgroundWorker();
            this.bgwGetHASHDecrypted = new System.ComponentModel.BackgroundWorker();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(30, 20);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(85, 37);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Secure";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(115, 20);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(41, 37);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "File";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(175, 30);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(224, 21);
            this.bunifuLabel3.TabIndex = 2;
            this.bunifuLabel3.Text = "Encrypt & Decrypt files easily";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel4.Location = new System.Drawing.Point(30, 80);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(85, 25);
            this.bunifuLabel4.TabIndex = 3;
            this.bunifuLabel4.Text = "Password";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel5.Location = new System.Drawing.Point(30, 170);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(93, 25);
            this.bunifuLabel5.TabIndex = 5;
            this.bunifuLabel5.Text = "Procedure";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cboProcedure
            // 
            this.cboProcedure.BackColor = System.Drawing.Color.Transparent;
            this.cboProcedure.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.cboProcedure.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.cboProcedure.BorderRadius = 5;
            this.cboProcedure.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.cboProcedure.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cboProcedure.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboProcedure.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cboProcedure.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboProcedure.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cboProcedure.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cboProcedure.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboProcedure.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.cboProcedure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProcedure.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboProcedure.FillDropDown = true;
            this.cboProcedure.FillIndicator = false;
            this.cboProcedure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProcedure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProcedure.ForeColor = System.Drawing.Color.White;
            this.cboProcedure.FormattingEnabled = true;
            this.cboProcedure.Icon = null;
            this.cboProcedure.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboProcedure.IndicatorColor = System.Drawing.Color.White;
            this.cboProcedure.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboProcedure.IndicatorThickness = 2;
            this.cboProcedure.IsDropdownOpened = false;
            this.cboProcedure.ItemBackColor = System.Drawing.Color.White;
            this.cboProcedure.ItemBorderColor = System.Drawing.Color.White;
            this.cboProcedure.ItemForeColor = System.Drawing.Color.Black;
            this.cboProcedure.ItemHeight = 31;
            this.cboProcedure.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cboProcedure.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cboProcedure.Items.AddRange(new object[] {
            "Encryption",
            "Decryption"});
            this.cboProcedure.ItemTopMargin = 3;
            this.cboProcedure.Location = new System.Drawing.Point(30, 201);
            this.cboProcedure.Name = "cboProcedure";
            this.cboProcedure.Size = new System.Drawing.Size(375, 37);
            this.cboProcedure.TabIndex = 6;
            this.cboProcedure.Text = null;
            this.cboProcedure.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboProcedure.TextLeftMargin = 5;
            // 
            // cboAction
            // 
            this.cboAction.BackColor = System.Drawing.Color.Transparent;
            this.cboAction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.cboAction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.cboAction.BorderRadius = 5;
            this.cboAction.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.cboAction.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cboAction.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboAction.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cboAction.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboAction.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cboAction.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cboAction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAction.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.cboAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAction.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboAction.FillDropDown = true;
            this.cboAction.FillIndicator = false;
            this.cboAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAction.ForeColor = System.Drawing.Color.White;
            this.cboAction.FormattingEnabled = true;
            this.cboAction.Icon = null;
            this.cboAction.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboAction.IndicatorColor = System.Drawing.Color.White;
            this.cboAction.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboAction.IndicatorThickness = 2;
            this.cboAction.IsDropdownOpened = false;
            this.cboAction.ItemBackColor = System.Drawing.Color.White;
            this.cboAction.ItemBorderColor = System.Drawing.Color.White;
            this.cboAction.ItemForeColor = System.Drawing.Color.Black;
            this.cboAction.ItemHeight = 31;
            this.cboAction.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cboAction.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cboAction.Items.AddRange(new object[] {
            "Delete file after procedure",
            "Don\'t delete file"});
            this.cboAction.ItemTopMargin = 3;
            this.cboAction.Location = new System.Drawing.Point(30, 290);
            this.cboAction.Name = "cboAction";
            this.cboAction.Size = new System.Drawing.Size(375, 37);
            this.cboAction.TabIndex = 8;
            this.cboAction.Text = null;
            this.cboAction.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboAction.TextLeftMargin = 5;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel6.Location = new System.Drawing.Point(30, 260);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(133, 25);
            this.bunifuLabel6.TabIndex = 7;
            this.bunifuLabel6.Text = "Action with file";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel13
            // 
            this.bunifuLabel13.AllowParentOverrides = false;
            this.bunifuLabel13.AutoEllipsis = false;
            this.bunifuLabel13.CursorType = null;
            this.bunifuLabel13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel13.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel13.Location = new System.Drawing.Point(440, 80);
            this.bunifuLabel13.Name = "bunifuLabel13";
            this.bunifuLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel13.Size = new System.Drawing.Size(109, 25);
            this.bunifuLabel13.TabIndex = 20;
            this.bunifuLabel13.Text = "Created files";
            this.bunifuLabel13.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel13.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            // 
            // bgwEncrypt
            // 
            this.bgwEncrypt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEncrypt_DoWork);
            // 
            // bgwDecrypt
            // 
            this.bgwDecrypt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDecrypt_DoWork);
            // 
            // btnCancel
            // 
            this.btnCancel.AllowAnimations = true;
            this.btnCancel.AllowMouseEffects = true;
            this.btnCancel.AllowToggling = false;
            this.btnCancel.AnimationSpeed = 200;
            this.btnCancel.AutoGenerateColors = false;
            this.btnCancel.AutoRoundBorders = false;
            this.btnCancel.AutoSizeLeftIcon = true;
            this.btnCancel.AutoSizeRightIcon = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.ButtonTextMarginLeft = 0;
            this.btnCancel.ColorContrastOnClick = 45;
            this.btnCancel.ColorContrastOnHover = 45;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnCancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnCancel.DisabledForecolor = System.Drawing.Color.White;
            this.btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancel.IconMarginLeft = 11;
            this.btnCancel.IconPadding = 10;
            this.btnCancel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancel.IconSize = 25;
            this.btnCancel.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnCancel.IdleBorderRadius = 10;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnCancel.IdleIconLeftImage = null;
            this.btnCancel.IdleIconRightImage = null;
            this.btnCancel.IndicateFocus = false;
            this.btnCancel.Location = new System.Drawing.Point(235, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnCancel.OnDisabledState.BorderRadius = 10;
            this.btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.OnDisabledState.BorderThickness = 1;
            this.btnCancel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnCancel.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnDisabledState.IconLeftImage = null;
            this.btnCancel.OnDisabledState.IconRightImage = null;
            this.btnCancel.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnCancel.onHoverState.BorderRadius = 10;
            this.btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.onHoverState.BorderThickness = 1;
            this.btnCancel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btnCancel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.onHoverState.IconLeftImage = null;
            this.btnCancel.onHoverState.IconRightImage = null;
            this.btnCancel.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnCancel.OnIdleState.BorderRadius = 10;
            this.btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.OnIdleState.BorderThickness = 1;
            this.btnCancel.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnCancel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnIdleState.IconLeftImage = null;
            this.btnCancel.OnIdleState.IconRightImage = null;
            this.btnCancel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnCancel.OnPressedState.BorderRadius = 10;
            this.btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.OnPressedState.BorderThickness = 1;
            this.btnCancel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnCancel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnPressedState.IconLeftImage = null;
            this.btnCancel.OnPressedState.IconRightImage = null;
            this.btnCancel.Size = new System.Drawing.Size(170, 45);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRun
            // 
            this.btnRun.AllowAnimations = true;
            this.btnRun.AllowMouseEffects = true;
            this.btnRun.AllowToggling = false;
            this.btnRun.AnimationSpeed = 200;
            this.btnRun.AutoGenerateColors = false;
            this.btnRun.AutoRoundBorders = false;
            this.btnRun.AutoSizeLeftIcon = true;
            this.btnRun.AutoSizeRightIcon = true;
            this.btnRun.BackColor = System.Drawing.Color.Transparent;
            this.btnRun.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnRun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRun.BackgroundImage")));
            this.btnRun.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRun.ButtonText = "Run";
            this.btnRun.ButtonTextMarginLeft = 0;
            this.btnRun.ColorContrastOnClick = 45;
            this.btnRun.ColorContrastOnHover = 45;
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnRun.CustomizableEdges = borderEdges2;
            this.btnRun.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRun.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnRun.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnRun.DisabledForecolor = System.Drawing.Color.White;
            this.btnRun.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRun.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRun.IconMarginLeft = 11;
            this.btnRun.IconPadding = 10;
            this.btnRun.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRun.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRun.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRun.IconSize = 25;
            this.btnRun.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnRun.IdleBorderRadius = 10;
            this.btnRun.IdleBorderThickness = 1;
            this.btnRun.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnRun.IdleIconLeftImage = null;
            this.btnRun.IdleIconRightImage = null;
            this.btnRun.IndicateFocus = false;
            this.btnRun.Location = new System.Drawing.Point(30, 450);
            this.btnRun.Name = "btnRun";
            this.btnRun.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnRun.OnDisabledState.BorderRadius = 10;
            this.btnRun.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRun.OnDisabledState.BorderThickness = 1;
            this.btnRun.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnRun.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnRun.OnDisabledState.IconLeftImage = null;
            this.btnRun.OnDisabledState.IconRightImage = null;
            this.btnRun.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnRun.onHoverState.BorderRadius = 10;
            this.btnRun.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRun.onHoverState.BorderThickness = 1;
            this.btnRun.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btnRun.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRun.onHoverState.IconLeftImage = null;
            this.btnRun.onHoverState.IconRightImage = null;
            this.btnRun.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnRun.OnIdleState.BorderRadius = 10;
            this.btnRun.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRun.OnIdleState.BorderThickness = 1;
            this.btnRun.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnRun.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRun.OnIdleState.IconLeftImage = null;
            this.btnRun.OnIdleState.IconRightImage = null;
            this.btnRun.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnRun.OnPressedState.BorderRadius = 10;
            this.btnRun.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRun.OnPressedState.BorderThickness = 1;
            this.btnRun.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnRun.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRun.OnPressedState.IconLeftImage = null;
            this.btnRun.OnPressedState.IconRightImage = null;
            this.btnRun.Size = new System.Drawing.Size(170, 45);
            this.btnRun.TabIndex = 12;
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRun.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRun.TextMarginLeft = 0;
            this.btnRun.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRun.UseDefaultRadiusAndThickness = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.AllowAnimations = true;
            this.btnGeneratePassword.AllowMouseEffects = true;
            this.btnGeneratePassword.AllowToggling = false;
            this.btnGeneratePassword.AnimationSpeed = 200;
            this.btnGeneratePassword.AutoGenerateColors = false;
            this.btnGeneratePassword.AutoRoundBorders = false;
            this.btnGeneratePassword.AutoSizeLeftIcon = true;
            this.btnGeneratePassword.AutoSizeRightIcon = true;
            this.btnGeneratePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnGeneratePassword.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnGeneratePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeneratePassword.BackgroundImage")));
            this.btnGeneratePassword.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGeneratePassword.ButtonText = "";
            this.btnGeneratePassword.ButtonTextMarginLeft = 0;
            this.btnGeneratePassword.ColorContrastOnClick = 45;
            this.btnGeneratePassword.ColorContrastOnHover = 45;
            this.btnGeneratePassword.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnGeneratePassword.CustomizableEdges = borderEdges3;
            this.btnGeneratePassword.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGeneratePassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGeneratePassword.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGeneratePassword.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGeneratePassword.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnGeneratePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGeneratePassword.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneratePassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGeneratePassword.IconLeftPadding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnGeneratePassword.IconMarginLeft = 11;
            this.btnGeneratePassword.IconPadding = 5;
            this.btnGeneratePassword.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeneratePassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGeneratePassword.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGeneratePassword.IconSize = 25;
            this.btnGeneratePassword.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnGeneratePassword.IdleBorderRadius = 8;
            this.btnGeneratePassword.IdleBorderThickness = 2;
            this.btnGeneratePassword.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnGeneratePassword.IdleIconLeftImage = global::SecureFile.Properties.Resources.Password;
            this.btnGeneratePassword.IdleIconRightImage = null;
            this.btnGeneratePassword.IndicateFocus = false;
            this.btnGeneratePassword.Location = new System.Drawing.Point(355, 109);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGeneratePassword.OnDisabledState.BorderRadius = 8;
            this.btnGeneratePassword.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGeneratePassword.OnDisabledState.BorderThickness = 2;
            this.btnGeneratePassword.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGeneratePassword.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGeneratePassword.OnDisabledState.IconLeftImage = null;
            this.btnGeneratePassword.OnDisabledState.IconRightImage = null;
            this.btnGeneratePassword.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btnGeneratePassword.onHoverState.BorderRadius = 8;
            this.btnGeneratePassword.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGeneratePassword.onHoverState.BorderThickness = 2;
            this.btnGeneratePassword.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btnGeneratePassword.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.onHoverState.IconLeftImage = null;
            this.btnGeneratePassword.onHoverState.IconRightImage = null;
            this.btnGeneratePassword.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnGeneratePassword.OnIdleState.BorderRadius = 8;
            this.btnGeneratePassword.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGeneratePassword.OnIdleState.BorderThickness = 2;
            this.btnGeneratePassword.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnGeneratePassword.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.OnIdleState.IconLeftImage = global::SecureFile.Properties.Resources.Password;
            this.btnGeneratePassword.OnIdleState.IconRightImage = null;
            this.btnGeneratePassword.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnGeneratePassword.OnPressedState.BorderRadius = 8;
            this.btnGeneratePassword.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGeneratePassword.OnPressedState.BorderThickness = 2;
            this.btnGeneratePassword.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnGeneratePassword.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.OnPressedState.IconLeftImage = null;
            this.btnGeneratePassword.OnPressedState.IconRightImage = null;
            this.btnGeneratePassword.Size = new System.Drawing.Size(50, 42);
            this.btnGeneratePassword.TabIndex = 11;
            this.btnGeneratePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeneratePassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGeneratePassword.TextMarginLeft = 0;
            this.btnGeneratePassword.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGeneratePassword.UseDefaultRadiusAndThickness = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.AllowAnimations = true;
            this.btnUpload.AllowMouseEffects = true;
            this.btnUpload.AllowToggling = false;
            this.btnUpload.AnimationSpeed = 200;
            this.btnUpload.AutoGenerateColors = false;
            this.btnUpload.AutoRoundBorders = false;
            this.btnUpload.AutoSizeLeftIcon = true;
            this.btnUpload.AutoSizeRightIcon = true;
            this.btnUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnUpload.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpload.BackgroundImage")));
            this.btnUpload.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnUpload.ButtonText = "Upload file ";
            this.btnUpload.ButtonTextMarginLeft = 0;
            this.btnUpload.ColorContrastOnClick = 45;
            this.btnUpload.ColorContrastOnHover = 45;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnUpload.CustomizableEdges = borderEdges4;
            this.btnUpload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpload.DisabledBorderColor = System.Drawing.Color.White;
            this.btnUpload.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnUpload.DisabledForecolor = System.Drawing.Color.White;
            this.btnUpload.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUpload.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUpload.IconMarginLeft = 11;
            this.btnUpload.IconPadding = 10;
            this.btnUpload.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpload.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUpload.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUpload.IconSize = 25;
            this.btnUpload.IdleBorderColor = System.Drawing.Color.White;
            this.btnUpload.IdleBorderRadius = 10;
            this.btnUpload.IdleBorderThickness = 2;
            this.btnUpload.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnUpload.IdleIconLeftImage = null;
            this.btnUpload.IdleIconRightImage = null;
            this.btnUpload.IndicateFocus = false;
            this.btnUpload.Location = new System.Drawing.Point(30, 360);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.OnDisabledState.BorderColor = System.Drawing.Color.White;
            this.btnUpload.OnDisabledState.BorderRadius = 10;
            this.btnUpload.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnUpload.OnDisabledState.BorderThickness = 2;
            this.btnUpload.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnUpload.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnUpload.OnDisabledState.IconLeftImage = null;
            this.btnUpload.OnDisabledState.IconRightImage = null;
            this.btnUpload.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnUpload.onHoverState.BorderRadius = 10;
            this.btnUpload.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnUpload.onHoverState.BorderThickness = 2;
            this.btnUpload.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btnUpload.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUpload.onHoverState.IconLeftImage = null;
            this.btnUpload.onHoverState.IconRightImage = null;
            this.btnUpload.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnUpload.OnIdleState.BorderRadius = 10;
            this.btnUpload.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnUpload.OnIdleState.BorderThickness = 2;
            this.btnUpload.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnUpload.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnUpload.OnIdleState.IconLeftImage = null;
            this.btnUpload.OnIdleState.IconRightImage = null;
            this.btnUpload.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnUpload.OnPressedState.BorderRadius = 10;
            this.btnUpload.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnUpload.OnPressedState.BorderThickness = 2;
            this.btnUpload.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnUpload.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUpload.OnPressedState.IconLeftImage = null;
            this.btnUpload.OnPressedState.IconRightImage = null;
            this.btnUpload.Size = new System.Drawing.Size(375, 60);
            this.btnUpload.TabIndex = 10;
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpload.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpload.TextMarginLeft = 0;
            this.btnUpload.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUpload.UseDefaultRadiusAndThickness = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.AutoSizeHeight = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(30, 110);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties4;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(319, 40);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 3;
            this.txtPassword.TextMarginTop = 1;
            this.txtPassword.TextPlaceholder = "";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.WordWrap = true;
            // 
            // FilesPanel
            // 
            this.FilesPanel.Location = new System.Drawing.Point(440, 110);
            this.FilesPanel.Name = "FilesPanel";
            this.FilesPanel.Size = new System.Drawing.Size(400, 385);
            this.FilesPanel.TabIndex = 22;
            // 
            // ScrollBar
            // 
            this.ScrollBar.AllowCursorChanges = true;
            this.ScrollBar.AllowHomeEndKeysDetection = false;
            this.ScrollBar.AllowIncrementalClickMoves = true;
            this.ScrollBar.AllowMouseDownEffects = true;
            this.ScrollBar.AllowMouseHoverEffects = true;
            this.ScrollBar.AllowScrollingAnimations = true;
            this.ScrollBar.AllowScrollKeysDetection = true;
            this.ScrollBar.AllowScrollOptionsMenu = true;
            this.ScrollBar.AllowShrinkingOnFocusLost = false;
            this.ScrollBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ScrollBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScrollBar.BackgroundImage")));
            this.ScrollBar.BindingContainer = this.FilesPanel;
            this.ScrollBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ScrollBar.BorderRadius = 12;
            this.ScrollBar.BorderThickness = 1;
            this.ScrollBar.DurationBeforeShrink = 2000;
            this.ScrollBar.LargeChange = 10;
            this.ScrollBar.Location = new System.Drawing.Point(846, 109);
            this.ScrollBar.Maximum = 100;
            this.ScrollBar.Minimum = 0;
            this.ScrollBar.MinimumThumbLength = 18;
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.ScrollBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.ScrollBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.ScrollBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ScrollBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ScrollBar.ShrinkSizeLimit = 3;
            this.ScrollBar.Size = new System.Drawing.Size(15, 385);
            this.ScrollBar.SmallChange = 1;
            this.ScrollBar.TabIndex = 0;
            this.ScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.ScrollBar.ThumbLength = 37;
            this.ScrollBar.ThumbMargin = 1;
            this.ScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.ScrollBar.Value = 0;
            this.ScrollBar.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.ScrollBar_Scroll);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // sbMessage
            // 
            this.sbMessage.AllowDragging = false;
            this.sbMessage.AllowMultipleViews = true;
            this.sbMessage.ClickToClose = true;
            this.sbMessage.DoubleClickToClose = true;
            this.sbMessage.DurationAfterIdle = 3000;
            this.sbMessage.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sbMessage.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sbMessage.ErrorOptions.ActionBorderRadius = 1;
            this.sbMessage.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.sbMessage.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.sbMessage.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.sbMessage.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.sbMessage.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.sbMessage.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sbMessage.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.sbMessage.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.sbMessage.ErrorOptions.IconLeftMargin = 12;
            this.sbMessage.FadeCloseIcon = false;
            this.sbMessage.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.sbMessage.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sbMessage.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sbMessage.InformationOptions.ActionBorderRadius = 1;
            this.sbMessage.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.sbMessage.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.sbMessage.InformationOptions.BackColor = System.Drawing.Color.White;
            this.sbMessage.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.sbMessage.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.sbMessage.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sbMessage.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.sbMessage.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.sbMessage.InformationOptions.IconLeftMargin = 12;
            this.sbMessage.Margin = 10;
            this.sbMessage.MaximumSize = new System.Drawing.Size(0, 0);
            this.sbMessage.MaximumViews = 7;
            this.sbMessage.MessageRightMargin = 15;
            this.sbMessage.MinimumSize = new System.Drawing.Size(0, 0);
            this.sbMessage.ShowBorders = false;
            this.sbMessage.ShowCloseIcon = true;
            this.sbMessage.ShowIcon = true;
            this.sbMessage.ShowShadows = true;
            this.sbMessage.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sbMessage.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sbMessage.SuccessOptions.ActionBorderRadius = 1;
            this.sbMessage.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.sbMessage.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.sbMessage.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.sbMessage.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.sbMessage.SuccessOptions.CloseIconColor = System.Drawing.Color.Black;
            this.sbMessage.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbMessage.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.sbMessage.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.sbMessage.SuccessOptions.IconLeftMargin = 12;
            this.sbMessage.ViewsMargin = 7;
            this.sbMessage.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sbMessage.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sbMessage.WarningOptions.ActionBorderRadius = 1;
            this.sbMessage.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.sbMessage.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.sbMessage.WarningOptions.BackColor = System.Drawing.Color.White;
            this.sbMessage.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.sbMessage.WarningOptions.CloseIconColor = System.Drawing.Color.Black;
            this.sbMessage.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbMessage.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.sbMessage.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.sbMessage.WarningOptions.IconLeftMargin = 12;
            this.sbMessage.ZoomCloseIcon = true;
            // 
            // Loader
            // 
            this.Loader.AllowStylePresets = true;
            this.Loader.BackColor = System.Drawing.Color.Transparent;
            this.Loader.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.Loader.Color = System.Drawing.Color.White;
            this.Loader.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.Loader.Customization = "";
            this.Loader.DashWidth = 0.5F;
            this.Loader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Loader.Image = null;
            this.Loader.Location = new System.Drawing.Point(95, 454);
            this.Loader.Name = "Loader";
            this.Loader.NoRounding = false;
            this.Loader.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.Loader.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.Loader.ShowText = false;
            this.Loader.Size = new System.Drawing.Size(38, 38);
            this.Loader.Speed = 7;
            this.Loader.TabIndex = 23;
            this.Loader.Text = "bunifuLoader1";
            this.Loader.TextPadding = new System.Windows.Forms.Padding(0);
            this.Loader.Thickness = 5;
            this.Loader.Transparent = true;
            // 
            // bgwGetHASHEncrypted
            // 
            this.bgwGetHASHEncrypted.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGetHASHEncrypted_DoWork);
            // 
            // bgwGetHASHDecrypted
            // 
            this.bgwGetHASHDecrypted.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGetHASHDecrypted_DoWork);
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = global::SecureFile.Properties.Resources.Close;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 5;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(838, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 24;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 5;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // SecureFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Loader);
            this.Controls.Add(this.FilesPanel);
            this.Controls.Add(this.ScrollBar);
            this.Controls.Add(this.bunifuLabel13);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.cboAction);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.cboProcedure);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecureFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecureFile";
            this.Load += new System.EventHandler(this.SecureFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuDropdown cboProcedure;
        private Bunifu.UI.WinForms.BunifuDropdown cboAction;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnUpload;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnGeneratePassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnRun;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnCancel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel13;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.ComponentModel.BackgroundWorker bgwEncrypt;
        private System.ComponentModel.BackgroundWorker bgwDecrypt;
        private System.Windows.Forms.FlowLayoutPanel FilesPanel;
        private Bunifu.UI.WinForms.BunifuVScrollBar ScrollBar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuSnackbar sbMessage;
        private Bunifu.UI.WinForms.BunifuLoader Loader;
        private System.ComponentModel.BackgroundWorker bgwGetHASHEncrypted;
        private System.ComponentModel.BackgroundWorker bgwGetHASHDecrypted;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
    }
}

