using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach(string str in args)
            {
                //If the string length is superior or equal to 8
                if (str.Length >= 8)
                {
                    //Print the line requested string and break
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
                
                //If the string length is superior to 3
                if (str.Length > 3)
                {
                    //Print the string
                    Console.WriteLine(str);
                }
                
            }
        }
    }
}
