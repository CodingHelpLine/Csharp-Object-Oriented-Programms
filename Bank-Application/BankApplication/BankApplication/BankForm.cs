using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class BankForm : Form
    {
        private Bank bank;

        public BankForm()
        {
            InitializeComponent();

            bank = new Bank();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int accountNumber = 0;

            if (radChecking.Checked)
            {
                accountNumber = Bank.NextAccountNumber();
                Account account = new CheckingAccount(accountNumber);
                bank.AddAccount(account);
            }
            else
            {
                accountNumber = Bank.NextAccountNumber();
                Account account = new SavingsAccount(accountNumber);
                bank.AddAccount(account);                
            }

            // add to combobox. 
            this.cboAccounts.Items.Clear();

            foreach (int number in bank.GetAccountNumbers())
            {
                this.cboAccounts.Items.Add(number);
            }

            MessageBox.Show($"Account has been created with id {accountNumber}");
        }

        /// <summary>
        /// Display Account details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.cboAccounts.SelectedIndex;

            if(index >= 0)
            {
                int accountNumber = int.Parse(this.cboAccounts.SelectedItem.ToString());

                Account account = bank.GetAccount(accountNumber);

                txtAccountFrom.Text = $"{account.AccountNumber}";
                txtBalance.Text = account.Balance.ToString("C02");
            }
        }

        /// <summary>
        /// Deposit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // Account must be selected
            // amount provided
            int idx = this.cboAccounts.SelectedIndex;

            if(idx >= 0)
            {
                // amount
                double amount = 0; 

                if(double.TryParse(txtAmount.Text, out amount))
                {
                    int accountNumber = 0;
                    int.TryParse(txtAccountFrom.Text, out accountNumber);

                    if(bank.Deposit(accountNumber, amount))
                    {
                        MessageBox.Show("Deposit Transaction Successful!");
                        txtAmount.Text = "";
                        txtBalance.Text = bank.GetAccount(accountNumber).Balance.ToString("C02");
                    }
                    else
                    {
                        MessageBox.Show("Deposit Transaction failed!");
                    }
                }
                else
                {
                    MessageBox.Show("You have entered invalid amount");
                }
            }
            else
            {
                MessageBox.Show("Please select an Account to do Transaction");
            }
        }

        /// <summary>
        /// Withdraw amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // Account must be selected
            // amount provided
            int idx = this.cboAccounts.SelectedIndex;

            if (idx >= 0)
            {
                // amount
                double amount = 0;

                if (double.TryParse(txtAmount.Text, out amount))
                {
                    int accountNumber = 0;
                    int.TryParse(txtAccountFrom.Text, out accountNumber);

                    if (bank.Withdaw(accountNumber, amount))
                    {
                        MessageBox.Show("Withdraw Transaction Successful!");
                        txtAmount.Text = "";
                        txtBalance.Text = bank.GetAccount(accountNumber).Balance.ToString("C02");
                    }
                    else
                    {
                        MessageBox.Show("Withdraw Transaction failed!");
                    }
                }
                else
                {
                    MessageBox.Show("You have entered invalid amount");
                }
            }
            else
            {
                MessageBox.Show("Please select an Account to do Transaction");
            }
        }

        /// <summary>
        /// Transfer Amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            // Account must be selected
            // amount provided
            int idx = this.cboAccounts.SelectedIndex;

            if (idx >= 0)
            {

                // need to get ToAccountNumber
                int fromAccountNumber = 0; 
                if(int.TryParse(txtAccountFrom.Text, out fromAccountNumber))
                {
                    // amount
                    double amount = 0;

                    if (double.TryParse(txtAmount.Text, out amount))
                    {
                        int toAccountNumber = 0;
                        int.TryParse(txtAccountTo.Text, out toAccountNumber);
                        MessageBox.Show($"Amount: {amount}");
                        if (bank.Transfer(fromAccountNumber, toAccountNumber, amount))
                        {
                            MessageBox.Show("Transfer Transaction Successful!");
                            txtAmount.Text = "";
                            txtBalance.Text = bank.GetAccount(fromAccountNumber).Balance.ToString("C02");
                            Console.WriteLine("{0}", bank.GetAccount(fromAccountNumber).Balance.ToString("C02"));
                        }
                        else
                        {
                            MessageBox.Show("Transfer Transaction failed!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have entered invalid amount");
                    }

                }
                else
                {
                    MessageBox.Show("Please enter Transfer account number");
                }

                
            }
            else
            {
                MessageBox.Show("Please select an Account to do Transaction");
            }
        }

        /// <summary>
        /// apply interest to selected account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            // Account must be selected
            // amount provided
            int idx = this.cboAccounts.SelectedIndex;

            if (idx >= 0)
            {
               
                int accountNumber = 0;
                int.TryParse(txtAccountFrom.Text, out accountNumber);
                double amount = bank.ApplyInterest(accountNumber);

                if (amount >= 0)
                {
                    MessageBox.Show($"Interest Added: {amount}");
                    txtAmount.Text = "";
                    txtBalance.Text = bank.GetAccount(accountNumber).Balance.ToString("C02");
                }
                else
                {
                    MessageBox.Show("Transaction failed!");
                }                
            }
            else
            {
                MessageBox.Show("Please select an Account to do Transaction");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
