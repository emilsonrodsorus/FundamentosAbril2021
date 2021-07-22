using LibreriaClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Controllers
{
    public class EmpleadoController
    {
        List<Empleado> listaEmpleados;

        public EmpleadoController() 
        {
            listaEmpleados = new List<Empleado>();
        }

        public void AgregarEmpleadoPlanta(string nombreEmpleado, string apellidoEmpleado,
            string ciEmpleado, string codigoEmpleado, double sueldoMinimo, string codigoSeguro) 
        {
            EmpleadoPlanta nuevoEmpleado = new EmpleadoPlanta(nombreEmpleado, apellidoEmpleado,
            ciEmpleado, codigoEmpleado, sueldoMinimo, codigoSeguro);

            listaEmpleados.Add(nuevoEmpleado);
        }

        public void AgregarEmpleadoConsultor(string nombreEmpleado, string apellidoEmpleado,
            string ciEmpleado, string codigoEmpleado, int cantidadMinimaHoras)
        {
            EmpleadoConsultor nuevoEmpleado = new EmpleadoConsultor(nombreEmpleado, apellidoEmpleado,
            ciEmpleado, codigoEmpleado, cantidadMinimaHoras);

            listaEmpleados.Add(nuevoEmpleado);
        }
    }
}
