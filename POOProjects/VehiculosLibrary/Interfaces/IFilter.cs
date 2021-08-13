using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosLibrary.ClasesAbstractas;

namespace VehiculosLibrary.Interfaces
{
    public interface IFilter
    {
        bool FiltrarPor(Vehiculo vehiculo, string parametro);
    }
}
