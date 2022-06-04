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

        public ThemHv(DataGridView dtg_HV)
        {
            InitializeComponent();
            int count = 0;
            count = dtg_HV.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dtg_HV.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
            if (chuoi2 + 1 < 10)
                tb_mahv.Texts = "00" + (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 100)
                tb_mahv.Texts = "0" + (chuoi2 + 1).ToString();
        }

        private void bt_Luu_Click_1(object sender, EventArgs e)
        {
            
             

            if (tb_TenHV.Texts == "" || tb_Sdt.Texts == "" )
            {
                MessageBox.Show("Điền đủ thông tin trước khi thêm hội viên");
            }
            else
            {
                if (hvBUS.InsertHoiVien(tb_mahv.Texts, tb_TenHV.Texts, cb_gioitinh.SelectedItem.ToString(), dt_ngsinh.Value.ToString(), dt_ngaydk.Value.ToString(), tb_Sdt.Texts))
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
