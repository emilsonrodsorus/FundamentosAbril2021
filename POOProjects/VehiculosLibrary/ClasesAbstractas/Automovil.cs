using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosLibrary.ClasesAbstractas
{
    public abstract class Automovil : Vehiculo
    {
        public Automovil(string numeroChasis, string numeroMotor)
            : base(numeroChasis, numeroMotor)
        { }
    }
}
