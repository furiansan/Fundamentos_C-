using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Circulo:IFigura
    {
        public double Radio { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public void DatosCirculo()
        {
            Console.WriteLine("Circulo de radio {0} ", Radio);
        }
    }
}
