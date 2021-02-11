using System;

namespace SentenciasCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            if (num > 5)
            {
                Console.WriteLine("num es mayor que 5");
            }

            string user = "user1";
            string pass = "Hola123";
            if (user == "user1" && pass=="Hola123")
            {
                Console.WriteLine("Acceso Correcto");
            }

            int edad = 18;
            if (edad >= 18)
            {
                Console.WriteLine("Mayor de edad");
            }
            else
            {
                Console.WriteLine("Menor de edad");
            }

            int a = 8;
            int b = 8;
            if (a > b)
            {
                Console.WriteLine("{0} es mayor que {1}",a,b);
            }
            else if(a < b)
            {
                Console.WriteLine("{0} es menor que {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} es igual que {1}", a, b);
            }

            string codigo = "A4";
            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("Producto1");
                    break;
                case "A2":
                    Console.WriteLine("Producto2");
                    break;
                case "A3":
                    Console.WriteLine("Producto3");
                    break;
                default:
                    Console.WriteLine("Producto no encontrado");
                    break;

            }
        }
    }
}
