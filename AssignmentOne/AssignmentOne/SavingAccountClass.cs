using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class SavingAccountClass: AccountClass
    {
        public SavingAccountClass(double _balance, int initAccountNumber, string initAccountHolderName, double initBalance, double initAnnualInterestRate) 
            : base(_balance, initAccountNumber, initAccountHolderName, initBalance, initAnnualInterestRate)
        {
            AnnualInterestRate = 0.03;
            double savings = Balance - _balance;


        }
    }
}
