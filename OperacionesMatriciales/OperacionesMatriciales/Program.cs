using System;

namespace OperacionesMatriciales
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] MatrizA = { { 1.1, 0.3 }, { 5.5, 8 } };
            double[,] MatrizB = { { 6, -2.1 }, { 0, 10.5 } };

            Console.WriteLine("Matriz A: ");
            MostrarMatriz(MatrizA);

            Console.WriteLine("Matriz B: ");
            MostrarMatriz(MatrizB);

            double[,] Suma = new double[MatrizA.GetLength(0),MatrizA.GetLength(1)];

            for (int i = 0; i < Suma.GetLength(0); i++)
            {
                for (int j = 0; j < Suma.GetLength(1); j++)
                {
                    Suma[i, j] = MatrizA[i, j] + MatrizB[i, j];
                }
            }
            Console.WriteLine("Matriz Suma: ");
            MostrarMatriz(Suma);
        }

        static void MostrarMatriz(double[,] matriz)
        {
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0:0.#0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
