using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoTrading.API;
using AutoTrading.Util;

namespace AutoTrading.UserControls.Accounts
{
    public partial class UCAccountList : UserControl
    {
        public UCAccountList()
        {
            InitializeComponent();
            InitEvents();
        }

        private void InitEvents()
        {
            Debug.Log(RestApiManager.GetInstance().GetAccounts().GetAllAccounts());
            
        }
    }
}
