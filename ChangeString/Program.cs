using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string str;
            char ch;

            Console.WriteLine("Escreve uma string");
            str = Console.ReadLine();

            Console.WriteLine("Escreve um caráter");
            ch = char.Parse(Console.ReadLine());

            foreach(char letra in str)
            {
                if (letra == ch)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(letra);
                }   
            }


        }
    }
}
