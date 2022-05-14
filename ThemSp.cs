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
    public partial class ThemSp : Form
    {
        public ThemSp()
        {
            InitializeComponent();
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
