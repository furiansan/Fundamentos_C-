using System;
using System.Collections.Generic;
using System.Text;

namespace Constructores
{
    class CuentaBancaria
    {
        // Auto properties
        public string NoCuenta { get; set; }
        public string Usuario { get; set; }

        // Backing field

        private decimal _saldo;

        // Full proterites

        public decimal Saldo
        {
            get { return _saldo; }

            set
            {
                /*if (value < 0)
                {
                    _saldo = 0;
                }
                else
                {
                    _saldo = value;
                }*/
                _saldo = value < 0 ? 0 : value;

            }
        }

        public static string Banco { get; set; }

        #region Construcdores
        public CuentaBancaria(string noCuenta)
        {
            NoCuenta = noCuenta;
        }

        public CuentaBancaria(string noCuenta,string usuario) 
            :this(noCuenta)
        {
            Usuario = usuario;
        }
        public CuentaBancaria(string noCuenta, string usuario, decimal saldo) 
            :this(noCuenta,usuario)
        {
           Saldo = saldo;
        }

        //constructor vacio

        public CuentaBancaria() { }

        #endregion

        #region Metodos de Instancia
        public void Retirar(decimal cantidad)
        {
            if (cantidad > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            Saldo -= cantidad;
        }

        public void Depositar (decimal cantidad)
        {
            Saldo += cantidad;
        }

        public override string ToString()
        {
            return string.Format("Numero de cuenta: {0},Ususario: {1}, Saldo: ${2}, Banco: {3}", NoCuenta,
                Usuario, Saldo, Banco);
        }
        #endregion

        public static void AsignarBanco(string banco)
        {
            Console.WriteLine("Asignando nuevo Banco...");
            Banco = banco;
        }


    }
}
