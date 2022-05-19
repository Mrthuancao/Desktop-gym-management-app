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
    public partial class GoiTap : Form
    {
        GoiTapBus gtBUS = new GoiTapBus();
        public GoiTap()
        {
            InitializeComponent();
            //dtg_GT.DataSource = gtBUS.ShowDaTaGriWiew();
            cb_goitap.DataSource = gtBUS.ShowCombox();
            cb_goitap.DisplayMember = "tengoi";
            cb_goitap.ValueMember = "magoi";

        }

        private void bt_Dk_Click(object sender, EventArgs e)
        {
            if (tb_madk.Texts == "" || tb_MaHV.Texts == "" || cb_Magoi.SelectedItem.ToString() == "" || tb_maPt.Texts == "" || dt_ngdk.Value.ToString()=="" || dt_ngHetHan.Value.ToString()=="")
            {
                MessageBox.Show("Điền đủ thông tin trước khi thêm hội viên");
            }
            else
            {
                if (gtBUS.InsertGoiTap(tb_madk.Texts,  cb_Magoi.SelectedItem.ToString(), tb_MaHV.Texts, tb_maPt.Texts, dt_ngdk.Value.ToString(), dt_ngHetHan.Value.ToString()))
                {
                    MessageBox.Show("Đã thêm thành công");
                }

            }
            
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
        private void tb_Xoa_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        

        private void cb_goitap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a= cb_goitap.Text;
            dtg_GT.DataSource = gtBUS.GetAllGoiTap(a);
        }

        private void tb_Bo_Click(object sender, EventArgs e)
        {

        }
    }
}
