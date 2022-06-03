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
    public partial class DanhSachPT : Form
    {
        TaiKhoanBUS TkBUS = new TaiKhoanBUS();
        public DanhSachPT()
        {
            InitializeComponent();
            dtg_DSPT.DataSource = TkBUS.GetAccountPT();

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_DSPT.SelectedRows.Count > 0)
                {
                    if (TkBUS.DeleteAccount(dtg_DSPT.SelectedRows[0].Cells["matk"].Value.ToString()))
                    {
                        MessageBox.Show("Đã xóa thành công");
                        this.Show();
                        dtg_DSPT.DataSource = TkBUS.GetAccountPT();
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
