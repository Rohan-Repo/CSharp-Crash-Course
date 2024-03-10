using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSimulator
{
    public class BankAccount
    {
        private Guid bankAccountNumber { get;  }
        private string bankAccountOwner { get; set; }

        // Calculate Balance at runtime based on the Transactions!
        internal decimal bankAccountBalance {
            get
            {
                decimal calc_balance = 0;

                foreach (Transactions transaction in accountTransactions)
                    calc_balance = calc_balance + transaction.transactionAmount;

                return calc_balance;
            }
        }
        private DateTime bankAccountCreatedDate { get; }

        internal List<Transactions> accountTransactions = new List<Transactions>();

        public BankAccount()
        {
            this.bankAccountNumber = Guid.Empty;
            this.bankAccountOwner = string.Empty;
            this.bankAccountCreatedDate = DateTime.MinValue;
        }

        public BankAccount(string bankAccountOwner, decimal initialBalance )
        {
            this.bankAccountNumber = Guid.NewGuid();
            this.bankAccountOwner = bankAccountOwner;
            this.bankAccountCreatedDate = DateTime.Now;
            // Set the Initial Balance
            depositMoney(initialBalance, DateTime.UtcNow, "Initial Balance!");
        }

        public bool depositMoney( decimal amount, DateTime dateTime, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException( nameof(amount), "Amount of Deposit must be Positive!" );

            var transaction = new Transactions( dateTime, amount, note);

            // Add to Transaction List
            accountTransactions.Add(transaction);

            return true;
        }
        public bool withdrawMoney(decimal amount, DateTime dateTime, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Withdrawl must be Positive!");

            if ((bankAccountBalance - amount) < 0)
                throw new InvalidOperationException("Insufficient Funds for this transfer! ");

            // Since Withdrawl reduces Account Balance, amount is negative
            Transactions transaction = new Transactions(dateTime, -amount, note);
            accountTransactions.Add(transaction);

            return true;
        }

        public void printBankAccountDetails()
        {
            Console.WriteLine("\n Bank Account Details : ");
            Console.WriteLine("\t bankAccountNumber : " + this.bankAccountNumber);
            Console.WriteLine("\t bankAccountCreatedDate : " + this.bankAccountCreatedDate);
            Console.WriteLine("\t bankAccountOwner : " + this.bankAccountOwner);
            Console.WriteLine("\t bankAccountBalance : " + this.bankAccountBalance);
        }

        public void generateTransactionReport()
        {
            Console.WriteLine("\n Transaction Details : ");

            var report = new StringBuilder();

            // Report Header
            report.AppendLine("transactionDate \t transactionAmount($) \t transactionNote \t transactionType");

            string transactionType = string.Empty;

            foreach (var transaction in accountTransactions)
            {
                transactionType = (transaction.transactionAmount > 0) ? "Deposit" : "Withdrawl";

                // Report Rows
                report.AppendLine($"{transaction.transactionDate} \t {transaction.transactionAmount} \t\t\t {transaction.transactionNote} \t\t {transactionType}");
            }

            Console.WriteLine( report );
        }

    }
}
