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


namespace Gym_Management.FormPT
{
    public partial class UserControlDays : UserControl
    {
        private TAIKHOAN logAcc;
        BuoiTapBUS btBus = new BuoiTapBUS();
        public TAIKHOAN LogAcc { get => logAcc; set => logAcc = value; }
        // let us create another static variable for day;
        public static string static_day;
        public static int ngay;
        public UserControlDays(TAIKHOAN acc)
        {
            
            logAcc = acc;
            InitializeComponent();
           
           

        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }
        public void days(int numday)
        {
            lb_days.Text = numday + "";
            ngay = numday;
            displayEvent();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day =lb_days.Text;
            timer1.Start();
            EventForm eventform = new EventForm(logAcc);
            eventform.Show();
        }
        private void displayEvent()
        {
            if (ngay != 0)
            {
                int a = btBus.CountHV(LogAcc.Manv, LichTap.static_month + "/" + ngay + "/" + LichTap.static_year);
                if (a != 0)
                    lb_htsl.Text = a.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
       
    }
}
