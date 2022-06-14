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
            cb_mlnv.DataSource = nvBUS.GetLNV();
            cb_mlnv.DisplayMember = "tenlnv";
            cb_mlnv.ValueMember = "malnv";
            
            int count = dtg_NV.Rows.Count;
            
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dtg_NV.Rows[count - 2].Cells[0].Value);
            
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
                tb_manv.Texts = "NV00" + (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 100)
                tb_manv.Texts = "NV0" + (chuoi2 + 1).ToString();
           
        }

        

        
        private void bt_xoahet_Click(object sender, EventArgs e)
        {
            //ClearTextBoxes();
            tb_TenNv.Texts = "";
            cb_gioitinh.Text = "";
            tb_Sdt.Texts = "";
            tb_Email.Texts = "";
            tb_Luong.Texts = "";
            cb_mlnv.Text = "";
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            
                if (tb_TenNv.Texts == "" || tb_Sdt.Texts == "" || tb_Email.Texts.ToString() == "" || tb_Luong.Texts == ""||  cb_mlnv.Text == "")
                {
                    MessageBox.Show("Điền đủ thông tin trước khi thêm nhân viên");
                }
                else
                {
                    if (nvBUS.InsertNhanVien(tb_TenNv.Texts, tb_manv.Texts, cb_gioitinh.SelectedItem.ToString(), dt_ngsinh.Value.ToString(), dt_ngayvaolam.Value.ToString(), tb_Sdt.Texts, tb_Email.Texts, decimal.Parse(tb_Luong.Texts), cb_mlnv.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Đã thêm thành công");
                    }

                }
                this.Close();
        }
    }
}
