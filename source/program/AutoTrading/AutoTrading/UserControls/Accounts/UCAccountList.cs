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
            InitColumns();
        }

        private void InitEvents()
        {
            Debug.Log(RestApiManager.GetInstance().GetAccounts().GetAllAccounts());
            
        }

        private void FillData()
        {
            //DataTable 
        }

        private void InitColumns()
        {
            List<Column> listColumn = new List<Column>
            {
                new Column("currency", "화폐", true),
                new Column("balance", "주문 가능 금액", true),
                new Column("locked", "주문 중인 금액", true),
                new Column("avg_buy_price", "매수 평균가", true),
                new Column("avg_buy_price_modified", "매수 평균가 수정 여부", true),
                new Column("unit_currency", "평단가 기준", true)
            };

            DataTable dt = new DataTable();
            gvCoin.DataSource = dt;

            foreach (Column col in listColumn)
            {
                dt.Columns.Add(col.Name);
                dt.Columns[col.Name].Caption = col.Caption;
                gvCoin.Columns[col.Name].Visible = col.Visible;
                gvCoin.Columns[col.Name].HeaderText = col.Caption;                
            }
        }
    }
}
