using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorProperties
{
    class Animal
    {

        private string name;
        private string sound;

        public const string SHELTER = "This is my world";

        public readonly int idNum;

        public void MakeSound() { 
             Console.WriteLine( "{0} says {1}", name, sound);
        }

        public Animal()
        : this("No name", "No sound") { }

        public Animal(string name)
            : this(name, "No sound") { }

        public Animal(string name, string sound) 
        {
            SetName(name);
            Sound = sound;
            NumOfAnimals = 1;

            Random rnd = new Random();
            idNum = rnd.Next(1, 23434323);

        }

        public void SetName(string name) {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else 
            {
                this.name = "No Name";
                Console.WriteLine("No can't contain numbers");
            }
        }

        public string GetName() {
            return name;
        }

        public string Sound { 
           get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No sound";
                    Console.WriteLine("Sounds is too long");
                }
                sound = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!name.Any(char.IsDigit))
                {
                    name = value;
                }
            }
        }

        public string Owner { get; set; } = "No owner";

        public static int numOfAnimals = 0;
    
        public static int NumOfAnimals {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }
        



    }
}
