using System;

        namespace ControlAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            OtroNamespace.MiClase Objt1 = new OtroNamespace.MiClase();

            Objt1.MetodoInterno();
            Objt1.MetodoPublico();

        }
    }
}