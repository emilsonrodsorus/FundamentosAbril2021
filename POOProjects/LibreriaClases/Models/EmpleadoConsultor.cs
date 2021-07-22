using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Models
{
    public class EmpleadoConsultor : Empleado
    {
        public EmpleadoConsultor(string codigoEmpleado) : 
            base(codigoEmpleado)
        {
            CantidadMinimaHoras = 160;
        }

        public EmpleadoConsultor(string nombreEmpleado, string apellidoEmpleado,
            string ciEmpleado, string codigoEmpleado, int cantidadMinimaHoras) :
            base(nombreEmpleado, apellidoEmpleado, ciEmpleado, codigoEmpleado)
        {
            CantidadMinimaHoras = cantidadMinimaHoras;
        }

        public int CantidadMinimaHoras { get; set; }
    }
}
