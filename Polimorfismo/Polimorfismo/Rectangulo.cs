using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Rectangulo:IFigura
    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public double CalcularArea()
        {
            return Base * Altura;
        }

        public void DatosRectangulo()
        {
            Console.WriteLine("Rectangulo de Base {0} y Altura {1}", Base, Altura);
        }
    }
}
