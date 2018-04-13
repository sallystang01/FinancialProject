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

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                // Sets variables
                double principal = double.Parse(tbInvest.Text);
                double interest = double.Parse(tbInterest.Text) / 100;
                double timesPeryear;
                double years = double.Parse(tbYears.Text);
                double deposits;
                double Deposits = 0;
                deposits = double.Parse(tbContribute.Text);





                //Conditional statement that sets my timesPeryear variable depending on the text
                // of the combo box on my form.

                if (cbInstance.Text == "Annually")
                {
                    timesPeryear = 1;
                }
                else if (cbInstance.Text == "Semiannually")
                {
                    timesPeryear = 2;
                }
                else if (cbInstance.Text == "Quarterly")
                {
                    timesPeryear = 4;
                }
                else if (cbInstance.Text == "Monthly")
                {
                    timesPeryear = 12;
                }

                else
                {
                    timesPeryear = 365; Deposits = ((deposits * 12) / 365);
                }

                // Does not allow 0 years
                

                // This variable retrives my calculation from my method
                double converted = CompoundInterestCalc.CompoundInterest(principal, interest, timesPeryear, years, deposits);

                // If years <= 0, display message box error and maintain current form size.
                // else, change form size.

                if (years <= 0)
                {
                    MessageBox.Show("You cannot compound interest for less than 1 year!");
                    this.Size = new Size(366, 275);
                }
                else
                {
                    this.Size = new Size(366, 423);
                }

                //Sets text to show the calculation on my label.
                lblOut.Text = "Your balance after" + " " + tbYears.Text + " " + "years" + " " + "is" + " " + converted.ToString("C");
            }

            // Error handeling
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears text and prepares the form for a new set of information
            tbContribute.Text = "";
            tbInterest.Text = "";
            tbInvest.Text = "";
            tbYears.Text = "";
            cbInstance.Text = "";

            this.Size = new Size(366, 275);
        }

        private void Compound_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Closes current form and returns to defualt
            Default frmDefault = new Default();
            frmDefault.Show();
        }
    }
}
