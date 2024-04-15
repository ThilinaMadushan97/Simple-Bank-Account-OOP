using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopClasses
{
    internal class Transtraction
    {
        public decimal Amount {  get; }
        public DateTime Date { get; }
        public string Notes { get; }

        //Constructer

        public Transtraction(decimal amount, DateTime date, string notes)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = notes;
        }

    }
}
