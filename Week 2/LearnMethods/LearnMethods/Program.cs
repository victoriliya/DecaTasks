using System;

namespace LearnMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double x = 5;
            double y = 4;
            Console.WriteLine("5 + 4 = {0}", GetSum(x,y));

            Console.WriteLine("x {0} ", x);*/

            /*int solution;
*/
            int solution;

            DoubleIt(15, out solution);

            Console.WriteLine("15 * 2 = {0}", solution);


            int x = 5;
            int y = 6;

            Console.WriteLine("Before x = {0} | y = {1}", x, y);

            Swap(ref x, ref y);

            Console.WriteLine("After x = {0} | y = {1}", x, y);
          
            Console.WriteLine("1 + 2 + 3 = {0}", GetSumMore(1, 3, 5));

            PrintInfo(name: "King",zipCode: 23454);

            Console.WriteLine("5 + 4 = {0}", GetSum(5, 4));

            Console.WriteLine("5 + 4 = {0}", GetSum("5", "4"));


        }

        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} live in the zip code {1}", name, zipCode);
        }

        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }
            return sum;
        }

        public static void Swap(ref int num1, ref int num2) {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        } 

        static void DoubleIt(int x, out int sol) {
            sol = x *2;
        }


        static double GetSum(double x = 1, double y = 1) {

            return x + y;

        }

        static double GetSum(string x, string y )
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);

            return dblX + dblY;

        }

    }
}
