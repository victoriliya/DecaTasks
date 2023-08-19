using Bank.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Week3_Task.Commons;
using Week3_Task.Core;

namespace Bank.Core
{
    
    /// <summary>
    /// This class specifies transaction opations  
    /// </summary>
    public class TransactionRepository  : ITransactionRepository
    {
        // Return the balance of an account
 
        // Returns a list of transactions
        public static List<Transaction> WinStatementOfAccount(Account account)
        {

            string SQL = @$"SELECT * FROM transactions WHERE customers_account = '{account.AccountNumber}'";
            DB rdb = new DB();
            return rdb.GetTransacetionsDB(SQL);

        }


    }
}
