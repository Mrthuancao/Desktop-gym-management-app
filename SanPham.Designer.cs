namespace Gym_Management
{
    partial class SanPham
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
            this.pn_sanpham = new System.Windows.Forms.Panel();
            this.pn_dtgsp = new System.Windows.Forms.Panel();
            this.dtg_SP = new System.Windows.Forms.DataGridView();
            this.lb_danhsachsp = new System.Windows.Forms.Label();
            this.pn_ttsp = new System.Windows.Forms.Panel();
            this.pb_anh = new FontAwesome.Sharp.IconPictureBox();
            this.lb_thongtin = new System.Windows.Forms.Label();
            this.lb_tensp = new System.Windows.Forms.Label();
            this.lb_loaisp = new System.Windows.Forms.Label();
            this.lb_gia = new System.Windows.Forms.Label();
            this.lb_sl = new System.Windows.Forms.Label();
            this.bt_search = new FontAwesome.Sharp.IconButton();
            this.gb_chucnang = new System.Windows.Forms.GroupBox();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_tensp = new Gym_Management.CustomTextBox();
            this.tb_hang = new Gym_Management.CustomTextBox();
            this.tb_loaisp = new Gym_Management.CustomTextBox();
            this.tb_soluongsp = new Gym_Management.CustomTextBox();
            this.bt_sua = new Gym_Management.CustomButton();
            this.bt_xoa = new Gym_Management.CustomButton();
            this.bt_Them = new Gym_Management.CustomButton();
            this.tb_Search = new Gym_Management.CustomTextBox();
            this.pn_sanpham.SuspendLayout();
            this.pn_dtgsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SP)).BeginInit();
            this.pn_ttsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).BeginInit();
            this.gb_chucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_sanpham
            // 
            this.pn_sanpham.Controls.Add(this.pn_dtgsp);
            this.pn_sanpham.Controls.Add(this.pn_ttsp);
            this.pn_sanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_sanpham.Location = new System.Drawing.Point(0, 0);
            this.pn_sanpham.Name = "pn_sanpham";
            this.pn_sanpham.Size = new System.Drawing.Size(1023, 719);
            this.pn_sanpham.TabIndex = 1;
            // 
            // pn_dtgsp
            // 
            this.pn_dtgsp.Controls.Add(this.dtg_SP);
            this.pn_dtgsp.Controls.Add(this.lb_danhsachsp);
            this.pn_dtgsp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_dtgsp.Location = new System.Drawing.Point(0, 361);
            this.pn_dtgsp.Name = "pn_dtgsp";
            this.pn_dtgsp.Size = new System.Drawing.Size(1023, 358);
            this.pn_dtgsp.TabIndex = 63;
            // 
            // dtg_SP
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtg_SP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_SP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_SP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtg_SP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_SP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.gianhap,
            this.dongia,
            this.soluong,
            this.ngaymua,
            this.malsp,
            this.tenlsp});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_SP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_SP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_SP.EnableHeadersVisualStyles = false;
            this.dtg_SP.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_SP.Location = new System.Drawing.Point(0, 32);
            this.dtg_SP.Name = "dtg_SP";
            this.dtg_SP.RowHeadersWidth = 51;
            this.dtg_SP.Size = new System.Drawing.Size(1023, 326);
            this.dtg_SP.TabIndex = 1;
            // 
            // lb_danhsachsp
            // 
            this.lb_danhsachsp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_danhsachsp.AutoSize = true;
            this.lb_danhsachsp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_danhsachsp.Location = new System.Drawing.Point(410, 1);
            this.lb_danhsachsp.Name = "lb_danhsachsp";
            this.lb_danhsachsp.Size = new System.Drawing.Size(207, 28);
            this.lb_danhsachsp.TabIndex = 61;
            this.lb_danhsachsp.Text = "Danh sách sản phẩm";
            // 
            // pn_ttsp
            // 
            this.pn_ttsp.Controls.Add(this.pb_anh);
            this.pn_ttsp.Controls.Add(this.tb_tensp);
            this.pn_ttsp.Controls.Add(this.tb_hang);
            this.pn_ttsp.Controls.Add(this.lb_thongtin);
            this.pn_ttsp.Controls.Add(this.tb_loaisp);
            this.pn_ttsp.Controls.Add(this.tb_soluongsp);
            this.pn_ttsp.Controls.Add(this.lb_tensp);
            this.pn_ttsp.Controls.Add(this.lb_loaisp);
            this.pn_ttsp.Controls.Add(this.lb_gia);
            this.pn_ttsp.Controls.Add(this.lb_sl);
            this.pn_ttsp.Controls.Add(this.bt_search);
            this.pn_ttsp.Controls.Add(this.gb_chucnang);
            this.pn_ttsp.Controls.Add(this.tb_Search);
            this.pn_ttsp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_ttsp.Location = new System.Drawing.Point(0, 0);
            this.pn_ttsp.Name = "pn_ttsp";
            this.pn_ttsp.Size = new System.Drawing.Size(1023, 359);
            this.pn_ttsp.TabIndex = 64;
            // 
            // pb_anh
            // 
            this.pb_anh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_anh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb_anh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_anh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pb_anh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pb_anh.IconColor = System.Drawing.SystemColors.ControlText;
            this.pb_anh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pb_anh.IconSize = 230;
            this.pb_anh.Location = new System.Drawing.Point(5, 50);
            this.pb_anh.Name = "pb_anh";
            this.pb_anh.Size = new System.Drawing.Size(291, 230);
            this.pb_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_anh.TabIndex = 12;
            this.pb_anh.TabStop = false;
            // 
            // lb_thongtin
            // 
            this.lb_thongtin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_thongtin.AutoSize = true;
            this.lb_thongtin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_thongtin.Location = new System.Drawing.Point(416, 28);
            this.lb_thongtin.Name = "lb_thongtin";
            this.lb_thongtin.Size = new System.Drawing.Size(201, 28);
            this.lb_thongtin.TabIndex = 60;
            this.lb_thongtin.Text = "Thông tin sản phẩm";
            // 
            // lb_tensp
            // 
            this.lb_tensp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_tensp.AutoSize = true;
            this.lb_tensp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tensp.Location = new System.Drawing.Point(338, 98);
            this.lb_tensp.Name = "lb_tensp";
            this.lb_tensp.Size = new System.Drawing.Size(38, 16);
            this.lb_tensp.TabIndex = 23;
            this.lb_tensp.Text = "Tên:";
            // 
            // lb_loaisp
            // 
            this.lb_loaisp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_loaisp.AutoSize = true;
            this.lb_loaisp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loaisp.Location = new System.Drawing.Point(338, 139);
            this.lb_loaisp.Name = "lb_loaisp";
            this.lb_loaisp.Size = new System.Drawing.Size(133, 16);
            this.lb_loaisp.TabIndex = 24;
            this.lb_loaisp.Text = "Tên loại sản phẩm:";
            // 
            // lb_gia
            // 
            this.lb_gia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_gia.AutoSize = true;
            this.lb_gia.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gia.Location = new System.Drawing.Point(338, 221);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(131, 16);
            this.lb_gia.TabIndex = 56;
            this.lb_gia.Text = "Giá một sản phẩm:";
            // 
            // lb_sl
            // 
            this.lb_sl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_sl.AutoSize = true;
            this.lb_sl.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sl.Location = new System.Drawing.Point(338, 180);
            this.lb_sl.Name = "lb_sl";
            this.lb_sl.Size = new System.Drawing.Size(71, 16);
            this.lb_sl.TabIndex = 25;
            this.lb_sl.Text = "Số lượng:";
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
            this.bt_search.Location = new System.Drawing.Point(982, 44);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(33, 33);
            this.bt_search.TabIndex = 55;
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // gb_chucnang
            // 
            this.gb_chucnang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_chucnang.Controls.Add(this.bt_sua);
            this.gb_chucnang.Controls.Add(this.bt_xoa);
            this.gb_chucnang.Controls.Add(this.bt_Them);
            this.gb_chucnang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_chucnang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_chucnang.Location = new System.Drawing.Point(780, 92);
            this.gb_chucnang.Name = "gb_chucnang";
            this.gb_chucnang.Size = new System.Drawing.Size(195, 201);
            this.gb_chucnang.TabIndex = 53;
            this.gb_chucnang.TabStop = false;
            this.gb_chucnang.Text = "Chức năng";
            // 
            // masp
            // 
            this.masp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tensp.DataPropertyName = "tensp";
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // gianhap
            // 
            this.gianhap.DataPropertyName = "gianhap";
            this.gianhap.HeaderText = "Giá nhập";
            this.gianhap.MinimumWidth = 6;
            this.gianhap.Name = "gianhap";
            this.gianhap.ReadOnly = true;
            this.gianhap.Width = 125;
            // 
            // dongia
            // 
            this.dongia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // ngaymua
            // 
            this.ngaymua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaymua.DataPropertyName = "ngaymua";
            this.ngaymua.HeaderText = "Ngày nhập";
            this.ngaymua.MinimumWidth = 6;
            this.ngaymua.Name = "ngaymua";
            this.ngaymua.ReadOnly = true;
            // 
            // malsp
            // 
            this.malsp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.malsp.DataPropertyName = "malsp";
            this.malsp.HeaderText = "Loại sản phẩm";
            this.malsp.MinimumWidth = 6;
            this.malsp.Name = "malsp";
            this.malsp.ReadOnly = true;
            this.malsp.Visible = false;
            // 
            // tenlsp
            // 
            this.tenlsp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenlsp.DataPropertyName = "tenlsp";
            this.tenlsp.HeaderText = "Tên loại sản phẩm";
            this.tenlsp.Name = "tenlsp";
            // 
            // tb_tensp
            // 
            this.tb_tensp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_tensp.BackColor = System.Drawing.SystemColors.Window;
            this.tb_tensp.BorderColor = System.Drawing.Color.Black;
            this.tb_tensp.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_tensp.BorderRadius = 5;
            this.tb_tensp.Bordersize = 2;
            this.tb_tensp.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tensp.ForeColor = System.Drawing.Color.Black;
            this.tb_tensp.Location = new System.Drawing.Point(528, 89);
            this.tb_tensp.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tensp.Multiline = false;
            this.tb_tensp.Name = "tb_tensp";
            this.tb_tensp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_tensp.PasswordChar = false;
            this.tb_tensp.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_tensp.PlaceholderText = "";
            this.tb_tensp.ReadOnly1 = true;
            this.tb_tensp.Size = new System.Drawing.Size(232, 33);
            this.tb_tensp.TabIndex = 20;
            this.tb_tensp.Texts = "";
            this.tb_tensp.UnderlinedStyle = false;
            // 
            // tb_hang
            // 
            this.tb_hang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_hang.BackColor = System.Drawing.SystemColors.Window;
            this.tb_hang.BorderColor = System.Drawing.Color.Black;
            this.tb_hang.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_hang.BorderRadius = 5;
            this.tb_hang.Bordersize = 2;
            this.tb_hang.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hang.ForeColor = System.Drawing.Color.Black;
            this.tb_hang.Location = new System.Drawing.Point(528, 211);
            this.tb_hang.Margin = new System.Windows.Forms.Padding(4);
            this.tb_hang.Multiline = false;
            this.tb_hang.Name = "tb_hang";
            this.tb_hang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_hang.PasswordChar = false;
            this.tb_hang.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_hang.PlaceholderText = "";
            this.tb_hang.ReadOnly1 = true;
            this.tb_hang.Size = new System.Drawing.Size(232, 33);
            this.tb_hang.TabIndex = 22;
            this.tb_hang.Texts = "";
            this.tb_hang.UnderlinedStyle = false;
            // 
            // tb_loaisp
            // 
            this.tb_loaisp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_loaisp.BackColor = System.Drawing.SystemColors.Window;
            this.tb_loaisp.BorderColor = System.Drawing.Color.Black;
            this.tb_loaisp.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_loaisp.BorderRadius = 5;
            this.tb_loaisp.Bordersize = 2;
            this.tb_loaisp.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_loaisp.ForeColor = System.Drawing.Color.Black;
            this.tb_loaisp.Location = new System.Drawing.Point(528, 130);
            this.tb_loaisp.Margin = new System.Windows.Forms.Padding(4);
            this.tb_loaisp.Multiline = false;
            this.tb_loaisp.Name = "tb_loaisp";
            this.tb_loaisp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_loaisp.PasswordChar = false;
            this.tb_loaisp.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_loaisp.PlaceholderText = "";
            this.tb_loaisp.ReadOnly1 = true;
            this.tb_loaisp.Size = new System.Drawing.Size(232, 33);
            this.tb_loaisp.TabIndex = 21;
            this.tb_loaisp.Texts = "";
            this.tb_loaisp.UnderlinedStyle = false;
            // 
            // tb_soluongsp
            // 
            this.tb_soluongsp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_soluongsp.BackColor = System.Drawing.SystemColors.Window;
            this.tb_soluongsp.BorderColor = System.Drawing.Color.Black;
            this.tb_soluongsp.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_soluongsp.BorderRadius = 5;
            this.tb_soluongsp.Bordersize = 2;
            this.tb_soluongsp.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soluongsp.ForeColor = System.Drawing.Color.Black;
            this.tb_soluongsp.Location = new System.Drawing.Point(528, 171);
            this.tb_soluongsp.Margin = new System.Windows.Forms.Padding(4);
            this.tb_soluongsp.Multiline = false;
            this.tb_soluongsp.Name = "tb_soluongsp";
            this.tb_soluongsp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_soluongsp.PasswordChar = false;
            this.tb_soluongsp.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_soluongsp.PlaceholderText = "";
            this.tb_soluongsp.ReadOnly1 = true;
            this.tb_soluongsp.Size = new System.Drawing.Size(232, 33);
            this.tb_soluongsp.TabIndex = 58;
            this.tb_soluongsp.Texts = "";
            this.tb_soluongsp.UnderlinedStyle = false;
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
            this.bt_sua.Location = new System.Drawing.Point(43, 123);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(102, 34);
            this.bt_sua.TabIndex = 54;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.TextColor = System.Drawing.Color.Transparent;
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
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
            this.bt_xoa.Location = new System.Drawing.Point(43, 73);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(102, 34);
            this.bt_xoa.TabIndex = 54;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextColor = System.Drawing.Color.Transparent;
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
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
            this.bt_Them.Location = new System.Drawing.Point(43, 25);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(102, 34);
            this.bt_Them.TabIndex = 54;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.TextColor = System.Drawing.Color.Transparent;
            this.bt_Them.UseVisualStyleBackColor = false;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
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
            this.tb_Search.Location = new System.Drawing.Point(794, 44);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Search.Multiline = false;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Search.PasswordChar = false;
            this.tb_Search.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Search.PlaceholderText = "Search...";
            this.tb_Search.ReadOnly1 = false;
            this.tb_Search.Size = new System.Drawing.Size(181, 33);
            this.tb_Search.TabIndex = 54;
            this.tb_Search.Texts = "";
            this.tb_Search.UnderlinedStyle = false;
            this.tb_Search.Enter += new System.EventHandler(this.SanPhamSearch_Enter);
            this.tb_Search.Leave += new System.EventHandler(this.SanPhamSearch_Leave);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 719);
            this.Controls.Add(this.pn_sanpham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SanPham";
            this.Text = "Sản phẩm";
            this.pn_sanpham.ResumeLayout(false);
            this.pn_dtgsp.ResumeLayout(false);
            this.pn_dtgsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SP)).EndInit();
            this.pn_ttsp.ResumeLayout(false);
            this.pn_ttsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).EndInit();
            this.gb_chucnang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_sanpham;
        private System.Windows.Forms.Label lb_danhsachsp;
        private System.Windows.Forms.Label lb_thongtin;
        private CustomTextBox tb_soluongsp;
        private System.Windows.Forms.Label lb_gia;
        private FontAwesome.Sharp.IconButton bt_search;
        private CustomTextBox tb_Search;
        private System.Windows.Forms.GroupBox gb_chucnang;
        private CustomButton bt_sua;
        private CustomButton bt_xoa;
        private CustomButton bt_Them;
        private System.Windows.Forms.Label lb_sl;
        private System.Windows.Forms.Label lb_loaisp;
        private System.Windows.Forms.Label lb_tensp;
        private CustomTextBox tb_loaisp;
        private CustomTextBox tb_hang;
        private CustomTextBox tb_tensp;
        private FontAwesome.Sharp.IconPictureBox pb_anh;
        private System.Windows.Forms.DataGridView dtg_SP;
        private System.Windows.Forms.Panel pn_dtgsp;
        private System.Windows.Forms.Panel pn_ttsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymua;
        private System.Windows.Forms.DataGridViewTextBoxColumn malsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlsp;
    }
}