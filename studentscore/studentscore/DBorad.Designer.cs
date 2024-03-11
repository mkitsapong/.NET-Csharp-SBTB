namespace studentscore
{
    partial class DBorad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBorad));
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnScore = new Guna.UI2.WinForms.Guna2Button();
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.uC_ResetScore1 = new studentscore.UC_ResetScore();
            this.uC_Print1 = new studentscore.UC_Print();
            this.uC_SC1 = new studentscore.UC_SC();
            this.uC_AddStudent1 = new studentscore.UC_AddStudent();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(453, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(225, 87);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Students";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnScore
            // 
            this.btnScore.BorderRadius = 20;
            this.btnScore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnScore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.White;
            this.btnScore.Location = new System.Drawing.Point(684, 37);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(225, 87);
            this.btnScore.TabIndex = 1;
            this.btnScore.Text = "Score";
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnReport
            // 
            this.btnReport.BorderRadius = 20;
            this.btnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(1146, 37);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(225, 87);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(915, 37);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(225, 87);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Reset Score";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.FillColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1837, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(45, 45);
            this.btnExit.TabIndex = 8;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // uC_ResetScore1
            // 
            this.uC_ResetScore1.BackColor = System.Drawing.Color.White;
            this.uC_ResetScore1.Location = new System.Drawing.Point(284, 153);
            this.uC_ResetScore1.Name = "uC_ResetScore1";
            this.uC_ResetScore1.Size = new System.Drawing.Size(1305, 1023);
            this.uC_ResetScore1.TabIndex = 13;
            this.uC_ResetScore1.Load += new System.EventHandler(this.uC_ResetScore1_Load);
            // 
            // uC_Print1
            // 
            this.uC_Print1.BackColor = System.Drawing.Color.White;
            this.uC_Print1.Location = new System.Drawing.Point(284, 153);
            this.uC_Print1.Name = "uC_Print1";
            this.uC_Print1.Size = new System.Drawing.Size(1350, 1023);
            this.uC_Print1.TabIndex = 11;
            // 
            // uC_SC1
            // 
            this.uC_SC1.BackColor = System.Drawing.Color.White;
            this.uC_SC1.Location = new System.Drawing.Point(284, 153);
            this.uC_SC1.Name = "uC_SC1";
            this.uC_SC1.Size = new System.Drawing.Size(1350, 1023);
            this.uC_SC1.TabIndex = 10;
            // 
            // uC_AddStudent1
            // 
            this.uC_AddStudent1.BackColor = System.Drawing.Color.White;
            this.uC_AddStudent1.Location = new System.Drawing.Point(284, 153);
            this.uC_AddStudent1.Name = "uC_AddStudent1";
            this.uC_AddStudent1.Size = new System.Drawing.Size(1350, 1023);
            this.uC_AddStudent1.TabIndex = 9;
            // 
            // DBorad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1894, 989);
            this.Controls.Add(this.uC_ResetScore1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.uC_Print1);
            this.Controls.Add(this.uC_SC1);
            this.Controls.Add(this.uC_AddStudent1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DBorad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBorad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DBorad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnScore;
        private Guna.UI2.WinForms.Guna2Button btnReport;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private UC_AddStudent uC_AddStudent1;
        private UC_SC uC_SC1;
        private UC_Print uC_Print1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private UC_ResetScore uC_ResetScore1;
    }
}