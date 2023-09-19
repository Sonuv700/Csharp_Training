using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Bank
    {
        private string accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;



        public Bank(string accountNo, string customerName, string accountType)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = '\0';
            this.amount = 0;
            this.balance = 0;
        }



        public void Credit(double amount)
        {
            if (amount > 0)
            {
                this.transactionType = 'D';
                this.amount = amount;
                this.balance += amount;
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Amount should be greater than zero.");
                Console.ReadLine();
            }
        }



        public void Debit(double amount)
        {
            if (amount > 0 && this.balance >= amount)
            {
                this.transactionType = 'W';
                this.amount = amount;
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
                Console.ReadLine();
            }
        }



        public void ShowData()
        {
            Console.WriteLine("Account Number: " + this.accountNo);
            Console.WriteLine("Customer Name: " + this.customerName);
            Console.WriteLine("Account Type: " + this.accountType);
            Console.WriteLine("Transaction Type: " + this.transactionType);
            Console.WriteLine("Amount: " + this.amount);
            Console.WriteLine("Balance: " + this.balance);
            Console.ReadLine();
        }



        static void Main(string[] args)
        {
            Bank account1 = new Bank("78811", "Sonu Verma", "Savings");
            account1.Credit(1000);
            account1.ShowData();



            account1.Debit(500);
            account1.ShowData();
        }
    }
    }

