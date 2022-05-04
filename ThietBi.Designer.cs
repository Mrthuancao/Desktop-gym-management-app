namespace Gym_Management
{
    partial class ThietBi
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
            this.pn_thietbi = new System.Windows.Forms.Panel();
            this.lb_danhsach = new System.Windows.Forms.Label();
            this.lb_thongtin = new System.Windows.Forms.Label();
            this.tb_giatb = new Gym_Management.CustomTextBox();
            this.tb_soluongtb = new Gym_Management.CustomTextBox();
            this.lb_giatb = new System.Windows.Forms.Label();
            this.lb_hangtb = new System.Windows.Forms.Label();
            this.bt_search = new FontAwesome.Sharp.IconButton();
            this.tb_Search = new Gym_Management.CustomTextBox();
            this.gb_chucnang = new System.Windows.Forms.GroupBox();
            this.bt_sua = new Gym_Management.CustomButton();
            this.bt_xoa = new Gym_Management.CustomButton();
            this.bt_Them = new Gym_Management.CustomButton();
            this.lb_sltb = new System.Windows.Forms.Label();
            this.lb_loaitb = new System.Windows.Forms.Label();
            this.lb_tentb = new System.Windows.Forms.Label();
            this.tb_loaitb = new Gym_Management.CustomTextBox();
            this.tb_hangtb = new Gym_Management.CustomTextBox();
            this.tb_tentb = new Gym_Management.CustomTextBox();
            this.pb_anh = new FontAwesome.Sharp.IconPictureBox();
            this.dtg_TB = new System.Windows.Forms.DataGridView();
            this.matb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_thietbi.SuspendLayout();
            this.gb_chucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_TB)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_thietbi
            // 
            this.pn_thietbi.Controls.Add(this.lb_danhsach);
            this.pn_thietbi.Controls.Add(this.lb_thongtin);
            this.pn_thietbi.Controls.Add(this.tb_giatb);
            this.pn_thietbi.Controls.Add(this.tb_soluongtb);
            this.pn_thietbi.Controls.Add(this.lb_giatb);
            this.pn_thietbi.Controls.Add(this.lb_hangtb);
            this.pn_thietbi.Controls.Add(this.bt_search);
            this.pn_thietbi.Controls.Add(this.tb_Search);
            this.pn_thietbi.Controls.Add(this.gb_chucnang);
            this.pn_thietbi.Controls.Add(this.lb_sltb);
            this.pn_thietbi.Controls.Add(this.lb_loaitb);
            this.pn_thietbi.Controls.Add(this.lb_tentb);
            this.pn_thietbi.Controls.Add(this.tb_loaitb);
            this.pn_thietbi.Controls.Add(this.tb_hangtb);
            this.pn_thietbi.Controls.Add(this.tb_tentb);
            this.pn_thietbi.Controls.Add(this.pb_anh);
            this.pn_thietbi.Controls.Add(this.dtg_TB);
            this.pn_thietbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_thietbi.Location = new System.Drawing.Point(0, 0);
            this.pn_thietbi.Name = "pn_thietbi";
            this.pn_thietbi.Size = new System.Drawing.Size(884, 641);
            this.pn_thietbi.TabIndex = 0;
            // 
            // lb_danhsach
            // 
            this.lb_danhsach.AutoSize = true;
            this.lb_danhsach.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_danhsach.Location = new System.Drawing.Point(334, 313);
            this.lb_danhsach.Name = "lb_danhsach";
            this.lb_danhsach.Size = new System.Drawing.Size(185, 28);
            this.lb_danhsach.TabIndex = 61;
            this.lb_danhsach.Text = "Danh sách thiết bị";
            // 
            // lb_thongtin
            // 
            this.lb_thongtin.AutoSize = true;
            this.lb_thongtin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_thongtin.Location = new System.Drawing.Point(334, 9);
            this.lb_thongtin.Name = "lb_thongtin";
            this.lb_thongtin.Size = new System.Drawing.Size(179, 28);
            this.lb_thongtin.TabIndex = 60;
            this.lb_thongtin.Text = "Thông tin thiết bị";
            // 
            // tb_giatb
            // 
            this.tb_giatb.BackColor = System.Drawing.SystemColors.Window;
            this.tb_giatb.BorderColor = System.Drawing.Color.Black;
            this.tb_giatb.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_giatb.BorderRadius = 5;
            this.tb_giatb.Bordersize = 2;
            this.tb_giatb.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giatb.ForeColor = System.Drawing.Color.Black;
            this.tb_giatb.Location = new System.Drawing.Point(403, 231);
            this.tb_giatb.Margin = new System.Windows.Forms.Padding(4);
            this.tb_giatb.Multiline = false;
            this.tb_giatb.Name = "tb_giatb";
            this.tb_giatb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_giatb.PasswordChar = false;
            this.tb_giatb.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_giatb.PlaceholderText = "";
            this.tb_giatb.Size = new System.Drawing.Size(232, 33);
            this.tb_giatb.TabIndex = 59;
            this.tb_giatb.Texts = "";
            this.tb_giatb.UnderlinedStyle = false;
            // 
            // tb_soluongtb
            // 
            this.tb_soluongtb.BackColor = System.Drawing.SystemColors.Window;
            this.tb_soluongtb.BorderColor = System.Drawing.Color.Black;
            this.tb_soluongtb.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_soluongtb.BorderRadius = 5;
            this.tb_soluongtb.Bordersize = 2;
            this.tb_soluongtb.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soluongtb.ForeColor = System.Drawing.Color.Black;
            this.tb_soluongtb.Location = new System.Drawing.Point(403, 149);
            this.tb_soluongtb.Margin = new System.Windows.Forms.Padding(4);
            this.tb_soluongtb.Multiline = false;
            this.tb_soluongtb.Name = "tb_soluongtb";
            this.tb_soluongtb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_soluongtb.PasswordChar = false;
            this.tb_soluongtb.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_soluongtb.PlaceholderText = "";
            this.tb_soluongtb.Size = new System.Drawing.Size(232, 33);
            this.tb_soluongtb.TabIndex = 58;
            this.tb_soluongtb.Texts = "";
            this.tb_soluongtb.UnderlinedStyle = false;
            // 
            // lb_giatb
            // 
            this.lb_giatb.AutoSize = true;
            this.lb_giatb.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_giatb.Location = new System.Drawing.Point(288, 243);
            this.lb_giatb.Name = "lb_giatb";
            this.lb_giatb.Size = new System.Drawing.Size(33, 16);
            this.lb_giatb.TabIndex = 57;
            this.lb_giatb.Text = "Giá:";
            // 
            // lb_hangtb
            // 
            this.lb_hangtb.AutoSize = true;
            this.lb_hangtb.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hangtb.Location = new System.Drawing.Point(288, 202);
            this.lb_hangtb.Name = "lb_hangtb";
            this.lb_hangtb.Size = new System.Drawing.Size(108, 16);
            this.lb_hangtb.TabIndex = 56;
            this.lb_hangtb.Text = "Hãng sản xuất:";
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
            // lb_sltb
            // 
            this.lb_sltb.AutoSize = true;
            this.lb_sltb.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sltb.Location = new System.Drawing.Point(288, 161);
            this.lb_sltb.Name = "lb_sltb";
            this.lb_sltb.Size = new System.Drawing.Size(71, 16);
            this.lb_sltb.TabIndex = 25;
            this.lb_sltb.Text = "Số lượng:";
            // 
            // lb_loaitb
            // 
            this.lb_loaitb.AutoSize = true;
            this.lb_loaitb.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loaitb.Location = new System.Drawing.Point(288, 120);
            this.lb_loaitb.Name = "lb_loaitb";
            this.lb_loaitb.Size = new System.Drawing.Size(39, 16);
            this.lb_loaitb.TabIndex = 24;
            this.lb_loaitb.Text = "Loại:";
            // 
            // lb_tentb
            // 
            this.lb_tentb.AutoSize = true;
            this.lb_tentb.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tentb.Location = new System.Drawing.Point(288, 79);
            this.lb_tentb.Name = "lb_tentb";
            this.lb_tentb.Size = new System.Drawing.Size(38, 16);
            this.lb_tentb.TabIndex = 23;
            this.lb_tentb.Text = "Tên:";
            // 
            // tb_loaitb
            // 
            this.tb_loaitb.BackColor = System.Drawing.SystemColors.Window;
            this.tb_loaitb.BorderColor = System.Drawing.Color.Black;
            this.tb_loaitb.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_loaitb.BorderRadius = 5;
            this.tb_loaitb.Bordersize = 2;
            this.tb_loaitb.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_loaitb.ForeColor = System.Drawing.Color.Black;
            this.tb_loaitb.Location = new System.Drawing.Point(403, 108);
            this.tb_loaitb.Margin = new System.Windows.Forms.Padding(4);
            this.tb_loaitb.Multiline = false;
            this.tb_loaitb.Name = "tb_loaitb";
            this.tb_loaitb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_loaitb.PasswordChar = false;
            this.tb_loaitb.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_loaitb.PlaceholderText = "";
            this.tb_loaitb.Size = new System.Drawing.Size(232, 33);
            this.tb_loaitb.TabIndex = 21;
            this.tb_loaitb.Texts = "";
            this.tb_loaitb.UnderlinedStyle = false;
            // 
            // tb_hangtb
            // 
            this.tb_hangtb.BackColor = System.Drawing.SystemColors.Window;
            this.tb_hangtb.BorderColor = System.Drawing.Color.Black;
            this.tb_hangtb.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_hangtb.BorderRadius = 5;
            this.tb_hangtb.Bordersize = 2;
            this.tb_hangtb.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hangtb.ForeColor = System.Drawing.Color.Black;
            this.tb_hangtb.Location = new System.Drawing.Point(403, 190);
            this.tb_hangtb.Margin = new System.Windows.Forms.Padding(4);
            this.tb_hangtb.Multiline = false;
            this.tb_hangtb.Name = "tb_hangtb";
            this.tb_hangtb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_hangtb.PasswordChar = false;
            this.tb_hangtb.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_hangtb.PlaceholderText = "";
            this.tb_hangtb.Size = new System.Drawing.Size(232, 33);
            this.tb_hangtb.TabIndex = 22;
            this.tb_hangtb.Texts = "";
            this.tb_hangtb.UnderlinedStyle = false;
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
            this.tb_tentb.Location = new System.Drawing.Point(403, 67);
            this.tb_tentb.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tentb.Multiline = false;
            this.tb_tentb.Name = "tb_tentb";
            this.tb_tentb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_tentb.PasswordChar = false;
            this.tb_tentb.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_tentb.PlaceholderText = "";
            this.tb_tentb.Size = new System.Drawing.Size(232, 33);
            this.tb_tentb.TabIndex = 20;
            this.tb_tentb.Texts = "";
            this.tb_tentb.UnderlinedStyle = false;
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
            // dtg_TB
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtg_TB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_TB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtg_TB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_TB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_TB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_TB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matb,
            this.tentb,
            this.loai,
            this.soluong,
            this.hang,
            this.gia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_TB.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_TB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_TB.EnableHeadersVisualStyles = false;
            this.dtg_TB.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_TB.Location = new System.Drawing.Point(0, 357);
            this.dtg_TB.Name = "dtg_TB";
            this.dtg_TB.Size = new System.Drawing.Size(884, 284);
            this.dtg_TB.TabIndex = 1;
            // 
            // matb
            // 
            this.matb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.matb.HeaderText = "Mã thiết bị";
            this.matb.Name = "matb";
            // 
            // tentb
            // 
            this.tentb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tentb.HeaderText = "Tên thiết bị";
            this.tentb.Name = "tentb";
            // 
            // loai
            // 
            this.loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loai.HeaderText = "Loại thiết bị";
            this.loai.Name = "loai";
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // hang
            // 
            this.hang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hang.HeaderText = "Hãng sản xuất";
            this.hang.Name = "hang";
            // 
            // gia
            // 
            this.gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            // 
            // ThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 641);
            this.Controls.Add(this.pn_thietbi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThietBi";
            this.Text = "Thiết bị";
            this.pn_thietbi.ResumeLayout(false);
            this.pn_thietbi.PerformLayout();
            this.gb_chucnang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_TB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_thietbi;
        private System.Windows.Forms.DataGridView dtg_TB;
        private System.Windows.Forms.DataGridViewTextBoxColumn matb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentb;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private FontAwesome.Sharp.IconPictureBox pb_anh;
        private System.Windows.Forms.GroupBox gb_chucnang;
        private System.Windows.Forms.Label lb_sltb;
        private System.Windows.Forms.Label lb_loaitb;
        private System.Windows.Forms.Label lb_tentb;
        private CustomTextBox tb_loaitb;
        private CustomTextBox tb_hangtb;
        private CustomTextBox tb_tentb;
        private CustomButton bt_Them;
        private CustomButton bt_xoa;
        private CustomButton bt_sua;
        private CustomTextBox tb_Search;
        private FontAwesome.Sharp.IconButton bt_search;
        private CustomTextBox tb_giatb;
        private CustomTextBox tb_soluongtb;
        private System.Windows.Forms.Label lb_giatb;
        private System.Windows.Forms.Label lb_hangtb;
        private System.Windows.Forms.Label lb_thongtin;
        private System.Windows.Forms.Label lb_danhsach;
    }
}