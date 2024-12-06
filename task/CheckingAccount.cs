using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace task
{
    public class CheckingAccount :Account
    {
        //  A Checking account has a name and a balance and has a fee of $1.50 per withdrawal transaction.Every withdrawal transaction will be assessed this flat fee.
        public double Fee { get; set; } 
       public CheckingAccount(string name = "osama ahmed", double balance = 0.0)
            : base(name, balance)
        {
            Fee = 1.50;
        }
        public override bool Withdraw(double amount)
        {
            if (Balance - amount - Fee >= 0)
            {
                Balance -= amount + Fee;
                return true;
            }
            return false;
        }
        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }


        public override string ToString()
        {
            return $"Checking Account {Name} has balance {Balance}";
        }


    }
}
