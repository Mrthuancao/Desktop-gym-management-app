using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Gym_Management.FormPT;

namespace Gym_Management
{
    public partial class fTableForPT : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Size formSize;
        private Form currentChildForm;
        public fTableForPT()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 74);
            pn_menu.Controls.Add(leftBorderBtn);
            //Form
            
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 255, 255);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 140, 0);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                ic_currentChildform.IconChar = currentBtn.IconChar;
                ic_currentChildform.IconColor = Color.Purple;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(220, 220, 220);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_desktop.Controls.Add(childForm);
            pn_desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lb_titleCharform.Text = childForm.Text;
        }

        private void bt_dshv_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new DanhSachHoiVien());
        }

        private void bt_lichtap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new LichTap());
        }

        private void bt_checkin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new CheckIn());
        }

        private void bt_dangxuat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            this.Close();
        }
       
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            ic_currentChildform.IconChar = currentBtn.IconChar;
            ic_currentChildform.IconColor = Color.Purple;
            lb_titleCharform.Text = "Home";

        }
        //Events
        //Reset
        private void pb_Home_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pn_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void fTableForPT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi chương trình?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void bt_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void bt_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
