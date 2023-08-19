using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Week3_Task.Commons;

namespace Bank.Data
{
    public static class TransactionSource
    {
        public static string path = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\transactionDB.json");
        public static List<Account> AccountTbl { get; set; } = new List<Account>();
        public static List<Transaction> TransactionTbl { get; set; } = new List<Transaction>();

        public static string ReadFromJson()
        {
            try
            {
                string jsonFromfile;
                using (StreamReader reader = new StreamReader(path))
                {
                    jsonFromfile = reader.ReadToEnd();
                }
                /*Console.WriteLine("Files");
                Console.WriteLine(jsonFromfile);
*/

                return jsonFromfile;

            }
            catch (Exception)
            {

                Console.WriteLine("Cant read from Json");
            }

            return string.Empty;
        }

        public static void WriteToJson(Transaction transaction)
        {
            string fText = ReadFromJson();
            List<Transaction> myTransaction = JsonConvert.DeserializeObject<List<Transaction>>(fText);

            myTransaction.Add(transaction);
            try
            {
                // var customer = GetCustomer();
                // var customer = GetCustomer();
                var jsonToWrite = JsonConvert.SerializeObject(myTransaction, Formatting.Indented);

                File.WriteAllText(path, jsonToWrite);

                /*Console.WriteLine("Json added!!!!!s");
                Console.WriteLine("at " + path);*/
            }
            catch (Exception)
            {
                throw;
            }


        }


    }
}
