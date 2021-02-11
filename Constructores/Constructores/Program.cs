using System;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
           /* CuentaBancaria cuenta1 = new CuentaBancaria("000001");
            Console.WriteLine("Numero de cuenta: {0},Ususario: {1}, Saldo: {2}", cuenta1.NoCuenta,
                cuenta1.Usuario,cuenta1.Saldo);*/

            CuentaBancaria cuenta2 = new CuentaBancaria("000002","Pepito Perez", 2000m);
            /*Console.WriteLine("Numero de cuenta: {0},Ususario: {1}, Saldo: {2}", cuenta2.NoCuenta,
                cuenta2.Usuario, cuenta2.Saldo);*/

            CuentaBancaria cuenta3 = new CuentaBancaria("000003", "Juana la Rana", 1000.5m);
            /*Console.WriteLine("Numero de cuenta: {0},Ususario: {1}, Saldo: {2}", cuenta3.NoCuenta,
                cuenta3.Usuario, cuenta3.Saldo);*/

            //LLamando a los metodos

            /*Console.WriteLine("Depositar $70 en cuenta 2");
            cuenta2.Depositar(70m);
            Console.WriteLine(cuenta2);

            Console.WriteLine("Retirar $10.5 en cuenta 3");
            cuenta3.Retirar(2000.5m);
            Console.WriteLine(cuenta3);*/

            CuentaBancaria.Banco = "Mi Banco";

            Console.WriteLine(cuenta2);
            Console.WriteLine(cuenta3);

            CuentaBancaria.AsignarBanco("Otro Banco");

            Console.WriteLine(cuenta2);
            Console.WriteLine(cuenta3);

        }
    }
}
