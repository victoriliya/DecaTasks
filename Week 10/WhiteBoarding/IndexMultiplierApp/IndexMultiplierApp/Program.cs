using System;
using System.Collections.Generic;

namespace IndexMultiplierApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You have a list of integers, and for each index you want to find the product of every integer except the integer at that index.For example a list[1, 3, 7, 4] returns[84, 28, 12, 21] which is by calculating [7 * 3 * 4, 1 * 7 * 4, 1 * 3 * 4, 1 * 7 * 3] */
            int[] arr = { 1, 3, 7, 4 }; 

            foreach (var item in IndexMultiplier(arr))
            {
                Console.Write(item + " ");
            }

        }

        public static List<int> IndexMultiplier(int[] inputArr)
        {
            int tmpSum;
            List<int> myNewArr = new List<int> { };
            for (int i = 0; i < inputArr.Length; i++)
            {      
                tmpSum = inputArr[0];
                for (int j = 0; j < inputArr.Length; j++)
                {
                    if (i != j)
                    {        
                        tmpSum = (tmpSum * inputArr[j]);
                    }    
                }               
                myNewArr.Add(tmpSum);
            }
            return myNewArr;
        }
    }
}
