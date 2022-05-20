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
        public ThemSp()
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
        private void bt_xoahet_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_masp.Texts != "" && tb_tensp.Texts != "" && tb_gianhap.Texts != ""
                    && tb_dongia.Texts != "" && tb_Sl.Texts != "")
                {

                    if (spBUS.insertSanPham(tb_masp.Texts, tb_tensp.Texts,
                        decimal.Parse(tb_gianhap.Texts), decimal.Parse(tb_dongia.Texts),
                        int.Parse(tb_Sl.Texts), dt_ngnhap.Value.ToString(), cb_loai.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Đã thêm thành công");
                        this.Close();

                    }
                }
                else
                    MessageBox.Show("Nhập đầy đủ thông tin cho sản phẩm");

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Thêm THẤT BẠI!");
            }
        }
    }
}
