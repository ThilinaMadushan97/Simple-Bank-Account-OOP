using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopClasses
{
    internal class BankAccount
    {
        public static int accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal balence { get; }

        //Constructor

        public BankAccount(string name, decimal initializeBalence)
        {
            this.Owner = name;
            this.balence = initializeBalence;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }
        public void MakeWithdrowal(decimal amount, DateTime date, string note)
        {

        }
    }
}
