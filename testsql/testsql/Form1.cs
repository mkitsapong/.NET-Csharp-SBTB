using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testsql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PDOTNET\testsql\test_sql.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From test_SQL where username ='"+textBox1.Text+"' and password = '"+textBox2.Text+"'",con);
            DataTable dt = new DataTable(); sqa.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1"){using (Form3 frm = new Form3()) { frm.ShowDialog(); }
            }
            else
            {
                MessageBox.Show("Please Check your Username And Password","Error",MessageBoxButtons.YesNo,MessageBoxIcon.Error) ;
                textBox2.Clear();
                textBox2.Focus();
            }
        }
    }
}
