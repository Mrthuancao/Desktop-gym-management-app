using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace Gym_Management
{
    public partial class ThemTb : Form
    {
        ThietBiBUS tbBUS = new ThietBiBUS();
        public ThemTb()
        {
            InitializeComponent();
            cb_loai.DataSource = tbBUS.GetTenltb();
            cb_loai.DisplayMember = "tenltb";
            cb_loai.ValueMember = "maltb";
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
        private void bt_xoahet_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            cb_loai.Text = "";
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            
            
            if (tb_matb.Texts == "" || tb_tentb.Texts == "" || tb_Sl.Texts == "" || tb_dongia.Texts == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin cho thiết bị");
            }
            else if (tbBUS.KiemTra(tb_matb.Texts)==1)
            {
                MessageBox.Show("Mã thiết bị đã có! Vui lòng nhập mã khác");
            }
            else
                if (tbBUS.insertEquipment(tb_matb.Texts, tb_tentb.Texts, dt_ngnhap.Value.ToString(),
                    dt_ngsd.Value.ToString(), dt_hanbt.Value.ToString(), decimal.Parse(tb_dongia.Texts),
                     cb_loai.SelectedValue.ToString(), int.Parse(tb_Sl.Texts)))
                {
                    MessageBox.Show("Đã thêm thành công");
                    this.Close();

                }

        }
    }
}
