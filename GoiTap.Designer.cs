﻿namespace Gym_Management
{
    partial class GoiTap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_goitap = new System.Windows.Forms.GroupBox();
            this.gb_DkGoiTap = new System.Windows.Forms.GroupBox();
            this.lb_mhv = new System.Windows.Forms.Label();
            this.cb_tengoi = new System.Windows.Forms.ComboBox();
            this.dt_ngHetHan = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_ngdk = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Dk = new Gym_Management.CustomButton();
            this.tb_MaHV = new Gym_Management.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_loc = new Gym_Management.CustomButton();
            this.cb_goitap = new System.Windows.Forms.ComboBox();
            this.dtg_GT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.helo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdssd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdcs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_maPt = new Gym_Management.CustomTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_giatien = new Gym_Management.CustomTextBox();
            this.gb_goitap.SuspendLayout();
            this.gb_DkGoiTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_GT)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_goitap
            // 
            this.gb_goitap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_goitap.Controls.Add(this.gb_DkGoiTap);
            this.gb_goitap.Controls.Add(this.label5);
            this.gb_goitap.Controls.Add(this.cb_loc);
            this.gb_goitap.Controls.Add(this.cb_goitap);
            this.gb_goitap.Controls.Add(this.dtg_GT);
            this.gb_goitap.Controls.Add(this.label1);
            this.gb_goitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_goitap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.gb_goitap.Location = new System.Drawing.Point(0, 0);
            this.gb_goitap.Name = "gb_goitap";
            this.gb_goitap.Size = new System.Drawing.Size(1055, 719);
            this.gb_goitap.TabIndex = 0;
            this.gb_goitap.TabStop = false;
            this.gb_goitap.Text = "Gói tập";
            // 
            // gb_DkGoiTap
            // 
            this.gb_DkGoiTap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_DkGoiTap.Controls.Add(this.tb_giatien);
            this.gb_DkGoiTap.Controls.Add(this.label7);
            this.gb_DkGoiTap.Controls.Add(this.label6);
            this.gb_DkGoiTap.Controls.Add(this.lb_mhv);
            this.gb_DkGoiTap.Controls.Add(this.cb_tengoi);
            this.gb_DkGoiTap.Controls.Add(this.dt_ngHetHan);
            this.gb_DkGoiTap.Controls.Add(this.label4);
            this.gb_DkGoiTap.Controls.Add(this.dt_ngdk);
            this.gb_DkGoiTap.Controls.Add(this.label3);
            this.gb_DkGoiTap.Controls.Add(this.label2);
            this.gb_DkGoiTap.Controls.Add(this.bt_Dk);
            this.gb_DkGoiTap.Controls.Add(this.tb_MaHV);
            this.gb_DkGoiTap.Controls.Add(this.tb_maPt);
            this.gb_DkGoiTap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_DkGoiTap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.gb_DkGoiTap.Location = new System.Drawing.Point(579, 22);
            this.gb_DkGoiTap.Name = "gb_DkGoiTap";
            this.gb_DkGoiTap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gb_DkGoiTap.Size = new System.Drawing.Size(440, 341);
            this.gb_DkGoiTap.TabIndex = 68;
            this.gb_DkGoiTap.TabStop = false;
            this.gb_DkGoiTap.Text = "Đăng kí gói tập";
            // 
            // lb_mhv
            // 
            this.lb_mhv.AutoSize = true;
            this.lb_mhv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mhv.Location = new System.Drawing.Point(11, 60);
            this.lb_mhv.Name = "lb_mhv";
            this.lb_mhv.Size = new System.Drawing.Size(88, 16);
            this.lb_mhv.TabIndex = 18;
            this.lb_mhv.Text = "Mã hội viên:";
            // 
            // cb_tengoi
            // 
            this.cb_tengoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_tengoi.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_tengoi.FormattingEnabled = true;
            this.cb_tengoi.IntegralHeight = false;
            this.cb_tengoi.ItemHeight = 18;
            this.cb_tengoi.Items.AddRange(new object[] {
            "Gói 1 tuần",
            "Gói 1 tháng",
            "Gói 2 tháng"});
            this.cb_tengoi.Location = new System.Drawing.Point(184, 92);
            this.cb_tengoi.Name = "cb_tengoi";
            this.cb_tengoi.Size = new System.Drawing.Size(232, 26);
            this.cb_tengoi.TabIndex = 67;
            // 
            // dt_ngHetHan
            // 
            this.dt_ngHetHan.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngHetHan.CalendarForeColor = System.Drawing.Color.Black;
            this.dt_ngHetHan.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngHetHan.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngHetHan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngHetHan.Location = new System.Drawing.Point(184, 169);
            this.dt_ngHetHan.Name = "dt_ngHetHan";
            this.dt_ngHetHan.Size = new System.Drawing.Size(232, 26);
            this.dt_ngHetHan.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Tên gói:";
            // 
            // dt_ngdk
            // 
            this.dt_ngdk.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngdk.CalendarForeColor = System.Drawing.Color.Black;
            this.dt_ngdk.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngdk.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngdk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngdk.Location = new System.Drawing.Point(184, 134);
            this.dt_ngdk.Name = "dt_ngdk";
            this.dt_ngdk.Size = new System.Drawing.Size(232, 26);
            this.dt_ngdk.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "Ngày đăng kí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ngày hết hạn:";
            // 
            // bt_Dk
            // 
            this.bt_Dk.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_Dk.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.bt_Dk.BorderColor = System.Drawing.SystemColors.Control;
            this.bt_Dk.BorderRadius = 15;
            this.bt_Dk.BorderSize = 0;
            this.bt_Dk.FlatAppearance.BorderSize = 0;
            this.bt_Dk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Dk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_Dk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Dk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Dk.ForeColor = System.Drawing.Color.Transparent;
            this.bt_Dk.Location = new System.Drawing.Point(167, 292);
            this.bt_Dk.Name = "bt_Dk";
            this.bt_Dk.Size = new System.Drawing.Size(169, 34);
            this.bt_Dk.TabIndex = 27;
            this.bt_Dk.Text = "Đăng kí";
            this.bt_Dk.TextColor = System.Drawing.Color.Transparent;
            this.bt_Dk.UseVisualStyleBackColor = false;
            // 
            // tb_MaHV
            // 
            this.tb_MaHV.BackColor = System.Drawing.SystemColors.Window;
            this.tb_MaHV.BorderColor = System.Drawing.Color.Black;
            this.tb_MaHV.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_MaHV.BorderRadius = 5;
            this.tb_MaHV.Bordersize = 2;
            this.tb_MaHV.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaHV.ForeColor = System.Drawing.Color.Black;
            this.tb_MaHV.Location = new System.Drawing.Point(184, 43);
            this.tb_MaHV.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MaHV.Multiline = false;
            this.tb_MaHV.Name = "tb_MaHV";
            this.tb_MaHV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_MaHV.PasswordChar = false;
            this.tb_MaHV.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_MaHV.PlaceholderText = "";
            this.tb_MaHV.ReadOnly1 = false;
            this.tb_MaHV.Size = new System.Drawing.Size(232, 33);
            this.tb_MaHV.TabIndex = 20;
            this.tb_MaHV.Texts = "";
            this.tb_MaHV.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(141, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 28);
            this.label5.TabIndex = 66;
            this.label5.Text = "Check gói tập";
            // 
            // cb_loc
            // 
            this.cb_loc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_loc.BackColor = System.Drawing.Color.DarkOrange;
            this.cb_loc.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.cb_loc.BorderColor = System.Drawing.SystemColors.Control;
            this.cb_loc.BorderRadius = 15;
            this.cb_loc.BorderSize = 0;
            this.cb_loc.FlatAppearance.BorderSize = 0;
            this.cb_loc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cb_loc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cb_loc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_loc.ForeColor = System.Drawing.Color.Transparent;
            this.cb_loc.Location = new System.Drawing.Point(146, 146);
            this.cb_loc.Name = "cb_loc";
            this.cb_loc.Size = new System.Drawing.Size(169, 34);
            this.cb_loc.TabIndex = 28;
            this.cb_loc.Text = "Lọc";
            this.cb_loc.TextColor = System.Drawing.Color.Transparent;
            this.cb_loc.UseVisualStyleBackColor = false;
            // 
            // cb_goitap
            // 
            this.cb_goitap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_goitap.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_goitap.FormattingEnabled = true;
            this.cb_goitap.IntegralHeight = false;
            this.cb_goitap.ItemHeight = 18;
            this.cb_goitap.Items.AddRange(new object[] {
            "Gói 1 tuần",
            "Gói 1 tháng",
            "Gói 2 tháng"});
            this.cb_goitap.Location = new System.Drawing.Point(146, 81);
            this.cb_goitap.Name = "cb_goitap";
            this.cb_goitap.Size = new System.Drawing.Size(232, 26);
            this.cb_goitap.TabIndex = 25;
            // 
            // dtg_GT
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtg_GT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_GT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_GT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtg_GT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_GT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_GT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_GT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.helo,
            this.wew,
            this.dsd,
            this.sdssd,
            this.hwd,
            this.cdcs});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_GT.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_GT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_GT.EnableHeadersVisualStyles = false;
            this.dtg_GT.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_GT.Location = new System.Drawing.Point(3, 369);
            this.dtg_GT.Name = "dtg_GT";
            this.dtg_GT.Size = new System.Drawing.Size(1049, 347);
            this.dtg_GT.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Gói tập:";
            // 
            // helo
            // 
            this.helo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.helo.HeaderText = "Mã hội viên";
            this.helo.Name = "helo";
            // 
            // wew
            // 
            this.wew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wew.HeaderText = "Tên hội viên";
            this.wew.Name = "wew";
            // 
            // dsd
            // 
            this.dsd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dsd.HeaderText = "Giá gói tập";
            this.dsd.Name = "dsd";
            // 
            // sdssd
            // 
            this.sdssd.HeaderText = "Ngày hết hạn";
            this.sdssd.Name = "sdssd";
            // 
            // hwd
            // 
            this.hwd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hwd.HeaderText = "Mã PT";
            this.hwd.Name = "hwd";
            // 
            // cdcs
            // 
            this.cdcs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdcs.HeaderText = "Giá tiền";
            this.cdcs.Name = "cdcs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Mã Pt(Nếu có):";
            // 
            // tb_maPt
            // 
            this.tb_maPt.BackColor = System.Drawing.SystemColors.Window;
            this.tb_maPt.BorderColor = System.Drawing.Color.Black;
            this.tb_maPt.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_maPt.BorderRadius = 5;
            this.tb_maPt.Bordersize = 2;
            this.tb_maPt.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_maPt.ForeColor = System.Drawing.Color.Black;
            this.tb_maPt.Location = new System.Drawing.Point(184, 202);
            this.tb_maPt.Margin = new System.Windows.Forms.Padding(4);
            this.tb_maPt.Multiline = false;
            this.tb_maPt.Name = "tb_maPt";
            this.tb_maPt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_maPt.PasswordChar = false;
            this.tb_maPt.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_maPt.PlaceholderText = "";
            this.tb_maPt.ReadOnly1 = false;
            this.tb_maPt.Size = new System.Drawing.Size(232, 33);
            this.tb_maPt.TabIndex = 69;
            this.tb_maPt.Texts = "";
            this.tb_maPt.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "Giá tiền:";
            // 
            // tb_giatien
            // 
            this.tb_giatien.BackColor = System.Drawing.SystemColors.Window;
            this.tb_giatien.BorderColor = System.Drawing.Color.Black;
            this.tb_giatien.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_giatien.BorderRadius = 5;
            this.tb_giatien.Bordersize = 2;
            this.tb_giatien.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giatien.ForeColor = System.Drawing.Color.Black;
            this.tb_giatien.Location = new System.Drawing.Point(184, 243);
            this.tb_giatien.Margin = new System.Windows.Forms.Padding(4);
            this.tb_giatien.Multiline = false;
            this.tb_giatien.Name = "tb_giatien";
            this.tb_giatien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_giatien.PasswordChar = false;
            this.tb_giatien.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_giatien.PlaceholderText = "";
            this.tb_giatien.ReadOnly1 = false;
            this.tb_giatien.Size = new System.Drawing.Size(232, 33);
            this.tb_giatien.TabIndex = 71;
            this.tb_giatien.Texts = "";
            this.tb_giatien.UnderlinedStyle = false;
            // 
            // GoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 719);
            this.Controls.Add(this.gb_goitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoiTap";
            this.Text = "Gói tập";
            this.gb_goitap.ResumeLayout(false);
            this.gb_goitap.PerformLayout();
            this.gb_DkGoiTap.ResumeLayout(false);
            this.gb_DkGoiTap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_GT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_goitap;
        public System.Windows.Forms.DateTimePicker dt_ngdk;
        private CustomButton cb_loc;
        private CustomButton bt_Dk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_goitap;
        private System.Windows.Forms.DataGridView dtg_GT;
        private CustomTextBox tb_MaHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_mhv;
        public System.Windows.Forms.DateTimePicker dt_ngHetHan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_tengoi;
        private System.Windows.Forms.GroupBox gb_DkGoiTap;
        private CustomTextBox tb_giatien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private CustomTextBox tb_maPt;
        private System.Windows.Forms.DataGridViewTextBoxColumn helo;
        private System.Windows.Forms.DataGridViewTextBoxColumn wew;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdssd;
        private System.Windows.Forms.DataGridViewTextBoxColumn hwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdcs;
    }
}