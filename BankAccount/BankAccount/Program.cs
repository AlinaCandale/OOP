using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalAccount firstAcc = new NormalAccount("alina", 100M);
            firstAcc.Deposit(152200);
            firstAcc.Withdrawl(1500);
            firstAcc.Withdrawl(100000);

            EconomyAccount sirstAcc = new EconomyAccount("adi", 100M);
            sirstAcc.Deposit(100);
            sirstAcc.Withdrawl(100);
            sirstAcc.Withdrawl(90);

            SecretAccount sa = new SecretAccount("maria", 20M);
            sa.Deposit(20);
            sa.Withdrawl(10);
            sa.Withdrawl(15);
            sa.CloseAccount();
            sa.Deposit(20);
            sa.Withdrawl(10);

            GameAccount ga = new GameAccount("johnny", 50M);
            ga.Deposit(15);
            ga.CloseAccount();
            ga.Deposit(1);
        }
    }
}

/*
Simulate a bank account supporting opening/closing, withdrawals, and deposits of money.
It should be possible to close an account; operations against a closed account must fail.
Remember you are working with money so you should use an appropriate data type for it.

Now you're asked to implement an economy account. We know that an economy account is similar to a normal bank account, 
but on each deposit gives you 0.01% extra to the deposited sum, and on withdrawals takes 0.02% from the withdrawed amount.

Now you want to have a secret account from where you are buying wine or purses. When you make deposits , 
the deposit is made in an normal account. You can't make withdrawals in october.

Now you need to introduce a new account called GameAccount, that you will use online. This account can't make withdrawals, only deposits

-Since you have so many types of accounts, with different purposes, you need to find a way to extract the common behavior
*/
