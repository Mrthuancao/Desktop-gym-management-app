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
        
        public HoiVien()
        {
            InitializeComponent();
            LoadHoiVienList();
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
    }
}
