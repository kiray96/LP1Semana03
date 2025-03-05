using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Create used variables
            string str;
            char ch;

            //Ask user for the string and read it 
            Console.WriteLine("Escreve uma string");
            str = Console.ReadLine();

            //Ask user for a character, read it and parse it as a char
            Console.WriteLine("Escreve um caráter");
            ch = char.Parse(Console.ReadLine());

            //Loop through all chars in given string
            foreach(char letra in str)
            {
                //Check if current char is given char
                if (letra == ch)
                {
                    //Print x
                    Console.Write("x");
                }
                else
                {
                    //Print original char
                    Console.Write(letra);
                }   
            }


        }
    }
}
