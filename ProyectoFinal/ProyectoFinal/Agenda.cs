using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal
{
    class Agenda
    {
        private const int TAM = 10;
        private Contacto[] _contactos;
        private int _index;

        public Agenda()
        {
            _index = 0;
            _contactos = new Contacto[TAM];
        }

        public void AgregarContacto(Contacto contacto)
        {
            if (_index < TAM)
            {
                _contactos[_index] = contacto;
                _index++;
            }
            else
            {
                Console.WriteLine("Agenda LLena");
            }
        }

        public void BorrarContacto()
        {
            if (_index > 0)
            {
                _contactos[_index] = null;
                _
            }
        }

    }
}
