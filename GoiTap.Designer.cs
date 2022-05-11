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
            this.lb_mhv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_MaHV = new Gym_Management.CustomTextBox();
            this.dtg_GT = new System.Windows.Forms.DataGridView();
            this.sdssd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_goitap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Them = new Gym_Management.CustomButton();
            this.customButton1 = new Gym_Management.CustomButton();
            this.customButton2 = new Gym_Management.CustomButton();
            this.dt_ngsinh = new System.Windows.Forms.DateTimePicker();
            this.gb_goitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_GT)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_goitap
            // 
            this.gb_goitap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_goitap.Controls.Add(this.dt_ngsinh);
            this.gb_goitap.Controls.Add(this.customButton2);
            this.gb_goitap.Controls.Add(this.customButton1);
            this.gb_goitap.Controls.Add(this.bt_Them);
            this.gb_goitap.Controls.Add(this.label2);
            this.gb_goitap.Controls.Add(this.cb_goitap);
            this.gb_goitap.Controls.Add(this.dtg_GT);
            this.gb_goitap.Controls.Add(this.tb_MaHV);
            this.gb_goitap.Controls.Add(this.label1);
            this.gb_goitap.Controls.Add(this.lb_mhv);
            this.gb_goitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_goitap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.gb_goitap.Location = new System.Drawing.Point(0, 0);
            this.gb_goitap.Name = "gb_goitap";
            this.gb_goitap.Size = new System.Drawing.Size(1055, 719);
            this.gb_goitap.TabIndex = 0;
            this.gb_goitap.TabStop = false;
            this.gb_goitap.Text = "Gói tập";
            // 
            // lb_mhv
            // 
            this.lb_mhv.AutoSize = true;
            this.lb_mhv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mhv.Location = new System.Drawing.Point(25, 99);
            this.lb_mhv.Name = "lb_mhv";
            this.lb_mhv.Size = new System.Drawing.Size(88, 16);
            this.lb_mhv.TabIndex = 18;
            this.lb_mhv.Text = "Mã hội viên:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Gói tập:";
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
            this.tb_MaHV.Location = new System.Drawing.Point(195, 82);
            this.tb_MaHV.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MaHV.Multiline = false;
            this.tb_MaHV.Name = "tb_MaHV";
            this.tb_MaHV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_MaHV.PasswordChar = false;
            this.tb_MaHV.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_MaHV.PlaceholderText = "";
            this.tb_MaHV.Size = new System.Drawing.Size(232, 33);
            this.tb_MaHV.TabIndex = 20;
            this.tb_MaHV.Texts = "";
            this.tb_MaHV.UnderlinedStyle = false;
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
            this.helo,
            this.wew,
            this.gt,
            this.sdt,
            this.sdssd});
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
            this.dtg_GT.Location = new System.Drawing.Point(3, 349);
            this.dtg_GT.Name = "dtg_GT";
            this.dtg_GT.Size = new System.Drawing.Size(1049, 367);
            this.dtg_GT.TabIndex = 22;
            // 
            // sdssd
            // 
            this.sdssd.HeaderText = "Ngày hết hạn";
            this.sdssd.Name = "sdssd";
            // 
            // sdt
            // 
            this.sdt.HeaderText = "sdt";
            this.sdt.Name = "sdt";
            // 
            // gt
            // 
            this.gt.HeaderText = "Giới tính";
            this.gt.Name = "gt";
            // 
            // wew
            // 
            this.wew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wew.HeaderText = "Tên hội viên";
            this.wew.Name = "wew";
            // 
            // helo
            // 
            this.helo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.helo.HeaderText = "Mã hội viên";
            this.helo.Name = "helo";
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
            this.cb_goitap.Location = new System.Drawing.Point(195, 173);
            this.cb_goitap.Name = "cb_goitap";
            this.cb_goitap.Size = new System.Drawing.Size(232, 26);
            this.cb_goitap.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ngày hết hạn:";
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
            this.bt_Them.Location = new System.Drawing.Point(822, 168);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(169, 34);
            this.bt_Them.TabIndex = 27;
            this.bt_Them.Text = "Xem gói tập";
            this.bt_Them.TextColor = System.Drawing.Color.Transparent;
            this.bt_Them.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.customButton1.Location = new System.Drawing.Point(197, 249);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(169, 34);
            this.customButton1.TabIndex = 28;
            this.customButton1.Text = "Lọc";
            this.customButton1.TextColor = System.Drawing.Color.Transparent;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.customButton2.Location = new System.Drawing.Point(534, 249);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(169, 34);
            this.customButton2.TabIndex = 29;
            this.customButton2.Text = "Gia hạn";
            this.customButton2.TextColor = System.Drawing.Color.Transparent;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // dt_ngsinh
            // 
            this.dt_ngsinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_ngsinh.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngsinh.CalendarForeColor = System.Drawing.Color.Black;
            this.dt_ngsinh.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dt_ngsinh.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dt_ngsinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngsinh.Location = new System.Drawing.Point(534, 175);
            this.dt_ngsinh.Name = "dt_ngsinh";
            this.dt_ngsinh.Size = new System.Drawing.Size(232, 26);
            this.dt_ngsinh.TabIndex = 30;
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
            ((System.ComponentModel.ISupportInitialize)(this.dtg_GT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_goitap;
        public System.Windows.Forms.DateTimePicker dt_ngsinh;
        private CustomButton customButton2;
        private CustomButton customButton1;
        private CustomButton bt_Them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_goitap;
        private System.Windows.Forms.DataGridView dtg_GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn helo;
        private System.Windows.Forms.DataGridViewTextBoxColumn wew;
        private System.Windows.Forms.DataGridViewTextBoxColumn gt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdssd;
        private CustomTextBox tb_MaHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_mhv;
    }
}