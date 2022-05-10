namespace Gym_Management
{
    partial class SuaTb
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
            this.gb_suatb = new System.Windows.Forms.GroupBox();
            this.dt_ngnhap = new System.Windows.Forms.DateTimePicker();
            this.lb_ngaynhao = new System.Windows.Forms.Label();
            this.cb_tinhtrang = new System.Windows.Forms.ComboBox();
            this.lb_tinhtrang = new System.Windows.Forms.Label();
            this.cb_loai = new System.Windows.Forms.ComboBox();
            this.tb_hang = new Gym_Management.CustomTextBox();
            this.lb_hang = new System.Windows.Forms.Label();
            this.tb_dongia = new Gym_Management.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_loai = new System.Windows.Forms.Label();
            this.lb_tsp = new System.Windows.Forms.Label();
            this.tb_Sl = new Gym_Management.CustomTextBox();
            this.tb_tentb = new Gym_Management.CustomTextBox();
            this.pb_anh = new FontAwesome.Sharp.IconPictureBox();
            this.bt_xoahet = new Gym_Management.CustomButton();
            this.bt_Luu = new Gym_Management.CustomButton();
            this.gb_suatb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_suatb
            // 
            this.gb_suatb.BackColor = System.Drawing.Color.Gainsboro;
            this.gb_suatb.Controls.Add(this.dt_ngnhap);
            this.gb_suatb.Controls.Add(this.lb_ngaynhao);
            this.gb_suatb.Controls.Add(this.cb_tinhtrang);
            this.gb_suatb.Controls.Add(this.lb_tinhtrang);
            this.gb_suatb.Controls.Add(this.cb_loai);
            this.gb_suatb.Controls.Add(this.tb_hang);
            this.gb_suatb.Controls.Add(this.lb_hang);
            this.gb_suatb.Controls.Add(this.tb_dongia);
            this.gb_suatb.Controls.Add(this.label4);
            this.gb_suatb.Controls.Add(this.label3);
            this.gb_suatb.Controls.Add(this.lb_loai);
            this.gb_suatb.Controls.Add(this.lb_tsp);
            this.gb_suatb.Controls.Add(this.tb_Sl);
            this.gb_suatb.Controls.Add(this.tb_tentb);
            this.gb_suatb.Controls.Add(this.pb_anh);
            this.gb_suatb.Controls.Add(this.bt_xoahet);
            this.gb_suatb.Controls.Add(this.bt_Luu);
            this.gb_suatb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_suatb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_suatb.ForeColor = System.Drawing.Color.Red;
            this.gb_suatb.Location = new System.Drawing.Point(0, 0);
            this.gb_suatb.Name = "gb_suatb";
            this.gb_suatb.Size = new System.Drawing.Size(433, 613);
            this.gb_suatb.TabIndex = 6;
            this.gb_suatb.TabStop = false;
            this.gb_suatb.Text = "SỬA THIẾT BỊ";
            // 
            // dt_ngnhap
            // 
            this.dt_ngnhap.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngnhap.CalendarForeColor = System.Drawing.Color.Black;
            this.dt_ngnhap.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngnhap.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngnhap.Location = new System.Drawing.Point(149, 496);
            this.dt_ngnhap.Name = "dt_ngnhap";
            this.dt_ngnhap.Size = new System.Drawing.Size(232, 26);
            this.dt_ngnhap.TabIndex = 73;
            // 
            // lb_ngaynhao
            // 
            this.lb_ngaynhao.AutoSize = true;
            this.lb_ngaynhao.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaynhao.ForeColor = System.Drawing.Color.Black;
            this.lb_ngaynhao.Location = new System.Drawing.Point(36, 504);
            this.lb_ngaynhao.Name = "lb_ngaynhao";
            this.lb_ngaynhao.Size = new System.Drawing.Size(83, 16);
            this.lb_ngaynhao.TabIndex = 72;
            this.lb_ngaynhao.Text = "Ngày nhập:";
            // 
            // cb_tinhtrang
            // 
            this.cb_tinhtrang.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_tinhtrang.FormattingEnabled = true;
            this.cb_tinhtrang.IntegralHeight = false;
            this.cb_tinhtrang.ItemHeight = 18;
            this.cb_tinhtrang.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.cb_tinhtrang.Location = new System.Drawing.Point(149, 545);
            this.cb_tinhtrang.Name = "cb_tinhtrang";
            this.cb_tinhtrang.Size = new System.Drawing.Size(232, 26);
            this.cb_tinhtrang.TabIndex = 71;
            // 
            // lb_tinhtrang
            // 
            this.lb_tinhtrang.AutoSize = true;
            this.lb_tinhtrang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tinhtrang.ForeColor = System.Drawing.Color.Black;
            this.lb_tinhtrang.Location = new System.Drawing.Point(36, 549);
            this.lb_tinhtrang.Name = "lb_tinhtrang";
            this.lb_tinhtrang.Size = new System.Drawing.Size(81, 16);
            this.lb_tinhtrang.TabIndex = 70;
            this.lb_tinhtrang.Text = "Tình trạng:";
            // 
            // cb_loai
            // 
            this.cb_loai.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_loai.FormattingEnabled = true;
            this.cb_loai.IntegralHeight = false;
            this.cb_loai.ItemHeight = 18;
            this.cb_loai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_loai.Location = new System.Drawing.Point(149, 288);
            this.cb_loai.Name = "cb_loai";
            this.cb_loai.Size = new System.Drawing.Size(232, 26);
            this.cb_loai.TabIndex = 69;
            // 
            // tb_hang
            // 
            this.tb_hang.BackColor = System.Drawing.SystemColors.Window;
            this.tb_hang.BorderColor = System.Drawing.Color.Black;
            this.tb_hang.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_hang.BorderRadius = 5;
            this.tb_hang.Bordersize = 2;
            this.tb_hang.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hang.ForeColor = System.Drawing.Color.Black;
            this.tb_hang.Location = new System.Drawing.Point(149, 439);
            this.tb_hang.Margin = new System.Windows.Forms.Padding(4);
            this.tb_hang.Multiline = false;
            this.tb_hang.Name = "tb_hang";
            this.tb_hang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_hang.PasswordChar = false;
            this.tb_hang.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_hang.PlaceholderText = "";
            this.tb_hang.Size = new System.Drawing.Size(232, 33);
            this.tb_hang.TabIndex = 68;
            this.tb_hang.Texts = "";
            this.tb_hang.UnderlinedStyle = false;
            // 
            // lb_hang
            // 
            this.lb_hang.AutoSize = true;
            this.lb_hang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hang.ForeColor = System.Drawing.Color.Black;
            this.lb_hang.Location = new System.Drawing.Point(36, 451);
            this.lb_hang.Name = "lb_hang";
            this.lb_hang.Size = new System.Drawing.Size(46, 16);
            this.lb_hang.TabIndex = 64;
            this.lb_hang.Text = "Hãng:";
            // 
            // tb_dongia
            // 
            this.tb_dongia.BackColor = System.Drawing.SystemColors.Window;
            this.tb_dongia.BorderColor = System.Drawing.Color.Black;
            this.tb_dongia.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_dongia.BorderRadius = 5;
            this.tb_dongia.Bordersize = 2;
            this.tb_dongia.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dongia.ForeColor = System.Drawing.Color.Black;
            this.tb_dongia.Location = new System.Drawing.Point(149, 385);
            this.tb_dongia.Margin = new System.Windows.Forms.Padding(4);
            this.tb_dongia.Multiline = false;
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_dongia.PasswordChar = false;
            this.tb_dongia.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_dongia.PlaceholderText = "";
            this.tb_dongia.Size = new System.Drawing.Size(232, 33);
            this.tb_dongia.TabIndex = 63;
            this.tb_dongia.Texts = "";
            this.tb_dongia.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Số lượng:";
            // 
            // lb_loai
            // 
            this.lb_loai.AutoSize = true;
            this.lb_loai.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loai.ForeColor = System.Drawing.Color.Black;
            this.lb_loai.Location = new System.Drawing.Point(36, 292);
            this.lb_loai.Name = "lb_loai";
            this.lb_loai.Size = new System.Drawing.Size(39, 16);
            this.lb_loai.TabIndex = 58;
            this.lb_loai.Text = "Loại:";
            // 
            // lb_tsp
            // 
            this.lb_tsp.AutoSize = true;
            this.lb_tsp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tsp.ForeColor = System.Drawing.Color.Black;
            this.lb_tsp.Location = new System.Drawing.Point(36, 242);
            this.lb_tsp.Name = "lb_tsp";
            this.lb_tsp.Size = new System.Drawing.Size(90, 16);
            this.lb_tsp.TabIndex = 57;
            this.lb_tsp.Text = "Tên thiết bị:";
            // 
            // tb_Sl
            // 
            this.tb_Sl.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Sl.BorderColor = System.Drawing.Color.Black;
            this.tb_Sl.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_Sl.BorderRadius = 5;
            this.tb_Sl.Bordersize = 2;
            this.tb_Sl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sl.ForeColor = System.Drawing.Color.Black;
            this.tb_Sl.Location = new System.Drawing.Point(149, 336);
            this.tb_Sl.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Sl.Multiline = false;
            this.tb_Sl.Name = "tb_Sl";
            this.tb_Sl.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Sl.PasswordChar = false;
            this.tb_Sl.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Sl.PlaceholderText = "";
            this.tb_Sl.Size = new System.Drawing.Size(232, 33);
            this.tb_Sl.TabIndex = 56;
            this.tb_Sl.Texts = "";
            this.tb_Sl.UnderlinedStyle = false;
            // 
            // tb_tentb
            // 
            this.tb_tentb.BackColor = System.Drawing.SystemColors.Window;
            this.tb_tentb.BorderColor = System.Drawing.Color.Black;
            this.tb_tentb.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_tentb.BorderRadius = 5;
            this.tb_tentb.Bordersize = 2;
            this.tb_tentb.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tentb.ForeColor = System.Drawing.Color.Black;
            this.tb_tentb.Location = new System.Drawing.Point(149, 230);
            this.tb_tentb.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tentb.Multiline = false;
            this.tb_tentb.Name = "tb_tentb";
            this.tb_tentb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_tentb.PasswordChar = false;
            this.tb_tentb.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_tentb.PlaceholderText = "";
            this.tb_tentb.Size = new System.Drawing.Size(232, 33);
            this.tb_tentb.TabIndex = 53;
            this.tb_tentb.Texts = "";
            this.tb_tentb.UnderlinedStyle = false;
            // 
            // pb_anh
            // 
            this.pb_anh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb_anh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_anh.ForeColor = System.Drawing.Color.Red;
            this.pb_anh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pb_anh.IconColor = System.Drawing.Color.Red;
            this.pb_anh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pb_anh.IconSize = 176;
            this.pb_anh.Location = new System.Drawing.Point(94, 38);
            this.pb_anh.Name = "pb_anh";
            this.pb_anh.Size = new System.Drawing.Size(269, 176);
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
            this.bt_xoahet.Location = new System.Drawing.Point(275, 577);
            this.bt_xoahet.Name = "bt_xoahet";
            this.bt_xoahet.Size = new System.Drawing.Size(70, 27);
            this.bt_xoahet.TabIndex = 51;
            this.bt_xoahet.Text = "Xóa hết";
            this.bt_xoahet.TextColor = System.Drawing.Color.Transparent;
            this.bt_xoahet.UseVisualStyleBackColor = false;
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
            this.bt_Luu.Location = new System.Drawing.Point(167, 577);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(70, 27);
            this.bt_Luu.TabIndex = 50;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.TextColor = System.Drawing.Color.Transparent;
            this.bt_Luu.UseVisualStyleBackColor = false;
            // 
            // SuaTb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 613);
            this.Controls.Add(this.gb_suatb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SuaTb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thiết bị";
            this.gb_suatb.ResumeLayout(false);
            this.gb_suatb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_suatb;
        public System.Windows.Forms.DateTimePicker dt_ngnhap;
        private System.Windows.Forms.Label lb_ngaynhao;
        private System.Windows.Forms.ComboBox cb_tinhtrang;
        private System.Windows.Forms.Label lb_tinhtrang;
        private System.Windows.Forms.ComboBox cb_loai;
        private CustomTextBox tb_hang;
        private System.Windows.Forms.Label lb_hang;
        private CustomTextBox tb_dongia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_loai;
        private System.Windows.Forms.Label lb_tsp;
        private CustomTextBox tb_Sl;
        private CustomTextBox tb_tentb;
        private FontAwesome.Sharp.IconPictureBox pb_anh;
        private CustomButton bt_xoahet;
        private CustomButton bt_Luu;
    }
}