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
        HoiVienBUS hvBUS = new HoiVienBUS();
        GoiTapBus gtBus = new GoiTapBus();
        
        public HoiVien()
        {
            InitializeComponent();
            LoadHoiVienList();
            AddHoiVienBinding();
            
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            ThemHv f = new ThemHv();
            f.ShowDialog();
        }
        void LoadHoiVienList()
        {
            dtg_HV.DataSource = hvBUS.GetHoiVienList(); 
            dtg_HV.Columns["phai"].Visible = false;
            dtg_HV.Columns["cannang"].Visible = false;
            dtg_HV.Columns["chieucao"].Visible = false;
            dtg_HV.Columns["ngsinh"].Visible = false;
            dtg_HV.Columns["ngdangki"].Visible = false;
            dtg_HV.Columns["sdt"].Visible = false;
            dtg_HV.Columns["nvquanli"].Visible = false;
        }

        void AddHoiVienBinding()
        {
            tb_MaHV.DataBindings.Add(new Binding("Texts",dtg_HV.DataSource, "mahv"));
            tb_TenHV.DataBindings.Add(new Binding("Texts", dtg_HV.DataSource, "hoten"));
            tb_gioitinh.DataBindings.Add(new Binding("Texts", dtg_HV.DataSource, "phai"));
            tb_cannang.DataBindings.Add(new Binding("Texts", dtg_HV.DataSource, "cannang"));
            tb_chieucao.DataBindings.Add(new Binding("Texts", dtg_HV.DataSource, "chieucao"));
            dt_ngsinh.DataBindings.Add(new Binding("Text", dtg_HV.DataSource, "ngsinh"));
            dt_ngaydk.DataBindings.Add(new Binding("Text", dtg_HV.DataSource, "ngdangki"));
            tb_Sdt.DataBindings.Add(new Binding("Texts", dtg_HV.DataSource, "sdt"));
            tb_maPT.DataBindings.Add(new Binding("Texts", dtg_HV.DataSource, "nvquanli"));
        }

     
    }
}
