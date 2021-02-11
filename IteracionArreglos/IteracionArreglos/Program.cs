using System;

namespace IteracionArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 10, 9, 30, -4, 0, 2, 11 };
           
            Console.WriteLine("Iterrar arreglo con for");
            for(int i=0; i < arreglo.Length; i++)
            {
                Console.Write("Numero{0}:{1} ", i, arreglo[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Iterrar arreglo con for each");
            foreach(int num in arreglo)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine();

            string[] cadenas = { "hola", "mundo", "ciclos", "arreglos", "cadenas" };
            Console.WriteLine("Iterar arreglo con ciclo for pero ciclo inverso");
            for(int n = cadenas.Length - 1; n >= 0; n--)
            {
                Console.Write("{0} ",cadenas[n]);
            }
        }
    }
}
