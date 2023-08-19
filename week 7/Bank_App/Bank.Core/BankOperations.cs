using Bank.Commons;
using Bank.Core;
using Bank.Data;
using Bank.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Week3_Task.Commons;

namespace Week3_Task.Core
{

    /// <summary>
    /// This class implements banking operations
    /// </summary>
    public class BankOperations : IBankOperation
    {
        /* Fields */
        // List of accounts
        private static List<Account> myAccounts = new List<Account>();
        private static List<Transaction> myTransactions = new List<Transaction>();
 
        /*Methods*/


        // Create a new user for winform

        public static Account WinCreateUser(Customer customer)
        {
            var foundAccount = AccountRepository.SearchAccountWithEmail(customer.Email);
            if (foundAccount != null && customer.Email == foundAccount.AccountEmail && (customer.Firstname + " " + customer.Surname) != foundAccount.AccountName)
            {
                return null;
            }

            customer.AccountNumber = Utilities.CreateAccountNumber();
            var fullName = customer.Firstname + " " + customer.Surname;

            string password = LoginUtilities.Hash(customer.Password);


            string SQL = @$"INSERT INTO account (id, account_name, account_number, account_type, account_mail, account_password, account_balance) VALUES ('{customer.Id}', '{fullName}', '{customer.AccountNumber}', '{customer.AccountType}', '{customer.Email}', '{password}', {0})";
            DB db = new DB();
            db.QueryExecute(SQL);

            return AccountRepository.SearchAccountWithEmail(customer.Email); ;
        }


        public static Account Deposit(Deposit deposit, Account inAccount)
        {
            Account account;
            var customerName = deposit.AccountName;
            var dAmount = deposit.Amount;
            string accountNumber = deposit.AccountNumber;
            double bal = 0;

            bool accountExist = false;

            account = AccountRepository.SearchAccountWinAccountNumber(deposit.AccountNumber);

            if (account.AccountNumber == accountNumber && String.Equals(account.AccountName, deposit.AccountName, StringComparison.OrdinalIgnoreCase))
            {
                accountExist = true;
                var customerNote = deposit.Note;
                
                bal = account.Balance + deposit.Amount;


                string SQL = @$"UPDATE account SET account_balance = {bal} WHERE account_number = '{deposit.AccountNumber}'";
                DB db = new DB();
                db.QueryExecute(SQL);

                string depositSQL = @$"INSERT INTO transactions ( note, type_of_transaction, customers_name, customers_account, transaction_amount) VALUES ( '{deposit.Note}', 'deposit', '{deposit.AccountName}', '{deposit.AccountNumber}', {deposit.Amount})";

                DB ddb = new DB();
                ddb.QueryExecute(depositSQL);

                return account;

            }
            

            if (accountExist != true)
            {
                return null;
            }
            return null;

        }

        public static bool Transfer(Transfer transfer, Account sendersAccount)
        {
            var customerName = transfer.AccountName;
            string accountNumber = transfer.RecipientsAccount;
            bool accountExist = false;

            Account account = AccountRepository.SearchAccountWinAccountNumber(transfer.RecipientsAccount);
            Account saccount = AccountRepository.SearchAccountWinAccountNumber(sendersAccount.AccountNumber);

            if (account.AccountNumber != null)
            {
                accountExist = true;
                var customerNote = transfer.Note;
                account.Balance += transfer.Amount;  // 
                string SQL = @$"UPDATE account SET account_balance = {account.Balance} WHERE account_number = '{account.AccountNumber}'";
                DB db = new DB();
                db.QueryExecute(SQL);

                string rdepositSQL = @$"INSERT INTO transactions ( note, type_of_transaction, customers_name, customers_account, transaction_amount) VALUES ( '{customerNote}', 'deposit', '{account.AccountName}', '{account.AccountNumber}', {transfer.Amount})";
                DB rdb = new DB();
                rdb.QueryExecute(rdepositSQL);


                saccount.Balance -= transfer.Amount;
                string NSQL = @$"UPDATE account SET account_balance = {saccount.Balance} WHERE account_number = '{saccount.AccountNumber}'";
                DB ndb = new DB();
                db.QueryExecute(NSQL);

                string sdepositSQL = @$"INSERT INTO transactions ( note, type_of_transaction, customers_name, customers_account, transaction_amount) VALUES ( '{customerNote}', 'transfer', '{sendersAccount.AccountName}', '{saccount.AccountNumber}', {transfer.Amount})";
                DB sdb = new DB();
                sdb.QueryExecute(sdepositSQL);

            }

            if (accountExist == false)
            {
                return false;
            }
            return true;

        }

        // Handles logic for transfer  operation

        // Handles withdrawal operations


        public static bool Withdraw(Withdraw withdraw, Account caccount)
        {
            Account account = AccountRepository.SearchAccountWinAccountNumber(caccount.AccountNumber);

            if (account.AccountNumber != null)
            {
                account.Balance -= withdraw.Amount;

                string WSQL = @$"UPDATE account SET account_balance = {account.Balance} WHERE account_number = '{account.AccountNumber}'";
                DB wdb = new DB();
                wdb.QueryExecute(WSQL);

                string swithdrawSQL = @$"INSERT INTO transactions ( note, type_of_transaction, customers_name, customers_account, transaction_amount) VALUES ( '{withdraw.Note}', 'withdrawal', '{account.AccountName}', '{account.AccountNumber}', {withdraw.Amount})";
                DB sdb = new DB();
                sdb.QueryExecute(swithdrawSQL);
                return true;
            }
            
            return false;
        }      

        // This method fetches account from DB
        public static Account GetAccount(Account account) {
            return AccountRepository.SearchAccountWinAccountNumber(account.AccountNumber);          
        }

    }

}
