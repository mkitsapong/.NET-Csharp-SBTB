using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wo1
{
    public partial class Form1 : Form
    {
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                btnClose.Enabled = true;
                btnOn.Enabled = true;
                btnOff.Enabled = true;
                serialPort1.PortName = cbbPort.Text;
                serialPort1.BaudRate = 115200;
                serialPort1.Open();
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                btnOn.Enabled = true;
                btnOff.Enabled = true;
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

        private void btnOn_Click(object sender, EventArgs e)
        {
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
            Application.Exit();
        }
    }
}
