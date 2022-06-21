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
        NhanVienBUS NvBUS = new NhanVienBUS();
        public CapTaiKhoan()
        {
            InitializeComponent();
            
            DataTable dt = tkBUS.GetALLACC();
            cb_manv.DataSource = NvBUS.GetManvPT();
            cb_manv.DisplayMember = "manv";
            int count = dt.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = dt.Rows[count - 1][0].ToString();
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
                tb_matk.Texts = "TK" + (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 100)
                tb_matk.Texts = "TK" + (chuoi2 + 1).ToString();

        }
        
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            
            cb_manv.Text = "";
            tb_username.Texts = "";
            tb_matkhau.Texts = "";
        }

        private void bt_Tao_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_matk.Texts != "" && tb_username.Texts != ""&& cb_manv.Text!="" && tb_matkhau.Texts!="")
                {
                    if (tkBUS.KiemTra(cb_manv.Text) == 1)
                        MessageBox.Show("Nhân viên này đã có tài khoản rồi! Vui lòng chọn nhân viên khác!");
                    else if (tkBUS.CheckUser(tb_username.Texts) == 1)
                        MessageBox.Show("Tài khoản đã có người dùng! Vui vòng nhập tài khoản khác!");
                    else if (tkBUS.insertAccount(tb_matk.Texts, tb_username.Texts, tb_matkhau.Texts, cb_manv.Text))
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
