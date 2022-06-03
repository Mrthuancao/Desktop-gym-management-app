namespace Gym_Management.FormPT
{
    partial class fTablePT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTablePT));
            this.pn_menu = new System.Windows.Forms.Panel();
            this.bt_dangxuat = new FontAwesome.Sharp.IconButton();
            this.bt_lichtap = new FontAwesome.Sharp.IconButton();
            this.bt_hoivien = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_titlebar = new System.Windows.Forms.Panel();
            this.bt_thongtin = new FontAwesome.Sharp.IconButton();
            this.bt_minimize = new FontAwesome.Sharp.IconButton();
            this.bt_maximize = new FontAwesome.Sharp.IconButton();
            this.bt_close = new FontAwesome.Sharp.IconButton();
            this.lb_titleCharform = new System.Windows.Forms.Label();
            this.ic_currentChildform = new FontAwesome.Sharp.IconPictureBox();
            this.pn_destop = new System.Windows.Forms.Panel();
            this.pn_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ic_currentChildform)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.Gainsboro;
            this.pn_menu.Controls.Add(this.bt_dangxuat);
            this.pn_menu.Controls.Add(this.bt_lichtap);
            this.pn_menu.Controls.Add(this.bt_hoivien);
            this.pn_menu.Controls.Add(this.panel1);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu.Location = new System.Drawing.Point(0, 0);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(250, 747);
            this.pn_menu.TabIndex = 0;
            // 
            // bt_dangxuat
            // 
            this.bt_dangxuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_dangxuat.FlatAppearance.BorderSize = 0;
            this.bt_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dangxuat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangxuat.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.bt_dangxuat.IconColor = System.Drawing.Color.Black;
            this.bt_dangxuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_dangxuat.Location = new System.Drawing.Point(0, 664);
            this.bt_dangxuat.Margin = new System.Windows.Forms.Padding(2);
            this.bt_dangxuat.Name = "bt_dangxuat";
            this.bt_dangxuat.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_dangxuat.Size = new System.Drawing.Size(250, 83);
            this.bt_dangxuat.TabIndex = 6;
            this.bt_dangxuat.Tag = "Đăng xuất";
            this.bt_dangxuat.Text = "   Đăng xuất";
            this.bt_dangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_dangxuat.UseVisualStyleBackColor = true;
            this.bt_dangxuat.Click += new System.EventHandler(this.bt_dangxuat_Click);
            // 
            // bt_lichtap
            // 
            this.bt_lichtap.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_lichtap.FlatAppearance.BorderSize = 0;
            this.bt_lichtap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_lichtap.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lichtap.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.bt_lichtap.IconColor = System.Drawing.Color.Black;
            this.bt_lichtap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_lichtap.Location = new System.Drawing.Point(0, 197);
            this.bt_lichtap.Margin = new System.Windows.Forms.Padding(2);
            this.bt_lichtap.Name = "bt_lichtap";
            this.bt_lichtap.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_lichtap.Size = new System.Drawing.Size(250, 83);
            this.bt_lichtap.TabIndex = 4;
            this.bt_lichtap.Tag = "Lịch tập";
            this.bt_lichtap.Text = "   Lịch tập";
            this.bt_lichtap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_lichtap.UseVisualStyleBackColor = true;
            this.bt_lichtap.Click += new System.EventHandler(this.bt_lichtap_Click);
            // 
            // bt_hoivien
            // 
            this.bt_hoivien.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_hoivien.FlatAppearance.BorderSize = 0;
            this.bt_hoivien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hoivien.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_hoivien.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.bt_hoivien.IconColor = System.Drawing.Color.Black;
            this.bt_hoivien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_hoivien.Location = new System.Drawing.Point(0, 114);
            this.bt_hoivien.Margin = new System.Windows.Forms.Padding(2);
            this.bt_hoivien.Name = "bt_hoivien";
            this.bt_hoivien.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_hoivien.Size = new System.Drawing.Size(250, 83);
            this.bt_hoivien.TabIndex = 3;
            this.bt_hoivien.Tag = "Hội viên";
            this.bt_hoivien.Text = "   Hội viên";
            this.bt_hoivien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_hoivien.UseVisualStyleBackColor = true;
            this.bt_hoivien.Click += new System.EventHandler(this.bt_hoivien_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 114);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Gym_Management.Properties.Resources.Fitness_Gym_Dumbbell_Abstract_Logo_Design_Icon_Vector21;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(55, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 108);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pn_titlebar
            // 
            this.pn_titlebar.BackColor = System.Drawing.Color.Gainsboro;
            this.pn_titlebar.Controls.Add(this.bt_thongtin);
            this.pn_titlebar.Controls.Add(this.bt_minimize);
            this.pn_titlebar.Controls.Add(this.bt_maximize);
            this.pn_titlebar.Controls.Add(this.bt_close);
            this.pn_titlebar.Controls.Add(this.lb_titleCharform);
            this.pn_titlebar.Controls.Add(this.ic_currentChildform);
            this.pn_titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_titlebar.Location = new System.Drawing.Point(250, 0);
            this.pn_titlebar.Name = "pn_titlebar";
            this.pn_titlebar.Size = new System.Drawing.Size(1023, 28);
            this.pn_titlebar.TabIndex = 1;
            this.pn_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_titlebar_MouseDown);
            // 
            // bt_thongtin
            // 
            this.bt_thongtin.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_thongtin.FlatAppearance.BorderSize = 0;
            this.bt_thongtin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.bt_thongtin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_thongtin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thongtin.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thongtin.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.bt_thongtin.IconColor = System.Drawing.Color.Indigo;
            this.bt_thongtin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_thongtin.IconSize = 30;
            this.bt_thongtin.Location = new System.Drawing.Point(817, 0);
            this.bt_thongtin.Margin = new System.Windows.Forms.Padding(2);
            this.bt_thongtin.Name = "bt_thongtin";
            this.bt_thongtin.Size = new System.Drawing.Size(104, 28);
            this.bt_thongtin.TabIndex = 5;
            this.bt_thongtin.Tag = "";
            this.bt_thongtin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_thongtin.UseVisualStyleBackColor = true;
            this.bt_thongtin.Click += new System.EventHandler(this.bt_thongtin_Click);
            // 
            // bt_minimize
            // 
            this.bt_minimize.BackColor = System.Drawing.Color.Blue;
            this.bt_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_minimize.FlatAppearance.BorderSize = 0;
            this.bt_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.bt_minimize.IconColor = System.Drawing.Color.White;
            this.bt_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_minimize.IconSize = 20;
            this.bt_minimize.Location = new System.Drawing.Point(921, 0);
            this.bt_minimize.Margin = new System.Windows.Forms.Padding(2);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.Size = new System.Drawing.Size(34, 28);
            this.bt_minimize.TabIndex = 4;
            this.bt_minimize.UseVisualStyleBackColor = false;
            this.bt_minimize.Click += new System.EventHandler(this.bt_minimize_Click);
            // 
            // bt_maximize
            // 
            this.bt_maximize.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_maximize.FlatAppearance.BorderSize = 0;
            this.bt_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_maximize.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.bt_maximize.IconColor = System.Drawing.Color.White;
            this.bt_maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_maximize.IconSize = 20;
            this.bt_maximize.Location = new System.Drawing.Point(955, 0);
            this.bt_maximize.Margin = new System.Windows.Forms.Padding(2);
            this.bt_maximize.Name = "bt_maximize";
            this.bt_maximize.Size = new System.Drawing.Size(34, 28);
            this.bt_maximize.TabIndex = 6;
            this.bt_maximize.UseVisualStyleBackColor = false;
            this.bt_maximize.Click += new System.EventHandler(this.bt_maximize_Click);
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
            this.bt_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_close.FlatAppearance.BorderSize = 0;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.bt_close.IconColor = System.Drawing.Color.White;
            this.bt_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_close.IconSize = 20;
            this.bt_close.Location = new System.Drawing.Point(989, 0);
            this.bt_close.Margin = new System.Windows.Forms.Padding(2);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(34, 28);
            this.bt_close.TabIndex = 2;
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // lb_titleCharform
            // 
            this.lb_titleCharform.AutoSize = true;
            this.lb_titleCharform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titleCharform.ForeColor = System.Drawing.Color.BlueViolet;
            this.lb_titleCharform.Location = new System.Drawing.Point(46, 4);
            this.lb_titleCharform.Name = "lb_titleCharform";
            this.lb_titleCharform.Size = new System.Drawing.Size(56, 20);
            this.lb_titleCharform.TabIndex = 5;
            this.lb_titleCharform.Text = "Home";
            // 
            // ic_currentChildform
            // 
            this.ic_currentChildform.BackColor = System.Drawing.Color.Gainsboro;
            this.ic_currentChildform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ic_currentChildform.ForeColor = System.Drawing.Color.Purple;
            this.ic_currentChildform.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ic_currentChildform.IconColor = System.Drawing.Color.Purple;
            this.ic_currentChildform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_currentChildform.IconSize = 28;
            this.ic_currentChildform.Location = new System.Drawing.Point(11, 0);
            this.ic_currentChildform.Name = "ic_currentChildform";
            this.ic_currentChildform.Size = new System.Drawing.Size(32, 28);
            this.ic_currentChildform.TabIndex = 1;
            this.ic_currentChildform.TabStop = false;
            // 
            // pn_destop
            // 
            this.pn_destop.BackColor = System.Drawing.Color.White;
            this.pn_destop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_destop.Location = new System.Drawing.Point(250, 28);
            this.pn_destop.Name = "pn_destop";
            this.pn_destop.Size = new System.Drawing.Size(1023, 719);
            this.pn_destop.TabIndex = 2;
            // 
            // fTablePT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 747);
            this.Controls.Add(this.pn_destop);
            this.Controls.Add(this.pn_titlebar);
            this.Controls.Add(this.pn_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTablePT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTablePT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTablePT_FormClosing);
            this.pn_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_titlebar.ResumeLayout(false);
            this.pn_titlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ic_currentChildform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.Panel pn_titlebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton bt_hoivien;
        private FontAwesome.Sharp.IconButton bt_dangxuat;
        private FontAwesome.Sharp.IconButton bt_lichtap;
        private System.Windows.Forms.Panel pn_destop;
        private FontAwesome.Sharp.IconPictureBox ic_currentChildform;
        private System.Windows.Forms.Label lb_titleCharform;
        private FontAwesome.Sharp.IconButton bt_close;
        private FontAwesome.Sharp.IconButton bt_maximize;
        private FontAwesome.Sharp.IconButton bt_minimize;
        private FontAwesome.Sharp.IconButton bt_thongtin;
    }
}