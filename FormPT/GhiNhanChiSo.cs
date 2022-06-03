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
    public partial class GhiNhanChiSo : Form
    {   
        LichTrinhBUS LtBUS = new LichTrinhBUS();
        public GhiNhanChiSo(string mahv)
        {
            InitializeComponent();
            tb_mahv.Texts = mahv;
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_cannang.Texts == "" || tb_cc.Texts == "")
            {
                MessageBox.Show("Điền đủ thông tin trước khi lưu");
            }
            else
            {
                if (LtBUS.InsertLichTrinh(tb_mahv.Texts, dt_ngcheck.Value.ToString(), tb_cannang.Texts, tb_cc.Texts))
                {
                    MessageBox.Show("Đã thêm thành công");
                }

            }
            this.Close();
        }
    }
}
