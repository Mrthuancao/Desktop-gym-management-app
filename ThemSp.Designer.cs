namespace Gym_Management
{
    partial class ThemSp
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
            this.gb_themsp = new System.Windows.Forms.GroupBox();
            this.lb_masp = new System.Windows.Forms.Label();
            this.lb_gianhap = new System.Windows.Forms.Label();
            this.cb_loai = new System.Windows.Forms.ComboBox();
            this.dt_ngnhap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_ngaynhao = new System.Windows.Forms.Label();
            this.lb_loai = new System.Windows.Forms.Label();
            this.lb_tsp = new System.Windows.Forms.Label();
            this.pb_anh = new FontAwesome.Sharp.IconPictureBox();
            this.tb_masp = new Gym_Management.CustomTextBox();
            this.tb_gianhap = new Gym_Management.CustomTextBox();
            this.tb_dongia = new Gym_Management.CustomTextBox();
            this.tb_Sl = new Gym_Management.CustomTextBox();
            this.tb_tensp = new Gym_Management.CustomTextBox();
            this.bt_xoahet = new Gym_Management.CustomButton();
            this.bt_Luu = new Gym_Management.CustomButton();
            this.gb_themsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_themsp
            // 
            this.gb_themsp.BackColor = System.Drawing.Color.Gainsboro;
            this.gb_themsp.Controls.Add(this.tb_masp);
            this.gb_themsp.Controls.Add(this.lb_masp);
            this.gb_themsp.Controls.Add(this.lb_gianhap);
            this.gb_themsp.Controls.Add(this.tb_gianhap);
            this.gb_themsp.Controls.Add(this.cb_loai);
            this.gb_themsp.Controls.Add(this.dt_ngnhap);
            this.gb_themsp.Controls.Add(this.tb_dongia);
            this.gb_themsp.Controls.Add(this.label4);
            this.gb_themsp.Controls.Add(this.label3);
            this.gb_themsp.Controls.Add(this.lb_ngaynhao);
            this.gb_themsp.Controls.Add(this.lb_loai);
            this.gb_themsp.Controls.Add(this.lb_tsp);
            this.gb_themsp.Controls.Add(this.tb_Sl);
            this.gb_themsp.Controls.Add(this.tb_tensp);
            this.gb_themsp.Controls.Add(this.pb_anh);
            this.gb_themsp.Controls.Add(this.bt_xoahet);
            this.gb_themsp.Controls.Add(this.bt_Luu);
            this.gb_themsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_themsp.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_themsp.ForeColor = System.Drawing.Color.Red;
            this.gb_themsp.Location = new System.Drawing.Point(0, 0);
            this.gb_themsp.Name = "gb_themsp";
            this.gb_themsp.Size = new System.Drawing.Size(486, 668);
            this.gb_themsp.TabIndex = 4;
            this.gb_themsp.TabStop = false;
            this.gb_themsp.Text = "THÊM SẢN PHẨM";
            // 
            // lb_masp
            // 
            this.lb_masp.AutoSize = true;
            this.lb_masp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_masp.ForeColor = System.Drawing.Color.Black;
            this.lb_masp.Location = new System.Drawing.Point(39, 262);
            this.lb_masp.Name = "lb_masp";
            this.lb_masp.Size = new System.Drawing.Size(100, 16);
            this.lb_masp.TabIndex = 78;
            this.lb_masp.Text = "Mã sản phẩm:";
            // 
            // lb_gianhap
            // 
            this.lb_gianhap.AutoSize = true;
            this.lb_gianhap.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gianhap.ForeColor = System.Drawing.Color.Black;
            this.lb_gianhap.Location = new System.Drawing.Point(39, 371);
            this.lb_gianhap.Name = "lb_gianhap";
            this.lb_gianhap.Size = new System.Drawing.Size(70, 16);
            this.lb_gianhap.TabIndex = 66;
            this.lb_gianhap.Text = "Giá nhập:";
            // 
            // cb_loai
            // 
            this.cb_loai.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_loai.FormattingEnabled = true;
            this.cb_loai.IntegralHeight = false;
            this.cb_loai.ItemHeight = 18;
            this.cb_loai.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "L4"});
            this.cb_loai.Location = new System.Drawing.Point(219, 584);
            this.cb_loai.Name = "cb_loai";
            this.cb_loai.Size = new System.Drawing.Size(232, 26);
            this.cb_loai.TabIndex = 7;
            // 
            // dt_ngnhap
            // 
            this.dt_ngnhap.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngnhap.CalendarForeColor = System.Drawing.Color.Black;
            this.dt_ngnhap.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngnhap.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngnhap.Location = new System.Drawing.Point(219, 533);
            this.dt_ngnhap.Name = "dt_ngnhap";
            this.dt_ngnhap.Size = new System.Drawing.Size(232, 26);
            this.dt_ngnhap.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 421);
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
            this.label3.Location = new System.Drawing.Point(39, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Số lượng:";
            // 
            // lb_ngaynhao
            // 
            this.lb_ngaynhao.AutoSize = true;
            this.lb_ngaynhao.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaynhao.ForeColor = System.Drawing.Color.Black;
            this.lb_ngaynhao.Location = new System.Drawing.Point(39, 538);
            this.lb_ngaynhao.Name = "lb_ngaynhao";
            this.lb_ngaynhao.Size = new System.Drawing.Size(83, 16);
            this.lb_ngaynhao.TabIndex = 59;
            this.lb_ngaynhao.Text = "Ngày nhập:";
            // 
            // lb_loai
            // 
            this.lb_loai.AutoSize = true;
            this.lb_loai.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loai.ForeColor = System.Drawing.Color.Black;
            this.lb_loai.Location = new System.Drawing.Point(39, 587);
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
            this.lb_tsp.Location = new System.Drawing.Point(39, 323);
            this.lb_tsp.Name = "lb_tsp";
            this.lb_tsp.Size = new System.Drawing.Size(106, 16);
            this.lb_tsp.TabIndex = 57;
            this.lb_tsp.Text = "Tên sản phẩm:";
            // 
            // pb_anh
            // 
            this.pb_anh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb_anh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_anh.ForeColor = System.Drawing.Color.Black;
            this.pb_anh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pb_anh.IconColor = System.Drawing.Color.Black;
            this.pb_anh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pb_anh.IconSize = 185;
            this.pb_anh.Location = new System.Drawing.Point(94, 38);
            this.pb_anh.Name = "pb_anh";
            this.pb_anh.Size = new System.Drawing.Size(330, 185);
            this.pb_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_anh.TabIndex = 52;
            this.pb_anh.TabStop = false;
            // 
            // tb_masp
            // 
            this.tb_masp.BackColor = System.Drawing.SystemColors.Window;
            this.tb_masp.BorderColor = System.Drawing.Color.Black;
            this.tb_masp.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_masp.BorderRadius = 5;
            this.tb_masp.Bordersize = 2;
            this.tb_masp.Enabled = false;
            this.tb_masp.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_masp.ForeColor = System.Drawing.Color.Black;
            this.tb_masp.Location = new System.Drawing.Point(219, 245);
            this.tb_masp.Margin = new System.Windows.Forms.Padding(4);
            this.tb_masp.Multiline = false;
            this.tb_masp.Name = "tb_masp";
            this.tb_masp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_masp.PasswordChar = false;
            this.tb_masp.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_masp.PlaceholderText = "";
            this.tb_masp.ReadOnly1 = false;
            this.tb_masp.Size = new System.Drawing.Size(232, 33);
            this.tb_masp.TabIndex = 1;
            this.tb_masp.Texts = "";
            this.tb_masp.UnderlinedStyle = false;
            // 
            // tb_gianhap
            // 
            this.tb_gianhap.BackColor = System.Drawing.SystemColors.Window;
            this.tb_gianhap.BorderColor = System.Drawing.Color.Black;
            this.tb_gianhap.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_gianhap.BorderRadius = 5;
            this.tb_gianhap.Bordersize = 2;
            this.tb_gianhap.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gianhap.ForeColor = System.Drawing.Color.Black;
            this.tb_gianhap.Location = new System.Drawing.Point(219, 359);
            this.tb_gianhap.Margin = new System.Windows.Forms.Padding(4);
            this.tb_gianhap.Multiline = false;
            this.tb_gianhap.Name = "tb_gianhap";
            this.tb_gianhap.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_gianhap.PasswordChar = false;
            this.tb_gianhap.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_gianhap.PlaceholderText = "";
            this.tb_gianhap.ReadOnly1 = false;
            this.tb_gianhap.Size = new System.Drawing.Size(232, 33);
            this.tb_gianhap.TabIndex = 3;
            this.tb_gianhap.Texts = "";
            this.tb_gianhap.UnderlinedStyle = false;
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
            this.tb_dongia.Location = new System.Drawing.Point(219, 410);
            this.tb_dongia.Margin = new System.Windows.Forms.Padding(4);
            this.tb_dongia.Multiline = false;
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_dongia.PasswordChar = false;
            this.tb_dongia.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_dongia.PlaceholderText = "";
            this.tb_dongia.ReadOnly1 = false;
            this.tb_dongia.Size = new System.Drawing.Size(232, 33);
            this.tb_dongia.TabIndex = 4;
            this.tb_dongia.Texts = "";
            this.tb_dongia.UnderlinedStyle = false;
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
            this.tb_Sl.Location = new System.Drawing.Point(219, 468);
            this.tb_Sl.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Sl.Multiline = false;
            this.tb_Sl.Name = "tb_Sl";
            this.tb_Sl.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Sl.PasswordChar = false;
            this.tb_Sl.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Sl.PlaceholderText = "";
            this.tb_Sl.ReadOnly1 = false;
            this.tb_Sl.Size = new System.Drawing.Size(232, 33);
            this.tb_Sl.TabIndex = 5;
            this.tb_Sl.Texts = "";
            this.tb_Sl.UnderlinedStyle = false;
            // 
            // tb_tensp
            // 
            this.tb_tensp.BackColor = System.Drawing.SystemColors.Window;
            this.tb_tensp.BorderColor = System.Drawing.Color.Black;
            this.tb_tensp.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_tensp.BorderRadius = 5;
            this.tb_tensp.Bordersize = 2;
            this.tb_tensp.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tensp.ForeColor = System.Drawing.Color.Black;
            this.tb_tensp.Location = new System.Drawing.Point(219, 306);
            this.tb_tensp.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tensp.Multiline = false;
            this.tb_tensp.Name = "tb_tensp";
            this.tb_tensp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_tensp.PasswordChar = false;
            this.tb_tensp.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_tensp.PlaceholderText = "";
            this.tb_tensp.ReadOnly1 = false;
            this.tb_tensp.Size = new System.Drawing.Size(232, 33);
            this.tb_tensp.TabIndex = 2;
            this.tb_tensp.Texts = "";
            this.tb_tensp.UnderlinedStyle = false;
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
            this.bt_xoahet.Location = new System.Drawing.Point(354, 626);
            this.bt_xoahet.Name = "bt_xoahet";
            this.bt_xoahet.Size = new System.Drawing.Size(70, 27);
            this.bt_xoahet.TabIndex = 9;
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
            this.bt_Luu.Location = new System.Drawing.Point(245, 626);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(70, 27);
            this.bt_Luu.TabIndex = 8;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.TextColor = System.Drawing.Color.Transparent;
            this.bt_Luu.UseVisualStyleBackColor = false;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // ThemSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 668);
            this.Controls.Add(this.gb_themsp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThemSp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sản phẩm";
            this.gb_themsp.ResumeLayout(false);
            this.gb_themsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_themsp;
        private System.Windows.Forms.ComboBox cb_loai;
        public System.Windows.Forms.DateTimePicker dt_ngnhap;
        private CustomTextBox tb_dongia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_ngaynhao;
        private System.Windows.Forms.Label lb_loai;
        private System.Windows.Forms.Label lb_tsp;
        private CustomTextBox tb_Sl;
        private FontAwesome.Sharp.IconPictureBox pb_anh;
        private CustomButton bt_xoahet;
        private CustomButton bt_Luu;
        private System.Windows.Forms.Label lb_gianhap;
        private CustomTextBox tb_gianhap;
        private CustomTextBox tb_masp;
        private System.Windows.Forms.Label lb_masp;
        private CustomTextBox tb_tensp;
    }
}