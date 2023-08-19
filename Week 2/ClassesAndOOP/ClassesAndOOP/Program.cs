using System;

namespace ClassesAndOOP
{
    class Program
    {
        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1) {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }

        }

        
        static void Main(string[] args)
        {

            Rectangle rect1;
            rect1.length = 100;
            rect1.width = 50;
            
            Console.WriteLine("Area of a rect1 {0}", rect1.Area());
            Console.WriteLine("Area of a rect1.lenght {0}", rect1.length);

            Rectangle rect2 = new Rectangle(45, 2);

            rect2 = rect1;

            rect1.length = 89;

            Console.WriteLine("");
            
            Console.WriteLine("Area of a rect2 {0}", rect2.Area());
            Console.WriteLine("Area of a rect2.length {0}", rect2.length);

        }
    }
}
