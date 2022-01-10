using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class SecretAccount : NormalAccount
    {
        public SecretAccount(string owner, decimal balance)
            : base(owner, balance) { }
        
        public SecretAccount(string owner, DateTime month)
            : base(owner) { }

        public override void Withdrawl(decimal amount)
        {
            if (DateTime.Now.Month != 10)
            {
                base.Withdrawl(amount);
            }
            else
            {
                Console.WriteLine("You can't make withdrawals in october");
                PrintBalance();
            }
        }
    }
}
