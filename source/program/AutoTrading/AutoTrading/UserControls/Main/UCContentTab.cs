using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoTrading.UserControls.Accounts;

namespace AutoTrading.UserControls
{
    public partial class UCContentTab : UserControl
    {
        public UCContentTab()
        {
            InitializeComponent();
        }

        private void InitEvents()
        {

        }

        private bool ExistTabPage(string key)
        {
            bool exist = false;
            foreach(TabPage page in this.tabControl.TabPages)
            {
                if (page.Name.Equals(key))
                {
                    exist = true;
                    this.tabControl.SelectedTab = page;
                    break;
                }
            }

            return exist;
        }

        public void CreateTabPage(string key, string title)
        {
            if (string.IsNullOrWhiteSpace(key) || ExistTabPage(key))
                return;

            TabPage page = new TabPage();
            page.Name = key;            
            page.Text = title;
            UserControl userControl;
            switch (key)
            {
                case "AccountList":
                    userControl = new UCAccountList();
                    userControl.Dock = DockStyle.Fill;
                    break;
                default:
                    userControl = new UserControl();
                    userControl.Dock = DockStyle.Fill;
                    break;
            }

            page.Controls.Add(userControl);
            this.tabControl.TabPages.Add(page);
            this.tabControl.SelectedTab = page;
        }
    }
}
