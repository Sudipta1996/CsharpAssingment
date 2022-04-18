using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class DemoAccount
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public int Balance { get; set; } = 0;

        public event EventHandler Underbalance;
        public event EventHandler BalanceZero;


        public void Withdraw(int amt)
        {
            Console.WriteLine("Enter the Ammount to Withdrawn :");
            amt = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (CheckBalance() < amt)
                {
                    throw new Exception("There isn\'t sufficient balance for withdrawal.");
                }
                Balance -= amt;
                Console.WriteLine("Successfully Withdrawn from Account." + amt);
                Console.WriteLine("\nCurrent Balance:" + CheckBalance());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private int CheckBalance()
        {
            if (Balance < 1000)
            {
                Underbalance(this, null);
            }
            if (Balance <= 0)
            {
                BalanceZero(this, null);
            }

            return Balance;
        }

        public void Deposite(int amt)
        {

            Console.WriteLine("Enter the Ammount to Deposit :");
            amt = Convert.ToInt32(Console.ReadLine());
            Balance += amt;
            Console.WriteLine("Successfully deposited into account." + amt);
            Console.WriteLine("Current Amount:" + Balance);


        }
        public static void UnderBalanceAlert(object sender, EventArgs e)
        {
            DemoAccount account = new DemoAccount();
            Console.WriteLine("\nUnderBalance Alert !! Account balance under limit 1000 - Current balance:" + account.Balance);
        }
        public static void BalanceZeroAlert(object sender, EventArgs e)
        {
            Console.WriteLine("\nZero Balance Alert!! Account balance: 0");
        }


        static void Main(string[] args)
        {

            DemoAccount account = new DemoAccount()
            {

                AccountNumber = "123456",
                CustomerName = "Pradip",
                Balance = 10000
            };
            Console.WriteLine("Customer Acc No :" + " " + account.AccountNumber + "\tCustomer Name :" + " " + account.CustomerName + "\tCustomer Balance :" + " " + account.Balance);
            account.Underbalance += UnderBalanceAlert;
            account.BalanceZero += BalanceZeroAlert;

            string choice;
            Console.WriteLine("Please enter a Choice: For Deposit Press d : For Withdraw Press w (d,w):");

            choice = Console.ReadLine();
            switch (choice)
            {
                case "w":
                    account.Withdraw(account.Balance);
                    break;
                case "d":
                    account.Deposite(account.Balance);
                    break;

            }

            Console.ReadKey();


        }

    }
}
