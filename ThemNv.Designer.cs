namespace Gym_Management
{
    partial class ThemNv
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
            this.gb_themhv = new System.Windows.Forms.GroupBox();
            this.tb_manv = new Gym_Management.CustomTextBox();
            this.lb_manv = new System.Windows.Forms.Label();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.bt_xoahet = new Gym_Management.CustomButton();
            this.bt_Luu = new Gym_Management.CustomButton();
            this.dt_ngayvaolam = new System.Windows.Forms.DateTimePicker();
            this.dt_ngsinh = new System.Windows.Forms.DateTimePicker();
            this.lb_mlnv = new System.Windows.Forms.Label();
            this.tb_mlnv = new Gym_Management.CustomTextBox();
            this.tb_Luong = new Gym_Management.CustomTextBox();
            this.lb_luong = new System.Windows.Forms.Label();
            this.lb_Sdt = new System.Windows.Forms.Label();
            this.tb_Email = new Gym_Management.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_ngayvaolam = new System.Windows.Forms.Label();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.lb_phai = new System.Windows.Forms.Label();
            this.lb_tennv = new System.Windows.Forms.Label();
            this.tb_Sdt = new Gym_Management.CustomTextBox();
            this.tb_TenNv = new Gym_Management.CustomTextBox();
            this.pb_anh = new FontAwesome.Sharp.IconPictureBox();
            this.gb_themhv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_themhv
            // 
            this.gb_themhv.BackColor = System.Drawing.Color.Gainsboro;
            this.gb_themhv.Controls.Add(this.tb_manv);
            this.gb_themhv.Controls.Add(this.lb_manv);
            this.gb_themhv.Controls.Add(this.cb_gioitinh);
            this.gb_themhv.Controls.Add(this.bt_xoahet);
            this.gb_themhv.Controls.Add(this.bt_Luu);
            this.gb_themhv.Controls.Add(this.dt_ngayvaolam);
            this.gb_themhv.Controls.Add(this.dt_ngsinh);
            this.gb_themhv.Controls.Add(this.lb_mlnv);
            this.gb_themhv.Controls.Add(this.tb_mlnv);
            this.gb_themhv.Controls.Add(this.tb_Luong);
            this.gb_themhv.Controls.Add(this.lb_luong);
            this.gb_themhv.Controls.Add(this.lb_Sdt);
            this.gb_themhv.Controls.Add(this.tb_Email);
            this.gb_themhv.Controls.Add(this.label5);
            this.gb_themhv.Controls.Add(this.lb_ngayvaolam);
            this.gb_themhv.Controls.Add(this.lb_ngaysinh);
            this.gb_themhv.Controls.Add(this.lb_phai);
            this.gb_themhv.Controls.Add(this.lb_tennv);
            this.gb_themhv.Controls.Add(this.tb_Sdt);
            this.gb_themhv.Controls.Add(this.tb_TenNv);
            this.gb_themhv.Controls.Add(this.pb_anh);
            this.gb_themhv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_themhv.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_themhv.ForeColor = System.Drawing.Color.Red;
            this.gb_themhv.Location = new System.Drawing.Point(0, 0);
            this.gb_themhv.Name = "gb_themhv";
            this.gb_themhv.Size = new System.Drawing.Size(486, 660);
            this.gb_themhv.TabIndex = 2;
            this.gb_themhv.TabStop = false;
            this.gb_themhv.Text = "THÊM HỘI VIÊN";
            // 
            // tb_manv
            // 
            this.tb_manv.BackColor = System.Drawing.SystemColors.Window;
            this.tb_manv.BorderColor = System.Drawing.Color.Black;
            this.tb_manv.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_manv.BorderRadius = 5;
            this.tb_manv.Bordersize = 2;
            this.tb_manv.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_manv.ForeColor = System.Drawing.Color.Black;
            this.tb_manv.Location = new System.Drawing.Point(209, 254);
            this.tb_manv.Margin = new System.Windows.Forms.Padding(4);
            this.tb_manv.Multiline = false;
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_manv.PasswordChar = false;
            this.tb_manv.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_manv.PlaceholderText = "";
            this.tb_manv.Size = new System.Drawing.Size(232, 33);
            this.tb_manv.TabIndex = 49;
            this.tb_manv.Texts = "";
            this.tb_manv.UnderlinedStyle = false;
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_manv.ForeColor = System.Drawing.Color.Black;
            this.lb_manv.Location = new System.Drawing.Point(30, 271);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(101, 16);
            this.lb_manv.TabIndex = 48;
            this.lb_manv.Text = "Mã nhân viên:";
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.IntegralHeight = false;
            this.cb_gioitinh.ItemHeight = 18;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gioitinh.Location = new System.Drawing.Point(209, 335);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(232, 26);
            this.cb_gioitinh.TabIndex = 2;
            // 
            // bt_xoahet
            // 
            this.bt_xoahet.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_xoahet.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.bt_xoahet.BorderColor = System.Drawing.SystemColors.Control;
            this.bt_xoahet.BorderRadius = 15;
            this.bt_xoahet.BorderSize = 0;
            this.bt_xoahet.FlatAppearance.BorderSize = 0;
            this.bt_xoahet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_xoahet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_xoahet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoahet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoahet.ForeColor = System.Drawing.Color.Transparent;
            this.bt_xoahet.Location = new System.Drawing.Point(347, 623);
            this.bt_xoahet.Name = "bt_xoahet";
            this.bt_xoahet.Size = new System.Drawing.Size(70, 27);
            this.bt_xoahet.TabIndex = 10;
            this.bt_xoahet.Text = "Xóa hết";
            this.bt_xoahet.TextColor = System.Drawing.Color.Transparent;
            this.bt_xoahet.UseVisualStyleBackColor = false;
            this.bt_xoahet.Click += new System.EventHandler(this.bt_xoahet_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_Luu.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.bt_Luu.BorderColor = System.Drawing.SystemColors.Control;
            this.bt_Luu.BorderRadius = 15;
            this.bt_Luu.BorderSize = 0;
            this.bt_Luu.FlatAppearance.BorderSize = 0;
            this.bt_Luu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.ForeColor = System.Drawing.Color.Transparent;
            this.bt_Luu.Location = new System.Drawing.Point(230, 623);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(70, 27);
            this.bt_Luu.TabIndex = 9;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.TextColor = System.Drawing.Color.Transparent;
            this.bt_Luu.UseVisualStyleBackColor = false;
            // 
            // dt_ngayvaolam
            // 
            this.dt_ngayvaolam.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngayvaolam.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngayvaolam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngayvaolam.Location = new System.Drawing.Point(209, 411);
            this.dt_ngayvaolam.Name = "dt_ngayvaolam";
            this.dt_ngayvaolam.Size = new System.Drawing.Size(232, 26);
            this.dt_ngayvaolam.TabIndex = 4;
            // 
            // dt_ngsinh
            // 
            this.dt_ngsinh.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngsinh.CalendarForeColor = System.Drawing.Color.Black;
            this.dt_ngsinh.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngsinh.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngsinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngsinh.Location = new System.Drawing.Point(209, 374);
            this.dt_ngsinh.Name = "dt_ngsinh";
            this.dt_ngsinh.Size = new System.Drawing.Size(232, 26);
            this.dt_ngsinh.TabIndex = 3;
            // 
            // lb_mlnv
            // 
            this.lb_mlnv.AutoSize = true;
            this.lb_mlnv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mlnv.ForeColor = System.Drawing.Color.Black;
            this.lb_mlnv.Location = new System.Drawing.Point(30, 600);
            this.lb_mlnv.Name = "lb_mlnv";
            this.lb_mlnv.Size = new System.Drawing.Size(128, 16);
            this.lb_mlnv.TabIndex = 47;
            this.lb_mlnv.Text = "Mã loại nhân viên:";
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
            this.tb_mlnv.Location = new System.Drawing.Point(209, 583);
            this.tb_mlnv.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mlnv.Multiline = false;
            this.tb_mlnv.Name = "tb_mlnv";
            this.tb_mlnv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_mlnv.PasswordChar = false;
            this.tb_mlnv.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_mlnv.PlaceholderText = "";
            this.tb_mlnv.Size = new System.Drawing.Size(232, 33);
            this.tb_mlnv.TabIndex = 8;
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
            this.tb_Luong.Location = new System.Drawing.Point(209, 542);
            this.tb_Luong.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Luong.Multiline = false;
            this.tb_Luong.Name = "tb_Luong";
            this.tb_Luong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Luong.PasswordChar = false;
            this.tb_Luong.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Luong.PlaceholderText = "";
            this.tb_Luong.Size = new System.Drawing.Size(232, 33);
            this.tb_Luong.TabIndex = 7;
            this.tb_Luong.Texts = "";
            this.tb_Luong.UnderlinedStyle = false;
            // 
            // lb_luong
            // 
            this.lb_luong.AutoSize = true;
            this.lb_luong.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_luong.ForeColor = System.Drawing.Color.Black;
            this.lb_luong.Location = new System.Drawing.Point(30, 559);
            this.lb_luong.Name = "lb_luong";
            this.lb_luong.Size = new System.Drawing.Size(53, 16);
            this.lb_luong.TabIndex = 44;
            this.lb_luong.Text = "Lương:";
            // 
            // lb_Sdt
            // 
            this.lb_Sdt.AutoSize = true;
            this.lb_Sdt.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sdt.ForeColor = System.Drawing.Color.Black;
            this.lb_Sdt.Location = new System.Drawing.Point(30, 471);
            this.lb_Sdt.Name = "lb_Sdt";
            this.lb_Sdt.Size = new System.Drawing.Size(100, 16);
            this.lb_Sdt.TabIndex = 43;
            this.lb_Sdt.Text = "Số điện thoại:";
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
            this.tb_Email.Location = new System.Drawing.Point(209, 495);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Email.Multiline = false;
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Email.PasswordChar = false;
            this.tb_Email.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Email.PlaceholderText = "";
            this.tb_Email.Size = new System.Drawing.Size(232, 33);
            this.tb_Email.TabIndex = 6;
            this.tb_Email.Texts = "";
            this.tb_Email.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Email:";
            // 
            // lb_ngayvaolam
            // 
            this.lb_ngayvaolam.AutoSize = true;
            this.lb_ngayvaolam.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngayvaolam.ForeColor = System.Drawing.Color.Black;
            this.lb_ngayvaolam.Location = new System.Drawing.Point(30, 421);
            this.lb_ngayvaolam.Name = "lb_ngayvaolam";
            this.lb_ngayvaolam.Size = new System.Drawing.Size(102, 16);
            this.lb_ngayvaolam.TabIndex = 40;
            this.lb_ngayvaolam.Text = "Ngày vào làm:";
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaysinh.ForeColor = System.Drawing.Color.Black;
            this.lb_ngaysinh.Location = new System.Drawing.Point(30, 384);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(77, 16);
            this.lb_ngaysinh.TabIndex = 39;
            this.lb_ngaysinh.Text = "Ngày sinh:";
            // 
            // lb_phai
            // 
            this.lb_phai.AutoSize = true;
            this.lb_phai.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phai.ForeColor = System.Drawing.Color.Black;
            this.lb_phai.Location = new System.Drawing.Point(30, 345);
            this.lb_phai.Name = "lb_phai";
            this.lb_phai.Size = new System.Drawing.Size(66, 16);
            this.lb_phai.TabIndex = 38;
            this.lb_phai.Text = "Giới tính:";
            // 
            // lb_tennv
            // 
            this.lb_tennv.AutoSize = true;
            this.lb_tennv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tennv.ForeColor = System.Drawing.Color.Black;
            this.lb_tennv.Location = new System.Drawing.Point(30, 312);
            this.lb_tennv.Name = "lb_tennv";
            this.lb_tennv.Size = new System.Drawing.Size(107, 16);
            this.lb_tennv.TabIndex = 37;
            this.lb_tennv.Text = "Tên nhân viên:";
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
            this.tb_Sdt.Location = new System.Drawing.Point(209, 454);
            this.tb_Sdt.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Sdt.Multiline = false;
            this.tb_Sdt.Name = "tb_Sdt";
            this.tb_Sdt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Sdt.PasswordChar = false;
            this.tb_Sdt.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Sdt.PlaceholderText = "";
            this.tb_Sdt.Size = new System.Drawing.Size(232, 33);
            this.tb_Sdt.TabIndex = 5;
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
            this.tb_TenNv.Location = new System.Drawing.Point(209, 295);
            this.tb_TenNv.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TenNv.Multiline = false;
            this.tb_TenNv.Name = "tb_TenNv";
            this.tb_TenNv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_TenNv.PasswordChar = false;
            this.tb_TenNv.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_TenNv.PlaceholderText = "";
            this.tb_TenNv.Size = new System.Drawing.Size(232, 33);
            this.tb_TenNv.TabIndex = 1;
            this.tb_TenNv.Texts = "";
            this.tb_TenNv.UnderlinedStyle = false;
            // 
            // pb_anh
            // 
            this.pb_anh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb_anh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_anh.ForeColor = System.Drawing.Color.Red;
            this.pb_anh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pb_anh.IconColor = System.Drawing.Color.Red;
            this.pb_anh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pb_anh.IconSize = 185;
            this.pb_anh.Location = new System.Drawing.Point(88, 39);
            this.pb_anh.Name = "pb_anh";
            this.pb_anh.Size = new System.Drawing.Size(330, 185);
            this.pb_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_anh.TabIndex = 31;
            this.pb_anh.TabStop = false;
            // 
            // ThemNv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(486, 660);
            this.Controls.Add(this.gb_themhv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThemNv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới nhân viên";
            this.gb_themhv.ResumeLayout(false);
            this.gb_themhv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_themhv;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private CustomButton bt_xoahet;
        private CustomButton bt_Luu;
        public System.Windows.Forms.DateTimePicker dt_ngayvaolam;
        public System.Windows.Forms.DateTimePicker dt_ngsinh;
        private System.Windows.Forms.Label lb_mlnv;
        private CustomTextBox tb_mlnv;
        private CustomTextBox tb_Luong;
        private System.Windows.Forms.Label lb_luong;
        private System.Windows.Forms.Label lb_Sdt;
        private CustomTextBox tb_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_ngayvaolam;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.Label lb_phai;
        private System.Windows.Forms.Label lb_tennv;
        private CustomTextBox tb_Sdt;
        private CustomTextBox tb_TenNv;
        private FontAwesome.Sharp.IconPictureBox pb_anh;
        private CustomTextBox tb_manv;
        private System.Windows.Forms.Label lb_manv;
    }
}