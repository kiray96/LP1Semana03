using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Perks perks = 0;
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
            }

            Console.WriteLine(perks);
        }
    }
}
