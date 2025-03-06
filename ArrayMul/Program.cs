using System;
using System.Globalization;
using System.Reflection;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            
            float [,] a = new float [2, 2];

            //Matrix = a
            a[0, 0] = float.Parse(args[0]);
            a[0, 1] = float.Parse(args[1]);
            a[1, 0] = float.Parse(args[2]);
            a[1, 1] = float.Parse(args[3]);

            float[] b = new float [2];

            //Vector = b
            b[0] = float.Parse(args[4]);
            b[1] = float.Parse(args[5]);

            float[] result = new float [2];

            for (int i = 0; i < a.GetLength(0); i ++)
            {
                result[i] = 0;
                for ( int j = 0; j < a.GetLength(1); j++)
                {
                    result[i] += a[i, j] * b[j];
                }
            }

            foreach (float valor in result)
            {
                Console.WriteLine($"| {valor, 7:f2} |");
            }


        }
    }
}
