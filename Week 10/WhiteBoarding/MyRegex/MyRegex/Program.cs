using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MyRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex myRegex = new Regex("^[a-zA-Z]{2,5}$");

            Regex rex = new Regex("Is");
            string str = "Is there a man Is Is";

          /*  MatchCollection m = rex.Matches(str);

            string[] myStr = m.ToArray();*/

            var arr = Regex.Matches(str, @"Is")
                .OfType<Match>()
                .Select(m => m.Groups[0].Value)
                .ToArray();



            foreach (object item in arr)
            {
                
                Console.Write(" " + item);
            }


        }
    }
}
