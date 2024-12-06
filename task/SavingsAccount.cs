using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    // Add a Savings Account class to the Account hierarchy and adds an interest rata.

    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount(string Name = "osama ahmed", double Balance = 0.0, double InterestRate = 0.0)
            : base(Name, Balance)
        {
            this.InterestRate = InterestRate;

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
        public override bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public void AddInterest()
        {
            Balance += Balance * InterestRate;
        }
        public override string ToString()
        {
            return $"Savings Account {Name} has balance {Balance} and interest rate {InterestRate}";
        }

    }
}
