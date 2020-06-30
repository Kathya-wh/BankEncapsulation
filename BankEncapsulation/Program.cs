using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Access and manage your account");

            var kAcct = new BankAccount(500);

            kAcct.Deposit(5000);

            var bal = kAcct.GetBalance();

            kAcct.Withdraw(100);
        }
    }
}
