using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosLibrary.ClasesAbstractas;

namespace VehiculosLibrary.Models
{
    public class Auto : Automovil
    {
        public Auto(string numeroChasis, string numeroMotor)
            : base(numeroChasis, numeroMotor)
        { }

        public override string ToString()
        {
            return string.Format("Auto: {0}", base.ToString());
        }
    }
}
