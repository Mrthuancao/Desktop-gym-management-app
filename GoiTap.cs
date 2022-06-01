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
            
            cb_goitap.DataSource = gtBUS.ShowCombox();
            cb_goitap.DisplayMember = "tengoi";
            cb_goitap.ValueMember = "magoi";
            cb_Magoi.DataSource = gtBUS.ShowCombox();
            cb_Magoi.DisplayMember = "tengoi";
            cb_Magoi.ValueMember = "magoi";
        }

        private void bt_Dk_Click(object sender, EventArgs e)
        {
            
            if (tb_madk.Texts == "" || tb_MaHV.Texts == "" || cb_Magoi.SelectedItem.ToString() == "" || tb_maPt.Texts == "" || dt_ngdk.Value.ToString()=="" || dt_ngHetHan.Value.ToString()=="")
            {
                MessageBox.Show("Điền đủ thông tin trước khi thêm hội viên");
            }
            else
            {
                if (gtBUS.InsertGoiTap(tb_madk.Texts, cb_Magoi.SelectedValue.ToString(), tb_MaHV.Texts, tb_maPt.Texts, dt_ngdk.Value.ToString(), dt_ngHetHan.Value.ToString()))
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
            load();
        }
        void load()
        {
            dtg_GT.DataSource = gtBUS.GetAllGoiTap(cb_goitap.Text);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dtg_GT.SelectedRows.Count > 0)
                {
                    if (gtBUS.DeleteDKGoiTap(dtg_GT.SelectedRows[0].Cells["madk"].Value.ToString()))
                    {
                        MessageBox.Show("Đã xóa thành công");
                        this.Show();
                        load();
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
