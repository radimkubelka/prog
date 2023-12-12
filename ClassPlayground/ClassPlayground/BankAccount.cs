using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class BankAccount
    {
        public int accountNumber;
        public string holderName;
        public string currency;
        public double balance;

        public BankAccount(string holderName, string currency)
        {
            Random rnd = new Random();
            accountNumber = rnd.Next(10000000, 1000000000);
            this.holderName = holderName;
            this.currency = currency;
            balance = 0;
        }

        public double Deposit(double addMoney)
        {
            balance += addMoney;
            return balance;
        }

        public double Withdraw(double withdrawMoney)
        {
            if (balance >= withdrawMoney)
            {
                balance -= withdrawMoney;
                return balance;
            }
            else
            {
                Console.WriteLine("nemáš dost peněz");
                return 0;
            }
        }

        public void Transfer(double sendMoney, BankAccount targetaccount)
        {
            if (balance >= sendMoney)
            {
                Withdraw(sendMoney);
                targetaccount.Deposit(sendMoney);
            }
            else
            {
                Console.WriteLine("nemáš dost peněz");
                return;
            }
        }
    }
}
