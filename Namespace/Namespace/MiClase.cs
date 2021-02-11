using System;
using System.Collections.Generic;
using System.Text;

namespace OtroNamespace
{
    class MiClase
    {
        public void MetodoPublico()
        {
            Console.WriteLine("LLamando a metodo publico");
        }
        protected void MetodoProtegido()
        {
            Console.WriteLine("LLamando a metodo protegido");
        }
        internal void MetodoInterno()
        {
            Console.WriteLine("LLamando a metodo interno");
        }
        private void MetodoPrivado()
        {
            Console.WriteLine("LLamando a metodo privado");
        }
    }
}
