using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class SavingsAccount : Account
    {
        // Interest Rate 
        private const double IR = 0.0375;

        /// <summary>
        /// Constructor with account number
        /// </summary>
        /// <param name="accountNumber"></param>
        public SavingsAccount(int accountNumber)
            : base(accountNumber)
        {
        }

        /// <summary>
        /// Constructor with account number and initial balance
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="initBalance"></param>
        public SavingsAccount(int accountNumber, double initBalance)
            : base(accountNumber, initBalance)
        {
        }


        /// <summary>
        /// Method to deposit an amount
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override bool Deposit(double amount)
        {
            // check positive
            if (amount < 0)
            {
                return false;
            }
            else
            {
                balance += amount;
            }

            return true;
        }

        /// <summary>
        /// Method to withdraw funds
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override bool Withdraw(double amount)
        {
            if (amount > 0)
            {
                // sufficient balance
                if ((amount) <= balance)
                {
                    balance -= (amount);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Function to transfer funds. 
        /// </summary>
        /// <param name="toAccount"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override bool Transfer(Account toAccount, double amount)
        {
            // first check amount +ve
            // Balance is sufficient
            if (Withdraw(amount))
            {
                toAccount.Deposit(amount);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Apply Interest to the Balance
        /// </summary>
        /// <returns></returns>
        public double ApplyInterest()
        {
            double interest = balance * IR;
            Deposit(interest);
            return interest;
        }

    }
}
