using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> superhumans = new Dictionary<string, string>();
            superhumans.Add("Clark kent", "Superman");
            superhumans.Add("Gal Gadot", "Wonder Woman");
            superhumans.Add("Icon", "Amazing");
            superhumans.Add("Tuface", "Rain man");

            Console.WriteLine("Count : {0}", superhumans.Count);
            Console.WriteLine("Icon : {0}", superhumans.ContainsKey("Icon"));

            string test;
           superhumans.TryGetValue("Icon",out test);

            Console.WriteLine(test);

            foreach (KeyValuePair<string, string> item in superhumans)
            {
                Console.WriteLine("{0} : {1}" , item.Key, item.Value);
            }
            
        }
    }
}
