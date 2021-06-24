using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTrading.WinForm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            InitEvents();
        }

        private void InitEvents()
        {
            this.Load += FrmLogin_Load;
            this.btnClose.Click += BtnClose_Click;
            this.btnLogin.Click += BtnLogin_Click;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            InitLoginInfo();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
            this.DialogResult = DialogResult.OK;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {            
            this.DialogResult = DialogResult.Cancel;
        }

        private void InitLoginInfo()
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.AccessKey) && !string.IsNullOrWhiteSpace(Properties.Settings.Default.SecretKey))
            {
                txtAccessKey.Text = Properties.Settings.Default.AccessKey;
                txtSecetKey.Text = Properties.Settings.Default.SecretKey;
                chkRememberIdInfo.Checked = true;
            }
        }

        private void Login()
        {
            if(chkRememberIdInfo.Checked)
            {
                Properties.Settings.Default.AccessKey = txtAccessKey.Text;
                Properties.Settings.Default.SecretKey = txtSecetKey.Text;

                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.AccessKey = string.Empty;
                Properties.Settings.Default.SecretKey = string.Empty;

                Properties.Settings.Default.Save();
            }
        }
    }
}
