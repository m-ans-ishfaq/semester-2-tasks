using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment.Three
{
    internal class ATM
    {
        public double Balance;
        public List<string> TransactionHistory;

        public ATM(double balance)
        {
            this.Balance = balance;
        }

        public void Deposit(double amount)
        {
            this.TransactionHistory.Add($"Deposit: {amount}");
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= this.Balance)
            {
                this.TransactionHistory.Add($"Withdrawn: {amount}");
                this.Balance -= amount;
            }
        }

        public double CheckBalance()
        {
            return this.Balance;
        }

        public List<string> GetTransactionHistory()
        {
            return this.TransactionHistory;
        }
    }
}
