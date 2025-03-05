using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach(string str in args)
            {
                if (str.Length >= 8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
                
                if (str.Length > 3)
                {
                    Console.WriteLine(str);
                }
                
            }
        }
    }
}
