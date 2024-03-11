namespace Resister
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_1 = new System.Windows.Forms.ComboBox();
            this.cbb_3 = new System.Windows.Forms.ComboBox();
            this.cbb_4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblband3 = new System.Windows.Forms.Panel();
            this.band_4 = new System.Windows.Forms.Panel();
            this.band_2 = new System.Windows.Forms.Panel();
            this.lblband1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_Rvalue = new System.Windows.Forms.TextBox();
            this.txt_Max = new System.Windows.Forms.TextBox();
            this.txt_Min = new System.Windows.Forms.TextBox();
            this.cbb_2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.txt_M = new System.Windows.Forms.TextBox();
            this.txt_Error = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 86);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nithan", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resistor Colour Code Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbb_1
            // 
            this.cbb_1.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_1.FormattingEnabled = true;
            this.cbb_1.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.cbb_1.Location = new System.Drawing.Point(205, 128);
            this.cbb_1.Name = "cbb_1";
            this.cbb_1.Size = new System.Drawing.Size(189, 43);
            this.cbb_1.TabIndex = 1;
            this.cbb_1.SelectedIndexChanged += new System.EventHandler(this.cbb_1_SelectedIndexChanged);
            // 
            // cbb_3
            // 
            this.cbb_3.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_3.FormattingEnabled = true;
            this.cbb_3.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White",
            "Gold",
            "Silver"});
            this.cbb_3.Location = new System.Drawing.Point(205, 240);
            this.cbb_3.Name = "cbb_3";
            this.cbb_3.Size = new System.Drawing.Size(189, 43);
            this.cbb_3.TabIndex = 3;
            this.cbb_3.SelectedIndexChanged += new System.EventHandler(this.cbb_3_SelectedIndexChanged);
            // 
            // cbb_4
            // 
            this.cbb_4.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_4.FormattingEnabled = true;
            this.cbb_4.Items.AddRange(new object[] {
            "Gold",
            "Silver"});
            this.cbb_4.Location = new System.Drawing.Point(205, 294);
            this.cbb_4.Name = "cbb_4";
            this.cbb_4.Size = new System.Drawing.Size(189, 43);
            this.cbb_4.TabIndex = 4;
            this.cbb_4.SelectedIndexChanged += new System.EventHandler(this.cbb_4_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Band";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Second Band";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tird Band";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fourth Band";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resistor Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 35);
            this.label7.TabIndex = 5;
            this.label7.Text = "Max Resistor Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 35);
            this.label8.TabIndex = 5;
            this.label8.Text = "Min Resistor Value";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(488, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 15);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.lblband3);
            this.panel3.Controls.Add(this.band_4);
            this.panel3.Controls.Add(this.band_2);
            this.panel3.Controls.Add(this.lblband1);
            this.panel3.Location = new System.Drawing.Point(592, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 98);
            this.panel3.TabIndex = 7;
            // 
            // lblband3
            // 
            this.lblband3.BackColor = System.Drawing.Color.Black;
            this.lblband3.Location = new System.Drawing.Point(65, 0);
            this.lblband3.Name = "lblband3";
            this.lblband3.Size = new System.Drawing.Size(15, 117);
            this.lblband3.TabIndex = 4;
            // 
            // band_4
            // 
            this.band_4.BackColor = System.Drawing.Color.Black;
            this.band_4.Location = new System.Drawing.Point(136, 0);
            this.band_4.Name = "band_4";
            this.band_4.Size = new System.Drawing.Size(14, 100);
            this.band_4.TabIndex = 3;
            // 
            // band_2
            // 
            this.band_2.BackColor = System.Drawing.Color.Black;
            this.band_2.Location = new System.Drawing.Point(46, 0);
            this.band_2.Name = "band_2";
            this.band_2.Size = new System.Drawing.Size(13, 100);
            this.band_2.TabIndex = 1;
            // 
            // lblband1
            // 
            this.lblband1.BackColor = System.Drawing.Color.Black;
            this.lblband1.Location = new System.Drawing.Point(28, 0);
            this.lblband1.Name = "lblband1";
            this.lblband1.Size = new System.Drawing.Size(12, 117);
            this.lblband1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel8.Location = new System.Drawing.Point(774, 223);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(102, 15);
            this.panel8.TabIndex = 8;
            // 
            // txt_Rvalue
            // 
            this.txt_Rvalue.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Rvalue.Location = new System.Drawing.Point(242, 410);
            this.txt_Rvalue.Name = "txt_Rvalue";
            this.txt_Rvalue.Size = new System.Drawing.Size(152, 43);
            this.txt_Rvalue.TabIndex = 9;
            this.txt_Rvalue.TextChanged += new System.EventHandler(this.txt_Rvalue_TextChanged);
            // 
            // txt_Max
            // 
            this.txt_Max.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Max.Location = new System.Drawing.Point(242, 472);
            this.txt_Max.Name = "txt_Max";
            this.txt_Max.Size = new System.Drawing.Size(152, 43);
            this.txt_Max.TabIndex = 10;
            // 
            // txt_Min
            // 
            this.txt_Min.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Min.Location = new System.Drawing.Point(242, 532);
            this.txt_Min.Name = "txt_Min";
            this.txt_Min.Size = new System.Drawing.Size(152, 43);
            this.txt_Min.TabIndex = 11;
            // 
            // cbb_2
            // 
            this.cbb_2.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_2.FormattingEnabled = true;
            this.cbb_2.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.cbb_2.Location = new System.Drawing.Point(205, 184);
            this.cbb_2.Name = "cbb_2";
            this.cbb_2.Size = new System.Drawing.Size(189, 43);
            this.cbb_2.TabIndex = 2;
            this.cbb_2.SelectedIndexChanged += new System.EventHandler(this.cbb_2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(456, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 35);
            this.label9.TabIndex = 5;
            this.label9.Text = "Resistor Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(456, 480);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 35);
            this.label10.TabIndex = 5;
            this.label10.Text = "Resistor Value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(456, 540);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 35);
            this.label11.TabIndex = 5;
            this.label11.Text = "% Error";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(830, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 35);
            this.label12.TabIndex = 5;
            this.label12.Text = "k Ohm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(830, 480);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 35);
            this.label13.TabIndex = 5;
            this.label13.Text = "M Ohm";
            // 
            // txt_k
            // 
            this.txt_k.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_k.Location = new System.Drawing.Point(638, 410);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(152, 43);
            this.txt_k.TabIndex = 9;
            // 
            // txt_M
            // 
            this.txt_M.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_M.Location = new System.Drawing.Point(638, 472);
            this.txt_M.Name = "txt_M";
            this.txt_M.Size = new System.Drawing.Size(152, 43);
            this.txt_M.TabIndex = 9;
            // 
            // txt_Error
            // 
            this.txt_Error.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Error.Location = new System.Drawing.Point(638, 532);
            this.txt_Error.Name = "txt_Error";
            this.txt_Error.Size = new System.Drawing.Size(152, 43);
            this.txt_Error.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nithan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(824, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::Resister.Properties.Resources._392_3929648_blue_bubble_background_lite_;
            this.ClientSize = new System.Drawing.Size(932, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Min);
            this.Controls.Add(this.txt_Max);
            this.Controls.Add(this.txt_Error);
            this.Controls.Add(this.txt_M);
            this.Controls.Add(this.txt_k);
            this.Controls.Add(this.txt_Rvalue);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_4);
            this.Controls.Add(this.cbb_3);
            this.Controls.Add(this.cbb_2);
            this.Controls.Add(this.cbb_1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resistor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_1;
        private System.Windows.Forms.ComboBox cbb_3;
        private System.Windows.Forms.ComboBox cbb_4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel band_4;
        private System.Windows.Forms.Panel band_2;
        private System.Windows.Forms.Panel lblband1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_Rvalue;
        private System.Windows.Forms.TextBox txt_Max;
        private System.Windows.Forms.TextBox txt_Min;
        private System.Windows.Forms.ComboBox cbb_2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_k;
        private System.Windows.Forms.TextBox txt_M;
        private System.Windows.Forms.TextBox txt_Error;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel lblband3;
    }
}

