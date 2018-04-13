using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Project
{

    class CompoundInterestCalc

    {
        public static double CompoundInterest(double principal, double interest, double timesPeryear, double years,
            double deposits)
        
        {
            try
            {
                //Declares variables
                double depAmount;
                double depAmountSub;
                double depAmountMult;
                double depAmountDiv;
                double Amount;
                double TotalAmount;
                double Deposits;

                // Condition if statement that sets Deposits variable depending on timesPeryear variable.
                if (timesPeryear == 1)
                {
                    Deposits = (deposits * 12);
                }
                else if (timesPeryear == 2)
                {
                    Deposits = (deposits * 6);
                }
                else if (timesPeryear == 4)
                {
                    Deposits = (deposits * 3);
                }
                else if (timesPeryear == 12)
                {
                    Deposits = deposits;
                }
                else
                {
                    Deposits = ((deposits * 12) / 365);
                }

                // setting up my formula body, exp, and interest
                double body = 1 + (interest / timesPeryear);
                double exp = (timesPeryear * years);
                double interestFreq = (interest / timesPeryear);



                // Executes the formula
                depAmount = Math.Pow(body, exp);
                depAmountSub = depAmount - 1;
                depAmountMult = depAmountSub * Deposits;
                depAmountDiv = (depAmountMult / interestFreq);
                Amount = principal * Math.Pow(body, exp);

                TotalAmount = (Amount + depAmountDiv);
                //Returns the calculation
                return TotalAmount;
            }
            // Error handeling
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
