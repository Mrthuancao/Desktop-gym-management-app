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
    public partial class ThemSp : Form
    {
        SanPhamBUS spBUS =  new SanPhamBUS();
        public ThemSp(DataGridView dtg_SP)
        {
            InitializeComponent();
            cb_loai.DataSource = spBUS.GetTenlsp();
            cb_loai.DisplayMember = "tenlsp";
            cb_loai.ValueMember = "malsp";
            int count = 0;
            count = dtg_SP.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dtg_SP.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)
                tb_masp.Texts = "SP-00" + (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 100)
                tb_masp.Texts = "SP-0" + (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 1000)
                tb_masp.Texts = "SP-" + (chuoi2 + 1).ToString();
            
                
        }
        
        private void bt_xoahet_Click(object sender, EventArgs e)
        {
            //ClearTextBoxes();
            tb_tensp.Texts = "";
            tb_gianhap.Texts = "";
            tb_dongia.Texts = "";
            tb_Sl.Texts = "";
            cb_loai.Text = "";
            
            
            
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (tb_masp.Texts == "" || tb_tensp.Texts == "" || tb_gianhap.Texts == ""|| tb_dongia.Texts == "" || tb_Sl.Texts == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin cho sản phẩm");
                    
                }
                else
                    if (spBUS.insertSanPham(tb_masp.Texts, tb_tensp.Texts,
                        decimal.Parse(tb_gianhap.Texts), decimal.Parse(tb_dongia.Texts),
                        int.Parse(tb_Sl.Texts), dt_ngnhap.Value.ToString(), cb_loai.SelectedValue.ToString()))
                {
                    MessageBox.Show("Đã thêm thành công");
                    this.Close();

                }


            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Thêm THẤT BẠI!");
            }
        }
    }
}
