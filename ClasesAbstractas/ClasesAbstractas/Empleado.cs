using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Puesto { get; set; }

        public abstract decimal Salario { get;}

        public Empleado(string nombre, string puesto)
        {
            Nombre = nombre;
            Puesto = puesto;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy {0}", Nombre);
        }
        public abstract void Trabajar();
    }
}
