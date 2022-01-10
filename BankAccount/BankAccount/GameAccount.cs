using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class GameAccount : Account
    {
        public GameAccount(string owner, decimal balance)
                  : base(owner, balance) { }

        public GameAccount(string owner)
               : base(owner) { }
    }
}
