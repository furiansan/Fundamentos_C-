using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //upcasting
            IFigura f1 = new Circulo { Radio = 5 };
            IFigura f2 = new Triangulo { Base = 10, Altura=8 };
            IFigura f3 = new Rectangulo { Base=4,Altura=3};
            IFigura f4 = new Circulo { Radio = 9 };

            IFigura[] figuras = { f1, f2, f3, f4 };

            foreach (var figura in figuras)
            {
                Console.WriteLine(figura.CalcularArea());
            }
            //downcasting
            Circulo c1 = f1 as Circulo;
            Triangulo t1 = f2 as Triangulo;
            Rectangulo r1 = f3 as Rectangulo;
            Circulo c2 = f4 as Circulo;

            c1.DatosCirculo();
        }
    }
}
