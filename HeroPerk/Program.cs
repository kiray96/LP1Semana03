using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Perks perks = 0;
            Perks silentJumper = Perks.Stealth | Perks.DoubleJump;
            bool unknown = false;
            String inputs = args[0];


            foreach(char input in inputs)
            {
                if (input == 'w')
                {
                    perks ^= Perks.WarpShift;
                }
                else if (input == 'a')
                {
                    perks ^= Perks.AutoHeal;
                }
                else if (input == 's')
                {
                    perks ^= Perks.Stealth;
                }
                else if (input == 'd')
                {
                    perks ^= Perks.DoubleJump;
                }
                else
                {
                    unknown = true;
                    break;
                }
            }


            if (unknown)
            {
                Console.WriteLine("!Unknown perk!");
            }
            else
            {
                if(perks == 0)
                {
                    Console.WriteLine("!No perks at all!");
                }

                else
                {
                    Console.WriteLine(perks);
                } 

                if ((perks & silentJumper) == silentJumper)
                {
                    Console.WriteLine("!Silent jumper!");
                }

                if ((perks & Perks.AutoHeal) != Perks.AutoHeal)
                {
                    Console.WriteLine("!Not gonna make it!");
                }
            }    
        }
    }
}
