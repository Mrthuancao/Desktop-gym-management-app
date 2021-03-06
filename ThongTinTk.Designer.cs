namespace Gym_Management
{
    partial class ThongTinTk
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
            this.lb_mhv = new System.Windows.Forms.Label();
            this.lb_tenhv = new System.Windows.Forms.Label();
            this.lb_pw = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_themhv = new System.Windows.Forms.GroupBox();
            this.tb_mtk = new Gym_Management.CustomTextBox();
            this.bt_xoahet = new Gym_Management.CustomButton();
            this.bt_sua = new Gym_Management.CustomButton();
            this.bt_Luu = new Gym_Management.CustomButton();
            this.tb_mnv = new Gym_Management.CustomTextBox();
            this.tb_username = new Gym_Management.CustomTextBox();
            this.tb_pass = new Gym_Management.CustomTextBox();
            this.gb_themhv.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_mhv
            // 
            this.lb_mhv.AutoSize = true;
            this.lb_mhv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mhv.ForeColor = System.Drawing.Color.Black;
            this.lb_mhv.Location = new System.Drawing.Point(35, 80);
            this.lb_mhv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mhv.Name = "lb_mhv";
            this.lb_mhv.Size = new System.Drawing.Size(128, 22);
            this.lb_mhv.TabIndex = 57;
            this.lb_mhv.Text = "Mã tài khoản:";
            // 
            // lb_tenhv
            // 
            this.lb_tenhv.AutoSize = true;
            this.lb_tenhv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenhv.ForeColor = System.Drawing.Color.Black;
            this.lb_tenhv.Location = new System.Drawing.Point(35, 149);
            this.lb_tenhv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tenhv.Name = "lb_tenhv";
            this.lb_tenhv.Size = new System.Drawing.Size(110, 22);
            this.lb_tenhv.TabIndex = 58;
            this.lb_tenhv.Text = "User name:";
            // 
            // lb_pw
            // 
            this.lb_pw.AutoSize = true;
            this.lb_pw.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pw.ForeColor = System.Drawing.Color.Black;
            this.lb_pw.Location = new System.Drawing.Point(35, 228);
            this.lb_pw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pw.Name = "lb_pw";
            this.lb_pw.Size = new System.Drawing.Size(98, 22);
            this.lb_pw.TabIndex = 59;
            this.lb_pw.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 60;
            this.label3.Text = "Mã nhân viên:";
            // 
            // gb_themhv
            // 
            this.gb_themhv.BackColor = System.Drawing.Color.Gainsboro;
            this.gb_themhv.Controls.Add(this.tb_mtk);
            this.gb_themhv.Controls.Add(this.bt_xoahet);
            this.gb_themhv.Controls.Add(this.bt_sua);
            this.gb_themhv.Controls.Add(this.bt_Luu);
            this.gb_themhv.Controls.Add(this.label3);
            this.gb_themhv.Controls.Add(this.lb_pw);
            this.gb_themhv.Controls.Add(this.lb_tenhv);
            this.gb_themhv.Controls.Add(this.lb_mhv);
            this.gb_themhv.Controls.Add(this.tb_mnv);
            this.gb_themhv.Controls.Add(this.tb_username);
            this.gb_themhv.Controls.Add(this.tb_pass);
            this.gb_themhv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_themhv.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_themhv.ForeColor = System.Drawing.Color.Red;
            this.gb_themhv.Location = new System.Drawing.Point(0, 0);
            this.gb_themhv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_themhv.Name = "gb_themhv";
            this.gb_themhv.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_themhv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gb_themhv.Size = new System.Drawing.Size(608, 433);
            this.gb_themhv.TabIndex = 3;
            this.gb_themhv.TabStop = false;
            this.gb_themhv.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // tb_mtk
            // 
            this.tb_mtk.BackColor = System.Drawing.SystemColors.Window;
            this.tb_mtk.BorderColor = System.Drawing.Color.Black;
            this.tb_mtk.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_mtk.BorderRadius = 5;
            this.tb_mtk.Bordersize = 2;
            this.tb_mtk.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mtk.ForeColor = System.Drawing.Color.Black;
            this.tb_mtk.Location = new System.Drawing.Point(253, 59);
            this.tb_mtk.Margin = new System.Windows.Forms.Padding(5);
            this.tb_mtk.Multiline = false;
            this.tb_mtk.Name = "tb_mtk";
            this.tb_mtk.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_mtk.PasswordChar = false;
            this.tb_mtk.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_mtk.PlaceholderText = "";
            this.tb_mtk.ReadOnly1 = true;
            this.tb_mtk.Size = new System.Drawing.Size(309, 41);
            this.tb_mtk.TabIndex = 1;
            this.tb_mtk.Texts = "";
            this.tb_mtk.UnderlinedStyle = false;
            // 
            // bt_xoahet
            // 
            this.bt_xoahet.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_xoahet.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.bt_xoahet.BorderColor = System.Drawing.SystemColors.Control;
            this.bt_xoahet.BorderRadius = 15;
            this.bt_xoahet.BorderSize = 0;
            this.bt_xoahet.FlatAppearance.BorderSize = 0;
            this.bt_xoahet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_xoahet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_xoahet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoahet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoahet.ForeColor = System.Drawing.Color.Transparent;
            this.bt_xoahet.Location = new System.Drawing.Point(368, 375);
            this.bt_xoahet.Margin = new System.Windows.Forms.Padding(4);
            this.bt_xoahet.Name = "bt_xoahet";
            this.bt_xoahet.Size = new System.Drawing.Size(93, 33);
            this.bt_xoahet.TabIndex = 63;
            this.bt_xoahet.Text = "Xóa hết";
            this.bt_xoahet.TextColor = System.Drawing.Color.Transparent;
            this.bt_xoahet.UseVisualStyleBackColor = false;
            this.bt_xoahet.Click += new System.EventHandler(this.bt_xoahet_Click);
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
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.Color.Transparent;
            this.bt_sua.Location = new System.Drawing.Point(267, 375);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(4);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(93, 33);
            this.bt_sua.TabIndex = 62;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.TextColor = System.Drawing.Color.Transparent;
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_Luu.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.bt_Luu.BorderColor = System.Drawing.SystemColors.Control;
            this.bt_Luu.BorderRadius = 15;
            this.bt_Luu.BorderSize = 0;
            this.bt_Luu.Enabled = false;
            this.bt_Luu.FlatAppearance.BorderSize = 0;
            this.bt_Luu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.ForeColor = System.Drawing.Color.Transparent;
            this.bt_Luu.Location = new System.Drawing.Point(469, 375);
            this.bt_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(93, 33);
            this.bt_Luu.TabIndex = 61;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.TextColor = System.Drawing.Color.Transparent;
            this.bt_Luu.UseVisualStyleBackColor = false;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // tb_mnv
            // 
            this.tb_mnv.BackColor = System.Drawing.SystemColors.Window;
            this.tb_mnv.BorderColor = System.Drawing.Color.Black;
            this.tb_mnv.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_mnv.BorderRadius = 5;
            this.tb_mnv.Bordersize = 2;
            this.tb_mnv.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mnv.ForeColor = System.Drawing.Color.Black;
            this.tb_mnv.Location = new System.Drawing.Point(253, 284);
            this.tb_mnv.Margin = new System.Windows.Forms.Padding(5);
            this.tb_mnv.Multiline = false;
            this.tb_mnv.Name = "tb_mnv";
            this.tb_mnv.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_mnv.PasswordChar = false;
            this.tb_mnv.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_mnv.PlaceholderText = "";
            this.tb_mnv.ReadOnly1 = true;
            this.tb_mnv.Size = new System.Drawing.Size(309, 41);
            this.tb_mnv.TabIndex = 56;
            this.tb_mnv.Texts = "";
            this.tb_mnv.UnderlinedStyle = false;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.SystemColors.Window;
            this.tb_username.BorderColor = System.Drawing.Color.Black;
            this.tb_username.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_username.BorderRadius = 5;
            this.tb_username.Bordersize = 2;
            this.tb_username.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.Black;
            this.tb_username.Location = new System.Drawing.Point(253, 128);
            this.tb_username.Margin = new System.Windows.Forms.Padding(5);
            this.tb_username.Multiline = false;
            this.tb_username.Name = "tb_username";
            this.tb_username.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_username.PasswordChar = false;
            this.tb_username.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_username.PlaceholderText = "";
            this.tb_username.ReadOnly1 = true;
            this.tb_username.Size = new System.Drawing.Size(309, 41);
            this.tb_username.TabIndex = 55;
            this.tb_username.Texts = "";
            this.tb_username.UnderlinedStyle = false;
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.SystemColors.Window;
            this.tb_pass.BorderColor = System.Drawing.Color.Black;
            this.tb_pass.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_pass.BorderRadius = 5;
            this.tb_pass.Bordersize = 2;
            this.tb_pass.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.ForeColor = System.Drawing.Color.Black;
            this.tb_pass.Location = new System.Drawing.Point(253, 207);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(5);
            this.tb_pass.Multiline = false;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_pass.PasswordChar = false;
            this.tb_pass.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_pass.PlaceholderText = "";
            this.tb_pass.ReadOnly1 = true;
            this.tb_pass.Size = new System.Drawing.Size(309, 41);
            this.tb_pass.TabIndex = 54;
            this.tb_pass.Texts = "";
            this.tb_pass.UnderlinedStyle = false;
            // 
            // ThongTinTk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 433);
            this.Controls.Add(this.gb_themhv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThongTinTk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.gb_themhv.ResumeLayout(false);
            this.gb_themhv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTextBox tb_pass;
        private CustomTextBox tb_username;
        private CustomTextBox tb_mnv;
        private System.Windows.Forms.Label lb_mhv;
        private System.Windows.Forms.Label lb_tenhv;
        private System.Windows.Forms.Label lb_pw;
        private System.Windows.Forms.Label label3;
        private CustomButton bt_Luu;
        private CustomButton bt_sua;
        private CustomButton bt_xoahet;
        private System.Windows.Forms.GroupBox gb_themhv;
        private CustomTextBox tb_mtk;
    }
}