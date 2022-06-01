namespace Gym_Management.FormPT
{
    partial class DanhSachHoiVien
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
            this.dtg_dshv = new System.Windows.Forms.DataGridView();
            this.mahv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_dshv = new System.Windows.Forms.Label();
            this.pn_dshv = new System.Windows.Forms.Panel();
            this.pn_dshvL = new System.Windows.Forms.Panel();
            this.pn_dshvR = new System.Windows.Forms.Panel();
            this.gb_BMI = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_kg = new System.Windows.Forms.Label();
            this.lb_cm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_BMI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dshv)).BeginInit();
            this.pn_dshv.SuspendLayout();
            this.pn_dshvL.SuspendLayout();
            this.pn_dshvR.SuspendLayout();
            this.gb_BMI.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_dshv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtg_dshv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_dshv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtg_dshv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_dshv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtg_dshv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_dshv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_dshv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_dshv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahv,
            this.hoten,
            this.sdt});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_dshv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_dshv.EnableHeadersVisualStyles = false;
            this.dtg_dshv.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_dshv.Location = new System.Drawing.Point(3, 148);
            this.dtg_dshv.Name = "dtg_dshv";
            this.dtg_dshv.ReadOnly = true;
            this.dtg_dshv.RowHeadersWidth = 51;
            this.dtg_dshv.Size = new System.Drawing.Size(470, 222);
            this.dtg_dshv.TabIndex = 1;
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
            // sdt
            // 
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // lb_dshv
            // 
            this.lb_dshv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_dshv.AutoSize = true;
            this.lb_dshv.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lb_dshv.Location = new System.Drawing.Point(130, 33);
            this.lb_dshv.Name = "lb_dshv";
            this.lb_dshv.Size = new System.Drawing.Size(268, 28);
            this.lb_dshv.TabIndex = 81;
            this.lb_dshv.Text = "Danh sách hội viên quản lý";
            // 
            // pn_dshv
            // 
            this.pn_dshv.Controls.Add(this.pn_dshvR);
            this.pn_dshv.Controls.Add(this.pn_dshvL);
            this.pn_dshv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_dshv.Location = new System.Drawing.Point(0, 0);
            this.pn_dshv.Name = "pn_dshv";
            this.pn_dshv.Size = new System.Drawing.Size(1000, 680);
            this.pn_dshv.TabIndex = 82;
            // 
            // pn_dshvL
            // 
            this.pn_dshvL.Controls.Add(this.dtg_dshv);
            this.pn_dshvL.Controls.Add(this.lb_dshv);
            this.pn_dshvL.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_dshvL.Location = new System.Drawing.Point(0, 0);
            this.pn_dshvL.Name = "pn_dshvL";
            this.pn_dshvL.Size = new System.Drawing.Size(484, 680);
            this.pn_dshvL.TabIndex = 83;
            // 
            // pn_dshvR
            // 
            this.pn_dshvR.Controls.Add(this.gb_BMI);
            this.pn_dshvR.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_dshvR.Location = new System.Drawing.Point(490, 0);
            this.pn_dshvR.Name = "pn_dshvR";
            this.pn_dshvR.Size = new System.Drawing.Size(510, 680);
            this.pn_dshvR.TabIndex = 84;
            // 
            // gb_BMI
            // 
            this.gb_BMI.Controls.Add(this.label16);
            this.gb_BMI.Controls.Add(this.label15);
            this.gb_BMI.Controls.Add(this.label14);
            this.gb_BMI.Controls.Add(this.label11);
            this.gb_BMI.Controls.Add(this.label10);
            this.gb_BMI.Controls.Add(this.label9);
            this.gb_BMI.Controls.Add(this.label8);
            this.gb_BMI.Controls.Add(this.label7);
            this.gb_BMI.Controls.Add(this.label5);
            this.gb_BMI.Controls.Add(this.label6);
            this.gb_BMI.Controls.Add(this.lb_kg);
            this.gb_BMI.Controls.Add(this.lb_cm);
            this.gb_BMI.Controls.Add(this.label4);
            this.gb_BMI.Controls.Add(this.lb_BMI);
            this.gb_BMI.Controls.Add(this.label1);
            this.gb_BMI.Controls.Add(this.label3);
            this.gb_BMI.Controls.Add(this.label12);
            this.gb_BMI.Controls.Add(this.label13);
            this.gb_BMI.Controls.Add(this.label2);
            this.gb_BMI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_BMI.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.gb_BMI.Location = new System.Drawing.Point(20, 53);
            this.gb_BMI.Name = "gb_BMI";
            this.gb_BMI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gb_BMI.Size = new System.Drawing.Size(478, 340);
            this.gb_BMI.TabIndex = 81;
            this.gb_BMI.TabStop = false;
            this.gb_BMI.Text = "Thông số BMI 3 tháng gần đây";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(393, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 28);
            this.label16.TabIndex = 95;
            this.label16.Text = "label16";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(280, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 28);
            this.label15.TabIndex = 94;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(158, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 28);
            this.label14.TabIndex = 93;
            this.label14.Text = "label14";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 28);
            this.label11.TabIndex = 92;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 28);
            this.label10.TabIndex = 91;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 28);
            this.label9.TabIndex = 90;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 28);
            this.label8.TabIndex = 89;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 28);
            this.label7.TabIndex = 88;
            this.label7.Text = "label7";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 28);
            this.label5.TabIndex = 87;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(7, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(459, 2);
            this.label6.TabIndex = 85;
            // 
            // lb_kg
            // 
            this.lb_kg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_kg.AutoSize = true;
            this.lb_kg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kg.Location = new System.Drawing.Point(4, 131);
            this.lb_kg.Name = "lb_kg";
            this.lb_kg.Size = new System.Drawing.Size(75, 16);
            this.lb_kg.TabIndex = 71;
            this.lb_kg.Text = "Khối lượng";
            // 
            // lb_cm
            // 
            this.lb_cm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_cm.AutoSize = true;
            this.lb_cm.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cm.Location = new System.Drawing.Point(2, 196);
            this.lb_cm.Name = "lb_cm";
            this.lb_cm.Size = new System.Drawing.Size(72, 16);
            this.lb_cm.TabIndex = 73;
            this.lb_cm.Text = "Chiều cao";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(4, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(459, 2);
            this.label4.TabIndex = 86;
            // 
            // lb_BMI
            // 
            this.lb_BMI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_BMI.AutoSize = true;
            this.lb_BMI.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BMI.Location = new System.Drawing.Point(2, 262);
            this.lb_BMI.Name = "lb_BMI";
            this.lb_BMI.Size = new System.Drawing.Size(31, 16);
            this.lb_BMI.TabIndex = 72;
            this.lb_BMI.Text = "BMI";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 81;
            this.label1.Text = "Tháng 1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(7, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 2);
            this.label3.TabIndex = 85;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(277, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 26);
            this.label12.TabIndex = 82;
            this.label12.Text = "Tháng 2";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(380, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 26);
            this.label13.TabIndex = 83;
            this.label13.Text = "Tháng 3";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(7, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 2);
            this.label2.TabIndex = 84;
            // 
            // DanhSachHoiVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.pn_dshv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachHoiVien";
            this.Text = "Hội viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dshv)).EndInit();
            this.pn_dshv.ResumeLayout(false);
            this.pn_dshvL.ResumeLayout(false);
            this.pn_dshvL.PerformLayout();
            this.pn_dshvR.ResumeLayout(false);
            this.gb_BMI.ResumeLayout(false);
            this.gb_BMI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_dshv;
        private System.Windows.Forms.Label lb_dshv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.Panel pn_dshv;
        private System.Windows.Forms.Panel pn_dshvL;
        private System.Windows.Forms.Panel pn_dshvR;
        private System.Windows.Forms.GroupBox gb_BMI;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_kg;
        private System.Windows.Forms.Label lb_cm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_BMI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
    }
}