namespace Gym_Management.FormPT
{
    partial class EventForm
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
            this.dt_ngay = new System.Windows.Forms.DateTimePicker();
            this.cb_buoi = new System.Windows.Forms.ComboBox();
            this.cb_mdk = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_madk = new System.Windows.Forms.Label();
            this.bt_xoa = new Gym_Management.CustomButton();
            this.tb_tenhv = new Gym_Management.CustomTextBox();
            this.bt_them = new Gym_Management.CustomButton();
            this.tb_ngay = new Gym_Management.CustomTextBox();
            this.dtg_bt = new System.Windows.Forms.DataGridView();
            this.madk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bt)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_ngay
            // 
            this.dt_ngay.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngay.CalendarForeColor = System.Drawing.Color.Black;
            this.dt_ngay.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngay.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngay.Enabled = false;
            this.dt_ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngay.Location = new System.Drawing.Point(594, 192);
            this.dt_ngay.Name = "dt_ngay";
            this.dt_ngay.Size = new System.Drawing.Size(165, 26);
            this.dt_ngay.TabIndex = 93;
            // 
            // cb_buoi
            // 
            this.cb_buoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_buoi.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_buoi.FormattingEnabled = true;
            this.cb_buoi.IntegralHeight = false;
            this.cb_buoi.ItemHeight = 18;
            this.cb_buoi.Items.AddRange(new object[] {
            "sáng",
            "chiều",
            "tối"});
            this.cb_buoi.Location = new System.Drawing.Point(594, 239);
            this.cb_buoi.Name = "cb_buoi";
            this.cb_buoi.Size = new System.Drawing.Size(165, 26);
            this.cb_buoi.TabIndex = 92;
            // 
            // cb_mdk
            // 
            this.cb_mdk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_mdk.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_mdk.FormattingEnabled = true;
            this.cb_mdk.IntegralHeight = false;
            this.cb_mdk.ItemHeight = 18;
            this.cb_mdk.Location = new System.Drawing.Point(594, 87);
            this.cb_mdk.Name = "cb_mdk";
            this.cb_mdk.Size = new System.Drawing.Size(165, 26);
            this.cb_mdk.TabIndex = 91;
            this.cb_mdk.SelectedIndexChanged += new System.EventHandler(this.cb_mdk_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 89;
            this.label3.Text = "Thời gian:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 87;
            this.label2.Text = "Buổi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "Tên hội viên:";
            // 
            // lb_madk
            // 
            this.lb_madk.AutoSize = true;
            this.lb_madk.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_madk.Location = new System.Drawing.Point(475, 97);
            this.lb_madk.Name = "lb_madk";
            this.lb_madk.Size = new System.Drawing.Size(84, 16);
            this.lb_madk.TabIndex = 85;
            this.lb_madk.Text = "Mã đăng kí:";
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
            this.bt_xoa.Location = new System.Drawing.Point(677, 294);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(82, 34);
            this.bt_xoa.TabIndex = 90;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextColor = System.Drawing.Color.Transparent;
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // tb_tenhv
            // 
            this.tb_tenhv.BackColor = System.Drawing.SystemColors.Window;
            this.tb_tenhv.BorderColor = System.Drawing.Color.Black;
            this.tb_tenhv.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_tenhv.BorderRadius = 5;
            this.tb_tenhv.Bordersize = 2;
            this.tb_tenhv.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenhv.ForeColor = System.Drawing.Color.Black;
            this.tb_tenhv.Location = new System.Drawing.Point(594, 134);
            this.tb_tenhv.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tenhv.Multiline = false;
            this.tb_tenhv.Name = "tb_tenhv";
            this.tb_tenhv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_tenhv.PasswordChar = false;
            this.tb_tenhv.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_tenhv.PlaceholderText = "";
            this.tb_tenhv.ReadOnly1 = false;
            this.tb_tenhv.Size = new System.Drawing.Size(165, 33);
            this.tb_tenhv.TabIndex = 88;
            this.tb_tenhv.Texts = "";
            this.tb_tenhv.UnderlinedStyle = false;
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_them.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.bt_them.BorderColor = System.Drawing.SystemColors.Control;
            this.bt_them.BorderRadius = 15;
            this.bt_them.BorderSize = 0;
            this.bt_them.FlatAppearance.BorderSize = 0;
            this.bt_them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.Transparent;
            this.bt_them.Location = new System.Drawing.Point(589, 294);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(82, 34);
            this.bt_them.TabIndex = 84;
            this.bt_them.Text = "Thêm";
            this.bt_them.TextColor = System.Drawing.Color.Transparent;
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // tb_ngay
            // 
            this.tb_ngay.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_ngay.BorderColor = System.Drawing.SystemColors.ControlText;
            this.tb_ngay.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_ngay.BorderRadius = 5;
            this.tb_ngay.Bordersize = 2;
            this.tb_ngay.Enabled = false;
            this.tb_ngay.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ngay.ForeColor = System.Drawing.Color.Red;
            this.tb_ngay.Location = new System.Drawing.Point(295, 13);
            this.tb_ngay.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ngay.Multiline = false;
            this.tb_ngay.Name = "tb_ngay";
            this.tb_ngay.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_ngay.PasswordChar = false;
            this.tb_ngay.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_ngay.PlaceholderText = "";
            this.tb_ngay.ReadOnly1 = false;
            this.tb_ngay.Size = new System.Drawing.Size(205, 39);
            this.tb_ngay.TabIndex = 4;
            this.tb_ngay.Texts = "";
            this.tb_ngay.UnderlinedStyle = false;
            // 
            // dtg_bt
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtg_bt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtg_bt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_bt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtg_bt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_bt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_bt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_bt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madk,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.buoi,
            this.thoigian});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_bt.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_bt.EnableHeadersVisualStyles = false;
            this.dtg_bt.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_bt.Location = new System.Drawing.Point(1, 87);
            this.dtg_bt.Name = "dtg_bt";
            this.dtg_bt.ReadOnly = true;
            this.dtg_bt.RowHeadersWidth = 51;
            this.dtg_bt.Size = new System.Drawing.Size(443, 260);
            this.dtg_bt.TabIndex = 94;
            // 
            // madk
            // 
            this.madk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.madk.DataPropertyName = "madk";
            this.madk.HeaderText = "Mã đăng ký";
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ và tên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // buoi
            // 
            this.buoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buoi.DataPropertyName = "buoi";
            this.buoi.HeaderText = "Buổi";
            this.buoi.Name = "buoi";
            this.buoi.ReadOnly = true;
            // 
            // thoigian
            // 
            this.thoigian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thoigian.DataPropertyName = "thoigian";
            this.thoigian.HeaderText = "Thời gian";
            this.thoigian.Name = "thoigian";
            this.thoigian.ReadOnly = true;
            this.thoigian.Visible = false;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 348);
            this.Controls.Add(this.dtg_bt);
            this.Controls.Add(this.dt_ngay);
            this.Controls.Add(this.cb_buoi);
            this.Controls.Add(this.cb_mdk);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_tenhv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_madk);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tb_ngay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch trình ngày";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTextBox tb_ngay;
        public System.Windows.Forms.DateTimePicker dt_ngay;
        private System.Windows.Forms.ComboBox cb_buoi;
        private System.Windows.Forms.ComboBox cb_mdk;
        private CustomButton bt_xoa;
        private System.Windows.Forms.Label label3;
        private CustomTextBox tb_tenhv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_madk;
        private CustomButton bt_them;
        private System.Windows.Forms.DataGridView dtg_bt;
        private System.Windows.Forms.DataGridViewTextBoxColumn madk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn buoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigian;
    }
}