using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        protected string owner;
        protected decimal balance;
        protected bool isClosed;

        public string Owner { get => owner; }
        public virtual decimal Balance { get { return balance; } }

        public Account(string owner, decimal balance)
        {
            this.owner = owner;
            this.balance = balance;
        }
        public Account(string owner) : this(owner, 0.0M) { }

        public void CloseAccount()
        {
            isClosed = true;
        }

        public virtual void Deposit(decimal amount)
        {
            if (isClosed)
            {
                Console.WriteLine("The account is closed and you can't make deposits");
            }
            else if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            PrintBalance();
        }

        public void PrintBalance()
        {
            Console.WriteLine($"{owner} {balance}");
        }
    }
}
