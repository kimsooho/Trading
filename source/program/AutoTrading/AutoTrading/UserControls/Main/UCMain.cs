using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoTrading.Util;
using AutoTrading.Events;

namespace AutoTrading.UserControls
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
            InitEvents();
        }

        private void InitEvents()
        {
            ucTreeView.NodeClick += UcTreeView_NodeClick;
        }

        private void UcTreeView_NodeClick(object sender, EventArgs e)
        {
            string key = (e as NodeMouseClickEventArgs).Key;
            string title = (e as NodeMouseClickEventArgs).Title;

            Debug.Log(string.Format("key : {0} / title : {1}", key, title));

            ucContentTab.CreateTabPage(key, title);                
        }
    }
}
