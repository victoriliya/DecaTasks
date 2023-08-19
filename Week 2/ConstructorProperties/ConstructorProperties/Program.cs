using System;

namespace ConstructorProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            Animal lion = new Animal();

            cat.Name = "Bones";
            cat.Sound = "Meow";

            lion.Sound = "Rooaar!!!";


            cat.MakeSound();
            lion.MakeSound();

            cat.Owner = "King";

            Console.WriteLine("the owner is {0}", cat.Owner );

            Console.WriteLine("# animals : {0}", Animal.NumOfAnimals);

            Console.WriteLine("{0} shelter id is : {1}", cat.Name, cat.idNum);

        }
    }
}
