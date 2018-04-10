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
                double Amount;
                double TotalAmount;
                

                if (cbInstance.Text == "Annually")
                {
                    timesPeryear = 1.00;
                }
                else if (cbInstance.Text == "SemiAnnually")
                {
                    timesPeryear = 2.00;
                }
                else if (cbInstance.Text == "Quarterly")
                {
                    timesPeryear = 4.00;
                }
                else if (cbInstance.Text == "Monthly")
                {
                    timesPeryear = 12.00;
                }
                else 
                {
                    timesPeryear = 365.00;
                }

                deposits = double.Parse(tbContribute.Text) * 12;

                double body = 1 + (interest / timesPeryear);

                double exp = timesPeryear * years;

                Amount = principal * Math.Pow(body, exp );
                
                lblOut.Text = "Your balance after" + " " + tbYears.Text + " " + "years" + " " + "is" + " " + Amount.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
