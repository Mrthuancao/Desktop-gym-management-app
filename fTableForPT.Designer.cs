namespace Gym_Management
{
    partial class fTableForPT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_menu = new System.Windows.Forms.Panel();
            this.bt_dangxuat = new FontAwesome.Sharp.IconButton();
            this.bt_checkin = new FontAwesome.Sharp.IconButton();
            this.bt_lichtap = new FontAwesome.Sharp.IconButton();
            this.bt_dshv = new FontAwesome.Sharp.IconButton();
            this.pn_logo = new System.Windows.Forms.Panel();
            this.pb_Home = new System.Windows.Forms.PictureBox();
            this.pn_TitleBar = new System.Windows.Forms.Panel();
            this.bt_thongtin = new FontAwesome.Sharp.IconButton();
            this.bt_minimize = new FontAwesome.Sharp.IconButton();
            this.bt_maximize = new FontAwesome.Sharp.IconButton();
            this.bt_close = new FontAwesome.Sharp.IconButton();
            this.lb_titleCharform = new System.Windows.Forms.Label();
            this.ic_currentChildform = new FontAwesome.Sharp.IconPictureBox();
            this.pn_desktop = new System.Windows.Forms.Panel();
            this.pb_solgan = new System.Windows.Forms.PictureBox();
            this.pn_menu.SuspendLayout();
            this.pn_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Home)).BeginInit();
            this.pn_TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ic_currentChildform)).BeginInit();
            this.pn_desktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_solgan)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.Gainsboro;
            this.pn_menu.Controls.Add(this.bt_dangxuat);
            this.pn_menu.Controls.Add(this.bt_checkin);
            this.pn_menu.Controls.Add(this.bt_lichtap);
            this.pn_menu.Controls.Add(this.bt_dshv);
            this.pn_menu.Controls.Add(this.pn_logo);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu.Location = new System.Drawing.Point(0, 0);
            this.pn_menu.Margin = new System.Windows.Forms.Padding(4);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(203, 747);
            this.pn_menu.TabIndex = 0;
            // 
            // bt_dangxuat
            // 
            this.bt_dangxuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_dangxuat.FlatAppearance.BorderSize = 0;
            this.bt_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dangxuat.Font = new System.Drawing.Font("Verdana", 10F);
            this.bt_dangxuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.bt_dangxuat.IconColor = System.Drawing.Color.Black;
            this.bt_dangxuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dangxuat.Location = new System.Drawing.Point(0, 673);
            this.bt_dangxuat.Margin = new System.Windows.Forms.Padding(4);
            this.bt_dangxuat.Name = "bt_dangxuat";
            this.bt_dangxuat.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.bt_dangxuat.Size = new System.Drawing.Size(203, 74);
            this.bt_dangxuat.TabIndex = 5;
            this.bt_dangxuat.Tag = "Đăng xuất";
            this.bt_dangxuat.Text = "   Đăng xuất";
            this.bt_dangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_dangxuat.UseVisualStyleBackColor = true;
            this.bt_dangxuat.Click += new System.EventHandler(this.bt_dangxuat_Click);
            // 
            // bt_checkin
            // 
            this.bt_checkin.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_checkin.FlatAppearance.BorderSize = 0;
            this.bt_checkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_checkin.Font = new System.Drawing.Font("Verdana", 10F);
            this.bt_checkin.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.bt_checkin.IconColor = System.Drawing.Color.Black;
            this.bt_checkin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_checkin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_checkin.Location = new System.Drawing.Point(0, 312);
            this.bt_checkin.Margin = new System.Windows.Forms.Padding(4);
            this.bt_checkin.Name = "bt_checkin";
            this.bt_checkin.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.bt_checkin.Size = new System.Drawing.Size(203, 74);
            this.bt_checkin.TabIndex = 4;
            this.bt_checkin.Tag = "Check-in";
            this.bt_checkin.Text = "   Check-in";
            this.bt_checkin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_checkin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_checkin.UseVisualStyleBackColor = true;
            this.bt_checkin.Click += new System.EventHandler(this.bt_checkin_Click);
            // 
            // bt_lichtap
            // 
            this.bt_lichtap.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_lichtap.FlatAppearance.BorderSize = 0;
            this.bt_lichtap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_lichtap.Font = new System.Drawing.Font("Verdana", 10F);
            this.bt_lichtap.IconChar = FontAwesome.Sharp.IconChar.Voicemail;
            this.bt_lichtap.IconColor = System.Drawing.Color.Black;
            this.bt_lichtap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_lichtap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_lichtap.Location = new System.Drawing.Point(0, 238);
            this.bt_lichtap.Margin = new System.Windows.Forms.Padding(4);
            this.bt_lichtap.Name = "bt_lichtap";
            this.bt_lichtap.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.bt_lichtap.Size = new System.Drawing.Size(203, 74);
            this.bt_lichtap.TabIndex = 3;
            this.bt_lichtap.Tag = "Lịch tập";
            this.bt_lichtap.Text = "   Lịch tập";
            this.bt_lichtap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_lichtap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_lichtap.UseVisualStyleBackColor = true;
            this.bt_lichtap.Click += new System.EventHandler(this.bt_lichtap_Click);
            // 
            // bt_dshv
            // 
            this.bt_dshv.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_dshv.FlatAppearance.BorderSize = 0;
            this.bt_dshv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dshv.Font = new System.Drawing.Font("Verdana", 10F);
            this.bt_dshv.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.bt_dshv.IconColor = System.Drawing.Color.Black;
            this.bt_dshv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_dshv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dshv.Location = new System.Drawing.Point(0, 164);
            this.bt_dshv.Margin = new System.Windows.Forms.Padding(4);
            this.bt_dshv.Name = "bt_dshv";
            this.bt_dshv.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.bt_dshv.Size = new System.Drawing.Size(203, 74);
            this.bt_dshv.TabIndex = 2;
            this.bt_dshv.Tag = "Hội viên";
            this.bt_dshv.Text = "   Hội viên";
            this.bt_dshv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dshv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_dshv.UseVisualStyleBackColor = true;
            this.bt_dshv.Click += new System.EventHandler(this.bt_dshv_Click);
            // 
            // pn_logo
            // 
            this.pn_logo.Controls.Add(this.pb_Home);
            this.pn_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_logo.Location = new System.Drawing.Point(0, 0);
            this.pn_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pn_logo.Name = "pn_logo";
            this.pn_logo.Size = new System.Drawing.Size(203, 164);
            this.pn_logo.TabIndex = 1;
            // 
            // pb_Home
            // 
            this.pb_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Home.Image = global::Gym_Management.Properties.Resources.Fitness_Gym_Dumbbell_Abstract_Logo_Design_Icon_Vector21;
            this.pb_Home.Location = new System.Drawing.Point(7, 7);
            this.pb_Home.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Home.Name = "pb_Home";
            this.pb_Home.Size = new System.Drawing.Size(184, 137);
            this.pb_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Home.TabIndex = 1;
            this.pb_Home.TabStop = false;
            this.pb_Home.Click += new System.EventHandler(this.pb_Home_Click);
            // 
            // pn_TitleBar
            // 
            this.pn_TitleBar.BackColor = System.Drawing.Color.Gainsboro;
            this.pn_TitleBar.Controls.Add(this.bt_thongtin);
            this.pn_TitleBar.Controls.Add(this.bt_minimize);
            this.pn_TitleBar.Controls.Add(this.bt_maximize);
            this.pn_TitleBar.Controls.Add(this.bt_close);
            this.pn_TitleBar.Controls.Add(this.lb_titleCharform);
            this.pn_TitleBar.Controls.Add(this.ic_currentChildform);
            this.pn_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_TitleBar.Location = new System.Drawing.Point(203, 0);
            this.pn_TitleBar.Name = "pn_TitleBar";
            this.pn_TitleBar.Size = new System.Drawing.Size(1070, 45);
            this.pn_TitleBar.TabIndex = 1;
            this.pn_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_TitleBar_MouseDown);
            // 
            // bt_thongtin
            // 
            this.bt_thongtin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_thongtin.FlatAppearance.BorderSize = 0;
            this.bt_thongtin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.bt_thongtin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_thongtin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thongtin.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thongtin.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.bt_thongtin.IconColor = System.Drawing.Color.Indigo;
            this.bt_thongtin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_thongtin.IconSize = 30;
            this.bt_thongtin.Location = new System.Drawing.Point(849, 0);
            this.bt_thongtin.Margin = new System.Windows.Forms.Padding(2);
            this.bt_thongtin.Name = "bt_thongtin";
            this.bt_thongtin.Size = new System.Drawing.Size(117, 45);
            this.bt_thongtin.TabIndex = 5;
            this.bt_thongtin.Tag = "";
            this.bt_thongtin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_thongtin.UseVisualStyleBackColor = true;
            // 
            // bt_minimize
            // 
            this.bt_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_minimize.BackColor = System.Drawing.Color.Blue;
            this.bt_minimize.FlatAppearance.BorderSize = 0;
            this.bt_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.bt_minimize.IconColor = System.Drawing.Color.White;
            this.bt_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_minimize.IconSize = 20;
            this.bt_minimize.Location = new System.Drawing.Point(968, 0);
            this.bt_minimize.Margin = new System.Windows.Forms.Padding(2);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.Size = new System.Drawing.Size(34, 45);
            this.bt_minimize.TabIndex = 4;
            this.bt_minimize.UseVisualStyleBackColor = false;
            this.bt_minimize.Click += new System.EventHandler(this.bt_minimize_Click);
            // 
            // bt_maximize
            // 
            this.bt_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_maximize.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_maximize.FlatAppearance.BorderSize = 0;
            this.bt_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_maximize.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.bt_maximize.IconColor = System.Drawing.Color.White;
            this.bt_maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_maximize.IconSize = 20;
            this.bt_maximize.Location = new System.Drawing.Point(1002, 0);
            this.bt_maximize.Margin = new System.Windows.Forms.Padding(2);
            this.bt_maximize.Name = "bt_maximize";
            this.bt_maximize.Size = new System.Drawing.Size(34, 45);
            this.bt_maximize.TabIndex = 6;
            this.bt_maximize.UseVisualStyleBackColor = false;
            this.bt_maximize.Click += new System.EventHandler(this.bt_maximize_Click);
            // 
            // bt_close
            // 
            this.bt_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
            this.bt_close.FlatAppearance.BorderSize = 0;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.bt_close.IconColor = System.Drawing.Color.White;
            this.bt_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_close.IconSize = 20;
            this.bt_close.Location = new System.Drawing.Point(1036, 0);
            this.bt_close.Margin = new System.Windows.Forms.Padding(2);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(34, 45);
            this.bt_close.TabIndex = 2;
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // lb_titleCharform
            // 
            this.lb_titleCharform.AutoSize = true;
            this.lb_titleCharform.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titleCharform.ForeColor = System.Drawing.Color.BlueViolet;
            this.lb_titleCharform.Location = new System.Drawing.Point(45, 10);
            this.lb_titleCharform.Name = "lb_titleCharform";
            this.lb_titleCharform.Size = new System.Drawing.Size(72, 25);
            this.lb_titleCharform.TabIndex = 5;
            this.lb_titleCharform.Text = "Home";
            // 
            // ic_currentChildform
            // 
            this.ic_currentChildform.BackColor = System.Drawing.Color.Gainsboro;
            this.ic_currentChildform.ForeColor = System.Drawing.Color.Purple;
            this.ic_currentChildform.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ic_currentChildform.IconColor = System.Drawing.Color.Purple;
            this.ic_currentChildform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_currentChildform.Location = new System.Drawing.Point(13, 7);
            this.ic_currentChildform.Name = "ic_currentChildform";
            this.ic_currentChildform.Size = new System.Drawing.Size(32, 32);
            this.ic_currentChildform.TabIndex = 0;
            this.ic_currentChildform.TabStop = false;
            // 
            // pn_desktop
            // 
            this.pn_desktop.Controls.Add(this.pb_solgan);
            this.pn_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_desktop.Location = new System.Drawing.Point(203, 45);
            this.pn_desktop.Name = "pn_desktop";
            this.pn_desktop.Size = new System.Drawing.Size(1070, 702);
            this.pn_desktop.TabIndex = 2;
            // 
            // pb_solgan
            // 
            this.pb_solgan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_solgan.Image = global::Gym_Management.Properties.Resources.welcome1;
            this.pb_solgan.Location = new System.Drawing.Point(174, 246);
            this.pb_solgan.Name = "pb_solgan";
            this.pb_solgan.Size = new System.Drawing.Size(767, 274);
            this.pb_solgan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_solgan.TabIndex = 1;
            this.pb_solgan.TabStop = false;
            // 
            // fTableForPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 747);
            this.Controls.Add(this.pn_desktop);
            this.Controls.Add(this.pn_TitleBar);
            this.Controls.Add(this.pn_menu);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTableForPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTableForPT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTableForPT_FormClosing);
            this.pn_menu.ResumeLayout(false);
            this.pn_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Home)).EndInit();
            this.pn_TitleBar.ResumeLayout(false);
            this.pn_TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ic_currentChildform)).EndInit();
            this.pn_desktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_solgan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.Panel pn_logo;
        private FontAwesome.Sharp.IconButton bt_dshv;
        private FontAwesome.Sharp.IconButton bt_dangxuat;
        private FontAwesome.Sharp.IconButton bt_checkin;
        private FontAwesome.Sharp.IconButton bt_lichtap;
        private System.Windows.Forms.PictureBox pb_Home;
        private System.Windows.Forms.Panel pn_TitleBar;
        private FontAwesome.Sharp.IconPictureBox ic_currentChildform;
        private System.Windows.Forms.Label lb_titleCharform;
        private System.Windows.Forms.Panel pn_desktop;
        private System.Windows.Forms.PictureBox pb_solgan;
        private FontAwesome.Sharp.IconButton bt_close;
        private FontAwesome.Sharp.IconButton bt_maximize;
        private FontAwesome.Sharp.IconButton bt_minimize;
        private FontAwesome.Sharp.IconButton bt_thongtin;
    }
}