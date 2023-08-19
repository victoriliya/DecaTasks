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

    
    
    /// <summary>
    /// This interface specifies contract for account operations
    /// </summary>
    public class  AccountRepository : IAccountRepository
    {

        /// <summary>
        /// This methods search for account that will be used in winforms
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
/*
        public static Account SearchAccountWithEmail(string email)
        {
            string SQL = @$"SELECT * FROM account WHERE account_mail = '{email}'";
            DB db = new DB();
            return db.GetFromDB(SQL);
        }
*/
        public static Account SearchAccountWithEmail(string email)
        {
            string SQL = @$"SELECT * FROM account WHERE account_mail = '{email}'";
            MySqLiteDB db = new MySqLiteDB();
            return db.GetFromDB(SQL);
        }

        public static Account SearchAccountWinAccountNumber(string account)
        {
            string SQL = @$"SELECT * FROM account WHERE account_number = '{account}'";

            DB db = new DB();
            return db.GetFromDB(SQL);

        }


    }
}
