using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using Week3_Task.Core;
using Week3_Task.Models;

namespace Week3_Task.Commons
{
    public static class Utilities
    {
        private static bool ValidateNumber(string entry)
        {
            if (entry.Length > 0)
            {
                Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
                return regex.IsMatch(entry.Trim());
            }

            return false;

        }
        private static bool ValidateEmail(string emailaddress)
        {
            try
            {
                if (emailaddress.Length > 0)
                {
                    MailAddress m = new MailAddress(emailaddress.Trim());
                    return true;
                }

                return false;


            }
            catch (FormatException)
            {
                return false;
            }
        }
        private static bool ValidateName(string name)
        {
            if (name.Length > 0)
            {
                Regex regex = new Regex(@"^(?=.*\d)[^!<>?=+@{}_#-$%]+$");
                return !(regex.IsMatch(name.Trim()));
            }

            return false;
        }
      
        public static string GetNumber(string text)
        {
            string number;
            while (true)
            {
                Console.Write(text);
                number = Console.ReadLine();
    
                if (ValidateNumber(number))
                {
                    return number.Trim();
                }
                else if (number == "r")
                {
                    BankOperations.Home();
                }
                else
                {
                    Console.WriteLine("This is not a valid number...");
                }
            }
            return  number;
        }
        public static string GetName(string text)
        {
            string name;
            while (true)
            {
                Console.Write(text);
                name = Console.ReadLine();
                if (ValidateName(name))
                {
                    break;
                }
                else if (name == "r")
                {
                    BankOperations.Home();
                }
                else
                {
                    Console.WriteLine("This is not a valid name...");
                }
            }
            return  FirstCharacterToUpper(name);
        }
        public static string GetEmail()
        {
            string email;
            while (true)
            {
                Console.Write("Input your valid email address: ");
                email = Console.ReadLine();
                if (ValidateEmail(email))
                {
                    return email;
                    break;
                }
                else
                {
                    Console.WriteLine("This is not a valid email address...");
                }

            }
            return email;
        }
        public static string GetAccountType()
        {
            string accountTypeEntry;
            while (true)
            {
                Console.Write("To open savings account enter 1. To open a current account enter 2: ");
                accountTypeEntry = Console.ReadLine();
                if (accountTypeEntry == "1")
                {
                    accountTypeEntry = "savings";
                    return accountTypeEntry;
                }else if (accountTypeEntry == "2")
                {
                    accountTypeEntry = "current";
                    return accountTypeEntry;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number, 1 0r 0...");                    
                }
            }
            return accountTypeEntry;
        }
        public static string CreatePassword(Account foundAccount)
        {
            string password;
            string cPassword;
        
            while (true)
            {
                Console.Write("Create a password: ");
                password = HidePassword();
                if (foundAccount != null)
                {
                    if (password == foundAccount.AccountPassword)
                    {
                        Console.WriteLine("\nPassword already associated to another account, choose another password....");
                        continue;
                    }
                }

                Console.Write("\nConfirm password: ");
                cPassword = HidePassword();
                
                if (password == "q" || password == "Q")
                {
                    BankOperations.Home();
                }else if (password == cPassword)
                {
                    Console.WriteLine("\n\nPassword successfully created...");
                    return password;
                    break;
                }else
                {
                    Console.WriteLine("\nPassword did not match.....");
                }
            }
        }
        public static void GoHome(string input)
        {
            if (input == "q" || input == "q")
            {
                BankOperations.Home();
            }
        }

        public static void Logout()
        {
            Console.WriteLine("Press enter to logout: ");
            Console.ReadLine();
            BankOperations.Home();
        }

        public static string HidePassword()
        {
            string password = "";              
            ConsoleKeyInfo key;
            string code = "";
            do
            {
                key = Console.ReadKey(true);
                if (Char.IsLetterOrDigit(key.KeyChar))
                {
                    Console.Write("*");
                }
                password += key.KeyChar;
            } while (key.Key != ConsoleKey.Enter);

            return password;
        }

        public static string CreateAccountNumber()
        {
            
            DateTime localDate = DateTime.Now;
            
            return String.Format("{0:yyyymmmds}", localDate);
        }
        
        public static string FirstCharacterToUpper(string val)
        {
            var str = val.Substring(0, 1).ToCharArray();
            var strCode = (int)str[0];
            if (strCode >= 97)
            {
                var strCaps = strCode - 32;
                return (char)strCaps + val.Substring(1);
            }

            return val;
        }

        public static string MaskAccountNumber(string e)
        {
            string value = e.ToString();

            // set asterisk to hide first n - 4 digits
            string asterisks = new string('*', value.Length - 4);

            // pick last 4 digits for showing
            string last = value.Substring(value.Length - 4, 4);

            // combine both asterisk mask and last digits
            return asterisks + last;

            // display as column text
            
        }


    }
}