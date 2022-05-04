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
    public partial class HoiVien : Form
    {
        public HoiVien()
        {
            InitializeComponent();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            ThemHv f = new ThemHv();
            f.ShowDialog();
        }
    }
}
