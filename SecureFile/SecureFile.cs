using Bunifu.UI.WinForms;
using SecureFile.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SecureFile
{
    public partial class SecureFile : Form
    {
        GeneratePassword generatePassword = new GeneratePassword();

        private string File = null;
        private string FileHASH = null;

        static SecureFile _object;

        public static SecureFile Instance
        {
            get
            {
                if (_object == null)
                {
                    _object = new SecureFile();
                }
                return _object;
            }
        }

        public SecureFile()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.Icon1;
        }

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        private void SecureFile_Load(object sender, EventArgs e)
        {
            bgwEncrypt.RunWorkerCompleted += BgwEncrypt_RunWorkerCompleted;
            bgwDecrypt.RunWorkerCompleted += BgwDecrypt_RunWorkerCompleted;

            bgwGetHASHEncrypted.RunWorkerCompleted += BgwGetHASHEncrypted_RunWorkerCompleted;
            bgwGetHASHDecrypted.RunWorkerCompleted += BgwGetHASHDecrypted_RunWorkerCompleted;

            ScrollBar.Maximum = FilesPanel.VerticalScroll.Maximum;
            ScrollBar.ThumbLength = 100;

            btnRun.Enabled = false;

            Loader.BackColor = Color.FromArgb(78, 161, 250);
            Loader.Visible = false;
        }



        private void bgwEncrypt_DoWork(object sender, DoWorkEventArgs e)
        {
            Encryptor.FileEncrypt(File, txtPassword.Text);
        }

        private void bgwDecrypt_DoWork(object sender, DoWorkEventArgs e)
        {
            Decryptor.FileDecrypt(File, File.Substring(0, File.Length - 4), txtPassword.Text);
        }

        private void bgwGetHASHEncrypted_DoWork(object sender, DoWorkEventArgs e)
        {
            FileHASH = CalculateHASH.GetMD5HashFromFile(File + ".aes");
        }

        private void bgwGetHASHDecrypted_DoWork(object sender, DoWorkEventArgs e)
        {
            FileHASH = CalculateHASH.GetMD5HashFromFile(File.Remove(File.Length - 4));
        }

        private void BgwDecrypt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgwGetHASHDecrypted.RunWorkerAsync();

            sbMessage.Show(this, "Successfully decrypted!", BunifuSnackbar.MessageTypes.Success,
                duration: 3000, position: BunifuSnackbar.Positions.TopCenter);
        }

        private void BgwEncrypt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgwGetHASHEncrypted.RunWorkerAsync();

            sbMessage.Show(this, "Successfully encrypted!", BunifuSnackbar.MessageTypes.Success,
                duration: 3000, position: BunifuSnackbar.Positions.TopCenter);
        }

        private void BgwGetHASHDecrypted_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FilesInfoUserControl FilesInfo = new FilesInfoUserControl();

            FilesInfo.File.Text = File.Remove(File.Length - 4);
            FilesInfo.HASH.Text = FileHASH;

            FilesPanel.Controls.Add(FilesInfo);

            if (cboAction.SelectedIndex == 0)
            {
                if (System.IO.File.Exists(File))
                {
                    try
                    {
                        System.IO.File.Delete(File);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            txtPassword.Clear();
            cboProcedure.Text = "";
            cboAction.Text = "";
            File = null;

            //btnClose.Enabled = true;
            btnCancel.Enabled = true;
            btnUpload.Enabled = true;

            Loader.Visible = false;
        }

        private void BgwGetHASHEncrypted_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FilesInfoUserControl FilesInfo = new FilesInfoUserControl();

            FilesInfo.File.Text = File + ".aes";
            FilesInfo.HASH.Text = FileHASH;

            FilesPanel.Controls.Add(FilesInfo);

            if (cboAction.SelectedIndex == 0)
            {
                if (System.IO.File.Exists(File))
                {
                    try
                    {
                        System.IO.File.Delete(File);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            txtPassword.Clear();
            cboProcedure.Text = "";
            cboAction.Text = "";
            File = null;

            //btnClose.Enabled = true;
            btnCancel.Enabled = true;
            btnUpload.Enabled = true;

            Loader.Visible = false;
        }
        


        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            try
            {
                txtPassword.Text = generatePassword.Generate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboProcedure.SelectedIndex == 0)
                {
                    //btnClose.Enabled = false;
                    btnRun.Enabled = false;
                    btnCancel.Enabled = false;
                    btnUpload.Enabled = false;

                    Loader.Visible = true;

                    bgwEncrypt.RunWorkerAsync();
                }

                else if (cboProcedure.SelectedIndex == 1)
                {
                    //btnClose.Enabled = false;
                    btnRun.Enabled = false;
                    btnCancel.Enabled = false;
                    btnUpload.Enabled = false;

                    Loader.Visible = true;

                    bgwDecrypt.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(cboProcedure.Text) ||
                string.IsNullOrEmpty(cboAction.Text))
                {
                    sbMessage.Show(this, "Fill all necessary fields!", BunifuSnackbar.MessageTypes.Warning,
                    duration: 3000, position: BunifuSnackbar.Positions.TopCenter);
                }

                else
                {
                    ofdFile.InitialDirectory = @"C:\";
                    ofdFile.Title = "SecureFile";
                    ofdFile.CheckFileExists = true;
                    ofdFile.CheckPathExists = true;

                    if (ofdFile.ShowDialog() == DialogResult.OK)
                    {
                        btnRun.Enabled = true;

                        File = ofdFile.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            cboProcedure.Text = "";
            cboAction.Text = "";
            File = null;
            //btnClose.Enabled = true;
            btnRun.Enabled = false;

        }

        private void ScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            FilesPanel.AutoScrollPosition = new Point(FilesPanel.AutoScrollPosition.X, e.Value);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (bgwEncrypt.IsBusy || bgwDecrypt.IsBusy || bgwGetHASHEncrypted.IsBusy || bgwGetHASHDecrypted.IsBusy)
            {
                sbMessage.Show(this, "Wait for the end of the operation!", BunifuSnackbar.MessageTypes.Warning,
                duration: 3000, position: BunifuSnackbar.Positions.TopCenter);
            }
            else
                Environment.Exit(0);

            //Environment.Exit(0);
        }
    }
}
