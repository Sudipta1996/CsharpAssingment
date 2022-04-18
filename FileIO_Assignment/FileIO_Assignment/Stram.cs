using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Assignment
{
    
    class Account
    {
        private double balance = 10000;
        String bank = String.Empty;
        String name = String.Empty;
        int account;
        double withdraw, deposit, totalbal;
        String myPath = @"D:\\Test.txt";

        public void Deposit()
        {
            string temp = "";


            StreamWriter writer = new StreamWriter(myPath, true);
            do
            {
                Console.WriteLine("If you want Enter Or Exit Type: y/n ");
                temp = Console.ReadLine().ToLower();

                if (temp != "n")
                {
                    Console.WriteLine("Enter Customer name:");
                    name = Console.ReadLine();
                    writer.WriteLine(name);

                    Console.WriteLine("Enter Account Number  :");
                    account = Convert.ToInt32(Console.ReadLine());
                    writer.WriteLine(account);

                    Console.WriteLine("Enter Deposit Amount :");
                    deposit = Convert.ToDouble(Console.ReadLine());
                    writer.WriteLine(deposit);

                    totalbal = balance + deposit;
                }


            } while (temp != "n");

            writer.Close();



            Console.WriteLine("Customer Name : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("Total Amount After Deposit  : " + totalbal);

        }
        public void Withdraw()
        {
            string temp = "";


            StreamWriter sr = new StreamWriter(myPath, true);

            do
            {

                Console.WriteLine("If you want Enter Or Exit Type: y/n ");
                temp = Console.ReadLine().ToLower();

                if (temp != "n")
                {
                    Console.WriteLine("Enter Customer Name :");
                    name = Console.ReadLine();
                    sr.WriteLine(name);

                    Console.WriteLine("Enter Account Number  :");
                    account = Convert.ToInt32(Console.ReadLine());
                    sr.WriteLine(account);

                    Console.WriteLine("Enter Withdraw Amount :");
                    withdraw = Convert.ToDouble(Console.ReadLine());
                    sr.WriteLine(withdraw);

                    if (withdraw <= balance)
                    {
                        totalbal = balance - withdraw;

                        Console.WriteLine("Customer Name: " + name);
                        Console.WriteLine("Account Number: " + account);
                        Console.WriteLine("Amount after Withdraw : " + totalbal);
                    }
                    else
                        Console.WriteLine("\n\nUnder balance");
                }


            } while (temp != "n");

            sr.Close();

        }
        public void ReaderFromFile()
        {
            StreamReader streamReader = new StreamReader(myPath);

            while (!streamReader.EndOfStream)
            {
                Console.WriteLine(streamReader.ReadLine());
            }

            streamReader.Close();

        }
        public class StreamReadWrite
        {
            static void Main(string[] args)
            {
                Account account = new Account();
                Console.WriteLine("Deposit......");

                account.Deposit();
                Console.WriteLine("Reading the data from file");
                Console.WriteLine();
                account.ReaderFromFile();

                Console.WriteLine("Withdraw.....");
                account.Withdraw();

                Console.WriteLine("Reading the data from file");
                Console.WriteLine();
                account.ReaderFromFile();
            }
        }

    }
}
