using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Callculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Display.Clear();
            value = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Display.Text = "0";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Display.Text);
            operation_pressed = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if((Display.Text=="0") || (operation_pressed))
                Display.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            Display.Text = Display.Text + b.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Display.Text = (value + Double.Parse(Display.Text)).ToString();
                    break;
                case "-":
                    Display.Text = (value - Double.Parse(Display.Text)).ToString();
                    break;
                case "*":
                    Display.Text = (value * Double.Parse(Display.Text)).ToString();
                    break;
                case "/":
                    Display.Text = (value / Double.Parse(Display.Text)).ToString();
                    break;
                    default:
                    break;
            }
        }
    }
}
