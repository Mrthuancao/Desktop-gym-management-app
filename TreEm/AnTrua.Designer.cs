namespace Gym_Management.TreEm
{
    partial class AnTrua
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customTextBox1 = new Gym_Management.CustomTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtg_GT = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaimonan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Dk = new Gym_Management.CustomButton();
            this.customButton1 = new Gym_Management.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_thongtin = new System.Windows.Forms.Label();
            this.tb_MaHV = new Gym_Management.CustomTextBox();
            this.cb_hv = new System.Windows.Forms.ComboBox();
            this.lb_mhv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customButton2 = new Gym_Management.CustomButton();
            this.customTextBox2 = new Gym_Management.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_GT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày:";
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox1.BorderRadius = 0;
            this.customTextBox1.Bordersize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox1.Location = new System.Drawing.Point(87, 33);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.ReadOnly1 = false;
            this.customTextBox1.Size = new System.Drawing.Size(187, 31);
            this.customTextBox1.TabIndex = 2;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(365, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker1.TabIndex = 3;
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
            this.stt,
            this.tenmonan,
            this.loaimonan,
            this.soluong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_GT.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_GT.EnableHeadersVisualStyles = false;
            this.dtg_GT.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_GT.Location = new System.Drawing.Point(2, 109);
            this.dtg_GT.Name = "dtg_GT";
            this.dtg_GT.RowHeadersWidth = 51;
            this.dtg_GT.Size = new System.Drawing.Size(457, 372);
            this.dtg_GT.TabIndex = 23;
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // tenmonan
            // 
            this.tenmonan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenmonan.HeaderText = "Tên món ăn";
            this.tenmonan.Name = "tenmonan";
            // 
            // loaimonan
            // 
            this.loaimonan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaimonan.HeaderText = "Loại món ăn";
            this.loaimonan.Name = "loaimonan";
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
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
            this.bt_Dk.Location = new System.Drawing.Point(474, 156);
            this.bt_Dk.Name = "bt_Dk";
            this.bt_Dk.Size = new System.Drawing.Size(113, 38);
            this.bt_Dk.TabIndex = 24;
            this.bt_Dk.Text = "Thêm món ăn";
            this.bt_Dk.TextColor = System.Drawing.Color.Transparent;
            this.bt_Dk.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.DarkOrange;
            this.customButton1.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.customButton1.BorderColor = System.Drawing.SystemColors.Control;
            this.customButton1.BorderRadius = 15;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.customButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.Transparent;
            this.customButton1.Location = new System.Drawing.Point(474, 286);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(113, 38);
            this.customButton1.TabIndex = 25;
            this.customButton1.Text = "Lưu";
            this.customButton1.TextColor = System.Drawing.Color.Transparent;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.customTextBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_mhv);
            this.panel1.Controls.Add(this.cb_hv);
            this.panel1.Controls.Add(this.tb_MaHV);
            this.panel1.Controls.Add(this.lb_thongtin);
            this.panel1.Location = new System.Drawing.Point(611, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 419);
            this.panel1.TabIndex = 26;
            // 
            // lb_thongtin
            // 
            this.lb_thongtin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_thongtin.AutoSize = true;
            this.lb_thongtin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_thongtin.Location = new System.Drawing.Point(84, 22);
            this.lb_thongtin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_thongtin.Name = "lb_thongtin";
            this.lb_thongtin.Size = new System.Drawing.Size(181, 28);
            this.lb_thongtin.TabIndex = 11;
            this.lb_thongtin.Text = "Thông tin món ăn";
            // 
            // tb_MaHV
            // 
            this.tb_MaHV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_MaHV.BackColor = System.Drawing.SystemColors.Window;
            this.tb_MaHV.BorderColor = System.Drawing.Color.Black;
            this.tb_MaHV.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_MaHV.BorderRadius = 5;
            this.tb_MaHV.Bordersize = 2;
            this.tb_MaHV.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaHV.ForeColor = System.Drawing.Color.Black;
            this.tb_MaHV.Location = new System.Drawing.Point(122, 93);
            this.tb_MaHV.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MaHV.Multiline = false;
            this.tb_MaHV.Name = "tb_MaHV";
            this.tb_MaHV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_MaHV.PasswordChar = false;
            this.tb_MaHV.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_MaHV.PlaceholderText = "Tên món ăn";
            this.tb_MaHV.ReadOnly1 = true;
            this.tb_MaHV.Size = new System.Drawing.Size(164, 33);
            this.tb_MaHV.TabIndex = 12;
            this.tb_MaHV.Texts = "";
            this.tb_MaHV.UnderlinedStyle = false;
            // 
            // cb_hv
            // 
            this.cb_hv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_hv.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_hv.FormattingEnabled = true;
            this.cb_hv.IntegralHeight = false;
            this.cb_hv.ItemHeight = 18;
            this.cb_hv.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cb_hv.Location = new System.Drawing.Point(122, 180);
            this.cb_hv.Name = "cb_hv";
            this.cb_hv.Size = new System.Drawing.Size(164, 26);
            this.cb_hv.TabIndex = 27;
            // 
            // lb_mhv
            // 
            this.lb_mhv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_mhv.AutoSize = true;
            this.lb_mhv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mhv.Location = new System.Drawing.Point(14, 110);
            this.lb_mhv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mhv.Name = "lb_mhv";
            this.lb_mhv.Size = new System.Drawing.Size(91, 16);
            this.lb_mhv.TabIndex = 28;
            this.lb_mhv.Text = "Tên món ăn:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Loại món ăn:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Số lượng:";
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.DarkOrange;
            this.customButton2.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.customButton2.BorderColor = System.Drawing.SystemColors.Control;
            this.customButton2.BorderRadius = 15;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.customButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.Transparent;
            this.customButton2.Location = new System.Drawing.Point(474, 221);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(113, 38);
            this.customButton2.TabIndex = 27;
            this.customButton2.Text = "Sửa món ăn";
            this.customButton2.TextColor = System.Drawing.Color.Transparent;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customTextBox2
            // 
            this.customTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox2.BorderColor = System.Drawing.Color.Black;
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.customTextBox2.BorderRadius = 5;
            this.customTextBox2.Bordersize = 2;
            this.customTextBox2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox2.ForeColor = System.Drawing.Color.Black;
            this.customTextBox2.Location = new System.Drawing.Point(122, 255);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.PlaceholderColor = System.Drawing.Color.Brown;
            this.customTextBox2.PlaceholderText = "Số lượng";
            this.customTextBox2.ReadOnly1 = true;
            this.customTextBox2.Size = new System.Drawing.Size(164, 33);
            this.customTextBox2.TabIndex = 31;
            this.customTextBox2.Texts = "";
            this.customTextBox2.UnderlinedStyle = false;
            // 
            // AnTrua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 494);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.bt_Dk);
            this.Controls.Add(this.dtg_GT);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnTrua";
            this.Text = "Ăn trưa";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_GT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomTextBox customTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dtg_GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonan;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaimonan;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private CustomButton bt_Dk;
        private CustomButton customButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_thongtin;
        private CustomTextBox tb_MaHV;
        private System.Windows.Forms.ComboBox cb_hv;
        private CustomTextBox customTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_mhv;
        private CustomButton customButton2;
    }
}