using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Models
{
    public class EmpleadoPlanta : Empleado
    {

        public EmpleadoPlanta(string codigoEmpleado) :
            base(codigoEmpleado)
        { }

        public EmpleadoPlanta(string nombreEmpleado, string apellidoEmpleado,
            string ciEmpleado, string codigoEmpleado, double sueldoMinimo, string codigoSeguro) :
            base(nombreEmpleado, apellidoEmpleado, ciEmpleado, codigoEmpleado)
        {
            SueldoMinimo = sueldoMinimo;
            CodigoSeguro = codigoSeguro;
        }
        public double SueldoMinimo { get; set; }
        public string CodigoSeguro { get; set; }
    }
}
