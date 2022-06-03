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
    public partial class DanhSachPT : Form
    {
        TaiKhoanBUS TkBUS = new TaiKhoanBUS();
        public DanhSachPT()
        {
            InitializeComponent();
            dtg_DSPT.DataSource = TkBUS.GetAccountPT();

        }
    }
}
