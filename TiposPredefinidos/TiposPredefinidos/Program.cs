using System;

namespace TiposPredefinidos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos Enteros

            int entero = 100;
            short s = 140;

            Console.WriteLine("int:{0}, short:{1}", entero, s);

            // Tipos Flotantes

            float f = 123.5f;
            double d = 3.14159;
            decimal dec = 129.99m;

            Console.WriteLine("float={0}, decimal:{1}", f, dec);
        }
    }
}
