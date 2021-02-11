using System;

namespace Tablas_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa muestra la tabla de multiplicar de un numero");
            int a = 0;
            int n = 1;
            int num = 0;
            do
            {
                Console.Write("\nIngrese el numero del que quiera ver la tabla: ");
                string dato = Console.ReadLine();
                bool valorcorrecto = int.TryParse(dato, out num); 

                if (valorcorrecto == true)
                {
                    while(n <= 10)
                    {
                        int prod = num * n;
                        Console.WriteLine("{0} X {1} = {2}", num, n, prod);
                        n++;
                    }
                }
                else
                {
                    Console.WriteLine("\nValor ingresado no es valido");
                }
                n = 1;
            } while (a == 0);

        }
    }
}
