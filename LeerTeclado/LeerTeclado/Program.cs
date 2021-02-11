using System;

namespace LeerTeclado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de dos numeros");
            Console.Write("Ingresa numero A:  ");
            string dato = Console.ReadLine();

            int a = int.Parse(dato);

            Console.Write("Ingresa numero B:  ");
            dato = Console.ReadLine();

            int b = int.Parse(dato);

            int suma = a + b;
            Console.WriteLine("El valor de la suma es: {0}", suma);

        }
    }
}
