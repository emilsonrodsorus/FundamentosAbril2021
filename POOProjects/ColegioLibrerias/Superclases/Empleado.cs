using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrerias.Superclases
{
    public class Empleado : Persona
    {

        public Empleado(string nombre, string apellido, string ci,
            string codigoEmple, int horas, double  pago) : base(nombre, apellido, ci)
        {
            CodigoEmpleado = codigoEmple;
            HorasTrabajadas = horas;
            PagoHora = pago;
        }

        public string CodigoEmpleado { get; set; }
        public int HorasTrabajadas { get; set; }
        public double PagoHora { get; set; }

        public double CalcularSueldo()
        {
            return HorasTrabajadas * PagoHora;
        }
    }
}
