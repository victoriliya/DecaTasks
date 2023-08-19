using System;
using System.Collections.Generic;
using Week3_Task.Commons;
using Week3_Task.Models;

namespace Week3_Task.Core
{
    public class BankOperations
    {
        private static List<Account> myAccounts = new List<Account>();
        private static List<Transaction> myTransactions = new List<Transaction>();
        private bool CreateAccount(Account newAccount)
        {
            myAccounts.Add(newAccount);
            Console.WriteLine("\nAccount successfully created... Hurray!!!");
            PrintAll();
            return true;
        }
        public static void Home()
        {
            string input;
            string email;
            Console.WriteLine(@"                
                             ''~``
                            ( o o )
    +------------------.oooO--(_)--Oooo.------------------+
    |               Welcome to Bank Vickoin               |
    |                    .oooO                            |
    |                    (   )   Oooo.                    |
    +---------------------\__/----(___)-------------------+
");
            while (true)
            {
                Console.WriteLine("=> To Log into your account enter 1.");
                Console.WriteLine("=> To Create an account enter 2. ");
                Console.Write("=> To deposit enter 3: ");
                input = Console.ReadLine();
       
                if (input == "1")
                {
                    LoginUser();
                    // CustomerOperation.Login();
                    break;
                }else if (input == "2")
                {
                    CreateUser();
                    break;
                }
                else if (input == "3")
                {
                    Deposit();
                    break;
                }
                else
                {
                    Console.WriteLine("Please input either 1, 2 or 3.");
                }
            }
        }
            
        private static void CreateUser()
        {
            var newCustomer = new Customer();
            
            newCustomer.AccountType = Utilities.GetAccountType();

            newCustomer.Firstname = Utilities.GetName("Enter your firstname: ");
            
            newCustomer.Surname = Utilities.GetName("Enter your surname: ");

            newCustomer.Email = Utilities.GetEmail();

            var foundAccount = BankOperations.SearchAccount(newCustomer.Email);
            if (foundAccount != null && newCustomer.Email == foundAccount.AccountEmail && (newCustomer.Firstname + " " + newCustomer.Surname) != foundAccount.AccountName)
            {
                Console.WriteLine("Email Already registered to another account...");
                CreateUser(); 
            }
            
            newCustomer.AccountNumber = Utilities.CreateAccountNumber();
            
            newCustomer.Password = Utilities.CreatePassword(foundAccount);

            var fullName = newCustomer.Firstname + " " + newCustomer.Surname;

            Console.WriteLine("|------------------|---------------|----------------|--------------|");
            Console.WriteLine("|       Name       |    Email      | Account Number | Account Type |");
            Console.WriteLine("|------------------|---------------|----------------|--------------|");
            Console.WriteLine("| {0, -17}| {1, -13} | {2, -14} | {3, -12} |", fullName, newCustomer.Email, newCustomer.AccountNumber, newCustomer.AccountType);
            Console.WriteLine("|------------------|---------------|----------------|--------------|");

            Console.WriteLine("Verify your input above.Press enter any key to create an account...");
            Console.WriteLine("Or press to enter q to re-input fields.");
            Console.Write("Or press to enter h to restart session: ");
            var create = Console.ReadLine();

            if (create == "q" ||create == "Q")
            {
                CreateUser();
            }
            else if (create == "h" ||create == "H")
            {
                BankOperations.Home();
            }else
            {
                var myBank = new BankOperations();

                myBank.CreateAccount(new Account(fullName, newCustomer.Email,  newCustomer.AccountNumber, newCustomer.AccountType, newCustomer.Password));
                Console.WriteLine("Press Enter to continue");
                while (true)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Account foundUser = BankOperations.SearchAccount(newCustomer.Email);
                        BankOperations.Dashboard(foundUser);
                    }
                }
            }
        }
        private static void Deposit()
        {
            while (true)
            {
                var customerName = Utilities.GetName("Enter you full name in the format 'shawn carter': ");
                var depositAmount = Utilities.GetNumber("Enter the amount you wish to deposit: ");
                var dAmount = Double.Parse(depositAmount);
                if (dAmount >= 999999)
                {
                    Console.WriteLine("Upgrade to premium account to deposit above 1000000");
                    continue;
                }
                string accountNumber = Utilities.GetNumber("Enter the account number: ");
                
                //Console.WriteLine($"Deposit Amount  {depositAmount} Account Number {accountNumber}");
               
                var foundAccount = SearchAccount(accountNumber);
                if (foundAccount != null)
                {
                    var customerNote = Utilities.GetName("Add a note : ");
                    myTransactions.Add(new Transaction(customerNote, "Deposit", customerName, accountNumber, depositAmount));
                    PrintAccount(foundAccount);
                    Console.WriteLine($"Press enter to transfer {depositAmount} to the account above");
                    if (Console.ReadLine() != "q")
                    {
                        foundAccount.Balance += Double.Parse(depositAmount);
                        Console.WriteLine($@"{depositAmount} has be transferred to {foundAccount.AccountName} {foundAccount.AccountNumber} successfully :) ");
                        PrintAll();
                        BankOperations.Home();
                    }
                }
                else
                {
                    Console.WriteLine("Account not found...");
                    Console.WriteLine("Enter 'q' to go home or press the enter key to go re-enter..");
                    Utilities.GoHome(Console.ReadLine());

                }
            }
        }

