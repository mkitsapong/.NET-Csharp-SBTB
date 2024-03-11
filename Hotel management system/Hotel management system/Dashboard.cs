using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_management_system
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
            
        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_AddRooM1.Visible = true;
            uC_AddRooM1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Employee1.Visible = false;
            uC_AddRooM1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            btnAddRoom.PerformClick();
           // Form1 f1 = new Form1();
          //  this.Hide();
           // f1.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
        customerDetails1.Visible = true;
            customerDetails1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            uC_Payment1.Visible = true;
            uC_Payment1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void uC_Employee1_Load(object sender, EventArgs e)
        {

        }
    }
}
