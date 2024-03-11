using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Linq.Expressions;

namespace work2
{
    public partial class Form2 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\PDOTNET\work2\DB_1611.accdb");

        DataTable dt;
        Bitmap bitmap;
        public Form2()
        {
            InitializeComponent();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you to Exit","Access connent",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_1611DataSet.DB_1234' table. You can move, or remove it, as needed.
            this.dB_1234TableAdapter.Fill(this.dB_1611DataSet.DB_1234);
            dataviewer();
            
        }

        private void btn_Adddata_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into DB_1234(ID,Firstname,Surname,Gender,Address,Tel)values('" + txt_ID.Text + "','" + txt_Firstname.Text + "','" + txt_Surname.Text + "','" + txt_Gender.Text + "','" + txt_Address.Text + "','" + txt_Tel.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Save in Database", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                dataviewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void dataviewer()
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *From DB_1234 ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update DB_1234 set ID='" + txt_ID.Text + "'where Firstname='" + txt_Firstname.Text + "' and Surname='" + txt_Surname.Text + "' ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Update Sussefully", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_View_Click(object sender, EventArgs e)
        {
            dataviewer();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            dataviewer();
            txt_ID.Text = "";
            txt_Firstname.Text = "";
            txt_Surname.Text = "";
            txt_Gender.Text = "";
            txt_Address.Text = "";
            txt_Tel.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_Firstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_Surname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txt_Gender.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txt_Address.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txt_Tel.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *From DB_1234 where Firstname ='"+txt_Search.Text+"' or Surname='"+txt_Search.Text+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                txt_Search.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string query = "Delete From DB_1234 where ID=@ID ";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txt_ID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Updated Sussefully", "Access Contect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataviewer();  
        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}


