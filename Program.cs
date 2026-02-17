using _2t;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        Bank bank = new Bank();

        var account1 = bank.CreateAccount("1", "Жужжа",20, AccountType.Debit);
        var account2 = bank.CreateAccount("2", "Злата", 600, AccountType.Debit);
        var account3 = bank.CreateAccount("2", "Ян", 200, AccountType.Debit);

        bank.ShowAllAccounts();

        account1.Deposit(account1, 80);
        account2.Transfer(account1, 100);

        bank.ShowAllAccounts();
    }
}