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
    public partial class SuaSp : Form
    {
        private SANPHAM sp;
        SanPhamBUS spBUS = new SanPhamBUS();
        public SANPHAM Sp { get => sp; set => sp = value; }
        public SuaSp(SANPHAM currentsp)
        {
            sp = currentsp;
            InitializeComponent();
            ChangeSP(sp);
        }

        void ChangeSP(SANPHAM sp)
        {
            tb_masp.Texts = sp.Masp;
            tb_tensp.Texts = sp.Tensp;
            tb_gianhap.Texts = sp.Gianhap.ToString();
            tb_dongia.Texts = sp.Dongia.ToString();
            tb_Sl.Texts = sp.Soluong.ToString();
            dt_ngnhap.Text = sp.Ngaymua;
            tb_loaisp.Texts = sp.Malsp;
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
                    if (spBUS.updateSanPham(tb_masp.Texts, tb_tensp.Texts,
                        decimal.Parse(tb_gianhap.Texts), decimal.Parse(tb_dongia.Texts),
                        int.Parse(tb_Sl.Texts), dt_ngnhap.Value.ToString(), tb_loaisp.Texts))
                    {
                        MessageBox.Show("Đã sửa thành công");
                        this.Close();

                    }
                }
                else
                    MessageBox.Show("Nhập đầy đủ các thông tin!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Sửa THẤT BẠI!");
            }
        }
    }
}
