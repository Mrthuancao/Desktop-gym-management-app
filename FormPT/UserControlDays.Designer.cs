namespace Gym_Management.FormPT
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_days = new System.Windows.Forms.Label();
            this.lb_htsl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb_days
            // 
            this.lb_days.AutoSize = true;
            this.lb_days.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_days.Location = new System.Drawing.Point(16, 13);
            this.lb_days.Name = "lb_days";
            this.lb_days.Size = new System.Drawing.Size(28, 21);
            this.lb_days.TabIndex = 0;
            this.lb_days.Text = "00";
            // 
            // lb_htsl
            // 
            this.lb_htsl.AutoSize = true;
            this.lb_htsl.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_htsl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_htsl.Location = new System.Drawing.Point(54, 40);
            this.lb_htsl.Name = "lb_htsl";
            this.lb_htsl.Size = new System.Drawing.Size(0, 26);
            this.lb_htsl.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_htsl);
            this.Controls.Add(this.lb_days);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(132, 78);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_days;
        private System.Windows.Forms.Label lb_htsl;
        private System.Windows.Forms.Timer timer1;
    }
}
