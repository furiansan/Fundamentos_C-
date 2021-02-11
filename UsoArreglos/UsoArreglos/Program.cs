using System;

namespace UsoArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.Write("Ingrese el tamaño del arreglo: ");
                string dato = Console.ReadLine();
                bool numcorrecto = int.TryParse(dato, out int n);

                if (numcorrecto == false || n < 0)
                {
                    Console.WriteLine("Dato ingresado no es correcto");
                }
                else
                {
                    i = 1;
                    int[] numeros = new int[n];

                    for (int a = 0; a < numeros.Length; a++)
                    {

                        Console.Write("Ingrese dato en indice {0}: ", a);
                        numeros[a] = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("Los datos ingresados son:");
                    MostrarArreglo(numeros);
                }

            } while (i == 0);

        }
        
        
        static void MostrarArreglo(int[] arreglo)
         {
            foreach(int b in arreglo)
            {
            Console.Write("{0} ", b);
            }
         }
    }
}

