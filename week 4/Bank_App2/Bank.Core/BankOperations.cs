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
    public class BankOperations : IBankOperation
    {
        /* Fields */
        // List of accounts
        private static List<Account> myAccounts = new List<Account>();
        private static List<Transaction> myTransactions = new List<Transaction>();
 
        private static Account WinCreateAccount(Account newAccount)
        {
            Account newAcc;
            myAccounts.Add(newAccount); 
            AccountSource.WriteToJson(newAccount);
            AccountSource.ReadFromJson();
            return AccountRepository.SearchAccountDB(newAccount.AccountEmail);
        }

        public static Account WinCreateUser(Customer customer)
        {
            var foundAccount = AccountRepository.SearchAccountDB(customer.Email);
            if (foundAccount != null && customer.Email == foundAccount.AccountEmail && (customer.Firstname + " " + customer.Surname) != foundAccount.AccountName)
            {
                return null;
            }

            customer.AccountNumber = Utilities.CreateAccountNumber();
            var fullName = customer.Firstname + " " + customer.Surname;

            string password = LoginUtilities.Hash(customer.Password);

            return BankOperations.WinCreateAccount(new Account(customer.Id, fullName, customer.Email, customer.AccountNumber, customer.AccountType, password));
        }

        public static Account Deposit( Deposit deposit )
        {
            string accountsDB = AccountSource.ReadFromJson();
            List<Account> myAccounts = JsonConvert.DeserializeObject<List<Account>>(accountsDB);
  
                var customerName = deposit.AccountName;
                var dAmount = deposit.Amount; 
                string accountNumber = deposit.AccountNumber;

                bool accountExist = false;

                foreach (var account in myAccounts)
                {
                    if (account.AccountNumber == accountNumber && String.Equals(account.AccountName, deposit.AccountName, StringComparison.OrdinalIgnoreCase))
                    {
                        accountExist = true;
                        var customerNote = deposit.Note;
                          
                        account.Balance += deposit.Amount;

                        string jsonToWrite = JsonConvert.SerializeObject(myAccounts, Formatting.Indented);
                       File.WriteAllText(AccountSource.path, jsonToWrite);

                       Transaction transaction = new Transaction(customerNote, "deposit", customerName, accountNumber, deposit.Amount.ToString() );
                        TransactionSource.WriteToJson(transaction);
                        return account;
                        
                    }
                }

            if (accountExist != true)
                {
                return null;
                }
            return null; 

        }

      
        // Make withdrawals
        private static void Withdrawal(Account user)
        {
            string accountsDB = AccountSource.ReadFromJson();
            List<Account> myAccounts = JsonConvert.DeserializeObject<List<Account>>(accountsDB);         
            var maxAmount = 999999; // Make maximum for current 999999
                 
            if (user.AccountType == "savings" && user.Balance < 1001 ) // Make maximum for savings 1000
            {
                Console.WriteLine("Insufficient funds!!");
            }
        }  

    }
}