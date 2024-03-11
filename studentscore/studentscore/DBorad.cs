using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace studentscore
{
    public partial class DBorad : Form
    {
      
        public DBorad()
        {
            InitializeComponent();
        }

        private void DBorad_Load(object sender, EventArgs e)
        {
            uC_AddStudent1.BringToFront();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uC_AddStudent1.Visible = true;
            uC_AddStudent1.BringToFront();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            uC_SC1.Visible = true;
            uC_SC1.BringToFront();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            uC_Print1.Visible = true;
            uC_Print1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_ResetScore1.Visible = true;
            uC_ResetScore1.BringToFront();
        }

        private void uC_ResetScore1_Load(object sender, EventArgs e)
        {

        }
    }
}