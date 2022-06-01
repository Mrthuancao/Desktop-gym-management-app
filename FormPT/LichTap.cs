using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace Gym_Management.FormPT
{
    public partial class LichTap : Form
    {   int month, year;
        //Lets create a static variable that we can pass to another form for month and year;
        public static int static_month, static_year;
        
        private TAIKHOAN logAcc;

        public TAIKHOAN LogAcc { get => logAcc; set => logAcc = value; }

        public LichTap(TAIKHOAN acc)
        {

            InitializeComponent();
            LogAcc = acc;
        }

        private void LichTap_Load(object sender, EventArgs e)
        {
            displaDays();
        }
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            //Show month and year
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lb_thangnam.Text = monthname + " " + year;

            static_month = month;
            static_year = year;
            // LETS get the first day of the month.
            DateTime startofthemonth = new DateTime(year, month, 1);
            // get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            // convert the startofthemonth to integer.
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;
            // first Ints createablank marcontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flp_lich.Controls.Add(ucblank);
            }
            //now lets create usercontrol for days
            for (int i=1; i<days;i++)
            {
                UserControlDays ucdays = new UserControlDays(logAcc);
                ucdays.days(i); 
                flp_lich.Controls.Add(ucdays);
            } 
        }

        private void bt_Truoc_Click(object sender, EventArgs e)
        {
            //Clear container
            flp_lich.Controls.Clear();
            //Decrement month to go to prevous month
            if (month != 1)
            {
                month--;
            }
            else
            {
                month = 12;
                year--;
            }
            static_month = month;
            static_year = year;
            //Show month and year
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lb_thangnam.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            // get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            // convert the startofthemonth to integer.
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // first Ints createablank marcontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flp_lich.Controls.Add(ucblank);
            }
            //now lets create usercontrol for days
            for (int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays(logAcc);
                ucdays.days(i);
                flp_lich.Controls.Add(ucdays);
            }
        }

        private void bt_sau_Click(object sender, EventArgs e)
        {   //Clear container
            flp_lich.Controls.Clear();
            //increment month to go to next month
            if (month != 12)
            {
                month++;
            }
            else
            {
                month = 1;
                year++;
            }
            static_month = month;
            static_year = year;
            //Show month and year
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lb_thangnam.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            // get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            // convert the startofthemonth to integer.
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // first Ints createablank marcontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flp_lich.Controls.Add(ucblank);
            }
            //now lets create usercontrol for days
            for (int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays(logAcc);
                ucdays.days(i); 
                flp_lich.Controls.Add(ucdays);
            }
        }
    }
}
