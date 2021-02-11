using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Herencia
            /*Persona p = new Persona("Pepito Perez", 30);

            Empleado e = new Empleado("Rosa Melano", 25, "Contadora", 2500000m);

            p.Saludar();

            Console.WriteLine(p);

            Console.WriteLine();

            e.Saludar();

            e.Trabajar();

            Console.WriteLine(e);*/
            #endregion

            #region Reto Subclase

            Estudiante Es = new Estudiante("Pepito Perez", 15, "Decimo", 4.2);

            Es.Saludar();

            Console.WriteLine(Es);

            Es.Estudiar();

            Es.IrClase();

            #endregion
        }
    }
}
