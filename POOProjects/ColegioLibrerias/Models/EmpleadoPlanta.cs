using ColegioLibrerias.Superclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrerias.Models
{
    class EmpleadoPlanta : Empleado
    {
        public EmpleadoPlanta(string nombre, string apellido, string ci,
            string codigoEmple, int horas, double pago, string seguro) :
            base(nombre, apellido, ci, codigoEmple, horas, pago)
        {
            Seguro = seguro;
        }

        public string Seguro { get; set; }
    }
}
