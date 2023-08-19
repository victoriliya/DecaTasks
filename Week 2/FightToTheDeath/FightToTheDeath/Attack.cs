using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace FightToTheDeath
{
    class Attack 
    {
        private bool playerA;
        private bool playerB;
        private static int playerAStart;
        private static int attackValue;
        private static bool change = true;

        Warrior a = new Warrior();
        Warrior b = new Warrior();
        



        public static void StartFight(Warrior a, Warrior b) {


            if (change)
            {
                playerAttack(a);
            }
            else { 
                playerAttack(b);

            }

        }

        private static int playerAttack(Warrior o) {
            Random rand = new Random();
            o.MaxHealth -= rand.Next(40, 120);
            change = !change;

            Console.WriteLine("{0}  left with {1}", o.Name, o.MaxHealth);
      
            return o.MaxHealth;
 
        }

        private static Warrior WhoWon() {
            if (o.MaxHealth < 1)
            {

            }
        }



    }
}
