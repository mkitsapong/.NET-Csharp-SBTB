using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            txtAficancoffee.Text = "0";
            txtAmericano.Text = "0";
            txtBlackForest.Text = "0";
            txtBoston.Text = "0";
            txtCappuccino.Text = "0";
            txtCatlton.Text = "0";
            txtCoffeeCake.Text = "0";
            txtEspresso.Text = "0";
            txtIcedCappuccino.Text = "0";
            txtIcedLatte.Text = "0";
            txtKilburn.Text = "0";
            txtLagos.Text = "0";
            txtLatte.Text = "0";
            txtQueen.Text = "0";
            txtRedValvet.Text = "0";
            txtValecoffee.Text = "0";
            lblCostOfCake.Text = "0";
            lblCostOfDrink.Text = "0";
            lblService.Text = "0";

            txtAficancoffee.Enabled = false;
            txtAmericano.Enabled = false;
            txtBlackForest.Enabled = false;
            txtBoston.Enabled = false;
            txtCappuccino.Enabled = false;
            txtCatlton.Enabled = false;
            txtCoffeeCake.Enabled = false;
            txtEspresso.Enabled = false;
            txtIcedCappuccino.Enabled = false;
            txtIcedLatte.Enabled = false;
            txtKilburn.Enabled = false;
            txtLagos.Enabled = false;
            txtLatte.Enabled = false;
            txtQueen.Enabled = false;
            txtRedValvet.Enabled = false;
            txtValecoffee.Enabled = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbLatte_CheckedChanged(object sender, EventArgs e)
        {
            if(cbLatte.Checked == true)
            {
                txtLatte.Enabled = true;
            }
            if (cbLatte.Checked == false)
            {
                txtLatte.Enabled = false;
                txtLatte.Text = "0";
            }
        }

        private void txtLatte_Click(object sender, EventArgs e)
        {
            txtLatte.Text = "0";
            txtLatte.Focus();
        }

        private void cbEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEspresso.Checked == true)
            {
                txtEspresso.Enabled = true;
            }
            if (cbEspresso.Checked == false)
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";
            }
        }

        private void txtEspresso_Click(object sender, EventArgs e)
        {
            txtEspresso.Text = "0";
            txtEspresso.Focus();
        }

        private void cbIcedLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIcedLatte.Checked == true)
            {
                txtIcedLatte.Enabled = true;
            }
            if (cbIcedLatte.Checked == false)
            {
                txtIcedLatte.Enabled = false;
                txtIcedLatte.Text = "0";
            }
        }

        private void txtIcedLatte_Click(object sender, EventArgs e)
        {
            txtIcedLatte.Text = "0";
            txtIcedLatte.Focus();
        }

        private void cbValecoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (cbValecoffee.Checked == true)
            {
                txtValecoffee.Enabled = true;
            }
            if (cbValecoffee.Checked == false)
            {
                txtValecoffee.Enabled = false;
                txtValecoffee.Text = "0";
            }
        }

        private void txtValecoffee_Click(object sender, EventArgs e)
        {
            txtValecoffee.Text = "0";
            txtValecoffee.Focus();
        }

        private void cbCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCappuccino.Checked == true)
            {
               txtCappuccino.Enabled = true;
            }
            if (cbCappuccino.Checked == false)
            {
                txtCappuccino.Enabled = false;
                txtCappuccino.Text = "0";
            }
        }

        private void txtCappuccino_Click(object sender, EventArgs e)
        {
            txtCappuccino.Text = "0";
            txtCappuccino.Focus();
        }

        private void cbAfricancoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAfricancoffee.Checked == true)
            {
                txtAficancoffee.Enabled = true;
            }
            if (cbAfricancoffee.Checked == false)
            {
                txtAficancoffee.Enabled = false;
                txtAficancoffee.Text = "0";
            }
        }

        private void txtAficancoffee_Click(object sender, EventArgs e)
        {
            txtAficancoffee.Text = "0";
            txtAficancoffee.Focus();
        }

        private void cbAmericanocoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAmericanocoffee.Checked == true)
            {
                txtAmericano.Enabled = true;
            }
            if (cbAmericanocoffee.Checked == false)
            {
                txtAmericano.Enabled = false;
                txtAmericano.Text = "0";
            }
        }

        private void txtAmericano_Click(object sender, EventArgs e)
        {
            txtAmericano.Text = "0";
            txtAmericano.Focus();
        }

        private void cbIcedCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIcedCappuccino.Checked == true)
            {
               txtIcedCappuccino.Enabled = true;
            }
            if (cbIcedCappuccino.Checked == false)
            {
                txtIcedCappuccino.Enabled = false;
                txtIcedCappuccino.Text = "0";
            }
        }

        private void txtIcedCappuccino_Click(object sender, EventArgs e)
        {
            txtIcedCappuccino.Text = "0";
            txtIcedCappuccino.Focus();
        }

        private void cbCoffeeCake_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCoffeeCake.Checked == true)
            {
                txtCoffeeCake.Enabled = true;
            }
            if (cbCoffeeCake.Checked == false)
            {
                txtCoffeeCake.Enabled = false;
                txtCoffeeCake.Text = "0";
            }
        }

        private void txtCoffeeCake_Click(object sender, EventArgs e)
        {
            txtCoffeeCake.Text = "0";
            txtCoffeeCake.Focus();
        }

        private void cbRedVelvetCake_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRedVelvetCake.Checked == true)
            {
               txtRedValvet.Enabled = true;
            }
            if (cbRedVelvetCake.Checked == false)
            {
                txtRedValvet.Enabled = false;
                txtRedValvet.Text = "0";
            }
        }

        private void txtRedValvet_Click(object sender, EventArgs e)
        {
            txtRedValvet.Text = "0";
            txtRedValvet.Focus();
        }

        private void cbBlackForestCake_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBlackForestCake.Checked == true)
            {
                txtBlackForest.Enabled = true;
            }
            if (cbBlackForestCake.Checked == false)
            {
                txtBlackForest.Enabled = false;
                txtBlackForest.Text = "0";
            }
        }

        private void txtBlackForest_Click(object sender, EventArgs e)
        {
            txtBlackForest.Text = "0";
            txtBlackForest.Focus();
        }

        private void cbBostonCreamCake_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBostonCreamCake.Checked == true)
            {
               txtBoston.Enabled = true;
            }
            if (cbBostonCreamCake.Checked == false)
            {
                txtBoston.Enabled = false;
                txtBoston.Text = "0";
            }
        }

        private void txtBoston_Click(object sender, EventArgs e)
        {
            txtBoston.Text = "0";
            txtBoston.Focus();
        }

        private void cbLagosChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLagosChocolateCake.Checked == true)
            {
                txtLagos.Enabled = true;
            }
            if (cbLagosChocolateCake.Checked == false)
            {
                txtLagos.Enabled = false;
                txtLagos.Text = "0";
            }
        }

        private void txtLagos_Click(object sender, EventArgs e)
        {
            txtLagos.Text = "0";
            txtLagos.Focus();
        }

        private void cbKilburnChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKilburnChocolateCake.Checked == true)
            {
               txtKilburn.Enabled = true;
            }
            if (cbKilburnChocolateCake.Checked == false)
            {
                txtKilburn.Enabled = false;
                txtKilburn.Text = "0";
            }
        }

        private void txtKilburn_Click(object sender, EventArgs e)
        {
            txtKilburn.Text = "0";
            txtKilburn.Focus();
        }

        private void cbCarltonHillChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCarltonHillChocolateCake.Checked == true)
            {
               txtCatlton.Enabled = true;
            }
            if (cbCarltonHillChocolateCake.Checked == false)
            {
                txtCatlton.Enabled = false;
                txtCatlton.Text = "0";
            }
        }

        private void txtCatlton_Click(object sender, EventArgs e)
        {
            txtCatlton.Text = "0";
            txtCatlton.Focus();
        }

        private void cbQueenParkChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if (cbQueenParkChocolateCake.Checked == true)
            {
               txtQueen.Enabled = true;
            }
            if (cbQueenParkChocolateCake.Checked == false)
            {
                txtQueen.Enabled = false;
                txtQueen.Text = "0";
            }
        }

        private void txtQueen_Click(object sender, EventArgs e)
        {
            txtQueen.Text = "0";
            txtQueen.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtAficancoffee.Text = "0";
            txtAmericano.Text = "0";
            txtBlackForest.Text = "0";
            txtBoston.Text = "0";
            txtCappuccino.Text = "0";
            txtCatlton.Text = "0";
            txtCoffeeCake.Text = "0";
            txtEspresso.Text = "0";
            txtIcedCappuccino.Text = "0";
            txtIcedLatte.Text = "0";
            txtKilburn.Text = "0";
            txtLagos.Text = "0";
            txtLatte.Text = "0";
            txtQueen.Text = "0";
            txtRedValvet.Text = "0";
            txtValecoffee.Text = "0";
            lblCostOfCake.Text = "0";
            lblCostOfDrink.Text = "0";
            lblService.Text = "0";

            cbAfricancoffee.Enabled = true;
            cbAmericanocoffee.Enabled = false;
            cbBlackForestCake.Enabled = false;
            cbBostonCreamCake.Enabled = false;
            cbCappuccino.Enabled = false;
            cbCarltonHillChocolateCake.Enabled = false;
            cbCoffeeCake.Enabled = false;
            cbEspresso.Enabled = false;
            cbIcedCappuccino.Enabled = false;
            cbIcedLatte.Enabled = false;
            cbKilburnChocolateCake.Enabled = false;
            cbLagosChocolateCake.Enabled = false;
            cbLatte.Enabled = false;
            cbQueenParkChocolateCake.Enabled = false;
            cbRedVelvetCake.Enabled = false;
            cbValecoffee.Enabled = false;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text(*.txt)|*.txt|all files(*.*)|*.*";
            if(openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFile.FileName;
                MessageBox.Show(strfilename);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text(*.txt)|*.txt|all files(*.*)|*.*";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void btnReceite_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
            rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("\t\t\t\t"+"Just Do Cafe"+Environment.NewLine);
            rtfReceipt.AppendText("\t\t"+"-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Latte\t\t\t\t\t\t\t"+txtLatte.Text+Environment.NewLine);
            rtfReceipt.AppendText("Espresso\t\t\t\t\t\t" + txtEspresso.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced-Latte\t\t\t\t\t\t" + txtIcedLatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Valecoffee\t\t\t\t\t\t" + txtValecoffee.Text + Environment.NewLine);
            rtfReceipt.AppendText("Cappuccino\t\t\t\t\t\t" + txtCappuccino.Text + Environment.NewLine);
            rtfReceipt.AppendText("Aficancoffee\t\t\t\t\t\t" + txtAficancoffee.Text + Environment.NewLine);
            rtfReceipt.AppendText("Americanocoffee\t\t\t\t\t\t" + txtAmericano.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced-Cappuccino\t\t\t\t\t\t" + txtIcedCappuccino.Text + Environment.NewLine);
            rtfReceipt.AppendText("Coffee Cake\t\t\t\t\t\t" + txtCoffeeCake.Text + Environment.NewLine);
            rtfReceipt.AppendText("Red Velvet Cake\t\t\t\t\t\t" + txtRedValvet.Text + Environment.NewLine);
            rtfReceipt.AppendText("Black Forest Cake\t\t\t\t\t" + txtBlackForest.Text + Environment.NewLine);
            rtfReceipt.AppendText("Boston Cream Cake\t\t\t\t\t" + txtBoston.Text + Environment.NewLine);
            rtfReceipt.AppendText("Lagos Chocolate Cake\t\t\t\t\t" + txtLagos.Text + Environment.NewLine);
            rtfReceipt.AppendText("Kilburn Chocolate Cake\t\t\t\t\t" + txtKilburn.Text + Environment.NewLine);
            rtfReceipt.AppendText("Carlton Hill Chocolate Cake\t\t\t\t" + txtCatlton.Text + Environment.NewLine);
            rtfReceipt.AppendText("Queen's Park Chocolate Cake\t\t\t\t" + txtQueen.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Service Charge\t\t\t\t\t\t" + lblService.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Tax\t\t\t\t\t\t\t" + lblTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("Sub Total\t\t\t\t\t\t" + lblSubTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("Total Cost\t\t\t\t\t\t" + lblTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTime.Text + "\t\t"+lblDate.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("\t\t\t ---------- Kitsapong ----------" + Environment.NewLine);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text=DateTime.Now.ToLongTimeString();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text,new Font("Arial",14,FontStyle.Regular),Brushes.Black,120,120);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double tax;
            tax = 7;
            double service;
            service = 2;
            double latte, espres, ilatte, vale, aCoff, amCoff, Capp, iCapp;
            double cCake, rVel, bFor, cBos, cLag, cKilb, cCarl, cQueen;
            latte = 45; espres = 70; ilatte = 60; vale = 55; aCoff = 60; amCoff = 45; Capp = 70; iCapp = 55;
            double latte_Coff = Convert.ToDouble(txtLatte.Text);
            double espresso = Convert.ToDouble(txtEspresso.Text);
            double IcedLatte = Convert.ToDouble(txtIcedLatte.Text);
            double val_Coff = Convert.ToDouble(txtValecoffee.Text);
            double Afri = Convert.ToDouble(txtAficancoffee.Text);
            double amer = Convert.ToDouble(txtAmericano.Text);
            double Cappu = Convert.ToDouble(txtCappuccino.Text);
            double IcedCappu = Convert.ToDouble(txtIcedCappuccino.Text); 

            cCake = 45; rVel = 55;bFor = 75; cBos = 45; cLag = 60; cKilb = 75; cCarl = 80; cQueen = 90;
            double c_Cake = Convert.ToDouble(txtCoffeeCake.Text);
            double c_Red = Convert.ToDouble(txtRedValvet.Text);
            double c_Black = Convert.ToDouble(txtBlackForest.Text);
            double c_Boston = Convert.ToDouble(txtBoston.Text);
            double c_Lag = Convert.ToDouble(txtLagos.Text);
            double c_Kil = Convert.ToDouble(txtKilburn.Text);
            double c_carl = Convert.ToDouble(txtCatlton.Text);
            double c_Que = Convert.ToDouble(txtQueen.Text);

            Class1 eat_in_Cafe = new Class1(latte_Coff,espresso,IcedLatte,val_Coff,Afri,amer,Cappu,IcedCappu,c_Cake,c_Red,c_Black,c_Boston,c_Lag,c_Kil,c_carl,c_Que);

            double cost_of_drinks = (latte_Coff * latte) + (espresso + espres) + (IcedLatte * ilatte) + (vale * val_Coff) + (aCoff * Afri) + (amCoff * amer) + (Capp + Cappu) + (iCapp * IcedCappu);
            lblCostOfDrink.Text = Convert.ToString(cost_of_drinks);

            double cost_of_cakes = (cCake + c_Cake)+(rVel * c_Red)+(bFor * c_Black)+(cBos*c_Boston)+(cLag*c_Lag)+(cKilb*c_Kil)+(cCarl*c_carl)+(cQueen*c_Que);
            lblCostOfCake.Text = Convert.ToString(cost_of_cakes);

            double service_charge = Convert.ToDouble(((cost_of_cakes + cost_of_drinks)* service) / 100);
            lblService.Text = Convert.ToString(service_charge);

            lblSubTotal.Text = Convert.ToString(cost_of_cakes + cost_of_drinks + service_charge);
            lblTax.Text = Convert.ToString(((cost_of_cakes + cost_of_drinks + service_charge) * tax) / 100);
            double iTax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(cost_of_cakes + cost_of_drinks + iTax + service_charge);

            lblCostOfCake.Text = String.Format("{0:0.00}", cost_of_cakes);
            lblCostOfDrink.Text = String.Format("{0:0.00}", cost_of_drinks);
            lblService.Text = String.Format("{0:0.00}", service_charge);
            lblSubTotal.Text = String.Format("{0:0.00}", (cost_of_cakes + cost_of_drinks + service_charge));
            lblTax.Text = String.Format("{0:0.00}", iTax);
            lblTotal.Text = String.Format("{0:0.00}", (lblTotal.Text));
        }

        private void rtfReceipt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
