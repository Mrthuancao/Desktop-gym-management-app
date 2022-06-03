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
    public partial class EventForm : Form
    {
        BindingSource buoitap = new BindingSource();
        BuoiTapBUS btBus = new BuoiTapBUS();
        
        private TAIKHOAN logAcc;
        
        public TAIKHOAN LogAcc { get => logAcc; set => logAcc = value; }

        public EventForm(TAIKHOAN acc)
        {
            logAcc = acc;
            InitializeComponent();
            tb_ngay.Texts = LichTap.static_month + "/" + UserControlDays.static_day + "/" + LichTap.static_year;
            dt_ngay.Text = tb_ngay.Texts;
            load();
        }
        void load()
        {
            
            dtg_bt.DataSource = buoitap;
            loadbtlist();
            cb_mdk.DataSource = btBus.ShowCombox(LogAcc.Manv);
            cb_mdk.DisplayMember = "madk";
            
        }
        void loadbtlist()
        {
            
            buoitap.DataSource = btBus.ShowDaTaGriWiew(LogAcc.Manv, LichTap.static_month + "/" + UserControlDays.static_day + "/" + LichTap.static_year);
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            // lets call the static variables we declare
            
            
        }

        private void cb_mdk_SelectedIndexChanged(object sender, EventArgs e)
        {
             tb_tenhv.Texts = btBus.GetNameByMaDK(cb_mdk.Text);
            
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (cb_buoi.SelectedItem == null|| cb_mdk.SelectedItem == null)
            {
                MessageBox.Show("Điền đủ thông tin trước khi thêm buổi tập");
            }
            else
            {
                if (btBus.InsertBuoiTap(cb_mdk.Text.ToString() ,cb_buoi.SelectedItem.ToString(), dt_ngay.Value.ToString()))
                {
                    MessageBox.Show("Đã thêm thành công");
                    loadbtlist();
                }

            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_bt.SelectedRows.Count > 0)
                {
                    if (btBus.DeleteDKBuoiTap(dtg_bt.SelectedRows[0].Cells["madk"].Value.ToString(),dtg_bt.SelectedRows[0].Cells["thoigian"].Value.ToString()))
                    {
                        MessageBox.Show("Đã xóa thành công");
                        this.Show();
                        loadbtlist();

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
