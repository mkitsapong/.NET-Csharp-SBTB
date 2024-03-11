using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Testdotnet
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\PDOTNET\Testdotnet\Testdotnet\Database61.accdb");

        DataTable dt;
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database61DataSet.WaterStore' table. You can move, or remove it, as needed.
            this.waterStoreTableAdapter.Fill(this.database61DataSet.WaterStore);
            waterStoreBindingSource.DataSource = this.database61DataSet.WaterStore;

            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            panel3.Enabled = false;
            panel5.Enabled = false;
            panel4.Enabled = false;
            panel6.Enabled = false;

            txtAquafina.Text = "0";
            txtAura.Text = "0";
            txtChang.Text = "0";
            txtCrystal.Text = "0";
            txtEvian.Text = "0";
            txtMinere.Text = "0";
            txtMontFleur.Text = "0";
            txtNestle.Text = "0";
            txtSingha.Text = "0";
            txtSprinkle.Text = "0";

            txtAquafina.Enabled = false;
            txtAura.Enabled = false;
            txtChang.Enabled = false;
            txtCrystal.Enabled = false;
            txtEvian.Enabled = false;
            txtMinere.Enabled = false;
            txtMontFleur.Enabled = false;
            txtNestle.Enabled = false;
            txtSingha.Enabled = false;
            txtSprinkle.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you to exit", "Test .NET", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            if (txtUsername.Text == "Kitsapong" && txtPassword.Text == "Password")
            {
                panel3.Enabled = true;
                panel5.Enabled = true;
                panel6.Enabled = true;
                panel4.Enabled = true;
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                lblError.Visible = true;
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSprinkle.Checked == true)
            {
                txtSprinkle.Enabled = true;
            }
            if (cbSprinkle.Checked == false)
            {
                txtSprinkle.Enabled = false;
                txtSprinkle.Text = "0";
            }
        }

        private void cbSingha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSingha.Checked == true)
            {
                txtSingha.Enabled = true;
            }
            if (cbSingha.Checked == false)
            {
                txtSingha.Enabled = false;
                txtSingha.Text = "0";
            }
        }

        private void cbNestle_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNestle.Checked == true)
            {
                txtNestle.Enabled = true;
            }
            if (cbNestle.Checked == false)
            {
                txtNestle.Enabled = false;
                txtNestle.Text = "0";
            }
        }

        private void cbMontFleur_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMontFleur.Checked == true)
            {
                txtMontFleur.Enabled = true;
            }
            if (cbMontFleur.Checked == false)
            {
                txtMontFleur.Enabled = false;
                txtMontFleur.Text = "0";
            }
        }

        private void cbEvian_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEvian.Checked == true)
            {
                txtEvian.Enabled = true;
            }
            if (cbEvian.Checked == false)
            {
                txtEvian.Enabled = false;
                txtEvian.Text = "0";
            }
        }

        private void cbCrystal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCrystal.Checked == true)
            {
                txtCrystal.Enabled = true;
            }
            if (cbCrystal.Checked == false)
            {
                txtCrystal.Enabled = false;
                txtCrystal.Text = "0";
            }
        }

        private void cbChang_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChang.Checked == true)
            {
                txtChang.Enabled = true;
            }
            if (cbChang.Checked == false)
            {
                txtChang.Enabled = false;
                txtChang.Text = "0";
            }
        }

        private void cbAura_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAura.Checked == true)
            {
                txtAura.Enabled = true;
            }
            if (cbAura.Checked == false)
            {
                txtAura.Enabled = false;
                txtAura.Text = "0";
            }
        }

        private void cbMinere_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMinere.Checked == true)
            {
                txtMinere.Enabled = true;
            }
            if (cbMinere.Checked == false)
            {
                txtMinere.Enabled = false;
                txtMinere.Text = "0";
            }
        }

        private void cbAquafina_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAquafina.Checked == true)
            {
                txtAquafina.Enabled = true;
            }
            if (cbAquafina.Checked == false)
            {
                txtAquafina.Enabled = false;
                txtAquafina.Text = "0";
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            double tax;
            tax = 7;
            double service;
            service = 5;
            double singha, nestle, montfleur, evian, sprinkle, crystal, chang, aura, minere, aquafina;
            singha = 9; nestle = 7; montfleur = 10; evian = 42; sprinkle = 7; crystal = 6; chang = 7; aura = 12; minere = 10; aquafina = 7;
            double Singha_Fresh = Convert.ToDouble(txtSingha.Text);
            double Nestle_Fresh = Convert.ToDouble(txtNestle.Text);
            double MontFleur_Fresh = Convert.ToDouble(txtMontFleur.Text);
            double Evian_Fresh = Convert.ToDouble(txtEvian.Text);
            double Sprinkle_Fresh = Convert.ToDouble(txtSprinkle.Text);
            double Crystal_Fresh = Convert.ToDouble(txtCrystal.Text);
            double Chang_Fresh = Convert.ToDouble(txtChang.Text);
            double Aura_Fresh = Convert.ToDouble(txtAura.Text);
            double Minere_Fresh = Convert.ToDouble(txtMinere.Text);
            double Aquafina_Fresh = Convert.ToDouble(txtAquafina.Text);

            double cost_of_drinks = (singha * Singha_Fresh) + (nestle * Nestle_Fresh) + (montfleur * MontFleur_Fresh) + (evian * Evian_Fresh) +
                (sprinkle * Sprinkle_Fresh) + (crystal * Crystal_Fresh) + (chang * Chang_Fresh) + (aura * Aura_Fresh) + (minere * Minere_Fresh) + (aquafina * Aquafina_Fresh);
            txtCost.Text = Convert.ToString(cost_of_drinks);

            double service_charge = Convert.ToInt16(((cost_of_drinks) * service) / 100);
            txtService.Text = Convert.ToString(service_charge);

            double tax_ja = Convert.ToInt16(((cost_of_drinks + service_charge) * tax) / 100);
            txtTax.Text = Convert.ToString(tax_ja);

            txtTotal.Text = Convert.ToString(cost_of_drinks + tax_ja + service_charge);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            txtAquafina.Text = "0";
            txtAura.Text = "0";
            txtChang.Text = "0";
            txtCrystal.Text = "0";
            txtEvian.Text = "0";
            txtMinere.Text = "0";
            txtMontFleur.Text = "0";
            txtNestle.Text = "0";
            txtSingha.Text = "0";
            txtSprinkle.Text = "0";

            txtService.Text = "0";
            txtCost.Text = "0";
            txtTax.Text = "0";
            txtTotal.Text = "0";
            }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
            rtfReceipt.AppendText("\t\t" + "        Fresh Water Store" + Environment.NewLine);
            rtfReceipt.AppendText("\t          ✼ •• ┈┈┈┈┈┈┈┈┈┈┈┈ •• ✼" + Environment.NewLine);
            rtfReceipt.AppendText("   " + lblTime.Text + "\t\t" + lblDate.Text + Environment.NewLine);
            rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("   Singha\t\t\t\t\t\t" + txtSingha.Text + Environment.NewLine);
            rtfReceipt.AppendText("   Nestle\t\t\t\t\t\t\t" + txtNestle.Text + Environment.NewLine);
            rtfReceipt.AppendText("   Mont Fleur\t\t\t\t\t\t" + txtMontFleur.Text + Environment.NewLine);
            rtfReceipt.AppendText("   Evian\t\t\t\t\t\t\t" + txtEvian.Text + Environment.NewLine);
            rtfReceipt.AppendText("   Sprinkle\t\t\t\t\t\t" + txtSprinkle.Text + Environment.NewLine);
            rtfReceipt.AppendText("   Crystal\t\t\t\t\t\t" + txtCrystal.Text + Environment.NewLine);
            rtfReceipt.AppendText("   Chang\t\t\t\t\t\t" + txtChang.Text + Environment.NewLine);
            rtfReceipt.AppendText("   Aura\t\t\t\t\t\t\t" + txtAura.Text + Environment.NewLine);
            rtfReceipt.AppendText("   Minere\t\t\t\t\t\t" + txtMinere.Text + Environment.NewLine);
            rtfReceipt.AppendText("   Aquafina\t\t\t\t\t\t" + txtAquafina.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t         •─────────✦❀✦────────•" + Environment.NewLine);
            rtfReceipt.AppendText("   Service Charge\t\t\t\t\t" + txtService.Text + Environment.NewLine);
            rtfReceipt.AppendText("   Tax\t\t\t\t\t\t\t" + txtTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("   Total Cost\t\t\t\t\t\t" + txtTotal.Text + Environment.NewLine);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text(*.txt)|*.txt|all files(*.*)|*.*";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFile.FileName;
                MessageBox.Show(strfilename);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text(*.txt)|*.txt|all files(*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void guna2GradientButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into WaterStore(Singha,Nestle,MontFleur,Evian,Sprinkle,Crystal,Chang,Aura,Minere,Aquafina,Cost,Service,Tax,Total)values('" + txtSingha.Text + "','" 
                    + txtNestle.Text + "','" + txtMontFleur.Text + "','" + txtEvian.Text + "','" + txtSprinkle.Text + "','" + txtCrystal.Text + "','" + txtChang.Text + "','" + txtAura.Text + "','"
                    + txtMinere.Text + "','" + txtAquafina.Text + "','" + txtCost.Text + "','" + txtService.Text +"','" + txtTax.Text +"','" + txtTotal.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Save in Database", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

                waterStoreBindingSource.EndEdit();
                waterStoreTableAdapter.Update(this.database61DataSet.WaterStore);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("ต้องการลบข้อมูล ?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   waterStoreBindingSource.RemoveCurrent();
                }
                else
                {
                  waterStoreBindingSource.ResetBindings(false);
                }
            }
        }
    } 
    }
