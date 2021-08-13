using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPreEx.Clases
{
    // manejando 2 formatos principales,
    // uno sera separados por guion -
    // otro separados por slash /
    public class Fecha
    {
        public Fecha(int dia, int mes, int anio, char formato)
        {
            Dia = dia;
            Mes = mes;
            Anio = anio;
            Formato = formato;
        }

        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public char Formato { get; set; }

        public bool ValidarFecha()
        {
            // se puede tomar como si el maximo numero de dias
            // sea 30
            if (Dia > 30)
            {
                return false;
            }
            if (Mes > 12)
            {
                return false;
            }
            if (Anio < 1800 || Anio > 2021)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            if (ValidarFecha())
            {
                return string.Format("{0}{1}{2}{3}{4}",
                    Dia, Formato, Mes, Formato, Anio);
            }
            else 
            {
                return "Fecha no valida";
            }
        }
    }
}
