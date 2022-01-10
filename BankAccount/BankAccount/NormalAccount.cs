using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class NormalAccount : Account
    {
        public NormalAccount(string owner, decimal balance)
                 : base(owner, balance) { }

        public NormalAccount(string owner) : this(owner, 0.0M) { } 

        public virtual void Withdrawl(decimal amount)
        {
            if (isClosed)
            {
                Console.WriteLine("The account is closed and you can't make withdrawl");
            }
            else if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            else if (balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else
            {
                balance -= amount;
            }
            PrintBalance();
        }

    }
}
