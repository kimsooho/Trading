using AutoTrading.API;
using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

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
            if (Login())
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

        private bool Login()
        {
            string strAccessKey = txtAccessKey.Text;
            string strSecretKey = txtSecetKey.Text;

            if (!CheckSession(strAccessKey, strSecretKey))
                return false;

            if (chkRememberIdInfo.Checked)
            {
                Properties.Settings.Default.AccessKey = strAccessKey;
                Properties.Settings.Default.SecretKey = strSecretKey;

                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.AccessKey = string.Empty;
                Properties.Settings.Default.SecretKey = string.Empty;

                Properties.Settings.Default.Save();
            }

            return true;
        }

        private bool CheckSession(string strAccessKey, string strSecretKey)
        {
            RestApiManager.GetInstance().SetKeys(strAccessKey, strSecretKey);

            string ret = RestApiManager.GetInstance().GetAccounts().GetAllAccounts();

            if (ret.Contains("error"))
            {
                JObject jObject = JObject.Parse(ret);
                MessageBox.Show(jObject["error"]["message"].ToString(), "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
