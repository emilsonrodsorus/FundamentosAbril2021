using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosLibrary.ClasesAbstractas;
using VehiculosLibrary.Interfaces;

namespace VehiculosLibrary.Implements
{
    public class FiltroPorNumeroMotor : IFilter
    {
        public bool FiltrarPor(Vehiculo vehiculo, string parametro)
        {
            return vehiculo.NumeroMotor.Contains(parametro);
        }

        public override string ToString()
        {
            return "Filtro por Numero de Motor";
        }
    }
}
