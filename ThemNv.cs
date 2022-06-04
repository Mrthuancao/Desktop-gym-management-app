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
        public ThemNv(DataGridView dtg_NV)
        {
            InitializeComponent();
            int count = 0;
            count = dtg_NV.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dtg_NV.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
                tb_manv.Texts = "NV00" + (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 100)
                tb_manv.Texts = "NV0" + (chuoi2 + 1).ToString();
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

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            
                if (tb_TenNv.Texts == "" || tb_Sdt.Texts == "" || tb_Email.Texts.ToString() == "" || tb_Luong.Texts == ""|| tb_mlnv.Texts == "")
                {
                    MessageBox.Show("Điền đủ thông tin trước khi thêm nhân viên");
                }
                else
                {
                    if (nvBUS.InsertNhanVien(tb_TenNv.Texts, tb_manv.Texts, cb_gioitinh.SelectedItem.ToString(), dt_ngsinh.Value.ToString(), dt_ngayvaolam.Value.ToString(), tb_Sdt.Texts, tb_Email.Texts, decimal.Parse(tb_Luong.Texts), tb_mlnv.Texts))
                    {
                        MessageBox.Show("Đã thêm thành công");
                    }

                }
                this.Close();
        }
    }
}
