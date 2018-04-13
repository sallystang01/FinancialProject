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
    public partial class Mortgage : Form
    {
        public Mortgage()
        {
            InitializeComponent();
        }

        private void Mortgage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Opens the default form after clicking "X" in top right corn and closes current form.
            Default frmDefault = new Default();
            frmDefault.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                //Declares variables
                double principal;
                double interest;
                double years;
                double months;
                double down;
                DateTime startDate = DateTime.Parse(tbStart.Text);

                //Sets variables
                principal = double.Parse(tbPrice.Text);
                interest = double.Parse(tbInterest.Text) / 100;
                years = double.Parse(tbTerm.Text);
                months = (years * 12);
                down = double.Parse(tbDown.Text);
                
                //Methods doing my calculations
                double converted = MortgageCalc.MortgagePayment(principal, interest, months, down);
                double totalInterest = MortgageCalc.MortgageInterest(interest, months, principal, down);
                string payOff = MortgageCalc.MortgageEndDate(startDate, months);

                // If years <= 0, display message box error and maintain current form size.
                // else, change form size.
                if (years <= 0)
                {
                    MessageBox.Show("You cannot compound interest for less than 1 year!");
                    this.Size = new Size(369, 310);
                }
                else
                {
                    this.Size = new Size(723, 310);
                }


                //Setting all the labels text to the calculated results from my methods
               
                lblOut.Text = "Your estimated monthly payment is" + " " + converted.ToString("c");
                double totalPayment = (converted * months);
                lblTotalPayment.Text = "Your total payment is" + " " + totalPayment.ToString("c");
                lblTotalInt.Text = "You will pay" + " " + totalInterest.ToString("c") + " " + "in interest";
                lblPayoffDate.Text = "Your estimated payoff date is" + " " + payOff.ToString();
            }
            // Error Handeling
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        
        // This button just clears all the text in the text boxes, labels, and returns the form size to normal.
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDown.Text = "";
            tbInterest.Text = "";
            tbPrice.Text = "";
            tbTerm.Text = "";
            lblOut.Text = "";
            lblTotalInt.Text = "";
            lblTotalPayment.Text = "";
            lblPayoffDate.Text = "";
            this.Size = new Size(369, 310);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            //Shows the calendar
            mCalendar.Visible = true;
        }

        private void mCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Takes the input from the calendar and convertes it and palces it into the text box.
            //Then it hides the calendar.
            //tbStart.Text = mCalendar.SelectionRange.Start.ToShortDateString();
            
        }

        private void mCalendar_MouseUp(object sender, MouseEventArgs e)
        {
            // Basically keeps the calendar visible until you choose a date
            switch (mCalendar.HitTest(e.Location).HitArea)
            {
                case MonthCalendar.HitArea.Date: break;
                case MonthCalendar.HitArea.NextMonthDate: break;
                case MonthCalendar.HitArea.PrevMonthDate: break;
                default: return;
            }
            //Takes the selected date and inputs it into the text box. 
            // Then it closes the calendar.
            tbStart.Text = mCalendar.SelectionRange.Start.ToShortDateString();
            mCalendar.Visible = false;
        }
    }
    }

