using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_Project
{
    public partial class Compound : Form
    {
        public Compound()
        {
            InitializeComponent();
        }

        private void tbIR_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitConf frmExit = new ExitConf();
            frmExit.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double principal = double.Parse(tbInvest.Text);
                double interest = double.Parse(tbInterest.Text) / 100;
                double timesPeryear;
                double years = double.Parse(tbYears.Text);
                double deposits;
                double depAmount;
                double Amount;
                double TotalAmount;
                double depAmountSub;
                double depAmountDiv;
                double depAmountMult;
                double Deposits = 0;



                deposits = double.Parse(tbContribute.Text);


                if (cbInstance.Text == "Annually")
                {
                    timesPeryear = 1; Deposits = (deposits * 12);
                }
                else if (cbInstance.Text == "Semiannually")
                {
                    timesPeryear = 2; Deposits = (deposits * 6);
                }
                else if (cbInstance.Text == "Quarterly")
                {
                    timesPeryear = 4; Deposits = (deposits * 3);
                }
                else if (cbInstance.Text == "Monthly")
                {
                    timesPeryear = 12; Deposits = deposits;
                }
                else 
                {
                    timesPeryear = 365; Deposits = ((deposits * 12) / 365);
                }

                
               

                double body = 1 + (interest / timesPeryear);
                double exp = (timesPeryear * years);
                double interestFreq = (interest / timesPeryear);




                depAmount =  Math.Pow(body, exp);
                depAmountSub = depAmount - 1;
                depAmountMult = depAmountSub * Deposits;
                depAmountDiv = (depAmountMult / interestFreq);
                Amount = principal * Math.Pow(body, exp);
                
                TotalAmount = (Amount + depAmountDiv);

                lblOut.Text = "Your balance after" + " " + tbYears.Text + " " + "years" + " " + "is" + " " + TotalAmount.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Closes form and opens default

            Default frmDefault = new Default();
            this.Close();
            frmDefault.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbInterest_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
