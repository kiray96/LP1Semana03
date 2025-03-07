﻿using System;
using System.Reflection.Metadata.Ecma335;

namespace TrapAnalyzer
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            TrapType trap = Enum.Parse<TrapType>(args[0]);
            PlayerGear gear = ParseGear(args);
            bool survives = CanSurviveTrap(trap, gear);
            DisplayResult(trap, survives);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the player gear.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The player gear.</returns>
        /// 

        private static PlayerGear ParseGear(string[] args)
        {
            PlayerGear gear = 0;

            foreach(string input in args)
            {
                if (input == "None")
                {
                    gear ^= PlayerGear.None;
                }
                else if (input == "Helmet")
                {
                    gear ^= PlayerGear.Helmet;
                }
                else if (input == "Shield")
                {
                    gear ^= PlayerGear.Shield;
                }

                Console.WriteLine(gear);
            }

        }

        /// <summary>
        /// Can the player survive the trap given the gear it has?
        /// </summary>
        /// <param name="trap">The trap the player falls into.</param>
        /// <param name="gear">The gear the player has.</param>
        /// <returns>Wether the player survived the trap or not.</returns>
        private static bool CanSurviveTrap(TrapType trap, PlayerGear gear)
        {
            switch (result)
            {
                case TrapType.FallingRocks:
                    Console.WriteLine("");
                    break;
                case TrapType.SpinningBlades:
                    Console.WriteLine("");
                    break;
                case TrapType.PoisonGas:
                    Console.WriteLine("");
                    break;
                case TrapType.LavaPit:
                    Console.WriteLine("");
                    break;
            }
        }

        /// <summary>
        /// Display information on wether the player survived the trap or not.
        /// </summary>
        /// <param name="trap">The trap the player has fallen into.</param>
        private static void DisplayResult(TrapType trap, bool survives)
        {
            if
            {
                survives = true;
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
