using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExpression
{
    class Program
    {
        public delegate double doubleIt(double value);
        static void Main(string[] args)
        {

            /* doubleIt dlIt = x => x * 2;

             List<int> myList = new List<int> { 2, 4 ,6 ,7 ,8 ,9, 12, 45 ,67 };

             var evenList = myList.Where(a => a % 2 == 0).ToList().ToArray();

             int[] myArr = { 4, 6, 7, 8, 9, 12, 45, 6 };

             var odd = myArr.Where(a => a % 2 != 0);*/

            List<int> fliplist = new List<int>();

            int i = 0;

            Random rnd = new Random();
            while (i < 100)
            {
                fliplist.Add(rnd.Next(1, 3));
                i++;
            }

            Console.WriteLine("Head : {0}", fliplist.Where(x => x == 1).ToList().Count());
            Console.WriteLine("Tails : {0}", fliplist.Where(x => x == 2).ToList().Count());

            var name = new List<string> { "sally", "Melvin", "Sadiq" };

            foreach (var item in name.Where(s => s.Contains("S") || s.Contains("s")).ToList())
            {
                Console.WriteLine(item);
            }
            

        }

        public static double doubler(double entry) {
            return entry * 2;
        }

    }
}
