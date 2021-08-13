using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPreEx.Clases
{
    public class Cuenta
    {
        public static string nombreBanco = "BNB";

        private double saldo;
        public double Saldo { get { return saldo; } }

        public void ingreso()
        {
            saldo = 0;
            Console.WriteLine("Ingresar primer valor de Saldo");
            Reintegro(Convert.ToDouble(Console.ReadLine()));
        }

        public void Reintegro(double nuevoValor)
        {
            saldo = saldo + nuevoValor;
        }

        public void Transferencia(Cuenta cuenta, double cantidadMover)
        {
            if (saldo >= cantidadMover)
            {
                saldo = saldo - cantidadMover;
                cuenta.Reintegro(cantidadMover);
            }
            else 
            {
                Console.WriteLine("No tienes suficiente saldo");
            }
        }
    }
}
