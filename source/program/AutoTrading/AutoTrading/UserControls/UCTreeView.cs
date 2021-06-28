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
    public partial class UCTreeView : UserControl
    {
        public UCTreeView()
        {
            InitializeComponent();
            InitItems();
        }

        private void InitEvents()
        {

        }

        private void InitItems()
        {
            TreeNode nodeAccounts = new TreeNode("투자 내역");
            nodeAccounts.Nodes.Add("보유 코인");
            nodeAccounts.Nodes.Add("거래 내역");

            TreeNode nodeOrder = new TreeNode("거래소");
            nodeOrder.Nodes.Add("코인 리스트");
            nodeOrder.Nodes.Add("주문 리스트");

            TreeNode nodeDepositWithdrawal = new TreeNode("입출금");
            nodeDepositWithdrawal.Nodes.Add("입출금 리스트");

            TreeNode nodeSystem = new TreeNode("계정 관리");
            nodeSystem.Nodes.Add("API 키 리스트");

            this.treeView.Nodes.Add(nodeAccounts);
            this.treeView.Nodes.Add(nodeOrder);
            this.treeView.Nodes.Add(nodeSystem);
        }
    }
}
