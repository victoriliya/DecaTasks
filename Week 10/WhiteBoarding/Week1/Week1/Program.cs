using System;
using System.Text.RegularExpressions;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Duplicate characters: Find the top most repeated character in a string.For instance, given a string ‘hello world’, the top most repeated character is ‘l’ because it can be found 3 times in the string.*/
            
            string input = "hello world";
            Console.WriteLine(findMostDuplicate(input));


        }

        public static int findMostDuplicate(string input){
            char tmp;
            int currentCount = 0;
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                tmp = input[i];
                if (input[i] == tmp)
                {
                    counter++;
                }
                currentCount = counter;
                if (currentCount <= counter)
                {
                    currentCount = counter;
                }

            }
            return currentCount;

        }
    }
}
