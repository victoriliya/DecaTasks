using System;
using System.Collections.Generic;
using System.Text;
using Week3_Task.Commons;

namespace Bank.Core
{
    interface IBankOperation
    {
        private static List<Account> myAccounts;
        private static List<Transaction> myTransactions;

        private static Account WinCreateAccount { get; }
        public static Account WinCreateUser { get; }
        public static Account Deposit { get; }

    }
}
