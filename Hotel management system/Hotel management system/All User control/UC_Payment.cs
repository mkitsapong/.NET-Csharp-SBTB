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

namespace Hotel_management_system.All_User_control
{
    public partial class UC_Payment : UserControl
    {
        function fn = new function();
        String query;
        public UC_Payment()
        {
            InitializeComponent();
        }
        private void UC_Payment_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            query = "select customer.cid,customer.cname,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,customer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where checkout is not null";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select * from rooms where roomid = '" + txtRoomNumber.Text + "' ";
            DataSet ds = fn.getData(query);
            txtPaidAmount.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomNumber.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtPaidAmount.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Suit Detail", 285, 300);
            printPreviewDialog1.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPPrice.Clear();
            txtPaidAmount.Clear();
            txtRefund.Clear();
            txtRoomNumber.Clear();
            txtRoomDamage.Clear();
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPaidAmount.Text.Length > 0)
                {
                    txtRefund.Text = (Convert.ToInt32(txtPPrice.Text) - Convert.ToInt32(txtAll.Text)).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtRefund.Text = "";
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("\tHotel Del Luna", new Font("Cooper Black", 12), Brushes.Black, new Point(10, 7));
            e.Graphics.DrawString("\t\t062-3420965", new Font("Century Gothic", 8), Brushes.Black, new Point(10, 25));
            e.Graphics.DrawString("\t-----------------------------------------", new Font("Century Gothic", 8), Brushes.Black, new Point(10, 33));
            e.Graphics.DrawString("Date" + lblTime.Text + "\t\t" + lblDate.Text, new Font("Century Gothic", 7), Brushes.Black, new Point(10, 45));
            e.Graphics.DrawString("Name : " + txtName.Text + "\t Room Number :" + txtRoomNumber.Text, new Font("Century Gothic", 6), Brushes.Black, new Point(10, 60));
            e.Graphics.DrawString("\t-----------------------------------------", new Font("Century Gothic", 8), Brushes.Black, new Point(10, 70));
            e.Graphics.DrawString("Price : \t\t\t\t\t\t" + txtPaidAmount.Text, new Font("Century Gothic", 6), Brushes.Black, new Point(10, 90));
            e.Graphics.DrawString("Day : \t\t\t\t\t\t" + txtday.Text, new Font("Century Gothic", 6), Brushes.Black, new Point(10, 100));
            e.Graphics.DrawString("Room Damage : \t\t\t\t" + txtRoomDamage.Text, new Font("Century Gothic", 6), Brushes.Black, new Point(10, 110));
            e.Graphics.DrawString("Price Amount :\t\t\t\t\t" + txtPPrice.Text, new Font("Century Gothic", 6), Brushes.Black, new Point(10, 120));
            e.Graphics.DrawString("Total All : \t\t\t\t\t" + txtAll.Text, new Font("Century Gothic", 6), Brushes.Black, new Point(10, 130));
            e.Graphics.DrawString("\t-----------------------------------------", new Font("Century Gothic", 8), Brushes.Black, new Point(10, 140));
            e.Graphics.DrawString("Refund : \t\t\t\t\t" + txtRefund.Text, new Font("Century Gothic", 6), Brushes.Black, new Point(10, 160));

            e.Graphics.DrawString("\t-----------------------------------------", new Font("Century Gothic", 8), Brushes.Black, new Point(10, 180));
            e.Graphics.DrawString("\tThank you for using the service.", new Font("Century Gothic", 7), Brushes.Black, new Point(10, 200));


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void txtRoomDamage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPaidAmount.Text.Length > 0)
                {
                    txtAll.Text = (Convert.ToInt32(txtRoomDamage.Text) + Convert.ToInt32(txttotal.Text)).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txttotal.Text = "";
            }
        }

        private void txtRoomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Form2 fn = new Form2();
            fn.ShowDialog();
            fn = null;
            this.Show();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtday_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPaidAmount.Text.Length > 0)
                {
                    txttotal.Text = (Convert.ToInt32(txtday.Text) * Convert.ToInt32(txtPaidAmount.Text)).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txttotal.Text = "";
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
 
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text(*.txt)|*.txt|all files(*.*)|*.*";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFile.FileName;
                MessageBox.Show(strfilename);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click_1(object sender, EventArgs e)
        {
         
        }

        private void openToolStripButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text(*.txt)|*.txt|all files(*.*)|*.*";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFile.FileName;
                MessageBox.Show(strfilename);
            }
        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
 
        }

        private void printToolStripButton_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void cutToolStripButton_Click_1(object sender, EventArgs e)
        {
        
        }

        private void copyToolStripButton_Click_1(object sender, EventArgs e)
        {
       
        }

        private void pasteToolStripButton_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
