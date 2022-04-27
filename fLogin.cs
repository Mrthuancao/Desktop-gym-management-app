﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit this window app?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void lb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            fTableManager f = new fTableManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
