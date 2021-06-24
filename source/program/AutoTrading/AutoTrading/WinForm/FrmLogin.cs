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
            this.btnClose.Click += BtnClose_Click;
            this.btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
