using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Estudiante : Persona
    {
        public double Promedio { get; set; }
        public string Grado { get; set; }

        public Estudiante() { }

        public Estudiante(string nombre, int edad, string grado, double promedio)
            : base(nombre,edad)
        {
            Grado = grado;
            Promedio = promedio;
        }

        public void Estudiar()
        {
            Console.WriteLine("{0} esta estudiando para subir su promedio de {1}", Nombre, Promedio);
        }

        public void IrClase()
        {
            Console.WriteLine("{0} esta yendo a clase en el grado {1}", Nombre, Grado);
        }

        public override void Saludar()
        {
            Console.WriteLine("Hola, mi nombre es {0} y tengo {1} años",Nombre,Edad);
        }
        public override string ToString()
        {
            return string.Format("{0}, {1} años, Grado {2}, Promedio: {3}",Nombre,Edad,Grado,Promedio);
        }
    }
}
