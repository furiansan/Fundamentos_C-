using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    class EmpleadoNomina: Empleado
    {
        public decimal SueldoBase { get; set; }

        public override decimal Salario
        {
            get
            {
                return SueldoBase;
            }
        }

        public EmpleadoNomina (string nombre, string puesto, decimal sueldoBase)
                   : base(nombre, puesto)
        {
            SueldoBase = sueldoBase;
        }

        public override void Trabajar()
        {
            Console.WriteLine("Trabajador en Nomina");
        }
    }
}
