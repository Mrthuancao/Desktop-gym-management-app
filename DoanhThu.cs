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
    public partial class DoanhThu : Form
    {
        //fields
        private Button currentButton;

        public DoanhThu()
        {
            InitializeComponent();
            SetDataBt(customButton1);
        }
        private void SetDataBt(object button)
        {
            var btn = (Button)button;
            //hightlight bt
            btn.BackColor = Color.OrangeRed;
            btn.ForeColor = Color.Black;
            //unhightlight bt
            if (currentButton != null & currentButton!=btn)
            {
                currentButton.BackColor = Color.DarkOrange;
                currentButton.ForeColor = Color.FromArgb(255, 255, 255);
            }
            currentButton = btn; //Set current button


        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            SetDataBt(sender);
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            SetDataBt(sender);
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            SetDataBt(sender);
        }
    }
}
