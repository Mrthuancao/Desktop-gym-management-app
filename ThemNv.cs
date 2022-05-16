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
    public partial class ThemNv : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        public ThemNv()
        {
            InitializeComponent();
        }

        private void bt_Luu_Click_1(object sender, EventArgs e)
        {
            if (tb_TenNv.Texts == "" || tb_Sdt.Texts == "" || tb_Email.Texts.ToString() == "" || tb_Luong.Texts == "")
            {
                MessageBox.Show("Điền đủ thông tin trước khi thêm hội viên");
            }
            else
            {
                if (nvBUS.InsertNhanVien(tb_manv.Texts, tb_TenNv.Texts, cb_gioitinh.SelectedItem.ToString(), dt_ngsinh.Value.ToString(), dt_ngayvaolam.Value.ToString(), tb_Sdt.Texts, tb_Email.Texts, int.Parse(tb_Luong.Texts), tb_mlnv.Texts))
                {
                    MessageBox.Show("Đã thêm thành công");
                }

            }
            this.Close();
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
    }
}
