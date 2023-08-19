using System;
namespace InheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal whiskers = new Animal()
            { 
                Name = "Cow",
                Sound = "Moooo!"
            };

            Dog bull = new Dog()
            {
                Name = "Bull",
                Sound = "Woof!",
                Sound2 = "Grrrr"
            };

            bull.Sound = "weeeeeeee";

            Console.WriteLine(bull.Sound);

            bull.SetAnimalIdInfo(1234, "Sally Aunty");

            bull.GetAnimalIdInfo();

            Animal.AnimalHealth animalHealth = new Animal.AnimalHealth();

            Console.WriteLine(animalHealth.HealthyWeight(11, 46));

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeeee!"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Woof!",
                Sound2 = "Gdreve"
            };

            monkey.MakeSound();

            spot.MakeSound();




        }
    }
}
