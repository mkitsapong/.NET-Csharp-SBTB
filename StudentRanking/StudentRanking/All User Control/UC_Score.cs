using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace StudentRanking.All_User_Control
{
    public partial class UC_Score : UserControl
    {
        function fn = new function();
        String query;
        public UC_Score()
        {
            InitializeComponent();
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
            }
        }

        private void UC_Score_Load(object sender, EventArgs e)
        {
            query = "select * from Information1";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

            UC_Score_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void UC_Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtSurname.Text != "" && txtDepartment.Text != "" && txtClass.Text != "" && txtRoom.Text != "" && txtList.Text != "" && txtScore.Text != "")
            {
                String ID =txtID.Text;
                String Name = txtName.Text;
                String Surname = txtSurname.Text;
                String Department = txtDepartment.Text;
                String Class = txtClass.Text;
                String Room = txtRoom.Text;
                String List = txtList.Text;
                String Score = txtScore.Text;

                query = "insert into Information3(ID,Name,Surname,Department,Class,Room,List,Score) values('" + ID + "','" + Name + "','" + Surname + "','" + Department + "','" + Class + "'," + Room + "'," + List + "'," + Score +  ")";
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
            }
    }
}

