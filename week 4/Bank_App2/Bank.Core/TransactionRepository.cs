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
    public class TransactionRepository  : ITransactionRepository
    {
        private static double MyBalance(string accNumber) 
        {
            Account acc = AccountRepository.SearchAccountDB(accNumber);
            return acc.Balance;
        }
       
        public static List<Transaction> WinStatementOfAccount(Account account)
        {
            List<Transaction> listTransactions = new List<Transaction>();
            var fText = TransactionSource.ReadFromJson();

            List<Transaction> myTransactions = JsonConvert.DeserializeObject<List<Transaction>>(fText);

            foreach (var item in myTransactions)
            {
                if (item.CustomerAccount == account.AccountNumber)
                {
                    listTransactions.Add(item);
                }
                
            }

            return listTransactions;   
            
        }


    }
}
