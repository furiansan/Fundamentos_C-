using System;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpleadoIndependiente EI = new EmpleadoIndependiente("Pepito Perez", "Operario", 1100000m);
            EI.Saludar();
            EI.Trabajar();
            Console.WriteLine("{0} y gana ${1}",EI.Puesto, EI.Salario);

            EmpleadoNomina EN = new EmpleadoNomina("Juana La Rana", "Contador", 2500000);
            EN.Saludar();
            EN.Trabajar();
            Console.WriteLine("{0} y gana ${1}",EN.Puesto, EN.Salario);


        }
    }
}
