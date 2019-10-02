using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance of an account == object
            var account = new Account
            {
                AccountEmailAddress = "testc@test.com",
                AccountType = "Checking"
            };

            account.Deposit(2003.234m);

            Console.WriteLine($"AccountNumber: {account.AccountNumber}, " +
                $"Balance: {account.AccountBalance: C}, " +
                $"AccountType: {account.AccountType}, " +
                $"AccountCreateDate: {account.AccountCreateDate}, " +
                $"accountEmailAddres: {account.AccountEmailAddress}");

        }
    }
}
