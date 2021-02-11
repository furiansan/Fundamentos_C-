using System;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usando ciclo For");
            for (int i = 0; i<10; i++)
            {
                if (i == 6)
                {
                    break;
                }
                Console.WriteLine("Valor del contador i :{0}", i);
            }

            Console.WriteLine("\nUsando ciclo While");
            int n = 0;
            while (n < 10)
            {
                if (n % 2 == 0)
                {
                    n++;
                    continue;
                }
                Console.WriteLine("Valor del contador n :{0}", n);
                n++;
            }

            Console.WriteLine("\nUsando ciclo Do - While");
            int c = 0;
            do
            {
                Console.WriteLine("Valor del contador c :{0}", c);
                c++;

            } while (c < 5);
        }
    }
}
