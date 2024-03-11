using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        double w;
        double h;
        double t;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database41DataSet.Table_2' table. You can move, or remove it, as needed.
            this.table_2TableAdapter.Fill(this.database41DataSet.Table_2);
            // TODO: This line of code loads data into the 'database41DataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.database41DataSet.Table1);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtWeight.Clear();
            txtHeight.Clear();
            txtBMI.Clear();
            txtBMI.BackColor=Color.White;
            txtWeight.Focus();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            h = double.Parse(txtHeight.Text);
            w = double.Parse(txtWeight.Text);
            t = w / ((h / 100 * (h / 100)));
            txtBMI.Text = string.Format("{0:F}", t);

            if (t <= 18.5)
            {
                txtBMI.BackColor = Color.DarkOliveGreen;
            }
            else if (t <= 22.90)
            {
                txtBMI.BackColor = Color.LightGreen;
            }
            else if (t <= 24.90)
            {
                txtBMI.BackColor = Color.GreenYellow;
            }
            else if (t <= 29.90)
            {
                txtBMI.BackColor = Color.ForestGreen;
            }
            else if (t >= 30.00) 
            {
                txtBMI.BackColor = Color.Yellow;
            }
        }
    }
}
