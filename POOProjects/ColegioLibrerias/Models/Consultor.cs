using ColegioLibrerias.Superclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrerias.Models
{
    class Consultor : Empleado
    {
        public Consultor(string nombre, string apellido, string ci,
            string codigoEmple, int horas, double pago) :
            base(nombre, apellido, ci, codigoEmple, horas, pago)
        { }
    }
}
