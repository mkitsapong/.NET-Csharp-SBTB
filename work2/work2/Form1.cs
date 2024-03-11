using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace work2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] Username = { "Kitsapong1", "Kitsapong2", "Kitsapong3", "Kitsapong4", "Kitsapong5" };
            String[] Password= { "1111", "2222", "3333", "4444", "5555" };
            Form2 f2 = new Form2();
            if (Username.Contains(txt_Username.Text) && Password.Contains(txt_Password.Text))
            {
                f2.ShowDialog();
                txt_Username.Text = "";
                txt_Password.Text = "";
            }
            else
            {
                txt_Username.Clear();
                txt_Password.Text = "";
                txt_Username.Focus();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

