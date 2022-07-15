using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
     class AccountClass
    {
        #region Properties
        private double _balance { get; set; }
        public int AccountNumber { get; }
        public string AccountHolderName { get; set; }
        public double Balance { get; }
        public double AnnualInterestRate { get; set; }
        #endregion
        private static double s_nextAccountNumber;

        #region Constructors
        public AccountClass(double _balance, int AccountNumber, string AccountHolderName, double Balance, double AnnualInterestRate)

        {
            this._balance = _balance;
            this.AccountNumber = AccountNumber;
            this.AccountHolderName = AccountHolderName;
            this.Balance = Balance;
            this.AnnualInterestRate = AnnualInterestRate;
            s_nextAccountNumber = s_nextAccountNumber + 1;
        }
        static AccountClass()
        {
            s_nextAccountNumber = 100;
        }

        public AccountClass(string name)
        {
            this.AccountHolderName = name;
        }

        #endregion

        #region Methods
        static double Deposit(double Balance, double _balance)
        {
            return Balance + _balance;
        }

        static double WithDraw(double Balance, double _balance)
        {
            return Balance - _balance;
        }

        #endregion


    }
}
