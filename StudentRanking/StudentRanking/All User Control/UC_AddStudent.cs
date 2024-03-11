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

namespace StudentRanking.All_User_Control
{
    public partial class UC_AddStudent : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddStudent()
        {
            InitializeComponent();
        }
        private void BindData()
        {
            SqlConnection con = new SqlConnection("data source = KITSAPONG;database=STUDENTID;integrated security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Information1", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }
        private void UC_AddStudent_Load(object sender, EventArgs e)
        {
            query = "select * from Information1";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtSurname.Text != "" && txtDepartment.Text != ""  && txtClass.Text !=  "" && txt_Room.Text != "")
            {
                Int64 ID = Int64.Parse(txtID.Text);
                String Name = txtName.Text;
                String Surname = txtSurname.Text;
                String Department = txtDepartment.Text;
                String Class = txtClass.Text;
                String Room = txt_Room.Text;

                query = "insert into Information1(ID,Name,Surname,Department,Class,Room) values('" + ID + "','" + Name + "','" + Surname + "','" + Department + "','" + Class + "'," + Room + ")";
                fn.setData(query, "Student Information Added.");

                UC_AddStudent_Load(this, null);
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
            txtDepartment.SelectedIndex = -1;
            txtClass.SelectedIndex = -1;
            txt_Room.SelectedIndex = -1;
        }

        private void UC_AddStudent_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddStudent_Enter(object sender, EventArgs e)
        {
            UC_AddStudent_Load(this,null);
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
                txt_Room.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtID.Enabled = false;
                txtClass.Enabled = false;
                txtDepartment.Enabled = false;
                txt_Room.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter first the student in search box", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("data source = KITSAPONG;database=STUDENTID;integrated security = True");

                    SqlCommand cmd = new SqlCommand("UPDATE Information1 SET Name=@FIRSTNAME,Surname=@LASTNAME,Department=@DEPARTMENT,Class=@CLASS,Room=@ROOM WHERE ID=@ID", con);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@FIRSTNAME", txtName.Text);
                    cmd.Parameters.AddWithValue("@LASTNAME", txtSurname.Text);
                    cmd.Parameters.AddWithValue("@DEPARTMENT", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@CLASS",txtClass.Text);
                    cmd.Parameters.AddWithValue("@ROOM", txt_Room.Text);

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
                    txt_Room.Text = "";
                    txtDepartment.Text = "";
                    txtClass.Text = "";
                    BindData();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtSurname.Enabled = true;
            txtID.Enabled = true;
            txtClass.Enabled = true;
            txtDepartment.Enabled = true;
            txt_Room.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Are You Sure?", "Confirmation...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from Information1 where ID =" + txtID.Text + "";
                    fn.setData(query, "Record Deleted.");
                    UC_AddStudent_Load(this, null);
                }
            }
        }
    }
}
