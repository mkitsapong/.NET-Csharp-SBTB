using Guna.UI2.WinForms;
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
    public partial class UC_CustomerRegistration : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
        private void UC_CustomerRegistration_Load(object sender, EventArgs e)
        {
            query = "select * from customer";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoonNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text + "'and roomType  = '" + txtRoomType.Text + "'and booked ='NO'";
            setComboBox(query, txtRoonNo);
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomType.SelectedIndex = -1;
            txtRoonNo.Items.Clear();
            txtPrice.Clear();
        }

        int rid;
        private void txtRoonNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomid from rooms where roomNo = '" + txtRoonNo.Text + "' ";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContact.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtDob.Text != "" && txtIDProof.Text != "" && txtAddress.Text != "" && txtCheckIn.Text != "" && txtPrice.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                String national = txtNationality.Text;
                String gender = txtGender.Text;
                String dob = txtDob.Text;
                String idproof = txtIDProof.Text;
                String addres = txtAddress.Text;
                String checkin = txtCheckIn.Text;

                query = "insert into customer (cname,mobile,nationality,gender,dob,idproof,addres,checkin,roomid) values ('" + name + "'," + mobile + ", '" + national + "','" + gender + "','" + dob + "','" + idproof + "','" + addres + "','" + checkin + "'," + rid + ") update rooms set booked ='YES' where roomNo = '" + txtRoonNo.Text + "'";
                fn.setData(query, "Room No" + txtRoonNo.Text + " Allocation Successful.");
                claerAll();
            }
            else
            {
                MessageBox.Show("All field are madetory.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void claerAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtIDProof.Clear();
            txtAddress.Clear();
            txtCheckIn.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoomType.SelectedIndex = -1;
            txtRoonNo.Items.Clear();
            txtPrice.Clear();
        }

        private void UC_CustomerRegistration_Leave(object sender, EventArgs e)
        {
            claerAll();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Suit Detail", 827, 1170);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("\t\t\t\tสัญญาเช่าห้องพัก", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("\t\t\t-----------------------------------------------------------", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 25));
            e.Graphics.DrawString("\t\t\t\t\t\tเขียนที่ Hotel Del Luna", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 55));
            e.Graphics.DrawString("\t\t\t\t\t\tวันที่   "  + txtCheckIn.Text +"", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 85));
            e.Graphics.DrawString("\t\t\tวันที่เข้าพัก  " + txtCheckIn.Text + " \tห้อง   "+txtRoonNo.Text+"", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 120));
            e.Graphics.DrawString("\tสัญญานี้ทำขึ้นระหว่าง  " +txtName.Text +"\tเลขที่บัตรประชาชน  "+txtIDProof.Text+" ", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 180));
            e.Graphics.DrawString("\tที่อยู่  "+txtAddress.Text+"", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 220));
            e.Graphics.DrawString("\tซึ่งต่อไปในสัญญานี้จะเรียกว่า 'ผู้เช่า' ฝ่ายหนึ่ง กับ นายกฤษพงศ์ เหมือนขวัญ", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 260));
            e.Graphics.DrawString("\tอยู่บ้านเลขที่  56  ตำบล/แขวง  เชิงกลัด  อำเภอ/เขต  บางระจัน จังหวัด  สิงห์บุรี  ", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 300));
            e.Graphics.DrawString("\tซึ่งต่อไปในสัญญาฉบับนี้เรียกว่า   'ผู้ให้เช่า'   อีกฝ่ายหนึ่ง   ทั้งสองฝ่ายตกลงกันมีข้อความดังต่อไปนี้", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 340));

            e.Graphics.DrawString("\t\t(1) ผู้เช่าตกลงเช่าและผู้ให้เช่าตกลงให้เช่าห้องพัก จำนวน 1 ห้อง ในวันที่ทำสัญญาฉบับนี้เป็นต้นไป", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 400));
            e.Graphics.DrawString("\tในราคาเช่าวันละ  "+txtPrice.Text+"  บาท (....................................................................................)", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 430));
            e.Graphics.DrawString("\t\t(2) ผู้เช่าตกลงจ่ายค่าล่วงหน้าในวันทำสัญญา เป็นเงินจำนวน ............................ บาท", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 460));
            e.Graphics.DrawString("\t(....................................................................................)", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 490));
            e.Graphics.DrawString("\t\t(3) ผู้เช่าตกลงที่จะดูแลรักษาห้องที่เช่าให้คงสภาพดีดังเดิมทุกประการ และยินยอมให้ผู้เช่า ", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 520));
            e.Graphics.DrawString("\tหรือผู้ที่ได้รับมอบหมายเข้ามาในห้องที่เช่าได้ตลอดเวลา เพื่อตรวจดูสภาพห้องที่เช่าได้ทุกเวลา ", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 550));
            e.Graphics.DrawString("\tโดยผู้เช่าให้สัญญาว่าจะไม่นำสิ่งผิดกฏหมายเข้ามาในห้องที่เช่า หากผู้ให้เช่่าพบหรือบุคคลอื่นพบสิ่งผิดกฏหมาย", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 580));
            e.Graphics.DrawString("\tผู้เช่าจะยอมผู้ให้เช่าบอกเลิกสัญญาเช่าได้ทันที", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 610));
            e.Graphics.DrawString("\t\t(4) ผู้เช่าตกลงที่จะเช่าเพื่อเป็นที่พักอาศัยเท่านั้น และให้สัญญาว่าจะไม่นำห้องที่เช่าออกให้ผู้อื่นเช่าต่อ", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 640));
            e.Graphics.DrawString("\tเว้นแต่จะได้รับความยินยอมเป็นหนังสือจากผู้ให้เช่า", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 670));
            e.Graphics.DrawString("\t\t(5) หากผู้ให้เช่าผิดสัญญาข้อหนึ่งข้อใด ยอมให้ผู้ให้เช่าบอกเลิกสัญญาเช่าได้ทันที และยอมชดใช้", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 700));
            e.Graphics.DrawString("\tค่าเสียหาย ค่าขาดประโยชน์ตามความเหมาะสมและตามสมควร เท่าที่ผู้ให้เช่าจะเสียหาย", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 730));

            e.Graphics.DrawString("\t\tลงชื่อ..............................................ผู้เช่า \t ลงชื่อ  นายกฤษพงศ์  เหมือนขวัญ  ผู้ให้เช่า", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 850));
            e.Graphics.DrawString("\t\tลงชื่อ..............................................พยาน \t ลงชื่อ..............................................พยาน", new Font("TH SarabunPSK", 16), Brushes.Black, new Point(10, 900));
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCheckIn.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtAddress.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtIDProof.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtContact.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
