using System;

namespace OOPCLasses
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Animal myAnimal = new Animal()
                        {
                            name = "Fox",
                            sound = "Raaaww"
                        };

                        Animal myAnimal2 = new Animal()
                        {
                            name = "Cow",
                            sound = "Moooh!!"
                        };

                        myAnimal2.MakeSound();

                        Console.WriteLine("# number of animals : {0}", Animal.GetNumAnimals());*/


            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("rectangle", 5, 6));


        }

    }
}
