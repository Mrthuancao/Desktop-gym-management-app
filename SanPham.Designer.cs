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
            this.lb_danhsach = new System.Windows.Forms.Label();
            this.lb_thongtin = new System.Windows.Forms.Label();
            this.tb_trinhtrang = new Gym_Management.CustomTextBox();
            this.tb_soluongsp = new Gym_Management.CustomTextBox();
            this.lb_tinhtrang = new System.Windows.Forms.Label();
            this.lb_gia = new System.Windows.Forms.Label();
            this.bt_search = new FontAwesome.Sharp.IconButton();
            this.tb_Search = new Gym_Management.CustomTextBox();
            this.gb_chucnang = new System.Windows.Forms.GroupBox();
            this.bt_sua = new Gym_Management.CustomButton();
            this.bt_xoa = new Gym_Management.CustomButton();
            this.bt_Them = new Gym_Management.CustomButton();
            this.lb_sl = new System.Windows.Forms.Label();
            this.lb_loaisp = new System.Windows.Forms.Label();
            this.lb_tensp = new System.Windows.Forms.Label();
            this.tb_loaisp = new Gym_Management.CustomTextBox();
            this.tb_hang = new Gym_Management.CustomTextBox();
            this.tb_msp = new Gym_Management.CustomTextBox();
            this.pb_anh = new FontAwesome.Sharp.IconPictureBox();
            this.dtg_SP = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trongluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_sanpham.SuspendLayout();
            this.gb_chucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SP)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_sanpham
            // 
            this.pn_sanpham.Controls.Add(this.lb_danhsach);
            this.pn_sanpham.Controls.Add(this.lb_thongtin);
            this.pn_sanpham.Controls.Add(this.tb_trinhtrang);
            this.pn_sanpham.Controls.Add(this.tb_soluongsp);
            this.pn_sanpham.Controls.Add(this.lb_tinhtrang);
            this.pn_sanpham.Controls.Add(this.lb_gia);
            this.pn_sanpham.Controls.Add(this.bt_search);
            this.pn_sanpham.Controls.Add(this.tb_Search);
            this.pn_sanpham.Controls.Add(this.gb_chucnang);
            this.pn_sanpham.Controls.Add(this.lb_sl);
            this.pn_sanpham.Controls.Add(this.lb_loaisp);
            this.pn_sanpham.Controls.Add(this.lb_tensp);
            this.pn_sanpham.Controls.Add(this.tb_loaisp);
            this.pn_sanpham.Controls.Add(this.tb_hang);
            this.pn_sanpham.Controls.Add(this.tb_msp);
            this.pn_sanpham.Controls.Add(this.pb_anh);
            this.pn_sanpham.Controls.Add(this.dtg_SP);
            this.pn_sanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_sanpham.Location = new System.Drawing.Point(0, 0);
            this.pn_sanpham.Name = "pn_sanpham";
            this.pn_sanpham.Size = new System.Drawing.Size(884, 641);
            this.pn_sanpham.TabIndex = 1;
            // 
            // lb_danhsach
            // 
            this.lb_danhsach.AutoSize = true;
            this.lb_danhsach.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_danhsach.Location = new System.Drawing.Point(334, 313);
            this.lb_danhsach.Name = "lb_danhsach";
            this.lb_danhsach.Size = new System.Drawing.Size(207, 28);
            this.lb_danhsach.TabIndex = 61;
            this.lb_danhsach.Text = "Danh sách sản phẩm";
            // 
            // lb_thongtin
            // 
            this.lb_thongtin.AutoSize = true;
            this.lb_thongtin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_thongtin.Location = new System.Drawing.Point(334, 9);
            this.lb_thongtin.Name = "lb_thongtin";
            this.lb_thongtin.Size = new System.Drawing.Size(201, 28);
            this.lb_thongtin.TabIndex = 60;
            this.lb_thongtin.Text = "Thông tin sản phẩm";
            // 
            // tb_trinhtrang
            // 
            this.tb_trinhtrang.BackColor = System.Drawing.SystemColors.Window;
            this.tb_trinhtrang.BorderColor = System.Drawing.Color.Black;
            this.tb_trinhtrang.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_trinhtrang.BorderRadius = 5;
            this.tb_trinhtrang.Bordersize = 2;
            this.tb_trinhtrang.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_trinhtrang.ForeColor = System.Drawing.Color.Black;
            this.tb_trinhtrang.Location = new System.Drawing.Point(403, 231);
            this.tb_trinhtrang.Margin = new System.Windows.Forms.Padding(4);
            this.tb_trinhtrang.Multiline = false;
            this.tb_trinhtrang.Name = "tb_trinhtrang";
            this.tb_trinhtrang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_trinhtrang.PasswordChar = false;
            this.tb_trinhtrang.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_trinhtrang.PlaceholderText = "";
            this.tb_trinhtrang.Size = new System.Drawing.Size(232, 33);
            this.tb_trinhtrang.TabIndex = 59;
            this.tb_trinhtrang.Texts = "";
            this.tb_trinhtrang.UnderlinedStyle = false;
            // 
            // tb_soluongsp
            // 
            this.tb_soluongsp.BackColor = System.Drawing.SystemColors.Window;
            this.tb_soluongsp.BorderColor = System.Drawing.Color.Black;
            this.tb_soluongsp.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_soluongsp.BorderRadius = 5;
            this.tb_soluongsp.Bordersize = 2;
            this.tb_soluongsp.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soluongsp.ForeColor = System.Drawing.Color.Black;
            this.tb_soluongsp.Location = new System.Drawing.Point(403, 149);
            this.tb_soluongsp.Margin = new System.Windows.Forms.Padding(4);
            this.tb_soluongsp.Multiline = false;
            this.tb_soluongsp.Name = "tb_soluongsp";
            this.tb_soluongsp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_soluongsp.PasswordChar = false;
            this.tb_soluongsp.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_soluongsp.PlaceholderText = "";
            this.tb_soluongsp.Size = new System.Drawing.Size(232, 33);
            this.tb_soluongsp.TabIndex = 58;
            this.tb_soluongsp.Texts = "";
            this.tb_soluongsp.UnderlinedStyle = false;
            // 
            // lb_tinhtrang
            // 
            this.lb_tinhtrang.AutoSize = true;
            this.lb_tinhtrang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tinhtrang.Location = new System.Drawing.Point(288, 243);
            this.lb_tinhtrang.Name = "lb_tinhtrang";
            this.lb_tinhtrang.Size = new System.Drawing.Size(81, 16);
            this.lb_tinhtrang.TabIndex = 57;
            this.lb_tinhtrang.Text = "Tình trạng:";
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gia.Location = new System.Drawing.Point(288, 202);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(33, 16);
            this.lb_gia.TabIndex = 56;
            this.lb_gia.Text = "Giá:";
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
            this.bt_search.Location = new System.Drawing.Point(848, 31);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(33, 33);
            this.bt_search.TabIndex = 55;
            this.bt_search.UseVisualStyleBackColor = false;
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
            this.tb_Search.Location = new System.Drawing.Point(664, 31);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Search.Multiline = false;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Search.PasswordChar = false;
            this.tb_Search.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_Search.PlaceholderText = "Search...";
            this.tb_Search.Size = new System.Drawing.Size(181, 33);
            this.tb_Search.TabIndex = 54;
            this.tb_Search.Texts = "";
            this.tb_Search.UnderlinedStyle = false;
            // 
            // gb_chucnang
            // 
            this.gb_chucnang.Controls.Add(this.bt_sua);
            this.gb_chucnang.Controls.Add(this.bt_xoa);
            this.gb_chucnang.Controls.Add(this.bt_Them);
            this.gb_chucnang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_chucnang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_chucnang.Location = new System.Drawing.Point(664, 79);
            this.gb_chucnang.Name = "gb_chucnang";
            this.gb_chucnang.Size = new System.Drawing.Size(181, 198);
            this.gb_chucnang.TabIndex = 53;
            this.gb_chucnang.TabStop = false;
            this.gb_chucnang.Text = "Chức năng";
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
            this.bt_sua.Location = new System.Drawing.Point(43, 132);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(102, 34);
            this.bt_sua.TabIndex = 54;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.TextColor = System.Drawing.Color.Transparent;
            this.bt_sua.UseVisualStyleBackColor = false;
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
            this.bt_xoa.Location = new System.Drawing.Point(43, 74);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(102, 34);
            this.bt_xoa.TabIndex = 54;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextColor = System.Drawing.Color.Transparent;
            this.bt_xoa.UseVisualStyleBackColor = false;
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
            // 
            // lb_sl
            // 
            this.lb_sl.AutoSize = true;
            this.lb_sl.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sl.Location = new System.Drawing.Point(288, 161);
            this.lb_sl.Name = "lb_sl";
            this.lb_sl.Size = new System.Drawing.Size(71, 16);
            this.lb_sl.TabIndex = 25;
            this.lb_sl.Text = "Số lượng:";
            // 
            // lb_loaisp
            // 
            this.lb_loaisp.AutoSize = true;
            this.lb_loaisp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loaisp.Location = new System.Drawing.Point(288, 120);
            this.lb_loaisp.Name = "lb_loaisp";
            this.lb_loaisp.Size = new System.Drawing.Size(39, 16);
            this.lb_loaisp.TabIndex = 24;
            this.lb_loaisp.Text = "Loại:";
            // 
            // lb_tensp
            // 
            this.lb_tensp.AutoSize = true;
            this.lb_tensp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tensp.Location = new System.Drawing.Point(288, 79);
            this.lb_tensp.Name = "lb_tensp";
            this.lb_tensp.Size = new System.Drawing.Size(38, 16);
            this.lb_tensp.TabIndex = 23;
            this.lb_tensp.Text = "Tên:";
            // 
            // tb_loaisp
            // 
            this.tb_loaisp.BackColor = System.Drawing.SystemColors.Window;
            this.tb_loaisp.BorderColor = System.Drawing.Color.Black;
            this.tb_loaisp.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_loaisp.BorderRadius = 5;
            this.tb_loaisp.Bordersize = 2;
            this.tb_loaisp.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_loaisp.ForeColor = System.Drawing.Color.Black;
            this.tb_loaisp.Location = new System.Drawing.Point(403, 108);
            this.tb_loaisp.Margin = new System.Windows.Forms.Padding(4);
            this.tb_loaisp.Multiline = false;
            this.tb_loaisp.Name = "tb_loaisp";
            this.tb_loaisp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_loaisp.PasswordChar = false;
            this.tb_loaisp.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_loaisp.PlaceholderText = "";
            this.tb_loaisp.Size = new System.Drawing.Size(232, 33);
            this.tb_loaisp.TabIndex = 21;
            this.tb_loaisp.Texts = "";
            this.tb_loaisp.UnderlinedStyle = false;
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
            this.tb_hang.Location = new System.Drawing.Point(403, 190);
            this.tb_hang.Margin = new System.Windows.Forms.Padding(4);
            this.tb_hang.Multiline = false;
            this.tb_hang.Name = "tb_hang";
            this.tb_hang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_hang.PasswordChar = false;
            this.tb_hang.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_hang.PlaceholderText = "";
            this.tb_hang.Size = new System.Drawing.Size(232, 33);
            this.tb_hang.TabIndex = 22;
            this.tb_hang.Texts = "";
            this.tb_hang.UnderlinedStyle = false;
            // 
            // tb_msp
            // 
            this.tb_msp.BackColor = System.Drawing.SystemColors.Window;
            this.tb_msp.BorderColor = System.Drawing.Color.Black;
            this.tb_msp.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_msp.BorderRadius = 5;
            this.tb_msp.Bordersize = 2;
            this.tb_msp.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_msp.ForeColor = System.Drawing.Color.Black;
            this.tb_msp.Location = new System.Drawing.Point(403, 67);
            this.tb_msp.Margin = new System.Windows.Forms.Padding(4);
            this.tb_msp.Multiline = false;
            this.tb_msp.Name = "tb_msp";
            this.tb_msp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_msp.PasswordChar = false;
            this.tb_msp.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_msp.PlaceholderText = "";
            this.tb_msp.Size = new System.Drawing.Size(232, 33);
            this.tb_msp.TabIndex = 20;
            this.tb_msp.Texts = "";
            this.tb_msp.UnderlinedStyle = false;
            // 
            // pb_anh
            // 
            this.pb_anh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb_anh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_anh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pb_anh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pb_anh.IconColor = System.Drawing.SystemColors.ControlText;
            this.pb_anh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pb_anh.IconSize = 202;
            this.pb_anh.Location = new System.Drawing.Point(12, 58);
            this.pb_anh.Name = "pb_anh";
            this.pb_anh.Size = new System.Drawing.Size(269, 202);
            this.pb_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_anh.TabIndex = 12;
            this.pb_anh.TabStop = false;
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
            this.loai,
            this.soluong,
            this.ngaynhap,
            this.gia,
            this.trongluong});
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
            this.dtg_SP.Location = new System.Drawing.Point(0, 357);
            this.dtg_SP.Name = "dtg_SP";
            this.dtg_SP.Size = new System.Drawing.Size(884, 284);
            this.dtg_SP.TabIndex = 1;
            // 
            // masp
            // 
            this.masp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.Name = "masp";
            // 
            // tensp
            // 
            this.tensp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.Name = "tensp";
            // 
            // loai
            // 
            this.loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loai.HeaderText = "Loại sản phẩm";
            this.loai.Name = "loai";
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // ngaynhap
            // 
            this.ngaynhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.Name = "ngaynhap";
            // 
            // gia
            // 
            this.gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gia.HeaderText = "Đơn giá";
            this.gia.Name = "gia";
            // 
            // trongluong
            // 
            this.trongluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trongluong.HeaderText = "Trọng lượng";
            this.trongluong.Name = "trongluong";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 641);
            this.Controls.Add(this.pn_sanpham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SanPham";
            this.Text = "Sản phẩm";
            this.pn_sanpham.ResumeLayout(false);
            this.pn_sanpham.PerformLayout();
            this.gb_chucnang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_sanpham;
        private System.Windows.Forms.Label lb_danhsach;
        private System.Windows.Forms.Label lb_thongtin;
        private CustomTextBox tb_trinhtrang;
        private CustomTextBox tb_soluongsp;
        private System.Windows.Forms.Label lb_tinhtrang;
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
        private CustomTextBox tb_msp;
        private FontAwesome.Sharp.IconPictureBox pb_anh;
        private System.Windows.Forms.DataGridView dtg_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn trongluong;
    }
}