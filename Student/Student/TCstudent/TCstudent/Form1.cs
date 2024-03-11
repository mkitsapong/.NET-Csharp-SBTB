using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCstudent
{
    public partial class Form1 : Form
    {
            public object Filter { get; private set; }

            public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tC_stidentDataSet11.testtc' table. You can move, or remove it, as needed.
            this.testtcTableAdapter2.Fill(this.tC_stidentDataSet11.testtc);
            testtcBindingSource2.DataSource = this.tC_stidentDataSet11.testtc;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            iDTextBox.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            testtcBindingSource2.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                iDTextBox.Focus();
                panel1.Enabled = true;
                this.tC_stidentDataSet11.testtc.AddtesttcRow(this.tC_stidentDataSet11.testtc.NewtesttcRow());
                testtcBindingSource2.MoveLast();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                testtcBindingSource2.EndEdit();
                testtcTableAdapter2.Update(this.tC_stidentDataSet11.testtc);
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                if (MessageBox.Show("ต้องการลบข้อมูล ?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    testtcBindingSource2.RemoveCurrent();
                }
                else
                {
                    testtcBindingSource2.ResetBindings(false);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using(OpenFileDialog ofd = new OpenFileDialog() { Filter="JPEG|*.jpg"})
                {
                    if (ofd.ShowDialog()== DialogResult.OK)
                    {
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txt_Search.Text))
                    guna2DataGridView1.DataSource = testtcBindingSource2;
                else
                {
                    var query = from result in this.tC_stidentDataSet11.testtc
                                where result.Name.Contains(txt_Search.Text) 
                                select result;
                    guna2DataGridView1.DataSource = query.ToList();
                }
            }
        }

        private void guna2DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
