namespace Gym_Management
{
    partial class fTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.pn_titlebar = new System.Windows.Forms.Panel();
            this.bt_thongtin = new FontAwesome.Sharp.IconButton();
            this.lb_titleCharform = new System.Windows.Forms.Label();
            this.ic_currentChildform = new FontAwesome.Sharp.IconPictureBox();
            this.bt_minimize = new FontAwesome.Sharp.IconButton();
            this.bt_close = new FontAwesome.Sharp.IconButton();
            this.bt_maximize = new FontAwesome.Sharp.IconButton();
            this.pn_destop = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_menu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_menu = new System.Windows.Forms.Panel();
            this.bt_Captaikhoan = new FontAwesome.Sharp.IconButton();
            this.bt_exit = new FontAwesome.Sharp.IconButton();
            this.bt_doanhthu = new FontAwesome.Sharp.IconButton();
            this.bt_goitap = new FontAwesome.Sharp.IconButton();
            this.bt_thietbi = new FontAwesome.Sharp.IconButton();
            this.bt_sanpham = new FontAwesome.Sharp.IconButton();
            this.bt_nhanvien = new FontAwesome.Sharp.IconButton();
            this.bt_khachhang = new FontAwesome.Sharp.IconButton();
            this.pn_titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ic_currentChildform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_titlebar
            // 
            this.pn_titlebar.BackColor = System.Drawing.Color.Gainsboro;
            this.pn_titlebar.Controls.Add(this.bt_thongtin);
            this.pn_titlebar.Controls.Add(this.lb_titleCharform);
            this.pn_titlebar.Controls.Add(this.ic_currentChildform);
            this.pn_titlebar.Controls.Add(this.bt_minimize);
            this.pn_titlebar.Controls.Add(this.bt_close);
            this.pn_titlebar.Controls.Add(this.bt_maximize);
            this.pn_titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_titlebar.Location = new System.Drawing.Point(200, 0);
            this.pn_titlebar.Margin = new System.Windows.Forms.Padding(2);
            this.pn_titlebar.Name = "pn_titlebar";
            this.pn_titlebar.Size = new System.Drawing.Size(934, 28);
            this.pn_titlebar.TabIndex = 1;
            this.pn_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_titlebar_MouseDown);
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
            this.bt_thongtin.Location = new System.Drawing.Point(725, 0);
            this.bt_thongtin.Margin = new System.Windows.Forms.Padding(2);
            this.bt_thongtin.Name = "bt_thongtin";
            this.bt_thongtin.Size = new System.Drawing.Size(104, 28);
            this.bt_thongtin.TabIndex = 4;
            this.bt_thongtin.Tag = "";
            this.bt_thongtin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_thongtin.UseVisualStyleBackColor = true;
            this.bt_thongtin.Click += new System.EventHandler(this.bt_thongtin_Click);
            // 
            // lb_titleCharform
            // 
            this.lb_titleCharform.AutoSize = true;
            this.lb_titleCharform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titleCharform.ForeColor = System.Drawing.Color.BlueViolet;
            this.lb_titleCharform.Location = new System.Drawing.Point(46, 4);
            this.lb_titleCharform.Name = "lb_titleCharform";
            this.lb_titleCharform.Size = new System.Drawing.Size(56, 20);
            this.lb_titleCharform.TabIndex = 4;
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
            this.ic_currentChildform.TabIndex = 0;
            this.ic_currentChildform.TabStop = false;
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
            this.bt_minimize.Location = new System.Drawing.Point(832, 0);
            this.bt_minimize.Margin = new System.Windows.Forms.Padding(2);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.Size = new System.Drawing.Size(34, 28);
            this.bt_minimize.TabIndex = 3;
            this.bt_minimize.UseVisualStyleBackColor = false;
            this.bt_minimize.Click += new System.EventHandler(this.bt_minimize_Click);
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
            this.bt_close.Location = new System.Drawing.Point(900, 0);
            this.bt_close.Margin = new System.Windows.Forms.Padding(2);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(34, 28);
            this.bt_close.TabIndex = 1;
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
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
            this.bt_maximize.Location = new System.Drawing.Point(866, 0);
            this.bt_maximize.Margin = new System.Windows.Forms.Padding(2);
            this.bt_maximize.Name = "bt_maximize";
            this.bt_maximize.Size = new System.Drawing.Size(34, 28);
            this.bt_maximize.TabIndex = 2;
            this.bt_maximize.UseVisualStyleBackColor = false;
            this.bt_maximize.Click += new System.EventHandler(this.bt_maximize_Click);
            // 
            // pn_destop
            // 
            this.pn_destop.BackColor = System.Drawing.Color.White;
            this.pn_destop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_destop.Location = new System.Drawing.Point(200, 28);
            this.pn_destop.Margin = new System.Windows.Forms.Padding(2);
            this.pn_destop.Name = "pn_destop";
            this.pn_destop.Size = new System.Drawing.Size(934, 633);
            this.pn_destop.TabIndex = 2;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_menu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 74);
            this.panel1.TabIndex = 0;
            // 
            // bt_menu
            // 
            this.bt_menu.FlatAppearance.BorderSize = 0;
            this.bt_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_menu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.bt_menu.IconColor = System.Drawing.Color.Black;
            this.bt_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_menu.IconSize = 30;
            this.bt_menu.Location = new System.Drawing.Point(155, 0);
            this.bt_menu.Margin = new System.Windows.Forms.Padding(2);
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.Size = new System.Drawing.Size(45, 74);
            this.bt_menu.TabIndex = 0;
            this.bt_menu.UseVisualStyleBackColor = true;
            this.bt_menu.Click += new System.EventHandler(this.bt_menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym_Management.Properties.Resources.Fitness_Gym_Dumbbell_Abstract_Logo_Design_Icon_Vector21;
            this.pictureBox1.Location = new System.Drawing.Point(25, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.Gainsboro;
            this.pn_menu.Controls.Add(this.bt_Captaikhoan);
            this.pn_menu.Controls.Add(this.bt_exit);
            this.pn_menu.Controls.Add(this.bt_doanhthu);
            this.pn_menu.Controls.Add(this.bt_goitap);
            this.pn_menu.Controls.Add(this.bt_thietbi);
            this.pn_menu.Controls.Add(this.bt_sanpham);
            this.pn_menu.Controls.Add(this.bt_nhanvien);
            this.pn_menu.Controls.Add(this.bt_khachhang);
            this.pn_menu.Controls.Add(this.panel1);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu.Location = new System.Drawing.Point(0, 0);
            this.pn_menu.Margin = new System.Windows.Forms.Padding(2);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(200, 661);
            this.pn_menu.TabIndex = 0;
            // 
            // bt_Captaikhoan
            // 
            this.bt_Captaikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Captaikhoan.FlatAppearance.BorderSize = 0;
            this.bt_Captaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Captaikhoan.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Captaikhoan.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.bt_Captaikhoan.IconColor = System.Drawing.Color.Black;
            this.bt_Captaikhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_Captaikhoan.IconSize = 30;
            this.bt_Captaikhoan.Location = new System.Drawing.Point(0, 332);
            this.bt_Captaikhoan.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Captaikhoan.Name = "bt_Captaikhoan";
            this.bt_Captaikhoan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_Captaikhoan.Size = new System.Drawing.Size(200, 43);
            this.bt_Captaikhoan.TabIndex = 8;
            this.bt_Captaikhoan.Tag = "Cấp tài khoản";
            this.bt_Captaikhoan.Text = "   Cấp tài khoản";
            this.bt_Captaikhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Captaikhoan.UseVisualStyleBackColor = true;
            this.bt_Captaikhoan.Click += new System.EventHandler(this.bt_Captaikhoan_Click_1);
            // 
            // bt_exit
            // 
            this.bt_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.bt_exit.IconColor = System.Drawing.Color.Black;
            this.bt_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_exit.IconSize = 30;
            this.bt_exit.Location = new System.Drawing.Point(0, 618);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Padding = new System.Windows.Forms.Padding(8, 0, 0, 8);
            this.bt_exit.Size = new System.Drawing.Size(200, 43);
            this.bt_exit.TabIndex = 7;
            this.bt_exit.Tag = "Đăng xuất";
            this.bt_exit.Text = "   Đăng xuất";
            this.bt_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_doanhthu
            // 
            this.bt_doanhthu.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_doanhthu.FlatAppearance.BorderSize = 0;
            this.bt_doanhthu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_doanhthu.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_doanhthu.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.bt_doanhthu.IconColor = System.Drawing.Color.Black;
            this.bt_doanhthu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_doanhthu.IconSize = 30;
            this.bt_doanhthu.Location = new System.Drawing.Point(0, 289);
            this.bt_doanhthu.Margin = new System.Windows.Forms.Padding(2);
            this.bt_doanhthu.Name = "bt_doanhthu";
            this.bt_doanhthu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_doanhthu.Size = new System.Drawing.Size(200, 43);
            this.bt_doanhthu.TabIndex = 6;
            this.bt_doanhthu.Tag = "Doanh thu";
            this.bt_doanhthu.Text = "   Doanh thu";
            this.bt_doanhthu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_doanhthu.UseVisualStyleBackColor = true;
            this.bt_doanhthu.Click += new System.EventHandler(this.bt_captaikhoan_Click);
            // 
            // bt_goitap
            // 
            this.bt_goitap.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_goitap.FlatAppearance.BorderSize = 0;
            this.bt_goitap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_goitap.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_goitap.IconChar = FontAwesome.Sharp.IconChar.Biking;
            this.bt_goitap.IconColor = System.Drawing.Color.Black;
            this.bt_goitap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_goitap.IconSize = 30;
            this.bt_goitap.Location = new System.Drawing.Point(0, 246);
            this.bt_goitap.Margin = new System.Windows.Forms.Padding(2);
            this.bt_goitap.Name = "bt_goitap";
            this.bt_goitap.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_goitap.Size = new System.Drawing.Size(200, 43);
            this.bt_goitap.TabIndex = 5;
            this.bt_goitap.Tag = "Gói tập";
            this.bt_goitap.Text = "   Gói tập";
            this.bt_goitap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_goitap.UseVisualStyleBackColor = true;
            this.bt_goitap.Click += new System.EventHandler(this.bt_doanhthu_Click);
            // 
            // bt_thietbi
            // 
            this.bt_thietbi.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_thietbi.FlatAppearance.BorderSize = 0;
            this.bt_thietbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thietbi.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thietbi.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.bt_thietbi.IconColor = System.Drawing.Color.Black;
            this.bt_thietbi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_thietbi.IconSize = 30;
            this.bt_thietbi.Location = new System.Drawing.Point(0, 203);
            this.bt_thietbi.Margin = new System.Windows.Forms.Padding(2);
            this.bt_thietbi.Name = "bt_thietbi";
            this.bt_thietbi.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_thietbi.Size = new System.Drawing.Size(200, 43);
            this.bt_thietbi.TabIndex = 3;
            this.bt_thietbi.Tag = "Thiết bị";
            this.bt_thietbi.Text = "   Thiết bị";
            this.bt_thietbi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_thietbi.UseVisualStyleBackColor = true;
            this.bt_thietbi.Click += new System.EventHandler(this.bt_thietbi_Click);
            // 
            // bt_sanpham
            // 
            this.bt_sanpham.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_sanpham.FlatAppearance.BorderSize = 0;
            this.bt_sanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sanpham.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sanpham.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.bt_sanpham.IconColor = System.Drawing.Color.Black;
            this.bt_sanpham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_sanpham.IconSize = 30;
            this.bt_sanpham.Location = new System.Drawing.Point(0, 160);
            this.bt_sanpham.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sanpham.Name = "bt_sanpham";
            this.bt_sanpham.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_sanpham.Size = new System.Drawing.Size(200, 43);
            this.bt_sanpham.TabIndex = 2;
            this.bt_sanpham.Tag = "Sản phẩm";
            this.bt_sanpham.Text = "   Sản phẩm";
            this.bt_sanpham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_sanpham.UseVisualStyleBackColor = true;
            this.bt_sanpham.Click += new System.EventHandler(this.bt_goitap_Click);
            // 
            // bt_nhanvien
            // 
            this.bt_nhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_nhanvien.FlatAppearance.BorderSize = 0;
            this.bt_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_nhanvien.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nhanvien.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.bt_nhanvien.IconColor = System.Drawing.Color.Black;
            this.bt_nhanvien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_nhanvien.IconSize = 30;
            this.bt_nhanvien.Location = new System.Drawing.Point(0, 117);
            this.bt_nhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.bt_nhanvien.Name = "bt_nhanvien";
            this.bt_nhanvien.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_nhanvien.Size = new System.Drawing.Size(200, 43);
            this.bt_nhanvien.TabIndex = 1;
            this.bt_nhanvien.Tag = "Nhân viên";
            this.bt_nhanvien.Text = "   Nhân viên";
            this.bt_nhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_nhanvien.UseVisualStyleBackColor = true;
            this.bt_nhanvien.Click += new System.EventHandler(this.bt_nhanvien_Click);
            // 
            // bt_khachhang
            // 
            this.bt_khachhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_khachhang.FlatAppearance.BorderSize = 0;
            this.bt_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_khachhang.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_khachhang.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.bt_khachhang.IconColor = System.Drawing.Color.Black;
            this.bt_khachhang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_khachhang.IconSize = 30;
            this.bt_khachhang.Location = new System.Drawing.Point(0, 74);
            this.bt_khachhang.Margin = new System.Windows.Forms.Padding(2);
            this.bt_khachhang.Name = "bt_khachhang";
            this.bt_khachhang.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_khachhang.Size = new System.Drawing.Size(200, 43);
            this.bt_khachhang.TabIndex = 0;
            this.bt_khachhang.Tag = "Hội viên";
            this.bt_khachhang.Text = "   Hội viên";
            this.bt_khachhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_khachhang.UseVisualStyleBackColor = true;
            this.bt_khachhang.Click += new System.EventHandler(this.bt_khachhang_Click);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.pn_destop);
            this.Controls.Add(this.pn_titlebar);
            this.Controls.Add(this.pn_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTableManager_FormClosing);
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.Resize += new System.EventHandler(this.fTableManager_Resize);
            this.pn_titlebar.ResumeLayout(false);
            this.pn_titlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ic_currentChildform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_titlebar;
        private System.Windows.Forms.Panel pn_destop;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private FontAwesome.Sharp.IconButton bt_close;
        private FontAwesome.Sharp.IconButton bt_minimize;
        private FontAwesome.Sharp.IconButton bt_maximize;
        private System.Windows.Forms.Panel pn_menu;
        private FontAwesome.Sharp.IconButton bt_exit;
        private FontAwesome.Sharp.IconButton bt_doanhthu;
        private FontAwesome.Sharp.IconButton bt_goitap;
        private FontAwesome.Sharp.IconButton bt_thongtin;
        private FontAwesome.Sharp.IconButton bt_thietbi;
        private FontAwesome.Sharp.IconButton bt_sanpham;
        private FontAwesome.Sharp.IconButton bt_nhanvien;
        private FontAwesome.Sharp.IconButton bt_khachhang;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton bt_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox ic_currentChildform;
        private System.Windows.Forms.Label lb_titleCharform;
        private FontAwesome.Sharp.IconButton bt_Captaikhoan;
    }
}