using Guna.UI2.WinForms;
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

namespace studentscore
{
    public partial class UC_ResetScore : UserControl
    {
        SqlConnection con = new SqlConnection("data source = KITSAPONG;database=STUDENTID;integrated security = True");
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private string sql;
        private static UC_ResetScore _instance;
        public static UC_ResetScore Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ResetScore();
                return _instance;
            }
        }
        function fn = new function();
        String query;
        public UC_ResetScore()
        {
            InitializeComponent();
        }

        private void UC_ResetScore_Load(object sender, EventArgs e)
        {
            query = "select * from Information3";
            DataSet dss = fn.getData(query);
            guna2DataGridView1.DataSource = dss.Tables[0];
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            UC_ResetScore_Load(this,null);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtID.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSurname.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDepartment.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtClass.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtList.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtScore.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();


                txtID.Enabled = false;
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtDepartment.Enabled = false;
                txtClass.Enabled = false;
                txtRoom.Enabled = false;
                txtSetscore.Enabled = true;
                txtList.Enabled = false;
                txtScore.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT  * FROM Information3 WHERE ID LIKE '%" + txtSearch.Text + "%' OR Name LIKE '%" + txtSearch.Text + "%' ";
            searchData(sql, guna2DataGridView1);
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
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
                da.Dispose();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtName.Enabled = true;
            txtSurname.Enabled = true;
            txtDepartment.Enabled = true;
            txtClass.Enabled = true;
            txtRoom.Enabled = true;
            txtSetscore.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSearch1.Text == "")
            {
                MessageBox.Show("Please enter first the student in search box", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("data source = KITSAPONG;database=STUDENTID;integrated security = True");

                    SqlCommand cmd = new SqlCommand("UPDATE Information3 SET Name=@FIRSTNAME,Surname=@LASTNAME,Department=@DEPARTMENT,Class=@CLASS,Room=@ROOM,Score=@SCORE,List=@LIST,[Set]=@SETSCORE WHERE ID=@ID", con);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@FIRSTNAME", txtName.Text);
                    cmd.Parameters.AddWithValue("@LASTNAME", txtSurname.Text);
                    cmd.Parameters.AddWithValue("@DEPARTMENT", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@CLASS", txtClass.Text);
                    cmd.Parameters.AddWithValue("@ROOM", txtRoom.Text);
                    cmd.Parameters.AddWithValue("@LIST", txtList.Text);
                    cmd.Parameters.AddWithValue("@SCORE", txtSetscore.Text);
                    cmd.Parameters.AddWithValue("@SETSCORE", txtSetscore.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully updated!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtID.Text = "";
                    txtName.Text = "";
                    txtSurname.Text = "";
                    txtRoom.Text = "";
                    txtDepartment.Text = "";
                    txtClass.Text = "";
                    txtSetscore.Text = "";
                    BindData();
                }
            }
        }
        private void BindData()
        {
            SqlConnection con = new SqlConnection("data source = KITSAPONG;database=STUDENTID;integrated security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Information3", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtSurname.Text != "" && txtDepartment.Text != "" && txtClass.Text != "" && txtRoom.Text != "" && txtList.Text != "" && txtScore.Text != "" && txtSetscore.Text != "")
            {
                String ID = txtID.Text;
                String Name = txtName.Text;
                String Surname = txtSurname.Text;
                String Department = txtDepartment.Text;
                String Class = txtClass.Text;
                String Room = txtRoom.Text;
                String List = txtList.Text;
                String Score = txtScore.Text;
                String Set = txtSetscore.Text;

                query = "insert into Information3(ID,Name,Surname,Department,Class,Room,List,Score,[Set])values('" + ID + "','" + Name + "','" + Surname + "','" + Department + "','" + Class + "','" + Room + "','" + List + "','" + Score + "','" + Set + "')";
                fn.setData(query, "Student Information Added.");
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll()
        {
            txtID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtDepartment.Clear();
            txtClass.Clear();
            txtRoom.Clear();
            txtList.Clear();
            txtScore.Clear();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtSearch1.Text == "")
            {
                MessageBox.Show("Please enter first the student in search box", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("data source = KITSAPONG;database=STUDENTID;integrated security = True");

                    SqlCommand cmd = new SqlCommand("UPDATE Information3 SET Name=@FIRSTNAME,Surname=@LASTNAME,Department=@DEPARTMENT,Class=@CLASS,Room=@ROOM,List=@LIST,Score=@SCORE,[Set]=@SET WHERE ID=@ID", con);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@FIRSTNAME", txtName.Text);
                    cmd.Parameters.AddWithValue("@LASTNAME", txtSurname.Text);
                    cmd.Parameters.AddWithValue("@DEPARTMENT", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@CLASS", txtClass.Text);
                    cmd.Parameters.AddWithValue("@ROOM", txtRoom.Text);
                    cmd.Parameters.AddWithValue("@LIST", txtList.Text);
                    cmd.Parameters.AddWithValue("@SCORE", txtScore.Text);
                    cmd.Parameters.AddWithValue("@SET", txtSetscore.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully updated!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtID.Text = "";
                    txtName.Text = "";
                    txtSurname.Text = "";
                    txtRoom.Text = "";
                    txtDepartment.Text = "";
                    txtClass.Text = "";
                    txtList.Text = "";
                    txtScore.Text = "";
                    BindData();
                }
            }
        }
    }
}
