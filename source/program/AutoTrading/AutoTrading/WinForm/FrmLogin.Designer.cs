namespace AutoTrading.WinForm
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel = new System.Windows.Forms.Panel();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbAccessKey = new System.Windows.Forms.Label();
            this.lbSecretKey = new System.Windows.Forms.Label();
            this.txtAccessKey = new System.Windows.Forms.TextBox();
            this.txtSecetKey = new System.Windows.Forms.TextBox();
            this.chkRememberIdInfo = new System.Windows.Forms.CheckBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.pnlInput);
            this.Panel.Controls.Add(this.pnlButton);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(516, 189);
            this.Panel.TabIndex = 0;
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.tableLayoutPanel);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlInput.Size = new System.Drawing.Size(516, 151);
            this.pnlInput.TabIndex = 2;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.lbAccessKey, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lbSecretKey, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txtAccessKey, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.txtSecetKey, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.chkRememberIdInfo, 2, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(506, 151);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lbAccessKey
            // 
            this.lbAccessKey.AutoSize = true;
            this.lbAccessKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAccessKey.Font = new System.Drawing.Font("굴림", 10F);
            this.lbAccessKey.Location = new System.Drawing.Point(13, 20);
            this.lbAccessKey.Name = "lbAccessKey";
            this.lbAccessKey.Size = new System.Drawing.Size(94, 30);
            this.lbAccessKey.TabIndex = 0;
            this.lbAccessKey.Text = "AccessKey : ";
            this.lbAccessKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSecretKey
            // 
            this.lbSecretKey.AutoSize = true;
            this.lbSecretKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSecretKey.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSecretKey.Location = new System.Drawing.Point(13, 81);
            this.lbSecretKey.Name = "lbSecretKey";
            this.lbSecretKey.Size = new System.Drawing.Size(94, 30);
            this.lbSecretKey.TabIndex = 1;
            this.lbSecretKey.Text = "SecretKey  :";
            this.lbSecretKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAccessKey
            // 
            this.txtAccessKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAccessKey.Font = new System.Drawing.Font("굴림", 10F);
            this.txtAccessKey.Location = new System.Drawing.Point(113, 23);
            this.txtAccessKey.Name = "txtAccessKey";
            this.txtAccessKey.Size = new System.Drawing.Size(390, 23);
            this.txtAccessKey.TabIndex = 2;
            // 
            // txtSecetKey
            // 
            this.txtSecetKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSecetKey.Font = new System.Drawing.Font("굴림", 10F);
            this.txtSecetKey.Location = new System.Drawing.Point(113, 84);
            this.txtSecetKey.Name = "txtSecetKey";
            this.txtSecetKey.PasswordChar = '*';
            this.txtSecetKey.Size = new System.Drawing.Size(390, 23);
            this.txtSecetKey.TabIndex = 3;
            // 
            // chkRememberIdInfo
            // 
            this.chkRememberIdInfo.AutoSize = true;
            this.chkRememberIdInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkRememberIdInfo.Location = new System.Drawing.Point(387, 114);
            this.chkRememberIdInfo.Name = "chkRememberIdInfo";
            this.chkRememberIdInfo.Size = new System.Drawing.Size(116, 34);
            this.chkRememberIdInfo.TabIndex = 4;
            this.chkRememberIdInfo.Text = "로그인 정보 저장";
            this.chkRememberIdInfo.UseVisualStyleBackColor = true;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.pnlLogin);
            this.pnlButton.Controls.Add(this.pnlClose);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 151);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlButton.Size = new System.Drawing.Size(516, 38);
            this.pnlButton.TabIndex = 1;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLogin.Location = new System.Drawing.Point(344, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Padding = new System.Windows.Forms.Padding(5);
            this.pnlLogin.Size = new System.Drawing.Size(81, 38);
            this.pnlLogin.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.Location = new System.Drawing.Point(5, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(71, 28);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // pnlClose
            // 
            this.pnlClose.Controls.Add(this.btnClose);
            this.pnlClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlClose.Location = new System.Drawing.Point(425, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Padding = new System.Windows.Forms.Padding(5);
            this.pnlClose.Size = new System.Drawing.Size(81, 38);
            this.pnlClose.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "닫 기";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 189);
            this.Controls.Add(this.Panel);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Panel.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbAccessKey;
        private System.Windows.Forms.Label lbSecretKey;
        private System.Windows.Forms.TextBox txtAccessKey;
        private System.Windows.Forms.TextBox txtSecetKey;
        private System.Windows.Forms.CheckBox chkRememberIdInfo;
    }
}