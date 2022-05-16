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
    public partial class HoiVien : Form
    {
        BindingSource hvist = new BindingSource();
        HoiVienBUS hvBUS = new HoiVienBUS();
        
        public HoiVien()
        {
            InitializeComponent();
            Load();

        }
        void Load()
        {
            dtg_HV.DataSource = hvist;
            LoadHoiVienList();
            AddHoiVienBinding();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            ThemHv f = new ThemHv();
            f.ShowDialog();
            LoadHoiVienList();
        }
        void LoadHoiVienList()
        {
            hvist.DataSource = hvBUS.GetHoiVienList(); 
            dtg_HV.Columns["phai"].Visible = false;
            dtg_HV.Columns["cannang"].Visible = false;
            dtg_HV.Columns["chieucao"].Visible = false;
            dtg_HV.Columns["ngsinh"].Visible = false;
            dtg_HV.Columns["ngdangki"].Visible = false;
            dtg_HV.Columns["sdt"].Visible = false;
        }
        
        void AddHoiVienBinding()
        {

            tb_MaHV.DataBindings.Add(new Binding("Texts",dtg_HV.DataSource, "mahv", true, DataSourceUpdateMode.Never));
            tb_TenHV.DataBindings.Add(new Binding("Texts", dtg_HV.DataSource, "hoten", true, DataSourceUpdateMode.Never));
            tb_gioitinh.DataBindings.Add(new Binding("Texts", dtg_HV.DataSource, "phai", true, DataSourceUpdateMode.Never));
            tb_cannang.DataBindings.Add(new Binding("Texts", dtg_HV.DataSource, "cannang", true, DataSourceUpdateMode.Never));
            tb_chieucao.DataBindings.Add(new Binding("Texts", dtg_HV.DataSource, "chieucao", true, DataSourceUpdateMode.Never));
            dt_ngsinh.DataBindings.Add(new Binding("Text", dtg_HV.DataSource, "ngsinh", true, DataSourceUpdateMode.Never));
            dt_ngaydk.DataBindings.Add(new Binding("Text", dtg_HV.DataSource, "ngdangki", true, DataSourceUpdateMode.Never));
            tb_Sdt.DataBindings.Add(new Binding("Texts", dtg_HV.DataSource, "sdt", true, DataSourceUpdateMode.Never));
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_HV.SelectedRows.Count > 0)
                {
                    if (hvBUS.DeleteHoiVien(dtg_HV.SelectedRows[0].Cells["mahv"].Value.ToString()))
                    {
                        MessageBox.Show("Đã xóa thành công");
                        this.Show();
                        LoadHoiVienList();
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

            tb_TenHV.ReadOnly1 = false;
            tb_gioitinh.ReadOnly1 = false;
            tb_cannang.ReadOnly1 = false;
            tb_chieucao.ReadOnly1 = false;
            tb_Sdt.ReadOnly1 = false;
            dt_ngsinh.Enabled = true;
            bt_Luu.Enabled = true;
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_HV.SelectedRows.Count > 0)
                {
                    if (hvBUS.UpdateHoiVien(tb_MaHV.Texts, tb_TenHV.Texts, tb_gioitinh.Texts, float.Parse(tb_cannang.Texts), float.Parse(tb_chieucao.Texts), dt_ngsinh.Value.ToString(), dt_ngaydk.Value.ToString(), tb_Sdt.Texts))
                    {
                        MessageBox.Show("Đã sửa thành công");
                        LoadHoiVienList();
                    }
                }
                else
                    MessageBox.Show("Chọn một hội viên để sửa");

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Sửa THẤT BẠI!");
            }
            tb_TenHV.ReadOnly1 = true;
            tb_gioitinh.ReadOnly1 = true;  
            tb_cannang.ReadOnly1 = true;
            tb_chieucao.ReadOnly1 = true;
            tb_Sdt.ReadOnly1 = true;
            dt_ngsinh.Enabled = false;
            bt_Luu.Enabled = false;

        }

        private void HoiVienSearch_Enter(object sender, EventArgs e)
        {
            if (tb_Search.Text == "Search...")
            {
                tb_Search.Text = "";
                tb_Search.ForeColor = Color.Black;
            }
        }


        private void HoiVienSearch_Leave(object sender, EventArgs e)
        {
            if (tb_Search.Text == "")
            {
                tb_Search.Text = "Search...";
                tb_Search.ForeColor = Color.Gray;
            }
        }

        List<HOIVIEN> SearchHoiVienByName(string hoten)
        {
            List<HOIVIEN> listhv = hvBUS.SearchHoiVienByName(hoten);

            return listhv;
        }
        private void bt_search_Click(object sender, EventArgs e)
        {
            hvist.DataSource = SearchHoiVienByName(tb_Search.Texts);
            
        }
    }
}
