using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment.One
{
    internal class Transaction
    {
        public int TransactionId;
        public string ProductName;
        public float Amount;
        public string DateAndTime;

        public Transaction() { }

        public Transaction(Transaction transaction)
        {
            this.TransactionId = transaction.TransactionId;
            this.ProductName = transaction.ProductName;
            this.Amount = transaction.Amount;
            this.DateAndTime = transaction.DateAndTime;
        }
    }
}
