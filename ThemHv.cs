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
    public partial class ThemHv : Form
    {
        HoiVienBUS hvBUS = new HoiVienBUS();

        public ThemHv()
        {
            InitializeComponent();
        }

        private void bt_Luu_Click_1(object sender, EventArgs e)
        {
            if (tb_TenHV.Texts == "" || tb_cannang.Texts == "" || tb_chieucao.Texts.ToString() == "" || tb_Sdt.Texts == "" )
            {
                MessageBox.Show("Điền đủ thông tin trước khi thêm hội viên");
            }
            else
            {
                if (hvBUS.InsertHoiVien(tb_mahv.Texts, tb_TenHV.Texts, cb_gioitinh.SelectedItem.ToString(), float.Parse(tb_cannang.Texts), float.Parse(tb_chieucao.Texts), dt_ngsinh.Value.ToString(), dt_ngaydk.Value.ToString(), tb_Sdt.Texts))
                {
                    MessageBox.Show("Đã thêm thành công");
                }

            }
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
