namespace Work3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cinemaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinemaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dB1222BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_1666DataSet1 = new Work3.DB_1666DataSet1();
            this.txt_People = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Payment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Seat_Number = new System.Windows.Forms.TextBox();
            this.txt_cinema_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cinema_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dB1222BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_1666DataSet = new Work3.DB_1666DataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dB_1222TableAdapter = new Work3.DB_1666DataSetTableAdapters.DB_1222TableAdapter();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dB_1222TableAdapter1 = new Work3.DB_1666DataSet1TableAdapters.DB_1222TableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB1222BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_1666DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB1222BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_1666DataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Justice Fighters Spaced", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 48);
            this.label1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nithan", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(390, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(342, 83);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cinema Shop";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.txt_People);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_Payment);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_Seat_Number);
            this.panel2.Controls.Add(this.txt_cinema_Name);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_cinema_ID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 547);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cinemaIDDataGridViewTextBoxColumn,
            this.cinemaNameDataGridViewTextBoxColumn,
            this.seatNumberDataGridViewTextBoxColumn,
            this.peopleDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dB1222BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(29, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 176);
            this.dataGridView1.TabIndex = 2;
            // 
            // cinemaIDDataGridViewTextBoxColumn
            // 
            this.cinemaIDDataGridViewTextBoxColumn.DataPropertyName = "CinemaID";
            this.cinemaIDDataGridViewTextBoxColumn.HeaderText = "CinemaID";
            this.cinemaIDDataGridViewTextBoxColumn.Name = "cinemaIDDataGridViewTextBoxColumn";
            // 
            // cinemaNameDataGridViewTextBoxColumn
            // 
            this.cinemaNameDataGridViewTextBoxColumn.DataPropertyName = "CinemaName";
            this.cinemaNameDataGridViewTextBoxColumn.HeaderText = "CinemaName";
            this.cinemaNameDataGridViewTextBoxColumn.Name = "cinemaNameDataGridViewTextBoxColumn";
            // 
            // seatNumberDataGridViewTextBoxColumn
            // 
            this.seatNumberDataGridViewTextBoxColumn.DataPropertyName = "SeatNumber";
            this.seatNumberDataGridViewTextBoxColumn.HeaderText = "SeatNumber";
            this.seatNumberDataGridViewTextBoxColumn.Name = "seatNumberDataGridViewTextBoxColumn";
            // 
            // peopleDataGridViewTextBoxColumn
            // 
            this.peopleDataGridViewTextBoxColumn.DataPropertyName = "People";
            this.peopleDataGridViewTextBoxColumn.HeaderText = "People";
            this.peopleDataGridViewTextBoxColumn.Name = "peopleDataGridViewTextBoxColumn";
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            // 
            // dB1222BindingSource1
            // 
            this.dB1222BindingSource1.DataMember = "DB_1222";
            this.dB1222BindingSource1.DataSource = this.dB_1666DataSet1;
            // 
            // dB_1666DataSet1
            // 
            this.dB_1666DataSet1.DataSetName = "DB_1666DataSet1";
            this.dB_1666DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_People
            // 
            this.txt_People.Font = new System.Drawing.Font("Nithan", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_People.Location = new System.Drawing.Point(283, 225);
            this.txt_People.Name = "txt_People";
            this.txt_People.Size = new System.Drawing.Size(288, 49);
            this.txt_People.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Justice Fighters Spaced", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-313, 488);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 48);
            this.label11.TabIndex = 0;
            this.label11.Text = "C";
            // 
            // txt_Payment
            // 
            this.txt_Payment.Font = new System.Drawing.Font("Nithan", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Payment.Location = new System.Drawing.Point(283, 280);
            this.txt_Payment.Name = "txt_Payment";
            this.txt_Payment.Size = new System.Drawing.Size(288, 49);
            this.txt_Payment.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Justice Fighters Spaced", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-313, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 48);
            this.label9.TabIndex = 0;
            this.label9.Text = "C";
            // 
            // txt_Seat_Number
            // 
            this.txt_Seat_Number.Font = new System.Drawing.Font("Nithan", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Seat_Number.Location = new System.Drawing.Point(283, 168);
            this.txt_Seat_Number.Name = "txt_Seat_Number";
            this.txt_Seat_Number.Size = new System.Drawing.Size(288, 49);
            this.txt_Seat_Number.TabIndex = 0;
            // 
            // txt_cinema_Name
            // 
            this.txt_cinema_Name.Font = new System.Drawing.Font("Nithan", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cinema_Name.Location = new System.Drawing.Point(283, 110);
            this.txt_cinema_Name.Name = "txt_cinema_Name";
            this.txt_cinema_Name.Size = new System.Drawing.Size(288, 49);
            this.txt_cinema_Name.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Justice Fighters Spaced", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-313, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 48);
            this.label7.TabIndex = 0;
            this.label7.Text = "C";
            // 
            // txt_cinema_ID
            // 
            this.txt_cinema_ID.Font = new System.Drawing.Font("Nithan", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cinema_ID.Location = new System.Drawing.Point(283, 53);
            this.txt_cinema_ID.Name = "txt_cinema_ID";
            this.txt_cinema_ID.Size = new System.Drawing.Size(288, 49);
            this.txt_cinema_ID.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Justice Fighters Spaced", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-313, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 48);
            this.label5.TabIndex = 0;
            this.label5.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Justice Fighters Spaced", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-313, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nithan", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 63);
            this.label10.TabIndex = 0;
            this.label10.Text = "Payment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nithan", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 63);
            this.label8.TabIndex = 0;
            this.label8.Text = "People";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nithan", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 63);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seat Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nithan", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 63);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cinema Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nithan", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 63);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cinema ID";
            // 
            // dB1222BindingSource
            // 
            this.dB1222BindingSource.DataMember = "DB_1222";
            this.dB1222BindingSource.DataSource = this.dB_1666DataSet;
            // 
            // dB_1666DataSet
            // 
            this.dB_1666DataSet.DataSetName = "DB_1666DataSet";
            this.dB_1666DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(609, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 71);
            this.panel3.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Nithan", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(2, 1);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(459, 70);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tan;
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Controls.Add(this.btn_View);
            this.panel4.Controls.Add(this.btn_Exit);
            this.panel4.Controls.Add(this.btnReset);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Location = new System.Drawing.Point(609, 196);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(462, 470);
            this.panel4.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Nithan", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(137, 213);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(189, 49);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("Nithan", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.Location = new System.Drawing.Point(53, 375);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(153, 61);
            this.btn_View.TabIndex = 0;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Nithan", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(257, 375);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(153, 61);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Nithan", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(137, 158);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(189, 49);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Nithan", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(137, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 49);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Nithan", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(137, 268);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(189, 49);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Nithan", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(137, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 49);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dB_1222TableAdapter
            // 
            this.dB_1222TableAdapter.ClearBeforeFill = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dB_1222TableAdapter1
            // 
            this.dB_1222TableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1082, 678);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB1222BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_1666DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB1222BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_1666DataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_People;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Payment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Seat_Number;
        private System.Windows.Forms.TextBox txt_cinema_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cinema_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private DB_1666DataSet dB_1666DataSet;
        private System.Windows.Forms.BindingSource dB1222BindingSource;
        private DB_1666DataSetTableAdapters.DB_1222TableAdapter dB_1222TableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_1666DataSet1 dB_1666DataSet1;
        private System.Windows.Forms.BindingSource dB1222BindingSource1;
        private DB_1666DataSet1TableAdapters.DB_1222TableAdapter dB_1222TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinemaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinemaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

