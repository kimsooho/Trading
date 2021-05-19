using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IdentityModel.Tokens.Jwt;
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
            InitEvents();
        }

        private void InitEvents()
        {
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   
            RestApiManager.GetInstance().SetKeys("ACCESS KEY 입력", "SECRET KEY 입력");
            MessageBox.Show(RestApiManager.GetInstance().GetAccounts().GetAllAccounts());
            Debug.GetInstance().Log("hello");
        }
    }
}
