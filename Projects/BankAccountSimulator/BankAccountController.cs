using System.Text.RegularExpressions;

namespace BankAccountSimulator
{
    internal class BankAccountController
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount_1 = new BankAccount( "John Doe", 12345 );
            bankAccount_1.printBankAccountDetails();

            bankAccount_1.depositMoney( 99, new DateTime(2023, 01, 01, 21,12,12 ), "Grocery Refund!");

            bankAccount_1.withdrawMoney(999, new DateTime(2023, 09, 11, 11, 58,35 ), "Buy Furniture!");

            bankAccount_1.generateTransactionReport();

            Console.WriteLine( "\n \t New Account Balance : " + bankAccount_1.bankAccountBalance );

            BankAccount bankAccount_2 = new BankAccount("Jane Doe", 98765 );
            bankAccount_2.printBankAccountDetails();
        }
    }
}
