using Guna.UI2.WinForms.Suite;
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
    public partial class UC_CustomerCheckOut : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerCheckOut()
        {
            InitializeComponent();
            txtCheckOutDate.MinDate = DateTime.Today;
            txtCheckOutDate.MaxDate = DateTime.Today.AddYears(1);
        }

        private void UC_CustomerCheckOut_Load(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,customer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where checkout is not null";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
                
        }

        private void txtMName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where cname like '" + txtMName.Text+"%' and chekout = 'NO'";
            DataSet ds =fn.getData(query);
            guna2DataGridView1.DataSource=ds.Tables[0];
        }
        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void txtRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(txtCName.Text != "")
            {
                if (MessageBox.Show("Are You Sure?", "Comfirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    String cdate = txtCheckOutDate.Text;
                    query = "update customer set chekout = 'YES',checkout='" + cdate + "' where cid = " + id + "update rooms set booked = 'NO' where roomNo = '" + txtRoom.Text+ "'";
                    fn.setData(query, "Check Out Successfully.");
                    UC_CustomerCheckOut_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("No Customer Selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtCName.Clear();
            txtMName.Clear();
            txtRoom.Clear();
            txtCheckOutDate.ResetText();
        }

        private void UC_CustomerCheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txtCheckOutDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
