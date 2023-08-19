using System;
using System.Collections;

namespace MyArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
      
            ArrayList al = new ArrayList() { "we", "are", "the", "one" };

            Console.WriteLine("Index of: {0}", al.IndexOf("hello", 0));

            string[] myArray = (string[])al.ToArray(typeof(string));
             
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            string[] customers = { "Bob", "Sally", "Fischer" };
            ArrayList customerArrayList = new ArrayList();
            customerArrayList.AddRange(customers);

            foreach (var item in customerArrayList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
