using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2t
{
    public enum AccountType
    {
        Debit,
        Credit,
        Savings
    }
    internal class BankAccount
    {
        public string AccountNumber { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; private set; }
        public AccountType Type { get; set; }

        // Конструктор
        public BankAccount(string accountNumber, string owner, decimal balance,AccountType type)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = balance;
            Type = type;
        }

        public void Deposit(BankAccount acc, decimal summa)
        {
            if (summa > 0)
            {
                Balance += summa;
                Console.WriteLine($"Пополнение на {summa} рублей. На счете {acc.AccountNumber}: {Balance} рублей");
            }
        }

        public void Withdraw(BankAccount acc, decimal summa)
        {
            if (summa > 0 && summa <= Balance)
            {
                Balance -= summa;
                Console.WriteLine($"Снято {summa} рублей. На счете {acc.AccountNumber}: {Balance} рублей");
            }
            else
            {
                Console.WriteLine("Недостаточно средств.");
            }
        }

        public void Transfer(BankAccount schet, decimal summa)
        {
            if (schet != null && summa > 0 && summa <= Balance)
            {
                Balance -= summa;
                schet.Balance += summa;
                Console.WriteLine($"Перевод {summa} рублей на счет {schet.AccountNumber}");
            }
        }
    }
}