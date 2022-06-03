namespace Gym_Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_goitap = new System.Windows.Forms.GroupBox();
            this.bt_xoa = new Gym_Management.CustomButton();
            this.dtg_GT = new System.Windows.Forms.DataGridView();
            this.madk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_DkGoiTap = new System.Windows.Forms.GroupBox();
            this.tb_Xoa = new Gym_Management.CustomButton();
            this.tb_madk = new Gym_Management.CustomTextBox();
            this.lb_madk = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_mhv = new System.Windows.Forms.Label();
            this.cb_Magoi = new System.Windows.Forms.ComboBox();
            this.dt_ngHetHan = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_ngdk = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Dk = new Gym_Management.CustomButton();
            this.tb_MaHV = new Gym_Management.CustomTextBox();
            this.tb_maPt = new Gym_Management.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_goitap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_goitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_GT)).BeginInit();
            this.gb_DkGoiTap.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_goitap
            // 
            this.gb_goitap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_goitap.Controls.Add(this.bt_xoa);
            this.gb_goitap.Controls.Add(this.dtg_GT);
            this.gb_goitap.Controls.Add(this.gb_DkGoiTap);
            this.gb_goitap.Controls.Add(this.label5);
            this.gb_goitap.Controls.Add(this.cb_goitap);
            this.gb_goitap.Controls.Add(this.label1);
            this.gb_goitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_goitap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.gb_goitap.Location = new System.Drawing.Point(0, 0);
            this.gb_goitap.Name = "gb_goitap";
            this.gb_goitap.Size = new System.Drawing.Size(1023, 719);
            this.gb_goitap.TabIndex = 0;
            this.gb_goitap.TabStop = false;
            this.gb_goitap.Text = "Gói tập";
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
            this.bt_xoa.Location = new System.Drawing.Point(177, 229);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(135, 34);
            this.bt_xoa.TabIndex = 70;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextColor = System.Drawing.Color.Transparent;
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // dtg_GT
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtg_GT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_GT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_GT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtg_GT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_GT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_GT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_GT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madk,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ngayhethan,
            this.maPT,
            this.giatien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_GT.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_GT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_GT.EnableHeadersVisualStyles = false;
            this.dtg_GT.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_GT.Location = new System.Drawing.Point(3, 387);
            this.dtg_GT.Name = "dtg_GT";
            this.dtg_GT.ReadOnly = true;
            this.dtg_GT.RowHeadersWidth = 51;
            this.dtg_GT.Size = new System.Drawing.Size(1017, 329);
            this.dtg_GT.TabIndex = 69;
            // 
            // madk
            // 
            this.madk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.madk.DataPropertyName = "madk";
            this.madk.HeaderText = "Mã đăng kí";
            this.madk.Name = "madk";
            this.madk.ReadOnly = true;
            this.madk.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mahv";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã hội viên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "hoten";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên hội viên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ngayhethan
            // 
            this.ngayhethan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayhethan.DataPropertyName = "thoigiankt";
            this.ngayhethan.HeaderText = "Ngày hết hạn";
            this.ngayhethan.Name = "ngayhethan";
            this.ngayhethan.ReadOnly = true;
            // 
            // maPT
            // 
            this.maPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPT.DataPropertyName = "manv";
            this.maPT.HeaderText = "Mã PT";
            this.maPT.Name = "maPT";
            this.maPT.ReadOnly = true;
            // 
            // giatien
            // 
            this.giatien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giatien.DataPropertyName = "giamoithang";
            this.giatien.HeaderText = "Giá tiền";
            this.giatien.Name = "giatien";
            this.giatien.ReadOnly = true;
            // 
            // gb_DkGoiTap
            // 
            this.gb_DkGoiTap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_DkGoiTap.Controls.Add(this.tb_Xoa);
            this.gb_DkGoiTap.Controls.Add(this.tb_madk);
            this.gb_DkGoiTap.Controls.Add(this.lb_madk);
            this.gb_DkGoiTap.Controls.Add(this.label6);
            this.gb_DkGoiTap.Controls.Add(this.lb_mhv);
            this.gb_DkGoiTap.Controls.Add(this.cb_Magoi);
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
            this.gb_DkGoiTap.Location = new System.Drawing.Point(563, 22);
            this.gb_DkGoiTap.Name = "gb_DkGoiTap";
            this.gb_DkGoiTap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gb_DkGoiTap.Size = new System.Drawing.Size(440, 341);
            this.gb_DkGoiTap.TabIndex = 68;
            this.gb_DkGoiTap.TabStop = false;
            this.gb_DkGoiTap.Text = "Đăng kí gói tập";
            // 
            // tb_Xoa
            // 
            this.tb_Xoa.BackColor = System.Drawing.Color.DarkOrange;
            this.tb_Xoa.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.tb_Xoa.BorderColor = System.Drawing.SystemColors.Control;
            this.tb_Xoa.BorderRadius = 15;
            this.tb_Xoa.BorderSize = 0;
            this.tb_Xoa.FlatAppearance.BorderSize = 0;
            this.tb_Xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tb_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tb_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Xoa.ForeColor = System.Drawing.Color.Transparent;
            this.tb_Xoa.Location = new System.Drawing.Point(299, 301);
            this.tb_Xoa.Name = "tb_Xoa";
            this.tb_Xoa.Size = new System.Drawing.Size(135, 34);
            this.tb_Xoa.TabIndex = 71;
            this.tb_Xoa.Text = "Xóa hết";
            this.tb_Xoa.TextColor = System.Drawing.Color.Transparent;
            this.tb_Xoa.UseVisualStyleBackColor = false;
            this.tb_Xoa.Click += new System.EventHandler(this.tb_Xoa_Click);
            // 
            // tb_madk
            // 
            this.tb_madk.BackColor = System.Drawing.SystemColors.Window;
            this.tb_madk.BorderColor = System.Drawing.Color.Black;
            this.tb_madk.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_madk.BorderRadius = 5;
            this.tb_madk.Bordersize = 2;
            this.tb_madk.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_madk.ForeColor = System.Drawing.Color.Black;
            this.tb_madk.Location = new System.Drawing.Point(184, 59);
            this.tb_madk.Margin = new System.Windows.Forms.Padding(4);
            this.tb_madk.Multiline = false;
            this.tb_madk.Name = "tb_madk";
            this.tb_madk.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_madk.PasswordChar = false;
            this.tb_madk.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_madk.PlaceholderText = "DK...";
            this.tb_madk.ReadOnly1 = false;
            this.tb_madk.Size = new System.Drawing.Size(232, 33);
            this.tb_madk.TabIndex = 2;
            this.tb_madk.Texts = "";
            this.tb_madk.UnderlinedStyle = false;
            // 
            // lb_madk
            // 
            this.lb_madk.AutoSize = true;
            this.lb_madk.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_madk.Location = new System.Drawing.Point(11, 76);
            this.lb_madk.Name = "lb_madk";
            this.lb_madk.Size = new System.Drawing.Size(84, 16);
            this.lb_madk.TabIndex = 70;
            this.lb_madk.Text = "Mã đăng kí:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Mã Pt(Nếu có):";
            // 
            // lb_mhv
            // 
            this.lb_mhv.AutoSize = true;
            this.lb_mhv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mhv.Location = new System.Drawing.Point(11, 124);
            this.lb_mhv.Name = "lb_mhv";
            this.lb_mhv.Size = new System.Drawing.Size(88, 16);
            this.lb_mhv.TabIndex = 18;
            this.lb_mhv.Text = "Mã hội viên:";
            // 
            // cb_Magoi
            // 
            this.cb_Magoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Magoi.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_Magoi.FormattingEnabled = true;
            this.cb_Magoi.IntegralHeight = false;
            this.cb_Magoi.ItemHeight = 18;
            this.cb_Magoi.Items.AddRange(new object[] {
            "G001",
            "G002",
            "G003",
            "G004",
            "G005",
            "G006",
            "G007"});
            this.cb_Magoi.Location = new System.Drawing.Point(184, 151);
            this.cb_Magoi.Name = "cb_Magoi";
            this.cb_Magoi.Size = new System.Drawing.Size(232, 26);
            this.cb_Magoi.TabIndex = 4;
            // 
            // dt_ngHetHan
            // 
            this.dt_ngHetHan.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngHetHan.CalendarForeColor = System.Drawing.Color.Black;
            this.dt_ngHetHan.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngHetHan.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngHetHan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngHetHan.Location = new System.Drawing.Point(184, 215);
            this.dt_ngHetHan.Name = "dt_ngHetHan";
            this.dt_ngHetHan.Size = new System.Drawing.Size(232, 26);
            this.dt_ngHetHan.TabIndex = 6;
            this.dt_ngHetHan.Value = new System.DateTime(2022, 6, 2, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 161);
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
            this.dt_ngdk.Location = new System.Drawing.Point(184, 183);
            this.dt_ngdk.Name = "dt_ngdk";
            this.dt_ngdk.Size = new System.Drawing.Size(232, 26);
            this.dt_ngdk.TabIndex = 5;
            this.dt_ngdk.Value = new System.DateTime(2022, 6, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "Ngày đăng kí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 225);
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
            this.bt_Dk.Location = new System.Drawing.Point(158, 301);
            this.bt_Dk.Name = "bt_Dk";
            this.bt_Dk.Size = new System.Drawing.Size(135, 34);
            this.bt_Dk.TabIndex = 8;
            this.bt_Dk.Text = "Đăng kí";
            this.bt_Dk.TextColor = System.Drawing.Color.Transparent;
            this.bt_Dk.UseVisualStyleBackColor = false;
            this.bt_Dk.Click += new System.EventHandler(this.bt_Dk_Click);
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
            this.tb_MaHV.Location = new System.Drawing.Point(184, 107);
            this.tb_MaHV.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MaHV.Multiline = false;
            this.tb_MaHV.Name = "tb_MaHV";
            this.tb_MaHV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_MaHV.PasswordChar = false;
            this.tb_MaHV.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_MaHV.PlaceholderText = "";
            this.tb_MaHV.ReadOnly1 = false;
            this.tb_MaHV.Size = new System.Drawing.Size(232, 33);
            this.tb_MaHV.TabIndex = 3;
            this.tb_MaHV.Texts = "";
            this.tb_MaHV.UnderlinedStyle = false;
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
            this.tb_maPt.Location = new System.Drawing.Point(184, 248);
            this.tb_maPt.Margin = new System.Windows.Forms.Padding(4);
            this.tb_maPt.Multiline = false;
            this.tb_maPt.Name = "tb_maPt";
            this.tb_maPt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_maPt.PasswordChar = false;
            this.tb_maPt.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_maPt.PlaceholderText = "NV...";
            this.tb_maPt.ReadOnly1 = false;
            this.tb_maPt.Size = new System.Drawing.Size(232, 33);
            this.tb_maPt.TabIndex = 7;
            this.tb_maPt.Texts = "";
            this.tb_maPt.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(171, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 28);
            this.label5.TabIndex = 66;
            this.label5.Text = "Check gói tập";
            // 
            // cb_goitap
            // 
            this.cb_goitap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_goitap.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_goitap.FormattingEnabled = true;
            this.cb_goitap.IntegralHeight = false;
            this.cb_goitap.ItemHeight = 18;
            this.cb_goitap.Location = new System.Drawing.Point(176, 156);
            this.cb_goitap.Name = "cb_goitap";
            this.cb_goitap.Size = new System.Drawing.Size(232, 26);
            this.cb_goitap.TabIndex = 25;
            this.cb_goitap.SelectedIndexChanged += new System.EventHandler(this.cb_goitap_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Gói tập:";
            // 
            // GoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 719);
            this.Controls.Add(this.gb_goitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoiTap";
            this.Text = "Gói tập";
            this.gb_goitap.ResumeLayout(false);
            this.gb_goitap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_GT)).EndInit();
            this.gb_DkGoiTap.ResumeLayout(false);
            this.gb_DkGoiTap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_goitap;
        public System.Windows.Forms.DateTimePicker dt_ngdk;
        private CustomButton bt_Dk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_goitap;
        private CustomTextBox tb_MaHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_mhv;
        public System.Windows.Forms.DateTimePicker dt_ngHetHan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Magoi;
        private System.Windows.Forms.GroupBox gb_DkGoiTap;
        private System.Windows.Forms.Label label6;
        private CustomTextBox tb_maPt;
        private CustomTextBox tb_madk;
        private System.Windows.Forms.Label lb_madk;
        private CustomButton tb_Xoa;
        private System.Windows.Forms.DataGridView dtg_GT;
        private CustomButton bt_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn madk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhethan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatien;
    }
}