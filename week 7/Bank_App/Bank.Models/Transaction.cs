﻿namespace Week3_Task.Commons
{

    /// <summary>
    /// Sets transaction data
    /// </summary>
    public class Transaction
    {
        //  fields
        public int TransactionId { get; set; }
        public string Note { get; set; }
        public string TypeOfTransaction { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAccount { get; set; }
        public string TransactionAmount { get; set; }


        public Transaction(string note, string typeOfTransaction, string customerName, string customerAccount, string transactionAmount)
        {
            Note = note;
            TypeOfTransaction = typeOfTransaction;
            CustomerName = customerName;
            CustomerAccount = customerAccount;
            TransactionAmount = transactionAmount;
        }

      
    }
}