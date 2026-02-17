using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2t
{
    internal class Bank
    {
        private List<BankAccount> accounts = new List<BankAccount>();
        public BankAccount CreateAccount(string number, string owner, decimal balance, AccountType type)
        {
            foreach (BankAccount schet in accounts)
            {
                if (schet.AccountNumber == number)
                {
                    Console.WriteLine("Счет с таким номером уже сущестует.");
                    return null;
                }
            }

            var account = new BankAccount(number, owner, balance, type);
            accounts.Add(account);
            return account;
        }
        
        public BankAccount FindAccount (string number)
        {
            foreach (var account in accounts)
            {
                if (account.AccountNumber == number)
                {
                    return account;
                }
            }
            return null;
        }
        public void ShowAllAccounts ()
        {
            Console.WriteLine("Все доступные счета:");
            foreach (var account in accounts)
            {
                Console.WriteLine($"Номер счета:{account.AccountNumber} \n Владелец:{account.Owner} \n Тип счета:{account.Type} \n Баланс:{account.Balance} \n\n");
            }
        }
    }
}
