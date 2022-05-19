using Gym_Management.ModelDoanhThu;
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
        private PTDoanhThu model;
        private Button currentButton;

        public DoanhThu()
        {
            InitializeComponent();
            SetDataBt(customButton1);
            //Default - Last 7 days
            dt_batdau.Value = DateTime.Today.AddDays(-7);
            dt_ketthuc.Value = DateTime.Now;
            customButton1.Select();
            model = new PTDoanhThu();
            LoadData();
        }
        //Private methods
        private void LoadData()
        {
            var refreshData = model.LoadData(dt_batdau.Value, dt_ketthuc.Value);
            if (refreshData == true)
            {
                lb_Sldon.Text = model.NumOrders.ToString();
                lb_Slhvm.Text = model.NumCustomers.ToString();
                lb_Tongdt.Text = "$" + model.TotalRevenue.ToString();
                lb_Tongln.Text = "$" + model.TotalProfit.ToString();

                chart_Doanhthu.DataSource = model.GrossRevenueList;
                chart_Doanhthu.Series[0].XValueMember = "Date";
                chart_Doanhthu.Series[0].YValueMembers = "TotalAmount";
                chart_Doanhthu.DataBind();

                chart_Top5.DataSource = model.TopProductsList;
                chart_Top5.Series[0].XValueMember = "Key";
                chart_Top5.Series[0].YValueMembers = "Value";
                chart_Top5.DataBind();

                dtg_Sptk.DataSource = model.UnderstockList;
                dtg_Sptk.Columns[0].HeaderText = "Tên sản phẩm";
                dtg_Sptk.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg_Sptk.Columns[1].HeaderText = "Số lượng";
                dtg_Sptk.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }
        private void DisableCustomDates()
        {
            dt_batdau.Enabled = false;
            dt_ketthuc.Enabled = false;
            bt_done.Visible = false;
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
            dt_batdau.Value = DateTime.Today.AddDays(-7);
            dt_ketthuc.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            SetDataBt(sender);
            dt_batdau.Value = DateTime.Today;
            dt_ketthuc.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            SetDataBt(sender);
            dt_batdau.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dt_ketthuc.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            SetDataBt(sender);
            dt_batdau.Value = DateTime.Today.AddDays(-30);
            dt_ketthuc.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();

        }

        private void bt_custom_Click(object sender, EventArgs e)
        {
            dt_batdau.Enabled = true;
            dt_ketthuc.Enabled = true;
            bt_done.Visible = true;
        }

        private void bt_done_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
