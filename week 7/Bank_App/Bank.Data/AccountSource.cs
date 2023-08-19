using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Reflection;
using System.IO;
using Week3_Task.Commons;

namespace Bank.Data
{

    /// <summary>
    /// This class is the gateway to the data
    /// </summary>
    public static class AccountSource
    {
        public static string path = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\customerDB.json");

       
        // Reads all the data from file

        public static string ReadFromJson() {
            try
            {
                string jsonFromfile;
                using (StreamReader reader = new StreamReader(path))
                {
                    jsonFromfile = reader.ReadToEnd();
                }
                
                return jsonFromfile;

            }
            catch (Exception)
            {

                Console.WriteLine("Cant read from Json");
            }
            return string.Empty;
        }

        // Write data to file
        public static void WriteToJson(Account account)
        {
            string fText = ReadFromJson();
            List<Account> myAccount = JsonConvert.DeserializeObject<List<Account>>(fText);

            myAccount.Add(account);
            try
            {
                var jsonToWrite = JsonConvert.SerializeObject(myAccount, Formatting.Indented);

                File.WriteAllText(path, jsonToWrite);

                Console.WriteLine("Json added!!!!!s");
                Console.WriteLine("at " + path);
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
