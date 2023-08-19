using System;

namespace MethodEnums
{
    class Program
    {
        static void Main(string[] args)
        {

            CarColor car1 = CarColor.Blue;

            PaintCar(car1);

            Console.WriteLine(car1);


        }

        enum CarColor : byte 
        { 
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }

        static void PaintCar(CarColor cc) {
            Console.WriteLine("The car was painted {0} with the code {1}", cc, (int)cc);
        }

    }
}
