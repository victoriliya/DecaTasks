using Bank.Core;
using System;
using Week3_Task.Core;

namespace Bank.Config
{
    public class BankConfig
    {
        // Middleware to Logic Interface and User Interface
        public static IAccountRepository IAccountInstance { get; private set; }
        public static void AddIAccountInstance()
        {
            AccountRepository ac = new AccountRepository();
            IAccountInstance = ac;
        }

        // Sets the account account instance to null
        public static void RemoveIAccountInstance()
        {
            IAccountInstance = null;
        }

        // Sets the bank operation interface
        public static IBankOperation IOperationInstance { get; private set; }
        public static void AddIBankOperation()
        {
            BankOperations bo = new BankOperations();
            IOperationInstance = bo;
        }

        // Set bank operation interface to null
        public static void RemoveIBankOperation()
        {
            IOperationInstance = null;
        }

        
        public static ITransactionRepository ITransactionInstance { get; private set; }

        // Set the transaction interface
        public static void AddITransactionRepository()
        {
            TransactionRepository ti = new TransactionRepository();
            ITransactionInstance = ti;
        }

        // sets the transaction interface to null
        public static void RemoveITransactionRepository()
        {
            ITransactionInstance = null;
        }

    }
}
