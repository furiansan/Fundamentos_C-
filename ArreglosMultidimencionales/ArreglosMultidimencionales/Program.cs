using System;

namespace ArreglosMultidimencionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar arreglo con 3 filas y 2 columnas

            int[,] a = new int[3, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 } };
            
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("a[{0},{1}]= {2} ",i,j, a[i, j]);
                }
            }

            //matriz cuadrada
            int[,] matriz = new int[2, 2] { { 5, 1 }, { 2, 4 } };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
