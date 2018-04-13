using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Project
{
    class MortgageCalc
    {
        public static double MortgagePayment(double principal, double interest, double months, double down)
        {
            try
            {
                //Declares variables
                double r;
                double n;
                double P;
                double M;
                //Sets Variables
                r = interest / 12;
                n = months;
                P = principal - down;
                //This is the formula
                M = P * ((r * (Math.Pow(1 + r, n))) / (Math.Pow(1 + r, n) - 1));

                //Returns my payment
                return M;
            }
            //Error handeling
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static double MortgageInterest(double interest, double months, double principal, double down)
        {
            try
            {  //Sets and declares my variables
                double I;
                double Interest = interest / 100;
                double n = months * 12;
                double M = principal - down;

                double body = (interest + 1);
                double bodyCalc = Math.Pow(body, n);
                double Numerator = (Interest * bodyCalc);
                double Denominator = (bodyCalc - 1);
                double Fraction = (Numerator / Denominator);
                double FullEq = (M * Fraction);
                //Forumula essentially
                double FullEqtoPay = ((FullEq * n) + down);
                I = FullEqtoPay - principal;
                //returns total interest
                return I;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string MortgageEndDate(DateTime StartDate, double months)
        {
            try
            {
                //This method essentially takes the start date and adds months to it and returns an end date
                int MonthsUntilEnd = Convert.ToInt32(months);
                DateTime PayOffCalc = StartDate.AddMonths(MonthsUntilEnd);
                string PayyOffDate = PayOffCalc.ToShortDateString();

                return PayyOffDate;
            }
            //Error handeling
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
