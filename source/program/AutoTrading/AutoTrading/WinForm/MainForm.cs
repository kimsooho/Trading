using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

using AutoTrading.API;
using AutoTrading.Util;

namespace AutoTrading.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Visible = false;

            Login();
            InitEvents();
            
        }

        private void InitEvents()
        {
            this.Load += MainForm_Load;
        }

        private void Login()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.StartPosition = FormStartPosition.CenterParent;
            if(frmLogin.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Login Fail");
                Application.ExitThread();
                Environment.Exit(0);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   
            //RestApiManager.GetInstance().SetKeys("ACCESS KEY 입력", "SECRET KEY 입력");
            //MessageBox.Show(RestApiManager.GetInstance().GetAccounts().GetAllAccounts());
            //Debug.Log("hello");
        }
    }
}
