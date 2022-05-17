using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Gym_Management
{
    public partial class fLogin : Form
    {
        TaiKhoanBUS accountBus = new TaiKhoanBUS();
        public TAIKHOAN currentUser;
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
        {   if (accountBus.logIn(tb_username.Texts, tb_password.Texts))
            {
                this.Hide();
                currentUser = accountBus.getAccountByUsername(tb_username.Texts);
                fTableManager fTable = new fTableManager(currentUser);
                fTable.ShowDialog();
                fTable.Close();
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản");
                tb_password.Text = "";
                tb_username.Focus();
            }
            
        }
    }
}
