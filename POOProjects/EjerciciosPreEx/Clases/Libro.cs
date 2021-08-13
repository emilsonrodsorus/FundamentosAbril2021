using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPreEx.Clases
{
    public class Libro
    {
        public Libro()
        {
            NombreLibro = "Sin Nombre";
            NombreAutor = "Anonimo";
            AnioEdicion = 0;
            Prestamo = false;
        }

        public Libro(string nombreLibro, string nombreAutor, int anio)
        {
            NombreLibro = nombreLibro;
            NombreAutor = nombreAutor;
            AnioEdicion = anio;
            Prestamo = false;
        }

        public string NombreLibro { get; set; }
        public string NombreAutor { get; set; }
        public int AnioEdicion { get; set; }
        public Fecha FechaPrestamo { get; set; }
        public bool Prestamo { get; set; }

        public void PrestarLibro()
        {
            Prestamo = true;
            Console.WriteLine("Ingrese Dia");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Mes");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Anio");
            int anio = Convert.ToInt32(Console.ReadLine());
            FechaPrestamo = new Fecha(dia, mes, anio, '/');
        }

        public void RetronarLibro()
        {
            Prestamo = false;
            FechaPrestamo = null;
        }

        public void VerificarLibro()
        {
            if (Prestamo)
            {
                Console.WriteLine("El libro fue prestado en fecha {0}", FechaPrestamo);
            }
            else 
            {
                Console.WriteLine("El libro no fue prestado");
            }
        }

        public override string ToString()
        {
            return string.Format("Libro del anio {0}, titulo: {1}, autor: {2}",
                AnioEdicion, NombreLibro, NombreAutor);
        }
    }
}
