using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace PJ3
{
    public partial class Form1 : Form
    {
        int seccond = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cbbPort.Items.AddRange(SerialPort.GetPortNames());
                cbbPort.SelectedIndex = 0;
            }
            catch { }
        }

        private void cbbPort_MouseClick(object sender, MouseEventArgs e)
        {
            cbbPort.Items.Clear();
            try
            {
                cbbPort.Items.AddRange(SerialPort.GetPortNames());
                cbbPort.SelectedIndex = 0;
            }
            catch { }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbbPort.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                btnOn.Enabled = true;
                btnOff.Enabled = true;
                btnOn2.Enabled = true;
                btnOff2.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
            catch { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                btnOn.Enabled = false;
                btnOff.Enabled = false;
                btnOn2.Enabled = false;
                btnOff2.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            catch { }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            seccond = 20;
            countdownTimer.Start();
            try
            {
                serialPort1.Write("A");
            }
            catch { }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("a");
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOn2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("B");
            }
            catch { }
        }

        private void btnOff2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("b");
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("C");
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("c");
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("D");
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("d");
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("E");
            }
            catch { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("e");
            }
            catch { }
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
        }
    }
}

