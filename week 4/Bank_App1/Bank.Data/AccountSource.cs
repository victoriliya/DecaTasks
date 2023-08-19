using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Reflection;
using System.IO;
using Week3_Task.Commons;

namespace Bank.Data
{

    public static class AccountSource
    {
        public static string path = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\customerDB.json");
        

        public static string ReadFromJson() {
            try
            {
                string jsonFromfile;
                using (StreamReader reader = new StreamReader(path))
                {
                    jsonFromfile = reader.ReadToEnd();
                }
                /*Console.WriteLine("Files");
                Console.WriteLine(jsonFromfile);*/
                
                return jsonFromfile;

            }
            catch (Exception)
            {

                Console.WriteLine("Cant read from Json");
            }
            return string.Empty;
        }

        public static void WriteToJson(Account account)
        {
            string fText = ReadFromJson();
            List<Account> myAccount = JsonConvert.DeserializeObject<List<Account>>(fText);

            myAccount.Add(account);
            try
            {
                // var customer = GetCustomer();
                // var customer = GetCustomer();
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

        /*public void WriteToJson()
        {
            try
            {
                var customer = GetCustomer();
                var jsonToWrite = JsonConvert.SerializeObject(customer, Formatting.Indented);

                File.AppendAllText(path, jsonToWrite);

                Console.WriteLine("Added Succesfully");

                *//*
                using (var writer = new StreamWriter(_path))
                {
                    writer.Write(jsonToWrite);
                }*//*
            }
            catch (Exception)
            {
                throw;
            }


        }*/
    }

}
