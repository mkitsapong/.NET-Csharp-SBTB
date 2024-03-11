using System;
using System.Collections;
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
using Guna.UI2.WinForms;
using System.Runtime.CompilerServices;

namespace studentscore
{
    public partial class UC_Print : UserControl
    {
        SqlConnection con = new SqlConnection("data source = KITSAPONG;database=STUDENTID;integrated security = True");
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private string sql;
        private static UC_Print _instance;
        public static UC_Print Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Print();
                return _instance;
            }
        }
        function fn = new function();
        String query;
        public UC_Print()
        {
            InitializeComponent();
        }

        private void UC_Print_Load(object sender, EventArgs e)
        {
            query = "select * from Information3";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

            searchData(sql, guna2DataGridView1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            UC_Print_Load(this, null);
        }
        private void searchData(string sql, DataGridView dgt)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                da = new SqlDataAdapter();
                dt = new DataTable();
                {
                    var withBlock = cmd;
                    withBlock.Connection = con;
                    withBlock.CommandText = sql;
                }
                {
                    var withBlock = da;
                    withBlock.SelectCommand = cmd;
                    withBlock.Fill(dt);
                }
                dgt.DataSource = dt;
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
                da.Dispose();
            }
        }
        
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void fillCombo(string sql,ComboBox cbo)
        {
            try
            {
                con.Open();
                con.Open();
                cmd = new SqlCommand();
                da = new SqlDataAdapter();
                dt = new DataTable();
                {
                    var withBlock = cmd;
                    withBlock.Connection = con;
                    withBlock.CommandText = sql;
                }
                {
                    var withBlock = da;
                    withBlock.SelectCommand = cmd;
                    withBlock.Fill(dt);

                }
                cbo.DataSource = dt;
                cbo.DisplayMember = dt.Columns[1].ColumnName;
                cbo.ValueMember = dt.Columns[0].ColumnName;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
                da.Dispose();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT  * FROM Information3 WHERE ID LIKE '%" + guna2TextBox1.Text + "%' OR Name LIKE '%" + guna2TextBox1.Text + "%' OR Class LIKE '%" + guna2TextBox1.Text + "%' ";
            searchData(sql,guna2DataGridView1);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(guna2DataGridView1.Width, guna2DataGridView1.Height);
            guna2DataGridView1.DrawToBitmap(imagebmp,new Rectangle(0,0,guna2DataGridView1.Width,guna2DataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 0, 0);
        }

        private void benPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
