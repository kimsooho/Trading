namespace AutoTrading.UserControls.Accounts
{
    partial class UCAccountList
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAccountInfo = new System.Windows.Forms.Panel();
            this.pnlCoinInfo = new System.Windows.Forms.Panel();
            this.gvCoin = new System.Windows.Forms.DataGridView();
            this.pnlCoinInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAccountInfo
            // 
            this.pnlAccountInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccountInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlAccountInfo.Name = "pnlAccountInfo";
            this.pnlAccountInfo.Size = new System.Drawing.Size(1214, 140);
            this.pnlAccountInfo.TabIndex = 0;
            // 
            // pnlCoinInfo
            // 
            this.pnlCoinInfo.Controls.Add(this.gvCoin);
            this.pnlCoinInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCoinInfo.Location = new System.Drawing.Point(0, 140);
            this.pnlCoinInfo.Name = "pnlCoinInfo";
            this.pnlCoinInfo.Size = new System.Drawing.Size(1214, 557);
            this.pnlCoinInfo.TabIndex = 1;
            // 
            // gvCoin
            // 
            this.gvCoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvCoin.Location = new System.Drawing.Point(0, 0);
            this.gvCoin.Name = "gvCoin";
            this.gvCoin.RowTemplate.Height = 23;
            this.gvCoin.Size = new System.Drawing.Size(1214, 557);
            this.gvCoin.TabIndex = 0;
            // 
            // UCAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCoinInfo);
            this.Controls.Add(this.pnlAccountInfo);
            this.Name = "UCAccountList";
            this.Size = new System.Drawing.Size(1214, 697);
            this.pnlCoinInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCoin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccountInfo;
        private System.Windows.Forms.Panel pnlCoinInfo;
        private System.Windows.Forms.DataGridView gvCoin;
    }
}
