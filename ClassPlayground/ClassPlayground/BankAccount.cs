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

        public BankAccount(int accountNumber, string holderName, string currency, double balance)
        {
            Random rnd = new Random();
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.currency = currency;
            this.balance = balance;
        }

        public double Deposit(double addMoney)
        {
            balance += addMoney;
            return balance;
        }

        public double Withdraw(double withdrawMoney)
        {
            balance -= withdrawMoney;
            return balance;
        }

        public void Transfer(double sendMoney, int accountnumber)
        {
            if (balance >= sendMoney)
            {
                balance -= sendMoney;
                balance += sendMoney;
            }
            else
            {
                Console.WriteLine("nemáš dost peněz");
                return;
            }
        }
    }
}
