using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace Gym_Management
{
    public partial class CapTaiKhoan : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();

        public CapTaiKhoan()
        {
            InitializeComponent();
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
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void bt_Tao_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_matk.Texts != "" && tb_manv.Texts != "" && tb_username.Texts != "" )
                {
                    if (tkBUS.insertAccount(tb_matk.Texts, tb_username.Texts, tb_matkhau.Texts, tb_manv.Texts))
                    {
                        MessageBox.Show("Đã thêm thành công");
                        this.Close();

                    }
                }
                else
                    MessageBox.Show("Nhập đầy đủ thông tin cho tài khoản");

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Thêm THẤT BẠI!");
            }
        }
    }
}
