using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task
{
    //Add a Trust account class to the Account hierarchy
    //A Trust account has a name, a balance, and an interest rate
    //The Trust account deposit works just like a savings account deposit.
    //However, any deposits of $5000.00 or more will receive a $50.00 bonus deposited to the account.
    //The Trust account withdrawal should only allow 3 withdrawals per year and each of these must be less than 20% of the account balance.

    public class TrustAccount : SavingsAccount
    {
        private const int MaxWithdrawals = 3; 
        private int withdrawalsThisYear = 0;

        public TrustAccount(string name = "osama ahmed", double balance = 0.0, double interestRate = 0.0)
            : base(name, balance, interestRate)
        {
        }

        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                if (amount >= 5000)
                {
                    Balance += amount + 50;
                }
                else
                {
                    Balance += amount;
                }
                return true;
            }
            return false;
        }

        public override bool Withdraw(double amount)
        {
            if (withdrawalsThisYear >= MaxWithdrawals)
            {
                Console.WriteLine("Withdrawal limit reached for the year.");
                return false;
            }

            double maxAllowedWithdrawal = Balance * 0.2; 
            if (amount > maxAllowedWithdrawal)
            {
                Console.WriteLine($"Cannot withdraw more than 20% of the balance. Maximum allowed: {maxAllowedWithdrawal}");
                return false;
            }

            if (Balance - amount >= 0)
            {
                Balance -= amount;
                withdrawalsThisYear++;
                return true;
            }

            Console.WriteLine("Insufficient funds.");
            return false;
        }
        public override string ToString()
        {
            return $"Trust Account {Name} has balance {Balance} and interest rate {InterestRate}";
        }


    }


}

