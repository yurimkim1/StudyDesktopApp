﻿using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MnuDivCode_Click(object sender, EventArgs e)
        {
            FrmDivCode frm = new FrmDivCode();
            frm.Dock = DockStyle.Fill;
            frm.MdiParent = this; // FrmMain
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = this.ClientSize.Width - 1000;
            frm.Height = this.Height - menuStrip1.Height;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroMessageBox.Show(this, "종료하시겠습니까?", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true; // 프로그램 종료 안함.
            }
        }

        private void MnuMember_Click(object sender, EventArgs e)
        {
            FrmMember frm = new FrmMember();
            frm.Dock = DockStyle.Fill;
            frm.MdiParent = this; // FrmMain
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = this.ClientSize.Width - 1000;
            frm.Height = this.Height - menuStrip1.Height;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }
    }
}