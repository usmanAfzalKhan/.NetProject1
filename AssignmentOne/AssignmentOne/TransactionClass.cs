using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class TransactionClass
    {
        enum TransactionType
        {
            WITHDRAW, DEPOSIT
        }
        private readonly double Amount;
        private readonly DateTime date;

        public DateTime GetDate()
        {
            return date;
        }
        public double GetAmount()
        {
            return Amount;
        }


    }
}
