
namespace SecureFile
{
    partial class FilesInfoUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesInfoUserControl));
            this.pbFile = new System.Windows.Forms.PictureBox();
            this.lblFile = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblHash = new Bunifu.UI.WinForms.BunifuLabel();
            this.ToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.sbMessage = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.Eulipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbFile)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFile
            // 
            this.pbFile.Image = global::SecureFile.Properties.Resources.File;
            this.pbFile.Location = new System.Drawing.Point(5, 11);
            this.pbFile.Name = "pbFile";
            this.pbFile.Size = new System.Drawing.Size(40, 40);
            this.pbFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFile.TabIndex = 0;
            this.pbFile.TabStop = false;
            this.ToolTip.SetToolTip(this.pbFile, "");
            this.ToolTip.SetToolTipIcon(this.pbFile, null);
            this.ToolTip.SetToolTipTitle(this.pbFile, "");
            this.pbFile.DoubleClick += new System.EventHandler(this.pbFile_DoubleClick);
            this.pbFile.MouseLeave += new System.EventHandler(this.pbFile_MouseLeave);
            this.pbFile.MouseHover += new System.EventHandler(this.pbFile_MouseHover);
            // 
            // lblFile
            // 
            this.lblFile.AllowParentOverrides = false;
            this.lblFile.AutoEllipsis = false;
            this.lblFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFile.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFile.ForeColor = System.Drawing.Color.White;
            this.lblFile.Location = new System.Drawing.Point(55, 10);
            this.lblFile.Name = "lblFile";
            this.lblFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFile.Size = new System.Drawing.Size(235, 21);
            this.lblFile.TabIndex = 15;
            this.lblFile.Text = "C:\\Users\\giorg\\source\\repos\\...";
            this.lblFile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFile.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.ToolTip.SetToolTip(this.lblFile, "");
            this.ToolTip.SetToolTipIcon(this.lblFile, null);
            this.ToolTip.SetToolTipTitle(this.lblFile, "");
            this.lblFile.MouseLeave += new System.EventHandler(this.lblFile_MouseLeave);
            this.lblFile.MouseHover += new System.EventHandler(this.lblFile_MouseHover);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(54, 37);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(66, 15);
            this.bunifuLabel1.TabIndex = 16;
            this.bunifuLabel1.Text = "MD5 HASH:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.ToolTip.SetToolTip(this.bunifuLabel1, "");
            this.ToolTip.SetToolTipIcon(this.bunifuLabel1, null);
            this.ToolTip.SetToolTipTitle(this.bunifuLabel1, "");
            // 
            // lblHash
            // 
            this.lblHash.AllowParentOverrides = false;
            this.lblHash.AutoEllipsis = false;
            this.lblHash.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHash.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblHash.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHash.ForeColor = System.Drawing.Color.White;
            this.lblHash.Location = new System.Drawing.Point(124, 37);
            this.lblHash.Name = "lblHash";
            this.lblHash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHash.Size = new System.Drawing.Size(212, 15);
            this.lblHash.TabIndex = 17;
            this.lblHash.Text = "D651AFF55A919DC77BBC01D27520FDCE";
            this.lblHash.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblHash.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.ToolTip.SetToolTip(this.lblHash, "");
            this.ToolTip.SetToolTipIcon(this.lblHash, null);
            this.ToolTip.SetToolTipTitle(this.lblHash, "");
            // 
            // ToolTip
            // 
            this.ToolTip.Active = true;
            this.ToolTip.AlignTextWithTitle = false;
            this.ToolTip.AllowAutoClose = false;
            this.ToolTip.AllowFading = true;
            this.ToolTip.AutoCloseDuration = 5000;
            this.ToolTip.BackColor = System.Drawing.SystemColors.Control;
            this.ToolTip.BorderColor = System.Drawing.Color.Gainsboro;
            this.ToolTip.ClickToShowDisplayControl = false;
            this.ToolTip.ConvertNewlinesToBreakTags = true;
            this.ToolTip.DisplayControl = null;
            this.ToolTip.EntryAnimationSpeed = 350;
            this.ToolTip.ExitAnimationSpeed = 200;
            this.ToolTip.GenerateAutoCloseDuration = false;
            this.ToolTip.IconMargin = 6;
            this.ToolTip.InitialDelay = 0;
            this.ToolTip.Name = "ToolTip";
            this.ToolTip.Opacity = 1D;
            this.ToolTip.OverrideToolTipTitles = false;
            this.ToolTip.Padding = new System.Windows.Forms.Padding(10);
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.ShowAlways = true;
            this.ToolTip.ShowBorders = false;
            this.ToolTip.ShowIcons = true;
            this.ToolTip.ShowShadows = true;
            this.ToolTip.Tag = null;
            this.ToolTip.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolTip.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolTip.TextMargin = 2;
            this.ToolTip.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolTip.TitleForeColor = System.Drawing.Color.Black;
            this.ToolTip.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.ToolTip.ToolTipTitle = null;
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
            this.sbMessage.ShowCloseIcon = false;
            this.sbMessage.ShowIcon = true;
            this.sbMessage.ShowShadows = true;
            this.sbMessage.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sbMessage.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sbMessage.SuccessOptions.ActionBorderRadius = 1;
            this.sbMessage.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbMessage.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.sbMessage.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.sbMessage.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.sbMessage.SuccessOptions.CloseIconColor = System.Drawing.Color.White;
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
            this.sbMessage.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.sbMessage.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sbMessage.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.sbMessage.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.sbMessage.WarningOptions.IconLeftMargin = 12;
            this.sbMessage.ZoomCloseIcon = true;
            // 
            // Eulipse
            // 
            this.Eulipse.ElipseRadius = 20;
            this.Eulipse.TargetControl = this;
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
            this.btnClose.Image = global::SecureFile.Properties.Resources.CloseFile;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 5;
            this.btnClose.ImageSize = new System.Drawing.Size(18, 18);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(23, 23);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(350, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 25;
            this.ToolTip.SetToolTip(this.btnClose, "");
            this.ToolTip.SetToolTipIcon(this.btnClose, null);
            this.btnClose.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.btnClose, "");
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 5;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // FilesInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.pbFile);
            this.Name = "FilesInfoUserControl";
            this.Size = new System.Drawing.Size(390, 65);
            this.ToolTip.SetToolTip(this, "");
            this.ToolTip.SetToolTipIcon(this, null);
            this.ToolTip.SetToolTipTitle(this, "");
            this.Load += new System.EventHandler(this.FilesInfoUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFile;
        private Bunifu.UI.WinForms.BunifuLabel lblFile;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel lblHash;
        private Bunifu.UI.WinForms.BunifuToolTip ToolTip;
        private Bunifu.UI.WinForms.BunifuSnackbar sbMessage;
        private Bunifu.Framework.UI.BunifuElipse Eulipse;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
    }
}
