using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTrading.UserControls
{
    public partial class UCUserInfo : UserControl
    {
        public UCUserInfo()
        {
            InitializeComponent();
        }

        private void InitEvnets()
        {
            this.Load += UCUserInfo_Load;
        }

        private void UCUserInfo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
