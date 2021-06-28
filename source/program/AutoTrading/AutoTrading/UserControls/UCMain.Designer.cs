namespace AutoTrading.UserControls
{
    partial class UCMain
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
            this.pnlTreeview = new System.Windows.Forms.Panel();
            this.ucTreeView = new AutoTrading.UserControls.UCTreeView();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.ucUserInfo = new AutoTrading.UserControls.UCUserInfo();
            this.pnlContents = new System.Windows.Forms.Panel();
            this.pnlTab = new System.Windows.Forms.Panel();
            this.ucContentTab = new AutoTrading.UserControls.UCContentTab();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTreeview.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            this.pnlContents.SuspendLayout();
            this.pnlTab.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTreeview
            // 
            this.pnlTreeview.Controls.Add(this.ucTreeView);
            this.pnlTreeview.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTreeview.Location = new System.Drawing.Point(0, 0);
            this.pnlTreeview.Name = "pnlTreeview";
            this.pnlTreeview.Size = new System.Drawing.Size(200, 439);
            this.pnlTreeview.TabIndex = 0;
            // 
            // ucTreeView
            // 
            this.ucTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTreeView.Location = new System.Drawing.Point(0, 0);
            this.ucTreeView.Name = "ucTreeView";
            this.ucTreeView.Size = new System.Drawing.Size(200, 439);
            this.ucTreeView.TabIndex = 0;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.ucUserInfo);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(737, 71);
            this.pnlUserInfo.TabIndex = 1;
            // 
            // ucUserInfo
            // 
            this.ucUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUserInfo.Location = new System.Drawing.Point(0, 0);
            this.ucUserInfo.Name = "ucUserInfo";
            this.ucUserInfo.Size = new System.Drawing.Size(737, 71);
            this.ucUserInfo.TabIndex = 0;
            // 
            // pnlContents
            // 
            this.pnlContents.Controls.Add(this.pnlTab);
            this.pnlContents.Controls.Add(this.pnlTreeview);
            this.pnlContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContents.Location = new System.Drawing.Point(0, 71);
            this.pnlContents.Name = "pnlContents";
            this.pnlContents.Size = new System.Drawing.Size(737, 439);
            this.pnlContents.TabIndex = 2;
            // 
            // pnlTab
            // 
            this.pnlTab.Controls.Add(this.ucContentTab);
            this.pnlTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTab.Location = new System.Drawing.Point(200, 0);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.Size = new System.Drawing.Size(537, 439);
            this.pnlTab.TabIndex = 1;
            // 
            // ucContentTab
            // 
            this.ucContentTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucContentTab.Location = new System.Drawing.Point(0, 0);
            this.ucContentTab.Name = "ucContentTab";
            this.ucContentTab.Size = new System.Drawing.Size(537, 439);
            this.ucContentTab.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Controls.Add(this.pnlContents);
            this.pnlMain.Controls.Add(this.pnlUserInfo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(741, 514);
            this.pnlMain.TabIndex = 1;
            // 
            // UCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(741, 514);
            this.pnlTreeview.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlContents.ResumeLayout(false);
            this.pnlTab.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTreeview;
        private UCTreeView ucTreeView;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Panel pnlContents;
        private System.Windows.Forms.Panel pnlTab;
        private UCUserInfo ucUserInfo;
        private UCContentTab ucContentTab;
        private System.Windows.Forms.Panel pnlMain;
    }
}
