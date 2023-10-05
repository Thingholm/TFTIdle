using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        private string name;
        private double balance;
        private bool locked;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public bool Locked
        {
            get { return locked; }
            set { locked = value; }
        }

        public BankAccount(double balance)
        {
            this.balance = balance;
        }
        public BankAccount(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }
        public BankAccount(string name, double balance, bool locked)
        {
            this.name = name;
            this.balance = balance;
            this.locked = locked;
        }

        public void Deposit(double amount)
        {
            if (!locked)
            {
                this.balance += amount;
            }
        }
        public void Withdraw(double amount)
        {
            if (amount <= this.Balance && !locked) 
            {
                this.balance -= amount;
            }
        }
        public void ChangeLockState()
        {
            this.locked = this.locked == true ? false : true;
        }
        public override string ToString()
        {
            return $"Name: {this.name}, Balance: {this.balance}";
        }
    }
}
