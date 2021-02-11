using System;
using System.Collections.Generic;
using System.Text;

namespace Reto_2
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private int _edad;
        public int Edad
        {
            get { return _edad; }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Verificar edad");
                    _edad = 0;
                }
                else
                {
                    _edad = value;
                }
            }
        }
        
        #region constructores
        public Persona(string nombre)
        {
            Nombre = nombre;
        }
        public Persona(string nombre, string apellido)
            :this (nombre)
        {
            Apellido = apellido;
        }
        public Persona(string nombre, string apellido, int edad) 
            : this(nombre, apellido)
        {
            Edad = edad;
        }
        public Persona() { }
        #endregion

        #region metodos

        public void Saludar()
        {
            
           Console.WriteLine("Hola mi nombre es {0} {1}", Nombre, Apellido);
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, Apellido: {1}, Edad:{2} años",Nombre,Apellido,Edad);
        }
#endregion
    }
}
