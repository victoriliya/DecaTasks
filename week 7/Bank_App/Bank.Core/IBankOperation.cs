using System;
using System.Collections.Generic;
using System.Text;
using Week3_Task.Commons;

namespace Bank.Core
{

    /// <summary>
    /// This class specifies the contract for all bank operations
    /// </summary>
    public interface IBankOperation
    {
        private static List<Account> myAccounts;
        private static List<Transaction> myTransactions;

        /// <summary>
        /// This methods create   account
        /// </summary>
        private static Account WinCreateAccount { get; }

        /// <summary>
        /// This method creates user to be used by win form UI
        /// </summary>
        public static Account WinCreateUser { get; }

        /// <summary>
        /// This method handles the logic for deposit operation
        /// </summary>
        public static Account Deposit { get; }

        /// <summary>
        /// This method handle transfer logic
        /// </summary>
        public static bool Transfer { get; }

    }
}
