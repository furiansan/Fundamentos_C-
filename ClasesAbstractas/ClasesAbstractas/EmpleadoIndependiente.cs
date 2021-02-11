using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    class EmpleadoIndependiente : Empleado
    {
        public decimal SueldoBase { get; set; }

        public override decimal Salario 
        { 
            get
            {
                return SueldoBase * 0.84m;  
            }        
        }

        public EmpleadoIndependiente(string nombre,string puesto,decimal sueldoBase)
            : base(nombre,puesto)
        {
            SueldoBase = sueldoBase;
        }
        public override void Trabajar()
        {
            Console.WriteLine("Trabajador independiente");
        }
    }
}