        private static void Withdrawal(Account user)
        {
            while (true)
            {
                var amount = Utilities.GetNumber("How much would you like to withdraw: ");
                var customerNote = Utilities.GetName("Add Note: ");
                var amountToWithdraw = Double.Parse(amount);
                var maxAmount = 999999;
                
                 
                if (user.AccountType == "savings")
                {
                    maxAmount = 1000;
                }
                if (user.Balance > amountToWithdraw && amountToWithdraw != 0)
                {
                    Console.WriteLine("amountToWithdraw " + user.AccountType);
                    Console.WriteLine("maxAmount " + maxAmount);
                    
                    if (amountToWithdraw <= maxAmount)
                    {
                        user.Balance -= amountToWithdraw;
                        myTransactions.Add(new Transaction(customerNote, "Withdrawal", "Self", user.AccountNumber, amountToWithdraw.ToString()));
                        Console.WriteLine($"#{amountToWithdraw} has been successfully withdrawn from {Utilities.MaskAccountNumber(user.AccountNumber)}.");
                        Console.WriteLine($"Your balance is {Balance(user.AccountNumber)}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot withdraw more that #{maxAmount} at a time for this account...");
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Insufficient funds!");
                    Console.WriteLine($"Your balance is {Balance(user.AccountNumber)}");
                }

                Console.Write("Enter any key to try again or press 'd' to go back: ");
                if (Console.ReadLine() == "d")
                {
                    Dashboard(user);
                }
                
                
            }
          
            
        }
        private static void Transfer(Account user)
        {
            var transferAmount = Utilities.GetNumber("Amount to be transferred: ");
            var transferAmountNum = Double.Parse(transferAmount);
            var getAccountNumber = Utilities.GetNumber("Enter recipients Vickoin account number: ");
            var recipientAccount = SearchAccount(getAccountNumber);
            if (recipientAccount != null)
            {
                var note = Utilities.GetName("Add Note");
                user.Balance -= transferAmountNum;
                recipientAccount.Balance += transferAmountNum;
                myTransactions.Add(new Transaction(note, "Transfer", user.AccountName, user.AccountNumber, transferAmount));
                myTransactions.Add(new Transaction(note, "Transfer", recipientAccount.AccountName, recipientAccount.AccountNumber, transferAmount));
                Console.WriteLine("Transfer successfull!....");
            }
            else
            {
                Console.WriteLine("Recipient account not found in Vickoin Peoples Bank: ");
            }

            Console.WriteLine("To back to dashboard enter: " );
            Console.ReadLine();
            Dashboard(user);
        }
        private static void CheckBalance(Account user)
        {
            var balance = Balance(user.AccountNumber);
            Math.Round(balance, 2);
            string fBalance = balance.ToString("0.00");
            Console.WriteLine($"Dear {user.AccountName} the balance for account number {Utilities.MaskAccountNumber(user.AccountNumber)}, is #{fBalance}");
            Dashboard(user);
        }
        
        public void CloseAccount()
        {
            
        }
        private static void PrintAll()
        {
            foreach (var acc
                in myAccounts)
            {
                
                string fBalance = Math.Round(acc.Balance, 2).ToString("0.00");
                Console.WriteLine("____________________________________");
                Console.WriteLine($"-> Account Mail: {acc.AccountEmail} \n-> Account Name: {acc.AccountName} \n-> Account Number: {acc.AccountNumber} \n-> Account Type: {acc.AccountType} \n-> Account Balance: #{fBalance} ");
            }
        }
        private static void PrintAccount(Account acc)
        {
            if (acc == null)
            {
                Console.WriteLine("Account not found!");
            }
            Console.WriteLine($"Account Mail: {acc.AccountEmail} Account Password: {acc.AccountPassword} Account Name: {acc.AccountName} Account Number: {acc.AccountNumber} Account Type: {acc.AccountType}");

        }
        private static void StatementOfAccount(string accNumber)
        {
            double accountBalance = Balance(accNumber);
            Math.Round(accountBalance, 2);
            string fBalance = accountBalance.ToString("0.00");
            int s = 0;
            foreach (var item in myTransactions)
            {
                if (item.CustomerAccount == accNumber)
                {
                    s++;
                    if (s == 1)
                    {
                        Console.WriteLine("________________________________________________________________________________________");
                        Console.WriteLine("|       Name       | Account Number | Transaction Type |     Amount    |     Note      |");
                        Console.WriteLine("|__________________|________________|__________________|_______________|_______________|");

                    }

                    Console.WriteLine("| {0, -16} | {1, -14} | {2, -16} | #{3, -12} | {4, -13} |", item.CustomerName, Utilities.MaskAccountNumber(item.CustomerAccount), item.TypeOfTransaction, item.TransactionAmount, item.Note );
                    Console.WriteLine("|______________________________________________________________________________________|");
                }
            }

            if (s == 0)
            {
                Console.WriteLine("No transaction has be done on this account");
            }

            Console.WriteLine($"Balance is #{fBalance}" );
            Console.WriteLine("Press enter to go home: ");
            Console.ReadLine();
            BankOperations.Home();

        }
        public static bool LoginUser()
        {
            Console.WriteLine("|---LOGIN---|");
            while (true)
            {
                Console.WriteLine("Enter 'q' to go home or ");
                Console.Write("Enter your email: ");
                string email = Console.ReadLine();
                Utilities.GoHome(email);
                Console.Write("Enter your password: ");
                //string password = Console.ReadLine();
                string password = Utilities.HidePassword();
                Account foundUser = SearchAccount(email);
                if (foundUser != null )
                {
                    if (foundUser.AccountPassword == password)
                    {
                        Dashboard(foundUser);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nPassword is incorrect....");
                    }
                    
                }
                else
                {
                    Console.WriteLine("\nEmail not found!....");
                }

                
            }

            return false;
        }
        public static Account SearchAccount(string entry)
        {
            foreach (var acc
                in myAccounts)
            {
                if (acc.AccountEmail == entry || acc.AccountType == entry || acc.AccountNumber == entry)
                {
                    return acc;
                }
            }
            return null;
        }
        private static double Balance(string accNumber)
        {
            Account acc = SearchAccount(accNumber);
            return acc.Balance;
        }
        public static  void Dashboard(Account user)
        {
            Console.WriteLine("\n=> To Deposit press 1");
            Console.WriteLine("=> To Withdraw press 2");
            Console.WriteLine("=> To Transfer press 3");
            Console.WriteLine("=> To Check Balance press 4");
            Console.WriteLine("=> To Transfer Get Statement Of Account 5");
            Console.WriteLine("=> enter 'n' to start new session: ");

            while (true)
            {
                string input;
                input = Console.ReadLine();
                if (input == "1")
                {
                    Deposit();    
                    break;
                }else if (input == "2")
                {
                    Withdrawal(user);
                    break;
                }else if (input == "3")
                {
                    Transfer(user);
                    break;
                }else if (input == "4")
                {
                    CheckBalance(user);
                    break;
                }else if (input == "5")
                {
                    StatementOfAccount(user.AccountNumber);
                    break;
                }
                else if (input == "n")
                {
                    BankOperations.Home();
                    break;
                }
                else 
                {
                    Console.WriteLine("Please input either 1, 2, 3, 4, 5 or 'n'...");
                }        
            }

            
        }

    }
}