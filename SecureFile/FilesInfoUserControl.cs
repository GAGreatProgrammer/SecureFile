using Bunifu.UI.WinForms;
using System;
using System.Windows.Forms;

namespace SecureFile
{
    public partial class FilesInfoUserControl : UserControl
    {
        SecureFile SecureFile = new SecureFile();
        private string FileFullPath = null;

        public FilesInfoUserControl()
        {
            InitializeComponent();
        }

        private void FilesInfoUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                FileFullPath = lblFile.Text;

                if (lblFile.Text.Length > 25)
                {
                    lblFile.Text = lblFile.Text.Substring(0, 25) + "...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        public BunifuLabel File
        {
            get { return lblFile; }
            set { lblFile = value; }
        }

        public BunifuLabel HASH
        {
            get { return lblHash; }
            set { lblHash = value; }
        }

        private void pbFile_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(lblHash.Text);

                sbMessage.Show(SecureFile.Instance, "HASH copied!", BunifuSnackbar.MessageTypes.Success,
                    duration: 3000, position: BunifuSnackbar.Positions.TopCenter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void pbFile_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(pbFile, "Double click the hash value to copy it to the clipboard");
        }

        private void pbFile_MouseLeave(object sender, EventArgs e)
        {
            ToolTip.Hide();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblFile_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(lblFile, FileFullPath);
        }

        private void lblFile_MouseLeave(object sender, EventArgs e)
        {
            ToolTip.Hide();
        }
    }
}
