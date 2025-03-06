using System;
//Usar pontos em vez de virgulas
using System.Globalization;
using System.Reflection;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Usar pontos em vez de virgulas
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            
            // Criar um array multidimencional de floats
            float [,] a = new float [2, 2];

            // Matrix = a
            // Preencher a matriz com os argumentos
            a[0, 0] = float.Parse(args[0]);
            a[0, 1] = float.Parse(args[1]);
            a[1, 0] = float.Parse(args[2]);
            a[1, 1] = float.Parse(args[3]);

            // Criar um vetor de floats
            float[] b = new float [2];

            // Vector = b
            // Preencher esse vetor de floats
            b[0] = float.Parse(args[4]);
            b[1] = float.Parse(args[5]);

            // Criar vetor para preencher com o resultado
            float[] result = new float [2];


            // Iterar (percorrer) pelas linhas da matriz 
            for (int i = 0; i < a.GetLength(0); i ++)
            {
                // Inicializar o valor do resultado que vai ser preenchido por
                // esta linha da matriz
                result[i] = 0;
                // Percorrer pelas colunas da matriz
                for ( int j = 0; j < a.GetLength(1); j++)
                {
                    // Somar a multiplicação dos valores no resultado 
                    result[i] += a[i, j] * b[j];
                }
            }

            // Correr e imprimir os valores do vetor resultante
            foreach (float valor in result)
            {
                // Imprimir um numero real alinhado à direita, com sete espaços
                // e com duas casas décimais entre duas barras com espaços
                Console.WriteLine($"| {valor, 7:f2} |");
            }


        }
    }
}
