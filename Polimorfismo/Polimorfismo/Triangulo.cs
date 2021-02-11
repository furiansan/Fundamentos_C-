using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Triangulo:IFigura
    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public void DatosTriangulo()
        {
            Console.WriteLine("Triangulo de Base {0} y altura {1}", Base, Altura);
        }
    }
}
