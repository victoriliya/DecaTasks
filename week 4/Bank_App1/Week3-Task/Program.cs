using Bank.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Week3_Task.Commons;
using Week3_Task.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using BankWinform.UI;

namespace Week3_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string first = "tony kroos";
            string second = "Tony kroos";

            Console.WriteLine(String.Equals(first, second, StringComparison.OrdinalIgnoreCase));*/
            

            Application.Run(new Login());
            //BankOperations.Home();
        }

    }
}
