using System;

namespace BankLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Dashy", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance}.");
            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            account.MakeWithdrawal(4, DateTime.Now, "a");
            account.MakeWithdrawal(10, DateTime.Now, "s");
            account.MakeWithdrawal(220, DateTime.Now, "d");

            Console.WriteLine($"Balance after withdrawal of $120 is ${account.Balance})");

            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
