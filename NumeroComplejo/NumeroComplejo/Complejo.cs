using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroComplejo
{
    struct Complejo
    {
        public double Real { get; }
        public double Imaginario { get; }

        public Complejo(double real, double imaginario):this()
        {
            Real = real;
            Imaginario = imaginario;
        }

        public Complejo Suma (Complejo otro)
        {
            return new Complejo(Real + otro.Real, Imaginario + otro.Imaginario);
        }

        public Complejo Multiplicacion(Complejo otro)
        {
            return new Complejo((Real * otro.Real) - (Imaginario * otro.Imaginario), 
                (Real * otro.Imaginario) + (Imaginario * otro.Real));
        }

        public override string ToString()
        {
            return string.Format("{0:0.0}+i{1:0.0}",Real,Imaginario);
        }
    }
}
