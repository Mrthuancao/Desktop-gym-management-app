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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            ThemSp f = new ThemSp();
            f.ShowDialog();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            SuaSp f = new SuaSp();
            f.ShowDialog();
        }
    }
}
