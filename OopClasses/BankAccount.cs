using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopClasses
{
    internal class BankAccount
    {
        private static int accountNumberSeed = 1234567890;

        private List<Transtraction> allTransactions = new List<Transtraction>();
        public string Number { get; }
        public string Owner { get; set; }
       
        public decimal balance
        {
            get
            {
                decimal balance = 0;
                foreach (var items in allTransactions)
                {
                    balance += items.Amount;
                }
                return balance;
            }
            
        } 

        //Constructor

        public BankAccount(string name, decimal initializeBalence)
        {
            this.Owner = name;
            MakeDeposit(initializeBalence, DateTime.Now, "Innitilize balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            var deposit = new Transtraction(amount, date, note);
            allTransactions.Add(deposit);
        }
        public void MakeWithdrowal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrowal must be positive");
            }

            var withdrowal = new Transtraction(-amount, date, note);
            allTransactions.Add(withdrowal);
        }
    }
}
