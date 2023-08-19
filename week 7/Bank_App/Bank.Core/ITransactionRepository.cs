using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Bank.Core
{
    
    /// <summary>
    /// This class specifies the transaction operations
    /// </summary>
    public interface ITransactionRepository
    {
        /// <summary>
        /// This method provides the logic for checking the balance
        /// </summary>
        private static double MyBalance { get; }

        /// <summary>
        /// Specify a list of transactions
        /// </summary>
        public static List<Transaction> WinStatementOfAccount { get; }
    }
}
