using Bank.Commons;
using Bank.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Week3_Task.Commons;
using Week3_Task.Core;

namespace Bank.Core
{
    public class  AccountRepository : IAccountRepository
    { 
        public static Account SearchAccountWin(string email) {
            string jsonFromfile = AccountSource.ReadFromJson();
            List<Account> myAccounts = JsonConvert.DeserializeObject<List<Account>>(jsonFromfile);
            foreach (var item in myAccounts)
            {
                if (true)
                {
                    return item;
                }
            }
            return null;
        }


        public static Account SearchAccountDB(string entry)
        {

            string jsonText = AccountSource.ReadFromJson();
            List<Account> myAccounts = JsonConvert.DeserializeObject<List<Account>>(jsonText);
           
            foreach (var acc in myAccounts)
            {
                if (acc.AccountEmail == entry || acc.AccountType == entry || acc.AccountNumber == entry)
                {
                    return acc;
                }
            }
            return null;

        }

    }
}
