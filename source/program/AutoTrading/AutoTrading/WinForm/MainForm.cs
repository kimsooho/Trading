﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

using AutoTrading.API;
using AutoTrading.Util;
using AutoTrading.UserControls;

namespace AutoTrading.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Visible = false;

            Login();
            InitEvents();
            
        }

        private void InitEvents()
        {
            this.Load += MainForm_Load;
        }

        private void Login()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.StartPosition = FormStartPosition.CenterParent;
            if(frmLogin.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Login Fail");
                Application.ExitThread();
                Environment.Exit(0);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Create();
        }

        private void Create()
        {
            UCMain uCMain = new UCMain();
            uCMain.Dock = DockStyle.Fill;
            this.Controls.Add(uCMain);
        }
    }
}
