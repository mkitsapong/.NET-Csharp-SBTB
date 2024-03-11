using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace loginsql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you to Exit","Exit Program",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opex\Documents\test_sql.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From test_sql where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", con);
                DataTable dt = new DataTable(); 
                sqa.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    using (Form2 frm = new Form2())
                    {
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Please check your Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
        }
    }
}
