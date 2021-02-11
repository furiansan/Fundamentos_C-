using System;

namespace PromCalificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.Write("Numero de calificaciones a ingresar: ");
                bool cantcorrecta = int.TryParse(Console.ReadLine(), out int cantidad);
                if (cantcorrecta == false || cantidad <= 0)
                {
                    Console.WriteLine("Cantidad no valida\n");
                }
                else
                {
                    float[] calificaciones = new float[cantidad];
                    int n = 0;
                    do
                    {
                            Console.Write("Ingrese calificacion {0}: ", n + 1);
                            bool califcorrecta = float.TryParse(Console.ReadLine(), out float calificacion);
                            if (califcorrecta == false || calificacion < 0 || calificacion > 5)
                            {
                                Console.WriteLine("Calificacion no es valida, debe ser un valor entre 0 y 5\n");
                            }
                            else
                            {
                                calificaciones[n] = calificacion;
                                n++;
                            }
                    } while (n<calificaciones.Length);
                    
                    //i= 1;

                    Mostrarcalificaciones(calificaciones);
                    Console.WriteLine();
                    Promedio(calificaciones);
                    Console.WriteLine();

                }
            } while (i == 0);

        }

        static void Promedio(float[] arreglo)
        {
            float sum = 0;
            

            for(int i = 0; i < arreglo.Length; i++)
            {
                sum += arreglo[i];
            }

            double prom = sum / arreglo.Length;

            Console.WriteLine("El promedio de las calificaciones es: {0:0.#} ", prom);
        }

        static void Mostrarcalificaciones(float[] arreglo)
        {
            Console.Write("\nCalificaciones ingresadas: ");
            foreach(float i in arreglo)
            {
                Console.Write("{0} / ",i);
            }
        }
    }
}
