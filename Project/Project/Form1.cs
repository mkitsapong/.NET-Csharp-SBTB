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

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("H");
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("L");
            }
            catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void BtnOpen_Click(object sender, EventArgs e)
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
            }
            catch { }
        }

        private void cbbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPort.Items.Clear();
            try
            {
                cbbPort.Items.AddRange(SerialPort.GetPortNames());
                cbbPort.SelectedIndex = 0;
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
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
            Application.Exit();
        }
    }
}

    
    

