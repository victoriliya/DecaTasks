using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text.RegularExpressions;



namespace Week3_Task.Commons
{
    public static class Utilities
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool ValidateNumber(string entry) // Ensures entry is a number
        {
            if (entry.Length > 0)
            {
                Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
                return regex.IsMatch(entry.Trim());
            }
            return false;
        }
      
        public static bool ValidateText(string name) // Make sure entry is a word
        {
            if (name.Length > 0)
            {
                Regex regex = new Regex(@"^(?=.*\d)[^!<>?=+@{}_#-$%]+$");
                return !(regex.IsMatch(name.Trim()));
            }
            return false;
        }
              
        public static string CreateAccountNumber() // Creates account using date time
        {          
            DateTime localDate = DateTime.Now;
            string acc = String.Format("{0:yyyymmmds}", localDate);
            return acc.PadRight(10, '0');
        }
        
        public static string FirstCharacterToUpper(string val) // Makes names first character to upper
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



    }
}