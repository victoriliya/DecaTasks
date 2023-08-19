using System;

namespace FightToTheDeath
{
    class Program
    {
        static void Main(string[] args)
        {
/*
        Random rand = new Random();
        int playerAStart = rand.Next(0, 2);

        Console.WriteLine(playerAStart);
*/

        Warrior rhino = new Warrior()
            {
                Name = "Rhino",
                MaxHealth = 10000,
                MaxAttack = 120,
                Block = 40
            };

            //rhino.PrintEntry();
        }
    }
}
