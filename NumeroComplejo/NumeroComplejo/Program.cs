using System;

namespace NumeroComplejo
{
    class Program
    {
        static void Main(string[] args)
        {
            Complejo c1 = new Complejo(3,4);
            Complejo c2 = new Complejo(-0.5,2);

            Console.WriteLine("Primer numero complejo: {0}", c1);
            Console.WriteLine("Segundo numero complejo: {0}", c2);

            Complejo Sum= c1.Suma(c2);
            Complejo Mult= c1.Multiplicacion(c2);
            Console.WriteLine("Suma de numeros complejos: {0}", Sum);
            Console.WriteLine("Multiplicacion de numeros complejos: {0}", Mult);
        }
    }
}
