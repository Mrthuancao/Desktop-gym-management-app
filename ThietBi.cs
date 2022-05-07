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
    public partial class ThietBi : Form
    {
        public ThietBi()
        {
            InitializeComponent();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            ThemTb f = new ThemTb();
            f.ShowDialog();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            SuaTb f =   new SuaTb();
            f.ShowDialog();
        }
    }
}
