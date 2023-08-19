using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCLasses
{
    class Animal
    {

        public string name;
        public string sound;
        private string cool;

        public Animal() 
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;

        }

        public Animal(string name = "No Name")
        {
            this.name = "No Name";
            this.sound = "No Sound";
            numOfAnimals++;

        }


        public Animal(string name = "No Name", string sound ="No Sound")
        {
            numOfAnimals++;
            this.name = "No Name";
            this.sound = "No Sound";
        }

        public void MakeSound() 
        {
            Console.WriteLine("{0} says {1}", name, sound);
         
        }

        static int numOfAnimals = 0;

        public static int GetNumAnimals() 
        {
            return numOfAnimals;
        }

      

    }
}
