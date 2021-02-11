using System;

namespace SintaxisArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //sintaxis 1
            int[] arreglo = new int[5];
            arreglo[0] = 1;
            arreglo[1] = 0;
            arreglo[2] = 20;
            arreglo[3] = -4;
            arreglo[4] = 8;

            Console.WriteLine(arreglo[3]);

            //sintaxis 2
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine(vocales[2]);

            //sintaxis 3
            double[] numeros = { 1.1, 2.2, 3.4, 5.8 };

            Console.WriteLine("Tamaño de numero: {0}", numeros.Length);
            Console.WriteLine(numeros[numeros.Length - 1]);
        }
    }
}
