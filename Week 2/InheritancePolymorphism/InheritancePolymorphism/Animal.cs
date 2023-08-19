using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritancePolymorphism
{
    class Animal
    {
        private string name;
        private string sound;

        protected AnimalIdInfo animalIdInfo = new AnimalIdInfo();

        public void SetAnimalIdInfo(int idNum, string owner) {
            animalIdInfo.IDNum = idNum;
            animalIdInfo.Owner = owner;
        }

        public void GetAnimalIdInfo() {
            Console.WriteLine($"{Name} had the ID of {animalIdInfo.IDNum} and is owned by {animalIdInfo.Owner}");
        }

        public virtual void MakeSound() 
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal()
            : this("No Name", "No Sound") { }

        public Animal(string name)
            : this(name, "No Sound") { }

        public Animal(string name, string sound) {
            Name = name;
            Sound = sound;
        }


        public string Name
        {
            get { return name; }
            set {
                if (!value.Any(char.IsDigit))
                {
                    Console.WriteLine( value.Any(char.IsDigit) ); 
                    name = "No name";
                }
                name = value;

            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                }
                sound = value;
            }
        }

        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight) {
                double calc = height / weight;

                if ((calc <= .18) && (calc >= .27))
                {
                    return true;
                }
                else {
                    return false;
                }

            }
        }

    }
}
