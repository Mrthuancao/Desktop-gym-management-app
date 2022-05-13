namespace Gym_Management
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.pn_loginr = new System.Windows.Forms.Panel();
            this.lb_exit = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_login = new Gym_Management.CustomButton();
            this.tb_password = new Gym_Management.CustomTextBox();
            this.tb_username = new Gym_Management.CustomTextBox();
            this.pn_loginr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_loginr
            // 
            this.pn_loginr.Controls.Add(this.lb_exit);
            this.pn_loginr.Controls.Add(this.bt_login);
            this.pn_loginr.Controls.Add(this.pictureBox4);
            this.pn_loginr.Controls.Add(this.pictureBox3);
            this.pn_loginr.Controls.Add(this.tb_password);
            this.pn_loginr.Controls.Add(this.tb_username);
            this.pn_loginr.Controls.Add(this.pictureBox2);
            this.pn_loginr.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_loginr.Location = new System.Drawing.Point(486, 0);
            this.pn_loginr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pn_loginr.Name = "pn_loginr";
            this.pn_loginr.Size = new System.Drawing.Size(487, 676);
            this.pn_loginr.TabIndex = 1;
            // 
            // lb_exit
            // 
            this.lb_exit.AutoSize = true;
            this.lb_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_exit.ForeColor = System.Drawing.Color.Red;
            this.lb_exit.Location = new System.Drawing.Point(445, 0);
            this.lb_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_exit.Name = "lb_exit";
            this.lb_exit.Size = new System.Drawing.Size(37, 36);
            this.lb_exit.TabIndex = 7;
            this.lb_exit.Text = "X";
            this.lb_exit.Click += new System.EventHandler(this.lb_exit_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Gym_Management.Properties.Resources.password_login;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(63, 380);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 46);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Gym_Management.Properties.Resources.user_name_login;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(63, 293);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 46);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Gym_Management.Properties.Resources.Fitness_Gym_Dumbbell_Abstract_Logo_Design_Icon_Vector2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(169, 71);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 676);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Gym_Management.Properties.Resources.NO_PAIN_NO_GAIN;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 676);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_login.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.bt_login.BorderColor = System.Drawing.SystemColors.Control;
            this.bt_login.BorderRadius = 15;
            this.bt_login.BorderSize = 0;
            this.bt_login.FlatAppearance.BorderSize = 0;
            this.bt_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.Color.Transparent;
            this.bt_login.Location = new System.Drawing.Point(148, 495);
            this.bt_login.Margin = new System.Windows.Forms.Padding(4);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(260, 62);
            this.bt_login.TabIndex = 6;
            this.bt_login.Text = "Đăng nhập";
            this.bt_login.TextColor = System.Drawing.Color.Transparent;
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.Window;
            this.tb_password.BorderColor = System.Drawing.Color.Black;
            this.tb_password.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.tb_password.BorderRadius = 5;
            this.tb_password.Bordersize = 2;
            this.tb_password.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.Location = new System.Drawing.Point(148, 385);
            this.tb_password.Margin = new System.Windows.Forms.Padding(5);
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_password.PasswordChar = false;
            this.tb_password.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_password.PlaceholderText = "Password";
            this.tb_password.Size = new System.Drawing.Size(309, 41);
            this.tb_password.TabIndex = 3;
            this.tb_password.Texts = "";
            this.tb_password.UnderlinedStyle = false;
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
            this.tb_username.Location = new System.Drawing.Point(148, 298);
            this.tb_username.Margin = new System.Windows.Forms.Padding(5);
            this.tb_username.Multiline = false;
            this.tb_username.Name = "tb_username";
            this.tb_username.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_username.PasswordChar = false;
            this.tb_username.PlaceholderColor = System.Drawing.Color.Brown;
            this.tb_username.PlaceholderText = "User name";
            this.tb_username.Size = new System.Drawing.Size(309, 41);
            this.tb_username.TabIndex = 1;
            this.tb_username.Texts = "";
            this.tb_username.UnderlinedStyle = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(973, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_loginr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.pn_loginr.ResumeLayout(false);
            this.pn_loginr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_loginr;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CustomTextBox tb_password;
        private CustomTextBox tb_username;
        private CustomButton bt_login;
        private System.Windows.Forms.Label lb_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}