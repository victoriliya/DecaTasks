using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Week3_Task.Commons;

namespace Bank.Data
{

    /// <summary>
    /// This class handles reading and writing to files
    /// </summary>
    public static class TransactionSource
    {
        public static string path = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\transactionDB.json"); // Gets the current path in project.
        public static List<Account> AccountTbl { get; set; } = new List<Account>(); // Creates a list of account
        public static List<Transaction> TransactionTbl { get; set; } = new List<Transaction>();  


        // Reads form file
        public static string ReadFromJson()
        {
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

        // Writes to file
        public static void WriteToJson(Transaction transaction)
        {
            string fText = ReadFromJson();
            List<Transaction> myTransaction = JsonConvert.DeserializeObject<List<Transaction>>(fText);

            myTransaction.Add(transaction);
            try
            {
                var jsonToWrite = JsonConvert.SerializeObject(myTransaction, Formatting.Indented);

                File.WriteAllText(path, jsonToWrite);

            }
            catch (Exception)
            {
                throw;
            }


        }


    }
}
