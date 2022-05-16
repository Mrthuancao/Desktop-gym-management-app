using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management
{
    public partial class ThongTinTk : Form
    {
        private TAIKHOAN logAcc;
        public TAIKHOAN LogAcc
        {
            get { return logAcc; }
            set { logAcc = value; ChangeAccount(logAcc); }
        }

        

        public ThongTinTk(TAIKHOAN acc)
        {
            logAcc = acc;
            InitializeComponent();
            ChangeAccount(logAcc);
        }
        void ChangeAccount(TAIKHOAN logAcc)
        {
            tb_mtk.Texts = logAcc.Matk;
            tb_username.Texts = logAcc.Username;
            tb_pass.Texts = logAcc.Pass;
            tb_mnv.Texts = logAcc.Manv;
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
        }
    }
}
