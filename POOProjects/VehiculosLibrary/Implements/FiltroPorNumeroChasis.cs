using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosLibrary.ClasesAbstractas;
using VehiculosLibrary.Interfaces;

namespace VehiculosLibrary.Implements
{
    public class FiltroPorNumeroChasis : IFilter
    {
        public bool FiltrarPor(Vehiculo vehiculo, string parametro)
        {
            return vehiculo.NumeroChasis.Contains(parametro);
        }

        public override string ToString()
        {
            return "Filtro por Numero de Chasis";
        }
    }
}
