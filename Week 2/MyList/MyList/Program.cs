using System;
using System.Collections;
using System.Collections.Generic;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            myList.Add("This");
            myList.Add("Feels");
            myList.Add("Good");


            string[] myStringArr = myList.ToArray();

            Console.WriteLine(myList[2]);



        }
    }
}
