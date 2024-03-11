using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resister
{
    public partial class Form1 : Form
    {
        private Color[] band1and2 = { Color.Black, Color.Brown, Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Violet, Color.Gray, Color.White };
        private Color[] band3 = { Color.Black, Color.Brown, Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Violet, Color.Gray, Color.White, Color.Gold, Color.Silver };
        private Color[] band4 = { Color.Gold, Color.Silver };
        private int[] digit = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private double[] multiplier = {1,10,100,1000,10000,100000,1000000,10000000, 100000000, 1000000000,0.1,0.01};
        private double[] er = {0.05,0.1};
        private void updateValue()
        {
            if(cbb_1.SelectedIndex >= 0 && cbb_2.SelectedIndex >= 0 && cbb_3.SelectedIndex >= 0 && cbb_4.SelectedIndex >= 0)
            {
                double value = 0;
                value = digit[cbb_1.SelectedIndex] * 10 + digit[cbb_2.SelectedIndex];
                value *= multiplier[cbb_3.SelectedIndex];

                double kilo = value / 1000;
                double mega = value / 1000000;
                double error = (er[cbb_4.SelectedIndex] * 100);
                double min = value - (value * er[cbb_4.SelectedIndex]);
                double max = value + (value * er[cbb_4.SelectedIndex]);

                txt_Rvalue.Text = value.ToString("N2");
                txt_Max.Text = min.ToString("N2");
                txt_Min.Text = max.ToString("N2");
                txt_k.Text = kilo.ToString("N2");
                txt_M.Text = mega.ToString("N2");
                txt_Error.Text = error.ToString("N2");
 
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbb_1.SelectedIndex = 0;
            cbb_2.SelectedIndex = 0;
            cbb_3.SelectedIndex = 0;
            cbb_4.SelectedIndex = 0;
        }

        private void cbb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblband1.BackColor = band1and2[cbb_1.SelectedIndex];
            updateValue();
        }
        private void cbb_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            band_2.BackColor = band1and2[cbb_2.SelectedIndex];
            updateValue();
        }

        private void cbb_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblband3.BackColor = band3[cbb_3.SelectedIndex];
            updateValue();
        }

        private void cbb_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            band_4.BackColor = band4[cbb_4.SelectedIndex];
            updateValue();
        }

        private void txt_Rvalue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
