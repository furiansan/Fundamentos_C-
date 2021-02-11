using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Contacto()
        {

        }

        public Contacto(string nombre,string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }
        public Contacto(string nombre, string telefono, string email)
            :this(nombre,telefono)
        {
            Email = email;
        }


    }
}
