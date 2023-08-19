using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightToTheDeath
{
    class Warrior
    {
        private string name;
        private int maxHealth;
        private int maxAttack;
        private int block;

        public Warrior()
            :this("No name", 0, 0, 0){}

        public Warrior(string name)
            : this(name, 0, 0, 0) { }

       
        public Warrior(string name, int maxHealth, int maxAttack, int block) { 
        }

        public string Name {
            get { return name; }
            set {
                if (!value.Any(char.IsDigit))
                {
                    name = value;

                }
                else {
                    name = "No name";

                }
            }
        }


        public int MaxHealth
        {
            get { return maxHealth; }
            set
            {
                if (value.GetType() != typeof(int))
                {
                    maxHealth = 0;
                }
                else
                {
                    maxHealth = value;
                }
            }
        }

        public int MaxAttack
        {
            get { return maxAttack; }
            set
            {
                if (value.GetType() != typeof(int))
                {
                    maxAttack = 0;
                }
                else
                {
                    maxAttack = value;
                }
            }
        }


        public int Block
        {
            get { return block; }
            set
            {
                if (value.GetType() != typeof(int))
                {
                    block = 0;
                }
                else
                {
                    block = value;
                }
            }
        }

        public void PrintEntry()
        {
            Console.WriteLine($"{Name} has {maxHealth} heallth, {maxAttack} attack and {block} blocks" );
        }


    }
}
