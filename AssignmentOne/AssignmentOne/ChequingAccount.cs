using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class ChequingAccount : AccountClass
    {
        const double overdraft = 1000;
        public ChequingAccount(double _balance, int initAccountNumber, string initAccountHolderName, double initBalance, double initAnnualInterestRate) 
            : base(_balance, initAccountNumber, initAccountHolderName, initBalance, initAnnualInterestRate)
        {
            double withdraw = Balance - _balance;
            AnnualInterestRate = 0.01;
            if (withdraw > (overdraft + Balance))
            {
                Console.WriteLine("You cannot withraw ypur money, it exceeds the overdraft.");
                Console.Write("Press to continue...");
                Console.ReadKey();
            }
            else
            {
                double moneyWithDraw = ((withdraw - (overdraft + Balance)) * 0.01) + (withdraw - (overdraft + Balance));
                _balance = moneyWithDraw;
            }

        }

    }
}