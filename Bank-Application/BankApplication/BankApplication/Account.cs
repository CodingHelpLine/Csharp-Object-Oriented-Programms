using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// Base class for Accounts - Abstract
    /// </summary>
    abstract class Account
    {
        // account number
        // balance
        private int accountNumber;
        protected double balance; 

        /// <summary>
        /// Constructor with account number
        /// </summary>
        /// <param name="accountNumber"></param>
        public Account(int accountNumber)
        {
            this.accountNumber = accountNumber;
            balance = 0; 
        }

        /// <summary>
        /// Constructor with account number and initial balance
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="initBalance"></param>
        public Account(int accountNumber, double initBalance)
        {
            this.accountNumber = accountNumber;
            this.balance = initBalance;
        }

        /// <summary>
        /// Readly Only Property
        /// </summary>
        public double Balance
        {
            get { return balance; }
        }

        /// <summary>
        /// Read Only properly for Account Number
        /// </summary>
        public int AccountNumber
        {
            get { return accountNumber; }
        }

        /// <summary>
        /// Method to deposit an amount
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public abstract bool Deposit(double amount);

        /// <summary>
        /// Method to withdraw funds
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public abstract bool Withdraw(double amount);

        /// <summary>
        /// Function to transfer funds. 
        /// </summary>
        /// <param name="toAccount"></param>
        /// /// <param name="amount"></param>
        /// <returns></returns>
        public abstract bool Transfer(Account toAccount, double amount);
        

    }
}
