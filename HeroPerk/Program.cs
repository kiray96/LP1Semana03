using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Definir a variavel onde os perks ficam guardados
            Perks perks = 0;

            // Definir caso em que dois perks juntos significam silent jumper
            Perks silentJumper = Perks.Stealth | Perks.DoubleJump;

            // Boleano para registar que foi encontrado input invalido 
            bool unknown = false;

            // Obter input dos argumentos do programa
            String inputs = args[0];

            // Percorrer todos os caracteres de input e ativar ou desativar os 
            // respectivos perks
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
                // Input desconhecido, quebrar o loop
                else
                {
                    unknown = true;
                    break;
                }
            }

            // Print o caso unknown perk
            if (unknown)
            {
                Console.WriteLine("!Unknown perk!");
            }
            else
            {
                // Verifica se alguma perk está definido e imprime  "no perks" 
                // caso não esteja ou imprime os perks existentes
                if(perks == 0)
                {
                    Console.WriteLine("!No perks at all!");
                }
                else
                {
                    Console.WriteLine(perks);
                } 

                // Verifica se ambos os perks de silentJumper estão presentes e 
                // impreme silentJumper
                if ((perks & silentJumper) == silentJumper)
                {
                    Console.WriteLine("!Silent jumper!");
                }

                // Verifica se autoheal nao está presente e imprime "not gonna
                // make it" se for esse o caso
                if ((perks & Perks.AutoHeal) != Perks.AutoHeal)
                {
                    Console.WriteLine("!Not gonna make it!");
                }
            }    
        }
    }
}
