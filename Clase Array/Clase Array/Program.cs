using System;

namespace Clase_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 32, 72, 13, 44, 25, 30, 10 };
            int[] temp = new int[list.Length];

            //genera una copia del arreglo list

            Array.Copy(list, temp, list.Length);

            Console.WriteLine("Arreglo original: ");
            MostrarArreglo(list);

            Console.WriteLine("Arreglo copiado: ");
            MostrarArreglo(temp);

            //invertir un arreglo.

            Array.Reverse(temp);
            Console.WriteLine("Arreglo ivertido: ");
            MostrarArreglo(temp);

            //Ordenar un arreglo

            Array.Sort(list);
            Console.WriteLine("Arreglo ordenado: ");
            MostrarArreglo(list);

        }

        static void MostrarArreglo(int[] arreglo)
        {
            foreach (int i in arreglo)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
