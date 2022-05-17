using DTO;
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
namespace Gym_Management
{
    public partial class ThongTinTk : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();  
        private TAIKHOAN logAcc;
        public TAIKHOAN LogAcc
        {
            get { return logAcc; }
            set { logAcc = value; ChangeAccount(logAcc); }
        }

        

        public ThongTinTk(TAIKHOAN acc)
        {
            logAcc = acc;
            InitializeComponent();
            ChangeAccount(logAcc);
        }
        void ChangeAccount(TAIKHOAN logAcc)
        {
            tb_mtk.Texts = logAcc.Matk;
            tb_username.Texts = logAcc.Username;
            tb_pass.Texts = logAcc.Pass;
            tb_mnv.Texts = logAcc.Manv;
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void bt_xoahet_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            tb_username.ReadOnly1 = false;
            tb_pass.ReadOnly1 = false;
            bt_Luu.Enabled = true;
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_username.Texts != "" && tb_pass.Texts != "")
                {
                    if (tkBUS.updateAccount(tb_mtk.Texts, tb_username.Texts, tb_pass.Texts))
                    {
                        MessageBox.Show("Đã sửa thành công");
                        tb_username.ReadOnly1 = true;
                        tb_pass.ReadOnly1 = true;
                        bt_Luu.Enabled = false;
                        this.Close();
                        
                    }
                }
                else
                    MessageBox.Show("Nhập username và password cho tài khoản");

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Sửa THẤT BẠI!");
            }
            tb_username.ReadOnly1 = true;
            tb_pass.ReadOnly1 = true;
            bt_Luu.Enabled = false;
        }
    }
}
