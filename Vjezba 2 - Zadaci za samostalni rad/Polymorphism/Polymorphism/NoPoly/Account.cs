using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.NoPoly
{
    public class DrawingAccount
    {
        private static Decimal WithdrawLimit = 1000;

        public Int32 AccountIdentity { get; set; }

        private Decimal _balance;

        public DrawingAccount(Decimal startingBalance)
        {
            _balance = startingBalance;
        }

        public Decimal Status
        {
            get
            {
                return _balance;
            }
        }

        public void deposit(Decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount's got to be positive in order to deposit money.");
            }
            _balance += amount;
        }

        public void withdraw(Decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount's got to be positive in order to withdraw money.");
            }
            else if (amount > WithdrawLimit)
            {
                throw new Exception("Amount's got to be smaller than security limit for single transaction.");
            }
            _balance -= amount;
        }
    }
}
