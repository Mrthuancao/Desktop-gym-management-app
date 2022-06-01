namespace Gym_Management
{
    partial class ThemHv
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
            this.tb_mahv = new Gym_Management.CustomTextBox();
            this.lb_mahv = new System.Windows.Forms.Label();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.dt_ngaydk = new System.Windows.Forms.DateTimePicker();
            this.dt_ngsinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_phai = new System.Windows.Forms.Label();
            this.lb_tenhv = new System.Windows.Forms.Label();
            this.tb_Sdt = new Gym_Management.CustomTextBox();
            this.tb_TenHV = new Gym_Management.CustomTextBox();
            this.pb_anh = new FontAwesome.Sharp.IconPictureBox();
            this.bt_xoahet = new Gym_Management.CustomButton();
            this.bt_Luu = new Gym_Management.CustomButton();
            this.gb_themhv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_themhv
            // 
            this.gb_themhv.BackColor = System.Drawing.Color.Gainsboro;
            this.gb_themhv.Controls.Add(this.tb_mahv);
            this.gb_themhv.Controls.Add(this.lb_mahv);
            this.gb_themhv.Controls.Add(this.cb_gioitinh);
            this.gb_themhv.Controls.Add(this.dt_ngaydk);
            this.gb_themhv.Controls.Add(this.dt_ngsinh);
            this.gb_themhv.Controls.Add(this.label1);
            this.gb_themhv.Controls.Add(this.label4);
            this.gb_themhv.Controls.Add(this.label3);
            this.gb_themhv.Controls.Add(this.lb_phai);
            this.gb_themhv.Controls.Add(this.lb_tenhv);
            this.gb_themhv.Controls.Add(this.tb_Sdt);
            this.gb_themhv.Controls.Add(this.tb_TenHV);
            this.gb_themhv.Controls.Add(this.pb_anh);
            this.gb_themhv.Controls.Add(this.bt_xoahet);
            this.gb_themhv.Controls.Add(this.bt_Luu);
            this.gb_themhv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_themhv.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_themhv.ForeColor = System.Drawing.Color.Red;
            this.gb_themhv.Location = new System.Drawing.Point(0, 0);
            this.gb_themhv.Margin = new System.Windows.Forms.Padding(4);
            this.gb_themhv.Name = "gb_themhv";
            this.gb_themhv.Size = new System.Drawing.Size(486, 595);
            this.gb_themhv.TabIndex = 3;
            this.gb_themhv.TabStop = false;
            this.gb_themhv.Text = "THÊM HỘI VIÊN";
            // 
            // tb_mahv
            // 
            this.tb_mahv.BackColor = System.Drawing.SystemColors.Window;
            this.tb_mahv.BorderColor = System.Drawing.Color.Black;
            this.tb_mahv.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_mahv.BorderRadius = 5;
            this.tb_mahv.Bordersize = 2;
            this.tb_mahv.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mahv.ForeColor = System.Drawing.Color.Black;
            this.tb_mahv.Location = new System.Drawing.Point(199, 247);
            this.tb_mahv.Margin = new System.Windows.Forms.Padding(5);
            this.tb_mahv.Multiline = false;
            this.tb_mahv.Name = "tb_mahv";
            this.tb_mahv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_mahv.PasswordChar = false;
            this.tb_mahv.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_mahv.PlaceholderText = "";
            this.tb_mahv.ReadOnly1 = false;
            this.tb_mahv.Size = new System.Drawing.Size(232, 33);
            this.tb_mahv.TabIndex = 1;
            this.tb_mahv.Texts = "";
            this.tb_mahv.UnderlinedStyle = false;
            // 
            // lb_mahv
            // 
            this.lb_mahv.AutoSize = true;
            this.lb_mahv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mahv.ForeColor = System.Drawing.Color.Black;
            this.lb_mahv.Location = new System.Drawing.Point(38, 264);
            this.lb_mahv.Name = "lb_mahv";
            this.lb_mahv.Size = new System.Drawing.Size(88, 16);
            this.lb_mahv.TabIndex = 75;
            this.lb_mahv.Text = "Mã hội viên:";
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
            this.cb_gioitinh.Location = new System.Drawing.Point(199, 353);
            this.cb_gioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(232, 26);
            this.cb_gioitinh.TabIndex = 3;
            // 
            // dt_ngaydk
            // 
            this.dt_ngaydk.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngaydk.CalendarForeColor = System.Drawing.Color.Black;
            this.dt_ngaydk.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngaydk.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngaydk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngaydk.Location = new System.Drawing.Point(199, 458);
            this.dt_ngaydk.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngaydk.Name = "dt_ngaydk";
            this.dt_ngaydk.Size = new System.Drawing.Size(232, 26);
            this.dt_ngaydk.TabIndex = 7;
            // 
            // dt_ngsinh
            // 
            this.dt_ngsinh.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngsinh.CalendarForeColor = System.Drawing.Color.Black;
            this.dt_ngsinh.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngsinh.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngsinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngsinh.Location = new System.Drawing.Point(199, 407);
            this.dt_ngsinh.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngsinh.Name = "dt_ngsinh";
            this.dt_ngsinh.Size = new System.Drawing.Size(232, 26);
            this.dt_ngsinh.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Ngày đăng kí:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Ngày sinh:";
            // 
            // lb_phai
            // 
            this.lb_phai.AutoSize = true;
            this.lb_phai.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phai.ForeColor = System.Drawing.Color.Black;
            this.lb_phai.Location = new System.Drawing.Point(38, 363);
            this.lb_phai.Name = "lb_phai";
            this.lb_phai.Size = new System.Drawing.Size(66, 16);
            this.lb_phai.TabIndex = 59;
            this.lb_phai.Text = "Giới tính:";
            // 
            // lb_tenhv
            // 
            this.lb_tenhv.AutoSize = true;
            this.lb_tenhv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenhv.ForeColor = System.Drawing.Color.Black;
            this.lb_tenhv.Location = new System.Drawing.Point(38, 316);
            this.lb_tenhv.Name = "lb_tenhv";
            this.lb_tenhv.Size = new System.Drawing.Size(94, 16);
            this.lb_tenhv.TabIndex = 58;
            this.lb_tenhv.Text = "Tên hội viên:";
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
            this.tb_Sdt.Location = new System.Drawing.Point(199, 505);
            this.tb_Sdt.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Sdt.Multiline = false;
            this.tb_Sdt.Name = "tb_Sdt";
            this.tb_Sdt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Sdt.PasswordChar = false;
            this.tb_Sdt.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Sdt.PlaceholderText = "";
            this.tb_Sdt.ReadOnly1 = false;
            this.tb_Sdt.Size = new System.Drawing.Size(232, 33);
            this.tb_Sdt.TabIndex = 8;
            this.tb_Sdt.Texts = "";
            this.tb_Sdt.UnderlinedStyle = false;
            // 
            // tb_TenHV
            // 
            this.tb_TenHV.BackColor = System.Drawing.SystemColors.Window;
            this.tb_TenHV.BorderColor = System.Drawing.Color.Black;
            this.tb_TenHV.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_TenHV.BorderRadius = 5;
            this.tb_TenHV.Bordersize = 2;
            this.tb_TenHV.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenHV.ForeColor = System.Drawing.Color.Black;
            this.tb_TenHV.Location = new System.Drawing.Point(199, 299);
            this.tb_TenHV.Margin = new System.Windows.Forms.Padding(5);
            this.tb_TenHV.Multiline = false;
            this.tb_TenHV.Name = "tb_TenHV";
            this.tb_TenHV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_TenHV.PasswordChar = false;
            this.tb_TenHV.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_TenHV.PlaceholderText = "";
            this.tb_TenHV.ReadOnly1 = false;
            this.tb_TenHV.Size = new System.Drawing.Size(232, 33);
            this.tb_TenHV.TabIndex = 2;
            this.tb_TenHV.Texts = "";
            this.tb_TenHV.UnderlinedStyle = false;
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
            this.pb_anh.Margin = new System.Windows.Forms.Padding(4);
            this.pb_anh.Name = "pb_anh";
            this.pb_anh.Size = new System.Drawing.Size(330, 185);
            this.pb_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_anh.TabIndex = 52;
            this.pb_anh.TabStop = false;
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
            this.bt_xoahet.Location = new System.Drawing.Point(343, 559);
            this.bt_xoahet.Name = "bt_xoahet";
            this.bt_xoahet.Size = new System.Drawing.Size(70, 27);
            this.bt_xoahet.TabIndex = 11;
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
            this.bt_Luu.Location = new System.Drawing.Point(209, 559);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(70, 27);
            this.bt_Luu.TabIndex = 10;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.TextColor = System.Drawing.Color.Transparent;
            this.bt_Luu.UseVisualStyleBackColor = false;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click_1);
            // 
            // ThemHv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(486, 595);
            this.Controls.Add(this.gb_themhv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemHv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới hội viên";
            this.gb_themhv.ResumeLayout(false);
            this.gb_themhv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_themhv;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        public System.Windows.Forms.DateTimePicker dt_ngaydk;
        public System.Windows.Forms.DateTimePicker dt_ngsinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_phai;
        private System.Windows.Forms.Label lb_tenhv;
        private CustomTextBox tb_Sdt;
        private CustomTextBox tb_TenHV;
        private FontAwesome.Sharp.IconPictureBox pb_anh;
        private CustomButton bt_xoahet;
        private CustomButton bt_Luu;
        private CustomTextBox tb_mahv;
        private System.Windows.Forms.Label lb_mahv;
    }
}