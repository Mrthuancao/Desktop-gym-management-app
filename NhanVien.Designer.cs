﻿namespace Gym_Management
{
    partial class NhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_NV = new System.Windows.Forms.Panel();
            this.bt_search = new FontAwesome.Sharp.IconButton();
            this.lb_danhsach = new System.Windows.Forms.Label();
            this.dtg_NV = new System.Windows.Forms.DataGridView();
            this.helo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_thongtin = new System.Windows.Forms.Panel();
            this.dt_ngayvaolam = new System.Windows.Forms.DateTimePicker();
            this.dt_ngsinh = new System.Windows.Forms.DateTimePicker();
            this.lb_mlnv = new System.Windows.Forms.Label();
            this.lb_luong = new System.Windows.Forms.Label();
            this.lb_Sdt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_ngayvaolam = new System.Windows.Forms.Label();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.lb_phai = new System.Windows.Forms.Label();
            this.lb_tennv = new System.Windows.Forms.Label();
            this.lb_mnv = new System.Windows.Forms.Label();
            this.pb_anh = new FontAwesome.Sharp.IconPictureBox();
            this.lb_thongtin = new System.Windows.Forms.Label();
            this.tb_Search = new Gym_Management.CustomTextBox();
            this.bt_xoa = new Gym_Management.CustomButton();
            this.bt_sua = new Gym_Management.CustomButton();
            this.bt_Them = new Gym_Management.CustomButton();
            this.tb_mlnv = new Gym_Management.CustomTextBox();
            this.tb_Luong = new Gym_Management.CustomTextBox();
            this.tb_Email = new Gym_Management.CustomTextBox();
            this.tb_Sdt = new Gym_Management.CustomTextBox();
            this.tb_TenNv = new Gym_Management.CustomTextBox();
            this.tb_Phai = new Gym_Management.CustomTextBox();
            this.tb_mnv = new Gym_Management.CustomTextBox();
            this.pn_NV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NV)).BeginInit();
            this.pn_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_NV
            // 
            this.pn_NV.Controls.Add(this.bt_search);
            this.pn_NV.Controls.Add(this.tb_Search);
            this.pn_NV.Controls.Add(this.bt_xoa);
            this.pn_NV.Controls.Add(this.bt_sua);
            this.pn_NV.Controls.Add(this.bt_Them);
            this.pn_NV.Controls.Add(this.lb_danhsach);
            this.pn_NV.Controls.Add(this.dtg_NV);
            this.pn_NV.Controls.Add(this.pn_thongtin);
            this.pn_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_NV.Location = new System.Drawing.Point(0, 0);
            this.pn_NV.Name = "pn_NV";
            this.pn_NV.Size = new System.Drawing.Size(884, 641);
            this.pn_NV.TabIndex = 1;
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.Transparent;
            this.bt_search.FlatAppearance.BorderSize = 0;
            this.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bt_search.IconColor = System.Drawing.Color.Black;
            this.bt_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_search.IconSize = 30;
            this.bt_search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_search.Location = new System.Drawing.Point(327, 68);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(33, 33);
            this.bt_search.TabIndex = 13;
            this.bt_search.UseVisualStyleBackColor = false;
            // 
            // lb_danhsach
            // 
            this.lb_danhsach.AutoSize = true;
            this.lb_danhsach.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_danhsach.Location = new System.Drawing.Point(95, 24);
            this.lb_danhsach.Name = "lb_danhsach";
            this.lb_danhsach.Size = new System.Drawing.Size(209, 28);
            this.lb_danhsach.TabIndex = 9;
            this.lb_danhsach.Text = "Danh sách nhân viên";
            // 
            // dtg_NV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtg_NV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_NV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_NV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtg_NV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_NV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_NV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.helo,
            this.wew});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_NV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_NV.EnableHeadersVisualStyles = false;
            this.dtg_NV.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_NV.Location = new System.Drawing.Point(0, 171);
            this.dtg_NV.Name = "dtg_NV";
            this.dtg_NV.Size = new System.Drawing.Size(337, 470);
            this.dtg_NV.TabIndex = 0;
            // 
            // helo
            // 
            this.helo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.helo.HeaderText = "Mã nhân viên";
            this.helo.Name = "helo";
            // 
            // wew
            // 
            this.wew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wew.HeaderText = "Tên nhân viên";
            this.wew.Name = "wew";
            // 
            // pn_thongtin
            // 
            this.pn_thongtin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_thongtin.Controls.Add(this.dt_ngayvaolam);
            this.pn_thongtin.Controls.Add(this.dt_ngsinh);
            this.pn_thongtin.Controls.Add(this.lb_mlnv);
            this.pn_thongtin.Controls.Add(this.tb_mlnv);
            this.pn_thongtin.Controls.Add(this.tb_Luong);
            this.pn_thongtin.Controls.Add(this.lb_luong);
            this.pn_thongtin.Controls.Add(this.lb_Sdt);
            this.pn_thongtin.Controls.Add(this.tb_Email);
            this.pn_thongtin.Controls.Add(this.label5);
            this.pn_thongtin.Controls.Add(this.lb_ngayvaolam);
            this.pn_thongtin.Controls.Add(this.lb_ngaysinh);
            this.pn_thongtin.Controls.Add(this.lb_phai);
            this.pn_thongtin.Controls.Add(this.lb_tennv);
            this.pn_thongtin.Controls.Add(this.lb_mnv);
            this.pn_thongtin.Controls.Add(this.tb_Sdt);
            this.pn_thongtin.Controls.Add(this.tb_TenNv);
            this.pn_thongtin.Controls.Add(this.tb_Phai);
            this.pn_thongtin.Controls.Add(this.tb_mnv);
            this.pn_thongtin.Controls.Add(this.pb_anh);
            this.pn_thongtin.Controls.Add(this.lb_thongtin);
            this.pn_thongtin.Location = new System.Drawing.Point(459, 12);
            this.pn_thongtin.Name = "pn_thongtin";
            this.pn_thongtin.Size = new System.Drawing.Size(413, 626);
            this.pn_thongtin.TabIndex = 8;
            // 
            // dt_ngayvaolam
            // 
            this.dt_ngayvaolam.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngayvaolam.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngayvaolam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngayvaolam.Location = new System.Drawing.Point(156, 419);
            this.dt_ngayvaolam.Name = "dt_ngayvaolam";
            this.dt_ngayvaolam.Size = new System.Drawing.Size(232, 26);
            this.dt_ngayvaolam.TabIndex = 30;
            // 
            // dt_ngsinh
            // 
            this.dt_ngsinh.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngsinh.CalendarForeColor = System.Drawing.Color.Black;
            this.dt_ngsinh.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngsinh.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngsinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngsinh.Location = new System.Drawing.Point(156, 380);
            this.dt_ngsinh.Name = "dt_ngsinh";
            this.dt_ngsinh.Size = new System.Drawing.Size(232, 26);
            this.dt_ngsinh.TabIndex = 29;
            // 
            // lb_mlnv
            // 
            this.lb_mlnv.AutoSize = true;
            this.lb_mlnv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mlnv.Location = new System.Drawing.Point(21, 586);
            this.lb_mlnv.Name = "lb_mlnv";
            this.lb_mlnv.Size = new System.Drawing.Size(128, 16);
            this.lb_mlnv.TabIndex = 28;
            this.lb_mlnv.Text = "Mã loại nhân viên:";
            // 
            // lb_luong
            // 
            this.lb_luong.AutoSize = true;
            this.lb_luong.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_luong.Location = new System.Drawing.Point(21, 545);
            this.lb_luong.Name = "lb_luong";
            this.lb_luong.Size = new System.Drawing.Size(53, 16);
            this.lb_luong.TabIndex = 25;
            this.lb_luong.Text = "Lương:";
            // 
            // lb_Sdt
            // 
            this.lb_Sdt.AutoSize = true;
            this.lb_Sdt.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sdt.Location = new System.Drawing.Point(21, 468);
            this.lb_Sdt.Name = "lb_Sdt";
            this.lb_Sdt.Size = new System.Drawing.Size(100, 16);
            this.lb_Sdt.TabIndex = 24;
            this.lb_Sdt.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Email:";
            // 
            // lb_ngayvaolam
            // 
            this.lb_ngayvaolam.AutoSize = true;
            this.lb_ngayvaolam.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngayvaolam.Location = new System.Drawing.Point(21, 429);
            this.lb_ngayvaolam.Name = "lb_ngayvaolam";
            this.lb_ngayvaolam.Size = new System.Drawing.Size(102, 16);
            this.lb_ngayvaolam.TabIndex = 21;
            this.lb_ngayvaolam.Text = "Ngày vào làm:";
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaysinh.Location = new System.Drawing.Point(21, 388);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(77, 16);
            this.lb_ngaysinh.TabIndex = 20;
            this.lb_ngaysinh.Text = "Ngày sinh:";
            // 
            // lb_phai
            // 
            this.lb_phai.AutoSize = true;
            this.lb_phai.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phai.Location = new System.Drawing.Point(21, 345);
            this.lb_phai.Name = "lb_phai";
            this.lb_phai.Size = new System.Drawing.Size(40, 16);
            this.lb_phai.TabIndex = 19;
            this.lb_phai.Text = "Phái:";
            // 
            // lb_tennv
            // 
            this.lb_tennv.AutoSize = true;
            this.lb_tennv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tennv.Location = new System.Drawing.Point(21, 304);
            this.lb_tennv.Name = "lb_tennv";
            this.lb_tennv.Size = new System.Drawing.Size(107, 16);
            this.lb_tennv.TabIndex = 18;
            this.lb_tennv.Text = "Tên nhân viên:";
            // 
            // lb_mnv
            // 
            this.lb_mnv.AutoSize = true;
            this.lb_mnv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mnv.Location = new System.Drawing.Point(21, 263);
            this.lb_mnv.Name = "lb_mnv";
            this.lb_mnv.Size = new System.Drawing.Size(101, 16);
            this.lb_mnv.TabIndex = 17;
            this.lb_mnv.Text = "Mã nhân viên:";
            // 
            // pb_anh
            // 
            this.pb_anh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb_anh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_anh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pb_anh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pb_anh.IconColor = System.Drawing.SystemColors.ControlText;
            this.pb_anh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pb_anh.IconSize = 176;
            this.pb_anh.Location = new System.Drawing.Point(88, 54);
            this.pb_anh.Name = "pb_anh";
            this.pb_anh.Size = new System.Drawing.Size(269, 176);
            this.pb_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_anh.TabIndex = 11;
            this.pb_anh.TabStop = false;
            // 
            // lb_thongtin
            // 
            this.lb_thongtin.AutoSize = true;
            this.lb_thongtin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_thongtin.Location = new System.Drawing.Point(129, 10);
            this.lb_thongtin.Name = "lb_thongtin";
            this.lb_thongtin.Size = new System.Drawing.Size(203, 28);
            this.lb_thongtin.TabIndex = 10;
            this.lb_thongtin.Text = "Thông tin nhân viên";
            // 
            // tb_Search
            // 
            this.tb_Search.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Search.BorderColor = System.Drawing.Color.Black;
            this.tb_Search.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_Search.BorderRadius = 5;
            this.tb_Search.Bordersize = 2;
            this.tb_Search.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.ForeColor = System.Drawing.Color.Black;
            this.tb_Search.Location = new System.Drawing.Point(88, 68);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Search.Multiline = false;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Search.PasswordChar = false;
            this.tb_Search.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Search.PlaceholderText = "Search...";
            this.tb_Search.Size = new System.Drawing.Size(232, 33);
            this.tb_Search.TabIndex = 12;
            this.tb_Search.Texts = "";
            this.tb_Search.UnderlinedStyle = false;
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_xoa.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.bt_xoa.BorderColor = System.Drawing.SystemColors.Control;
            this.bt_xoa.BorderRadius = 15;
            this.bt_xoa.BorderSize = 0;
            this.bt_xoa.FlatAppearance.BorderSize = 0;
            this.bt_xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.Transparent;
            this.bt_xoa.Location = new System.Drawing.Point(351, 235);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(102, 34);
            this.bt_xoa.TabIndex = 11;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextColor = System.Drawing.Color.Transparent;
            this.bt_xoa.UseVisualStyleBackColor = false;
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_sua.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.bt_sua.BorderColor = System.Drawing.SystemColors.Control;
            this.bt_sua.BorderRadius = 15;
            this.bt_sua.BorderSize = 0;
            this.bt_sua.FlatAppearance.BorderSize = 0;
            this.bt_sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.Color.Transparent;
            this.bt_sua.Location = new System.Drawing.Point(351, 300);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(102, 34);
            this.bt_sua.TabIndex = 10;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.TextColor = System.Drawing.Color.Transparent;
            this.bt_sua.UseVisualStyleBackColor = false;
            // 
            // bt_Them
            // 
            this.bt_Them.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_Them.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.bt_Them.BorderColor = System.Drawing.SystemColors.Control;
            this.bt_Them.BorderRadius = 15;
            this.bt_Them.BorderSize = 0;
            this.bt_Them.FlatAppearance.BorderSize = 0;
            this.bt_Them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.ForeColor = System.Drawing.Color.Transparent;
            this.bt_Them.Location = new System.Drawing.Point(351, 171);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(102, 34);
            this.bt_Them.TabIndex = 7;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.TextColor = System.Drawing.Color.Transparent;
            this.bt_Them.UseVisualStyleBackColor = false;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // tb_mlnv
            // 
            this.tb_mlnv.BackColor = System.Drawing.SystemColors.Window;
            this.tb_mlnv.BorderColor = System.Drawing.Color.Black;
            this.tb_mlnv.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_mlnv.BorderRadius = 5;
            this.tb_mlnv.Bordersize = 2;
            this.tb_mlnv.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mlnv.ForeColor = System.Drawing.Color.Black;
            this.tb_mlnv.Location = new System.Drawing.Point(156, 579);
            this.tb_mlnv.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mlnv.Multiline = false;
            this.tb_mlnv.Name = "tb_mlnv";
            this.tb_mlnv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_mlnv.PasswordChar = false;
            this.tb_mlnv.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_mlnv.PlaceholderText = "";
            this.tb_mlnv.Size = new System.Drawing.Size(232, 33);
            this.tb_mlnv.TabIndex = 27;
            this.tb_mlnv.Texts = "";
            this.tb_mlnv.UnderlinedStyle = false;
            // 
            // tb_Luong
            // 
            this.tb_Luong.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Luong.BorderColor = System.Drawing.Color.Black;
            this.tb_Luong.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_Luong.BorderRadius = 5;
            this.tb_Luong.Bordersize = 2;
            this.tb_Luong.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Luong.ForeColor = System.Drawing.Color.Black;
            this.tb_Luong.Location = new System.Drawing.Point(156, 538);
            this.tb_Luong.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Luong.Multiline = false;
            this.tb_Luong.Name = "tb_Luong";
            this.tb_Luong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Luong.PasswordChar = false;
            this.tb_Luong.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Luong.PlaceholderText = "";
            this.tb_Luong.Size = new System.Drawing.Size(232, 33);
            this.tb_Luong.TabIndex = 26;
            this.tb_Luong.Texts = "";
            this.tb_Luong.UnderlinedStyle = false;
            // 
            // tb_Email
            // 
            this.tb_Email.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Email.BorderColor = System.Drawing.Color.Black;
            this.tb_Email.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_Email.BorderRadius = 5;
            this.tb_Email.Bordersize = 2;
            this.tb_Email.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.ForeColor = System.Drawing.Color.Black;
            this.tb_Email.Location = new System.Drawing.Point(156, 497);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Email.Multiline = false;
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Email.PasswordChar = false;
            this.tb_Email.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Email.PlaceholderText = "";
            this.tb_Email.Size = new System.Drawing.Size(232, 33);
            this.tb_Email.TabIndex = 23;
            this.tb_Email.Texts = "";
            this.tb_Email.UnderlinedStyle = false;
            // 
            // tb_Sdt
            // 
            this.tb_Sdt.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Sdt.BorderColor = System.Drawing.Color.Black;
            this.tb_Sdt.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_Sdt.BorderRadius = 5;
            this.tb_Sdt.Bordersize = 2;
            this.tb_Sdt.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sdt.ForeColor = System.Drawing.Color.Black;
            this.tb_Sdt.Location = new System.Drawing.Point(156, 456);
            this.tb_Sdt.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Sdt.Multiline = false;
            this.tb_Sdt.Name = "tb_Sdt";
            this.tb_Sdt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Sdt.PasswordChar = false;
            this.tb_Sdt.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Sdt.PlaceholderText = "";
            this.tb_Sdt.Size = new System.Drawing.Size(232, 33);
            this.tb_Sdt.TabIndex = 16;
            this.tb_Sdt.Texts = "";
            this.tb_Sdt.UnderlinedStyle = false;
            // 
            // tb_TenNv
            // 
            this.tb_TenNv.BackColor = System.Drawing.SystemColors.Window;
            this.tb_TenNv.BorderColor = System.Drawing.Color.Black;
            this.tb_TenNv.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_TenNv.BorderRadius = 5;
            this.tb_TenNv.Bordersize = 2;
            this.tb_TenNv.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenNv.ForeColor = System.Drawing.Color.Black;
            this.tb_TenNv.Location = new System.Drawing.Point(156, 292);
            this.tb_TenNv.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TenNv.Multiline = false;
            this.tb_TenNv.Name = "tb_TenNv";
            this.tb_TenNv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_TenNv.PasswordChar = false;
            this.tb_TenNv.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_TenNv.PlaceholderText = "";
            this.tb_TenNv.Size = new System.Drawing.Size(232, 33);
            this.tb_TenNv.TabIndex = 13;
            this.tb_TenNv.Texts = "";
            this.tb_TenNv.UnderlinedStyle = false;
            // 
            // tb_Phai
            // 
            this.tb_Phai.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Phai.BorderColor = System.Drawing.Color.Black;
            this.tb_Phai.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_Phai.BorderRadius = 5;
            this.tb_Phai.Bordersize = 2;
            this.tb_Phai.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phai.ForeColor = System.Drawing.Color.Black;
            this.tb_Phai.Location = new System.Drawing.Point(156, 333);
            this.tb_Phai.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Phai.Multiline = false;
            this.tb_Phai.Name = "tb_Phai";
            this.tb_Phai.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Phai.PasswordChar = false;
            this.tb_Phai.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Phai.PlaceholderText = "";
            this.tb_Phai.Size = new System.Drawing.Size(232, 33);
            this.tb_Phai.TabIndex = 13;
            this.tb_Phai.Texts = "";
            this.tb_Phai.UnderlinedStyle = false;
            // 
            // tb_mnv
            // 
            this.tb_mnv.BackColor = System.Drawing.SystemColors.Window;
            this.tb_mnv.BorderColor = System.Drawing.Color.Black;
            this.tb_mnv.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_mnv.BorderRadius = 5;
            this.tb_mnv.Bordersize = 2;
            this.tb_mnv.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mnv.ForeColor = System.Drawing.Color.Black;
            this.tb_mnv.Location = new System.Drawing.Point(156, 251);
            this.tb_mnv.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mnv.Multiline = false;
            this.tb_mnv.Name = "tb_mnv";
            this.tb_mnv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_mnv.PasswordChar = false;
            this.tb_mnv.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_mnv.PlaceholderText = "";
            this.tb_mnv.Size = new System.Drawing.Size(232, 33);
            this.tb_mnv.TabIndex = 12;
            this.tb_mnv.Texts = "";
            this.tb_mnv.UnderlinedStyle = false;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 641);
            this.Controls.Add(this.pn_NV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVien";
            this.Text = "Nhân viên";
            this.pn_NV.ResumeLayout(false);
            this.pn_NV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NV)).EndInit();
            this.pn_thongtin.ResumeLayout(false);
            this.pn_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_NV;
        private FontAwesome.Sharp.IconButton bt_search;
        private CustomTextBox tb_Search;
        private CustomButton bt_xoa;
        private CustomButton bt_sua;
        private CustomButton bt_Them;
        private System.Windows.Forms.Label lb_danhsach;
        private System.Windows.Forms.DataGridView dtg_NV;
        private System.Windows.Forms.Panel pn_thongtin;
        private System.Windows.Forms.Label lb_Sdt;
        private CustomTextBox tb_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_ngayvaolam;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.Label lb_phai;
        private System.Windows.Forms.Label lb_tennv;
        private System.Windows.Forms.Label lb_mnv;
        private CustomTextBox tb_Sdt;
        private CustomTextBox tb_TenNv;
        private CustomTextBox tb_Phai;
        private CustomTextBox tb_mnv;
        private FontAwesome.Sharp.IconPictureBox pb_anh;
        private System.Windows.Forms.Label lb_thongtin;
        private System.Windows.Forms.DataGridViewTextBoxColumn helo;
        private System.Windows.Forms.DataGridViewTextBoxColumn wew;
        private System.Windows.Forms.Label lb_mlnv;
        private CustomTextBox tb_mlnv;
        private CustomTextBox tb_Luong;
        private System.Windows.Forms.Label lb_luong;
        public System.Windows.Forms.DateTimePicker dt_ngayvaolam;
        public System.Windows.Forms.DateTimePicker dt_ngsinh;
    }
}