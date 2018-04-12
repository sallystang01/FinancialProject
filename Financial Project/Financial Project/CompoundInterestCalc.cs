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

            double depAmount;
            double depAmountSub;
            double depAmountMult;
            double depAmountDiv;
            double Amount;
            double TotalAmount;
            double Deposits;

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


            double body = 1 + (interest / timesPeryear);
        double exp = (timesPeryear * years);
        double interestFreq = (interest / timesPeryear);




        depAmount =  Math.Pow(body, exp);
                depAmountSub = depAmount - 1;
                depAmountMult = depAmountSub* Deposits;
        depAmountDiv = (depAmountMult / interestFreq);
                Amount = principal* Math.Pow(body, exp);

        TotalAmount = (Amount + depAmountDiv);
            return TotalAmount;
        }
    }

}
