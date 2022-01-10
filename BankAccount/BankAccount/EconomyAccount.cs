using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class EconomyAccount : NormalAccount
    {
        static decimal deposit_procent = 0.01M;
        static decimal withdraw_procent = 0.02M;
        public EconomyAccount(string owner, decimal initialBalance)
            : base(owner, initialBalance + initialBalance * deposit_procent / 100) { }

        public EconomyAccount(string owner)
               : base(owner) { }

        public override void Deposit(decimal amount)
        {
            base.Deposit(amount + amount * deposit_procent / 100);
        }

        public override void Withdrawl(decimal amount)
        {
            base.Withdrawl(amount + amount * withdraw_procent / 100);
        }
    }
}
