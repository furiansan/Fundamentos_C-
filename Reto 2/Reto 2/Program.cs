using System;

namespace Reto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Julian","Valderrama",31);

            Persona persona2 = new Persona("Felipe", "Correa", -10);

            persona1.Saludar();
            persona2.Saludar();

            Console.WriteLine(persona1);
            Console.WriteLine(persona2);




        }
    }
}
