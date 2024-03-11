using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_management_system.All_User_control
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        string query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSET.Text = (num + 1).ToString();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtName.Text !="" && txtMobile.Text !="" && txtGrnder.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGrnder.Text;
                String email = txtEmail.Text;
                String username = txtUsername.Text;
                String pass = txtPassword.Text;

                query = "insert into employee (ename,mobile,gender,emailid,username,pass) values('"+name+"',"+mobile+",'"+gender+"','"+email+"','"+username+"','"+pass+"')";
                fn.setData(query, "Employee Registered.");

                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Fill all Fields.", "Warning...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGrnder.SelectedIndex = -1;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void rabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rabEmployee.SelectedIndex == 1)
            {
                setEmplooyee(guna2DataGridView1);
            }
            else if(rabEmployee.SelectedIndex == 2)
            {
                setEmplooyee(guna2DataGridView2);
            }
        }
        public void setEmplooyee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Are You Sure?", "Confirmation...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid =" + txtID.Text + "";
                    fn.setData(query, "Record Deleted.");
                    rabEmployee_SelectedIndexChanged(this, null);

                }
            }
        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void labelToSET_Click(object sender, EventArgs e)
        {

        }
    }
}
