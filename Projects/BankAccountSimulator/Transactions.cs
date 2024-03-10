using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSimulator
{
    public class Transactions
    {
        internal DateTime transactionDate { get; }
        internal decimal transactionAmount { get; set; }
        internal string transactionNote { get; }

        public Transactions(DateTime transactionDate, decimal amount, string notes)
        {
            this.transactionDate = transactionDate;
            this.transactionAmount = amount;
            this.transactionNote = notes;
        }

        
        public void printTransactionDetails()
        {
            Console.WriteLine("\n Transaction Details : ");
            Console.WriteLine("\t transactionDate : " + this.transactionDate);
            Console.WriteLine("\t transactionAmount : " + this.transactionAmount);
            Console.WriteLine("\t transactionNote : " + this.transactionNote);
            
        }
    }
}
