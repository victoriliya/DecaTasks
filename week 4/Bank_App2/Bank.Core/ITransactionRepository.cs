using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Bank.Core
{
    interface ITransactionRepository
    {
        private static double MyBalance { get; }
        public static List<Transaction> WinStatementOfAccount { get; }
    }
}
