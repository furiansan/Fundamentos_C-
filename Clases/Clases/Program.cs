using System;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear un objeto de tipo rectangulo
            Rectangulo rect = new Rectangulo();
            rect.Base = 10;
            rect.Altura = 5;

            int area=rect.CalcularArea();
            Console.WriteLine(area);

            //sintaxis de inicializacion
            Rectangulo rect2 = new Rectangulo { Altura = 8, Base = 3 };
            int area2 = rect2.CalcularArea();
            Console.WriteLine(area2);

        }
    }
}
