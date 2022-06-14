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
    public partial class SuaTb : Form
    {
        private THIETBI tb;
        ThietBiBUS tbBUS = new ThietBiBUS();
        public THIETBI Tb { get => tb; set => tb = value; }

        public SuaTb(THIETBI currenttb)
        {
            tb = currenttb;
            InitializeComponent();
            cb_loai.DataSource = tbBUS.GetTenltb();
            cb_loai.DisplayMember = "tenltb";
            cb_loai.ValueMember = "maltb";
            Changetb(tb);


        }
        void Changetb(THIETBI tb)
        {
            tb_matb.Texts = tb.Matb;
            tb_tentb.Texts = tb.Tenthietbi;
            dt_ngnhap.Text = tb.Ngmua;
            dt_ngsd.Text = tb.Ngsd;
            dt_hanbt.Text = tb.Hanbaotri;
            tb_dongia.Texts = tb.Gia.ToString();
            //tb_loaitb.Texts = tb.Maltb;
            cb_loai.Text = tbBUS.Tentb(tb.Maltb);
            tb_Sl.Texts = tb.Soluong.ToString();
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
            try
            {
                if (tb_matb.Texts != "" && tb_tentb.Texts != "" && tb_Sl.Texts != ""
                    && tb_dongia.Texts != "" )
                {
                    if (tbBUS.updateEquipment(tb_matb.Texts, tb_tentb.Texts, dt_ngnhap.Value.ToString(),
                        dt_ngsd.Value.ToString(), dt_hanbt.Value.ToString(), decimal.Parse(tb_dongia.Texts),
                        cb_loai.SelectedValue.ToString(), int.Parse(tb_Sl.Texts)))
                    {
                        MessageBox.Show("Đã sửa thành công");
                        this.Close();

                    }
                }
                else
                    MessageBox.Show("Nhập đầy đủ các thông tin!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Sửa THẤT BẠI!");
            }
        }
    }
} 
