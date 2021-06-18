using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppCA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of Varialable
            string AccountHolderName = "";
            int InitialBalance = 0;


            Console.WriteLine("Welcome to Himalayan Bank Ltd.\n");
            Console.WriteLine("---------------------------------------------");
            Console.Write("\n");

            Console.WriteLine("Enter Account Holder's Name:");
            AccountHolderName = Console.ReadLine().ToUpper().ToString();

            //Initial balance in Account
            Console.WriteLine("Enter Initial Balance deposited:");
            InitialBalance = Convert.ToInt32(Console.ReadLine());

            if(InitialBalance > 1 && InitialBalance <= 1000)
            {
                Console.WriteLine("Initial Balance cannot be greate than 1000" + "You entered :" + InitialBalance);
            }

            var account = new BankAccount(AccountHolderName, InitialBalance);


            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Fixed Deposit (Refundable on Account Close");
            Console.WriteLine("Fixed Deposit: " + account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Cash Back Offer (Rs. 100)");
            Console.WriteLine("Cash Back (from Bank): " +  account.Balance);

            Console.WriteLine("==========================================================");

            Console.WriteLine(account.GetAccountHistory());

            // Test that the initial balances must be positive:
            try
            {
                var invalidAccount = new BankAccount("invalid", InitialBalance);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance", e.Message);
                Console.WriteLine(e.ToString());
            }

            // Test for a negative balance
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey(true);
        }
    }
}
