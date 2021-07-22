using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Models
{
    public class Empleado
    {
        // cuando solo agregamos Propiedades, el codigo genera los atributos
        // por debajo

        public Empleado(string codigoEmpleado)
        {
            NombreEmpleado = string.Empty; // ""
            ApellidoEmpleado = string.Empty; // ""
            CI = string.Empty; // ""
            CodigoEmpleado = codigoEmpleado; // ""
        }

        //sobrecarga de la funcion constructora, 
        // para poder crear Empleados con todos los datos
        public Empleado(string nombreEmpleado, string apellidoEmpleado,
            string ciEmpleado, string codigoEmpleado)
        {
            NombreEmpleado = nombreEmpleado;
            ApellidoEmpleado = apellidoEmpleado;
            CI = ciEmpleado;
            CodigoEmpleado = codigoEmpleado;
        }

        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string CI { get; set; }
        public string CodigoEmpleado { get; set; }

        // Sobreescribir la funcion toString para que el empleado
        // se pueda presentar
        public override string ToString()
        {
            Object
            return string.Format("Empleado con codigo {0}, nombre completo {1}, y CI {2}",
                CodigoEmpleado, ApellidoEmpleado + string.Empty + NombreEmpleado, CI);
        }
    }
}
