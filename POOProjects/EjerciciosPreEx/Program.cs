using EjerciciosPreEx.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPreEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contador contadorAux = new Contador();
            //while (true)
            //{
            //    Console.WriteLine("Ingrese un numero");
            //    int numero = Convert.ToInt32(Console.ReadLine());
            //    //if (numero % 2 == 0)
            //    //{
            //    //    contadorAux.IncrementarContador();
            //    //}
            //    //else 
            //    //{
            //    //    contadorAux.DecrementarContador();
            //    //}

            //    contadorAux.FuncionContar(155);

            //    Console.WriteLine("Ingresaste {0} numeros pares", contadorAux.Count);
            //}
            //Fecha fecha1 = new Fecha(30, 12, 2021, '/');
            //Console.WriteLine(fecha1);

            //Cuenta cuenta1 = new Cuenta();
            //cuenta1.ingreso();
            //Cuenta cuenta2 = new Cuenta();
            //cuenta2.ingreso();

            //cuenta1.Transferencia(cuenta2, 10000);
            //Console.WriteLine(Cuenta.nombreBanco);

            //CI ci1 = new CI();
            //ci1.FechaInicio = new Fecha(15, 11, 2020, '/');
            Libro libro1 = new Libro("La Odisea", "Homero", 250);
            Console.WriteLine(libro1);
            libro1.VerificarLibro();
            libro1.PrestarLibro();
            libro1.VerificarLibro();
            libro1.RetronarLibro();
            libro1.VerificarLibro();
        }
    }
}
