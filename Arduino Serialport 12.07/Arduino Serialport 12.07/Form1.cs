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

namespace Arduino_Serialport_12._07
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
                cbb_Port.Items.AddRange(SerialPort.GetPortNames());
                cbb_Port.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbb_Port.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                btn_Open.Enabled = false;
                btn_Close.Enabled = true;
                btn_Off.Enabled = true;
                btn_On.Enabled = true;
            }
            catch
            {

            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btn_Open.Enabled = true;
                btn_Close.Enabled = false;
                btn_Off.Enabled = false;
                btn_On.Enabled = false;
            }
            catch
            {

            }
        }

        private void btn_On_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("H");
            }
            catch
            {

            }
        }

        private void btn_Off_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("L");
            }
            catch
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
            Application.Exit();
        }

        private void cbb_Port_MouseClick(object sender, MouseEventArgs e)
        {
            cbb_Port.Items.Clear();
            try
            {
                cbb_Port.Items.AddRange(SerialPort.GetPortNames());
                cbb_Port.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
