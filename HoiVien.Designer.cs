namespace Gym_Management
{
    partial class HoiVien
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
            this.pn_HV = new System.Windows.Forms.Panel();
            this.bt_search = new FontAwesome.Sharp.IconButton();
            this.lb_danhsach = new System.Windows.Forms.Label();
            this.dtg_HV = new System.Windows.Forms.DataGridView();
            this.mahv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_thongtin = new System.Windows.Forms.Panel();
            this.lb_chieucao = new System.Windows.Forms.Label();
            this.lb_cannang = new System.Windows.Forms.Label();
            this.lb_maPt = new System.Windows.Forms.Label();
            this.dt_ngaydk = new System.Windows.Forms.DateTimePicker();
            this.dt_ngsinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_phai = new System.Windows.Forms.Label();
            this.lb_tenhv = new System.Windows.Forms.Label();
            this.lb_mhv = new System.Windows.Forms.Label();
            this.pb_anh = new FontAwesome.Sharp.IconPictureBox();
            this.lb_thongtin = new System.Windows.Forms.Label();
            this.bt_Luu = new Gym_Management.CustomButton();
            this.tb_Search = new Gym_Management.CustomTextBox();
            this.bt_xoa = new Gym_Management.CustomButton();
            this.bt_sua = new Gym_Management.CustomButton();
            this.bt_Them = new Gym_Management.CustomButton();
            this.tb_maPT = new Gym_Management.CustomTextBox();
            this.tb_gioitinh = new Gym_Management.CustomTextBox();
            this.tb_chieucao = new Gym_Management.CustomTextBox();
            this.tb_cannang = new Gym_Management.CustomTextBox();
            this.tb_Sdt = new Gym_Management.CustomTextBox();
            this.tb_TenHV = new Gym_Management.CustomTextBox();
            this.tb_MaHV = new Gym_Management.CustomTextBox();
            this.pn_HV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HV)).BeginInit();
            this.pn_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_HV
            // 
            this.pn_HV.Controls.Add(this.bt_Luu);
            this.pn_HV.Controls.Add(this.bt_search);
            this.pn_HV.Controls.Add(this.tb_Search);
            this.pn_HV.Controls.Add(this.bt_xoa);
            this.pn_HV.Controls.Add(this.bt_sua);
            this.pn_HV.Controls.Add(this.bt_Them);
            this.pn_HV.Controls.Add(this.lb_danhsach);
            this.pn_HV.Controls.Add(this.dtg_HV);
            this.pn_HV.Controls.Add(this.pn_thongtin);
            this.pn_HV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_HV.Location = new System.Drawing.Point(0, 0);
            this.pn_HV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pn_HV.Name = "pn_HV";
            this.pn_HV.Size = new System.Drawing.Size(1407, 885);
            this.pn_HV.TabIndex = 0;
            // 
            // bt_search
            // 
            this.bt_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_search.BackColor = System.Drawing.Color.Transparent;
            this.bt_search.FlatAppearance.BorderSize = 0;
            this.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bt_search.IconColor = System.Drawing.Color.Black;
            this.bt_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_search.IconSize = 30;
            this.bt_search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_search.Location = new System.Drawing.Point(492, 84);
            this.bt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(44, 41);
            this.bt_search.TabIndex = 13;
            this.bt_search.UseVisualStyleBackColor = false;
            // 
            // lb_danhsach
            // 
            this.lb_danhsach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_danhsach.AutoSize = true;
            this.lb_danhsach.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_danhsach.Location = new System.Drawing.Point(208, 30);
            this.lb_danhsach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_danhsach.Name = "lb_danhsach";
            this.lb_danhsach.Size = new System.Drawing.Size(235, 35);
            this.lb_danhsach.TabIndex = 9;
            this.lb_danhsach.Text = "Danh sách hội viên";
            // 
            // dtg_HV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtg_HV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_HV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtg_HV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_HV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtg_HV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_HV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_HV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_HV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahv,
            this.hoten});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_HV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_HV.EnableHeadersVisualStyles = false;
            this.dtg_HV.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_HV.Location = new System.Drawing.Point(0, 210);
            this.dtg_HV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtg_HV.Name = "dtg_HV";
            this.dtg_HV.ReadOnly = true;
            this.dtg_HV.RowHeadersWidth = 51;
            this.dtg_HV.Size = new System.Drawing.Size(528, 674);
            this.dtg_HV.TabIndex = 0;
            // 
            // mahv
            // 
            this.mahv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahv.DataPropertyName = "mahv";
            this.mahv.HeaderText = "Mã hội viên";
            this.mahv.MinimumWidth = 6;
            this.mahv.Name = "mahv";
            this.mahv.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ và tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // pn_thongtin
            // 
            this.pn_thongtin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_thongtin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_thongtin.Controls.Add(this.tb_maPT);
            this.pn_thongtin.Controls.Add(this.tb_gioitinh);
            this.pn_thongtin.Controls.Add(this.lb_chieucao);
            this.pn_thongtin.Controls.Add(this.lb_cannang);
            this.pn_thongtin.Controls.Add(this.tb_chieucao);
            this.pn_thongtin.Controls.Add(this.tb_cannang);
            this.pn_thongtin.Controls.Add(this.lb_maPt);
            this.pn_thongtin.Controls.Add(this.dt_ngaydk);
            this.pn_thongtin.Controls.Add(this.dt_ngsinh);
            this.pn_thongtin.Controls.Add(this.label1);
            this.pn_thongtin.Controls.Add(this.label4);
            this.pn_thongtin.Controls.Add(this.label3);
            this.pn_thongtin.Controls.Add(this.lb_phai);
            this.pn_thongtin.Controls.Add(this.lb_tenhv);
            this.pn_thongtin.Controls.Add(this.lb_mhv);
            this.pn_thongtin.Controls.Add(this.tb_Sdt);
            this.pn_thongtin.Controls.Add(this.tb_TenHV);
            this.pn_thongtin.Controls.Add(this.tb_MaHV);
            this.pn_thongtin.Controls.Add(this.pb_anh);
            this.pn_thongtin.Controls.Add(this.lb_thongtin);
            this.pn_thongtin.Location = new System.Drawing.Point(719, 6);
            this.pn_thongtin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pn_thongtin.Name = "pn_thongtin";
            this.pn_thongtin.Size = new System.Drawing.Size(671, 874);
            this.pn_thongtin.TabIndex = 8;
            // 
            // lb_chieucao
            // 
            this.lb_chieucao.AutoSize = true;
            this.lb_chieucao.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chieucao.Location = new System.Drawing.Point(41, 555);
            this.lb_chieucao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_chieucao.Name = "lb_chieucao";
            this.lb_chieucao.Size = new System.Drawing.Size(102, 22);
            this.lb_chieucao.TabIndex = 37;
            this.lb_chieucao.Text = "Chiều cao:";
            // 
            // lb_cannang
            // 
            this.lb_cannang.AutoSize = true;
            this.lb_cannang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cannang.Location = new System.Drawing.Point(41, 490);
            this.lb_cannang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cannang.Name = "lb_cannang";
            this.lb_cannang.Size = new System.Drawing.Size(100, 22);
            this.lb_cannang.TabIndex = 36;
            this.lb_cannang.Text = "Cân nặng:";
            // 
            // lb_maPt
            // 
            this.lb_maPt.AutoSize = true;
            this.lb_maPt.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maPt.Location = new System.Drawing.Point(41, 791);
            this.lb_maPt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_maPt.Name = "lb_maPt";
            this.lb_maPt.Size = new System.Drawing.Size(143, 22);
            this.lb_maPt.TabIndex = 32;
            this.lb_maPt.Text = "Mã PT(Nếu có):";
            // 
            // dt_ngaydk
            // 
            this.dt_ngaydk.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngaydk.CalendarForeColor = System.Drawing.Color.Black;
            this.dt_ngaydk.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngaydk.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngaydk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngaydk.Location = new System.Drawing.Point(288, 657);
            this.dt_ngaydk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dt_ngaydk.Name = "dt_ngaydk";
            this.dt_ngaydk.Size = new System.Drawing.Size(308, 30);
            this.dt_ngaydk.TabIndex = 7;
            // 
            // dt_ngsinh
            // 
            this.dt_ngsinh.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngsinh.CalendarForeColor = System.Drawing.Color.Black;
            this.dt_ngsinh.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngsinh.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngsinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngsinh.Location = new System.Drawing.Point(288, 596);
            this.dt_ngsinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dt_ngsinh.Name = "dt_ngsinh";
            this.dt_ngsinh.Size = new System.Drawing.Size(308, 30);
            this.dt_ngsinh.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 730);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 670);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày đăng kí:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 608);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngày sinh:";
            // 
            // lb_phai
            // 
            this.lb_phai.AutoSize = true;
            this.lb_phai.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phai.Location = new System.Drawing.Point(41, 433);
            this.lb_phai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_phai.Name = "lb_phai";
            this.lb_phai.Size = new System.Drawing.Size(91, 22);
            this.lb_phai.TabIndex = 19;
            this.lb_phai.Text = "Giới tính:";
            // 
            // lb_tenhv
            // 
            this.lb_tenhv.AutoSize = true;
            this.lb_tenhv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenhv.Location = new System.Drawing.Point(41, 368);
            this.lb_tenhv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tenhv.Name = "lb_tenhv";
            this.lb_tenhv.Size = new System.Drawing.Size(123, 22);
            this.lb_tenhv.TabIndex = 18;
            this.lb_tenhv.Text = "Tên hội viên:";
            // 
            // lb_mhv
            // 
            this.lb_mhv.AutoSize = true;
            this.lb_mhv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mhv.Location = new System.Drawing.Point(41, 303);
            this.lb_mhv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mhv.Name = "lb_mhv";
            this.lb_mhv.Size = new System.Drawing.Size(116, 22);
            this.lb_mhv.TabIndex = 17;
            this.lb_mhv.Text = "Mã hội viên:";
            // 
            // pb_anh
            // 
            this.pb_anh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb_anh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_anh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pb_anh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pb_anh.IconColor = System.Drawing.SystemColors.ControlText;
            this.pb_anh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pb_anh.IconSize = 180;
            this.pb_anh.Location = new System.Drawing.Point(199, 75);
            this.pb_anh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_anh.Name = "pb_anh";
            this.pb_anh.Size = new System.Drawing.Size(355, 180);
            this.pb_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_anh.TabIndex = 11;
            this.pb_anh.TabStop = false;
            // 
            // lb_thongtin
            // 
            this.lb_thongtin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_thongtin.AutoSize = true;
            this.lb_thongtin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_thongtin.Location = new System.Drawing.Point(253, 21);
            this.lb_thongtin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_thongtin.Name = "lb_thongtin";
            this.lb_thongtin.Size = new System.Drawing.Size(230, 35);
            this.lb_thongtin.TabIndex = 10;
            this.lb_thongtin.Text = "Thông tin hội viên";
            // 
            // bt_Luu
            // 
            this.bt_Luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Luu.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_Luu.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.bt_Luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Luu.BorderColor = System.Drawing.SystemColors.Control;
            this.bt_Luu.BorderRadius = 15;
            this.bt_Luu.BorderSize = 0;
            this.bt_Luu.FlatAppearance.BorderSize = 0;
            this.bt_Luu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.ForeColor = System.Drawing.Color.Transparent;
            this.bt_Luu.Location = new System.Drawing.Point(556, 476);
            this.bt_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(136, 42);
            this.bt_Luu.TabIndex = 9;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.TextColor = System.Drawing.Color.Transparent;
            this.bt_Luu.UseVisualStyleBackColor = false;
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Search.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Search.BorderColor = System.Drawing.Color.Black;
            this.tb_Search.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_Search.BorderRadius = 5;
            this.tb_Search.Bordersize = 2;
            this.tb_Search.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.ForeColor = System.Drawing.Color.Black;
            this.tb_Search.Location = new System.Drawing.Point(155, 84);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Search.Multiline = false;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_Search.PasswordChar = false;
            this.tb_Search.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Search.PlaceholderText = "Search...";
            this.tb_Search.Size = new System.Drawing.Size(309, 41);
            this.tb_Search.TabIndex = 12;
            this.tb_Search.Texts = "";
            this.tb_Search.UnderlinedStyle = false;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.bt_xoa.Location = new System.Drawing.Point(556, 306);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(136, 42);
            this.bt_xoa.TabIndex = 11;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextColor = System.Drawing.Color.Transparent;
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.bt_sua.Location = new System.Drawing.Point(556, 400);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(4);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(136, 42);
            this.bt_sua.TabIndex = 10;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.TextColor = System.Drawing.Color.Transparent;
            this.bt_sua.UseVisualStyleBackColor = false;
            // 
            // bt_Them
            // 
            this.bt_Them.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.bt_Them.Location = new System.Drawing.Point(556, 222);
            this.bt_Them.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(136, 42);
            this.bt_Them.TabIndex = 7;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.TextColor = System.Drawing.Color.Transparent;
            this.bt_Them.UseVisualStyleBackColor = false;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // tb_maPT
            // 
            this.tb_maPT.BackColor = System.Drawing.SystemColors.Window;
            this.tb_maPT.BorderColor = System.Drawing.Color.Black;
            this.tb_maPT.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_maPT.BorderRadius = 5;
            this.tb_maPT.Bordersize = 2;
            this.tb_maPT.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_maPT.ForeColor = System.Drawing.Color.Black;
            this.tb_maPT.Location = new System.Drawing.Point(288, 775);
            this.tb_maPT.Margin = new System.Windows.Forms.Padding(5);
            this.tb_maPT.Multiline = false;
            this.tb_maPT.Name = "tb_maPT";
            this.tb_maPT.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_maPT.PasswordChar = false;
            this.tb_maPT.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_maPT.PlaceholderText = "";
            this.tb_maPT.Size = new System.Drawing.Size(309, 41);
            this.tb_maPT.TabIndex = 39;
            this.tb_maPT.Texts = "";
            this.tb_maPT.UnderlinedStyle = false;
            // 
            // tb_gioitinh
            // 
            this.tb_gioitinh.BackColor = System.Drawing.SystemColors.Window;
            this.tb_gioitinh.BorderColor = System.Drawing.Color.Black;
            this.tb_gioitinh.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_gioitinh.BorderRadius = 5;
            this.tb_gioitinh.Bordersize = 2;
            this.tb_gioitinh.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gioitinh.ForeColor = System.Drawing.Color.Black;
            this.tb_gioitinh.Location = new System.Drawing.Point(288, 412);
            this.tb_gioitinh.Margin = new System.Windows.Forms.Padding(5);
            this.tb_gioitinh.Multiline = false;
            this.tb_gioitinh.Name = "tb_gioitinh";
            this.tb_gioitinh.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_gioitinh.PasswordChar = false;
            this.tb_gioitinh.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_gioitinh.PlaceholderText = "";
            this.tb_gioitinh.Size = new System.Drawing.Size(309, 41);
            this.tb_gioitinh.TabIndex = 38;
            this.tb_gioitinh.Texts = "";
            this.tb_gioitinh.UnderlinedStyle = false;
            // 
            // tb_chieucao
            // 
            this.tb_chieucao.BackColor = System.Drawing.SystemColors.Window;
            this.tb_chieucao.BorderColor = System.Drawing.Color.Black;
            this.tb_chieucao.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_chieucao.BorderRadius = 5;
            this.tb_chieucao.Bordersize = 2;
            this.tb_chieucao.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_chieucao.ForeColor = System.Drawing.Color.Black;
            this.tb_chieucao.Location = new System.Drawing.Point(288, 534);
            this.tb_chieucao.Margin = new System.Windows.Forms.Padding(5);
            this.tb_chieucao.Multiline = false;
            this.tb_chieucao.Name = "tb_chieucao";
            this.tb_chieucao.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_chieucao.PasswordChar = false;
            this.tb_chieucao.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_chieucao.PlaceholderText = "";
            this.tb_chieucao.Size = new System.Drawing.Size(309, 41);
            this.tb_chieucao.TabIndex = 5;
            this.tb_chieucao.Texts = "";
            this.tb_chieucao.UnderlinedStyle = false;
            // 
            // tb_cannang
            // 
            this.tb_cannang.BackColor = System.Drawing.SystemColors.Window;
            this.tb_cannang.BorderColor = System.Drawing.Color.Black;
            this.tb_cannang.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_cannang.BorderRadius = 5;
            this.tb_cannang.Bordersize = 2;
            this.tb_cannang.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cannang.ForeColor = System.Drawing.Color.Black;
            this.tb_cannang.Location = new System.Drawing.Point(288, 469);
            this.tb_cannang.Margin = new System.Windows.Forms.Padding(5);
            this.tb_cannang.Multiline = false;
            this.tb_cannang.Name = "tb_cannang";
            this.tb_cannang.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_cannang.PasswordChar = false;
            this.tb_cannang.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_cannang.PlaceholderText = "";
            this.tb_cannang.Size = new System.Drawing.Size(309, 41);
            this.tb_cannang.TabIndex = 4;
            this.tb_cannang.Texts = "";
            this.tb_cannang.UnderlinedStyle = false;
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
            this.tb_Sdt.Location = new System.Drawing.Point(288, 709);
            this.tb_Sdt.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Sdt.Multiline = false;
            this.tb_Sdt.Name = "tb_Sdt";
            this.tb_Sdt.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_Sdt.PasswordChar = false;
            this.tb_Sdt.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Sdt.PlaceholderText = "";
            this.tb_Sdt.Size = new System.Drawing.Size(309, 41);
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
            this.tb_TenHV.Location = new System.Drawing.Point(288, 347);
            this.tb_TenHV.Margin = new System.Windows.Forms.Padding(5);
            this.tb_TenHV.Multiline = false;
            this.tb_TenHV.Name = "tb_TenHV";
            this.tb_TenHV.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_TenHV.PasswordChar = false;
            this.tb_TenHV.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_TenHV.PlaceholderText = "";
            this.tb_TenHV.Size = new System.Drawing.Size(309, 41);
            this.tb_TenHV.TabIndex = 2;
            this.tb_TenHV.Texts = "";
            this.tb_TenHV.UnderlinedStyle = false;
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
            this.tb_MaHV.Location = new System.Drawing.Point(288, 282);
            this.tb_MaHV.Margin = new System.Windows.Forms.Padding(5);
            this.tb_MaHV.Multiline = false;
            this.tb_MaHV.Name = "tb_MaHV";
            this.tb_MaHV.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_MaHV.PasswordChar = false;
            this.tb_MaHV.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_MaHV.PlaceholderText = "";
            this.tb_MaHV.Size = new System.Drawing.Size(309, 41);
            this.tb_MaHV.TabIndex = 1;
            this.tb_MaHV.Texts = "";
            this.tb_MaHV.UnderlinedStyle = false;
            // 
            // HoiVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 885);
            this.Controls.Add(this.pn_HV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HoiVien";
            this.Text = "Hội viên";
            this.pn_HV.ResumeLayout(false);
            this.pn_HV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HV)).EndInit();
            this.pn_thongtin.ResumeLayout(false);
            this.pn_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_HV;
        private System.Windows.Forms.DataGridView dtg_HV;
        private System.Windows.Forms.Label lb_danhsach;
        private System.Windows.Forms.Panel pn_thongtin;
        private CustomButton bt_Them;
        private CustomButton bt_xoa;
        private CustomButton bt_sua;
        private CustomTextBox tb_Search;
        private FontAwesome.Sharp.IconPictureBox pb_anh;
        private System.Windows.Forms.Label lb_thongtin;
        private CustomTextBox tb_Sdt;
        private CustomTextBox tb_TenHV;
        private FontAwesome.Sharp.IconButton bt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_phai;
        private System.Windows.Forms.Label lb_tenhv;
        private System.Windows.Forms.Label lb_mhv;
        public System.Windows.Forms.DateTimePicker dt_ngaydk;
        public System.Windows.Forms.DateTimePicker dt_ngsinh;
        private System.Windows.Forms.Label lb_maPt;
        private CustomButton bt_Luu;
        private System.Windows.Forms.Label lb_chieucao;
        private System.Windows.Forms.Label lb_cannang;
        private CustomTextBox tb_chieucao;
        private CustomTextBox tb_cannang;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private CustomTextBox tb_MaHV;
        private CustomTextBox tb_maPT;
        private CustomTextBox tb_gioitinh;
    }
}