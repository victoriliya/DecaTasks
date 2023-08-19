using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Majik
{
    class Program
    {
        static void Main(string[] args)
        {
            var oneTo10 = new List<int>();

            oneTo10.AddRange(Enumerable.Range(1, 10));

            int[] myArray = { 1, 2 ,3 ,4, 2 ,1 , 4};

            

            try
            {
                Console.WriteLine(myArray.ToList().BinarySearch(4)); 
            }
            catch (Exception)
            {

                
            }
            Console.WriteLine() ;

           

            

        }
    }
}
