using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(string Name = "osama ahmed", double Balance = 0.0)
        {
            this.Name = Name;
            this.Balance = Balance;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }

        public virtual bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public static Account operator +(Account acc1, Account acc2)
        {
            return new Account(acc1.Name + " & " + acc2.Name, acc1.Balance + acc2.Balance);
        }
        public override string ToString()
        {
            return $"Account {Name} has balance {Balance}";
        }
    }
}
