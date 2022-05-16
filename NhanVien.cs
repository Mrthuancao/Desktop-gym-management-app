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
    public partial class NhanVien : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();

        public NhanVien()
        {
            InitializeComponent();
            LoadNhanVienList();
            AddNhanVienBinding();

        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            ThemNv f = new ThemNv();
            f.ShowDialog();
            InitializeComponent();
            LoadNhanVienList();
            AddNhanVienBinding();

        }
        void LoadNhanVienList()
        {
            dtg_NV.DataSource = nvBUS.GetEmployeesList();
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

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_NV.SelectedRows.Count > 0)
                {
                    if (nvBUS.deleteEmployee(dtg_NV.SelectedRows[0].Cells["manv"].Value.ToString()))
                    {
                        MessageBox.Show("Đã xóa thành công");
                        //dtg_HV.DataSource = hvBUS.GetAllHoivienDetailed();
                        InitializeComponent();
                        LoadNhanVienList();
                        AddNhanVienBinding();
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
    }
}
