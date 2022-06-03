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

namespace Gym_Management.FormPT
{
    public partial class DanhSachHoiVien : Form
    {
        BuoiTapBUS btBus = new BuoiTapBUS();
        LichTrinhBUS ltBUS = new LichTrinhBUS();
        private TAIKHOAN logAcc;
        public TAIKHOAN LogAcc { get => logAcc; set => logAcc = value; }
        public DanhSachHoiVien(TAIKHOAN acc)
        {
            logAcc = acc;
            InitializeComponent();
            dtg_DSHV.DataSource = btBus.GetName(LogAcc.Manv);
            cb_HoTen.DataSource = btBus.GetName(LogAcc.Manv);
            cb_HoTen.DisplayMember = "hoten";
            cb_HoTen.ValueMember = "mahv";
            
        }
        void Load()
        {
            bmi1.Text =""; bmi2.Text = ""; bmi3.Text = "";
            kg1.Text = ""; kg2.Text = ""; kg3.Text = "";
            cc1.Text = ""; cc2.Text = ""; cc3.Text = "";
            dtg_test.DataSource = ltBUS.GetAllLt(LogAcc.Manv, cb_HoTen.SelectedValue.ToString());
            HienThi();
            
        }
        void HienThi()
        {            
            if (dtg_test.RowCount.ToString() != "1")
            {
                switch (dtg_test.RowCount)
                {
                    case 2:
                        DataGridViewRow row = dtg_test.Rows[0];
                        Row0(row);
                        break;
                    case 3:
                        DataGridViewRow a = dtg_test.Rows[0];
                        DataGridViewRow b = dtg_test.Rows[1];
                        Row0(a);
                        Row1(b);
                        break;
                    default:
                        DataGridViewRow x = dtg_test.Rows[0];
                        DataGridViewRow y = dtg_test.Rows[1];
                        DataGridViewRow z = dtg_test.Rows[2];
                        Row0(x);
                        Row1(y);
                        Row2(z);
                        break;
                    
                }


              
            }
        }
        void Row0(DataGridViewRow row0)
        {
            kg1.Text = row0.Cells["cannang"].Value?.ToString();
            cc1.Text = row0.Cells["chieucao"].Value?.ToString();
            decimal a = Convert.ToDecimal(row0.Cells["cannang"].Value);
            decimal b = Convert.ToDecimal(row0.Cells["chieucao"].Value);
            if (b != 0)
            {
                bmi1.Text = Math.Round((a / (b * 2)), 2).ToString();
            }
        }
        void Row1(DataGridViewRow row1)
        {
            kg2.Text = row1.Cells["cannang"].Value?.ToString();
            cc2.Text = row1.Cells["chieucao"].Value?.ToString();
            decimal a = Convert.ToDecimal(row1.Cells["cannang"].Value);
            decimal b = Convert.ToDecimal(row1.Cells["chieucao"].Value);
            if (b != 0)
            {
                bmi2.Text = Math.Round((a / (b * 2)), 2).ToString();
            }
        }
        void Row2(DataGridViewRow row2)
        {
            kg3.Text = row2.Cells["cannang"].Value?.ToString();
            cc3.Text = row2.Cells["chieucao"].Value?.ToString();
            decimal a = Convert.ToDecimal(row2.Cells["cannang"].Value);
            decimal b = Convert.ToDecimal(row2.Cells["chieucao"].Value);
            if (b != 0)
            {
                bmi3.Text = Math.Round((a / (b * 2)), 2).ToString();
            }
        }
        private void cb_HoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load();
        }

        private void bt_Dk_Click(object sender, EventArgs e)
        {
            GhiNhanChiSo f = new GhiNhanChiSo(cb_HoTen.SelectedValue.ToString());
            f.ShowDialog();
        }
    }
}
