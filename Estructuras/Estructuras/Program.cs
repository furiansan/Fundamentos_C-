using System;

namespace Estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(4, 5, 6);

            Console.WriteLine("El modulo del Vector 1 es: {0}", v1.CalcularModulo());
            Console.WriteLine("El modulo del Vector 2 es: {0}", v2.CalcularModulo());

            Vector Resultado = v1.Suma(v2);
            Console.WriteLine("La suma de los vectores es: {0}", Resultado);
        }
    }
}
