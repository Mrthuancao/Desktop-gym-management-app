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
    public partial class NhanVien : Form
    {
        BindingSource nvlist = new BindingSource();
        NhanVienBUS nvBUS = new NhanVienBUS();

        public NhanVien()
        {
            InitializeComponent();
            Load();

        }

        void Load()
        {
            dtg_NV.DataSource = nvlist;
            LoadNhanVienList();
            AddNhanVienBinding();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            ThemNv f = new ThemNv(dtg_NV);
            f.ShowDialog();
            LoadNhanVienList();

        }
        void LoadNhanVienList()
        {
            nvlist.DataSource = nvBUS.GetNhanVienList();
            dtg_NV.Columns["phai"].Visible = false;
            dtg_NV.Columns["email"].Visible = false;
            dtg_NV.Columns["luong"].Visible = false;
            dtg_NV.Columns["ngsinh"].Visible = false;
            dtg_NV.Columns["ngvaolam"].Visible = false;
            dtg_NV.Columns["sdt"].Visible = false;
            dtg_NV.Columns["malnv"].Visible = false;
        }

        void AddNhanVienBinding()
        {
            tb_mnv.DataBindings.Add(new Binding("Texts", dtg_NV.DataSource, "manv"));
            tb_TenNv.DataBindings.Add(new Binding("Texts", dtg_NV.DataSource, "hoten"));
            tb_gioitinh.DataBindings.Add(new Binding("Texts", dtg_NV.DataSource, "phai"));
            dt_ngsinh.DataBindings.Add(new Binding("Text", dtg_NV.DataSource, "ngsinh"));
            dt_ngayvaolam.DataBindings.Add(new Binding("Text", dtg_NV.DataSource, "ngvaolam"));
            tb_Sdt.DataBindings.Add(new Binding("Texts", dtg_NV.DataSource, "sdt"));
            tb_Email.DataBindings.Add(new Binding("Texts", dtg_NV.DataSource, "email"));
            tb_Luong.DataBindings.Add(new Binding("Texts", dtg_NV.DataSource, "luong"));
            tb_mlnv.DataBindings.Add(new Binding("Texts", dtg_NV.DataSource, "malnv"));
        }

        private void bt_xoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dtg_NV.SelectedRows.Count > 0)
                {
                    if (nvBUS.DeleteNhanVien(dtg_NV.SelectedRows[0].Cells["hoten"].Value.ToString()))
                    {
                        MessageBox.Show("Đã xóa thành công");
                        this.Show();
                        LoadNhanVienList();
                    }
                }
                else
                    MessageBox.Show("Chọn một hội viên để xóa");


            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Xóa THẤT BẠI!");
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            
                tb_mnv.ReadOnly1 = false;
                tb_TenNv.ReadOnly1 = false;
                tb_gioitinh.ReadOnly1 = false;
                tb_Sdt.ReadOnly1 = false;
                tb_Email.ReadOnly1 = false;
                tb_Luong.ReadOnly1 = false;
                tb_mlnv.ReadOnly1 = false;
                dt_ngayvaolam.Enabled = true;
                dt_ngsinh.Enabled = true;
                bt_Luu.Enabled = true;
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_NV.SelectedRows.Count > 0)
                {
                    if (nvBUS.UpdateNhanVien(tb_mnv.Texts, tb_TenNv.Texts, tb_gioitinh.Texts, dt_ngsinh.Value.ToString(),
                        dt_ngayvaolam.Value.ToString(), tb_Sdt.Texts, tb_Email.Texts, decimal.Parse(tb_Luong.Texts),
                        tb_mlnv.Texts))
                    {
                        MessageBox.Show("Đã sửa thành công!");
                        LoadNhanVienList();
                    }
                }
                else
                    MessageBox.Show("Chọn một nhân viên để sửa");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Sửa THẤT BẠI!");
            }

            tb_mnv.ReadOnly1 = true;
            tb_TenNv.ReadOnly1 = true;
            tb_gioitinh.ReadOnly1 = true;
            tb_Sdt.ReadOnly1 = true;
            tb_Email.ReadOnly1 = true;
            tb_Luong.ReadOnly1 = true;
            tb_mlnv.ReadOnly1 = true;
            dt_ngayvaolam.Enabled = false;
            dt_ngsinh.Enabled = false;
            bt_Luu.Enabled = false;

        }

        private void NhanVienSearch_Enter(object sender, EventArgs e)
        {
            if (tb_Search.Text == "Search...")
            {
                tb_Search.Text = "";
                tb_Search.ForeColor = Color.Black;
            }
        }

        private void NhanVienSearch_Leave(object sender, EventArgs e)
        {
            if (tb_Search.Text == "")
            {
                tb_Search.Text = "Search...";
                tb_Search.ForeColor = Color.Gray;
            }
        }

        List<NHANVIEN> SearchNhanVienByName(string hoten)
        {
            List<NHANVIEN> listnv = nvBUS.GetNhanVienByName(hoten);

            return listnv;
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            nvlist.DataSource = SearchNhanVienByName(tb_Search.Texts);
        }
    }
}
