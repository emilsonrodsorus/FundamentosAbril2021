using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosLibrary.ClasesAbstractas;

namespace VehiculosLibrary.Models
{
    public class Moto : Automovil
    {
        public Moto(string numeroChasis, string numeroMotor)
           : base(numeroChasis, numeroMotor)
        { }
        public override string ToString()
        {
            return string.Format("Moto: {0}", base.ToString());
        }
    }
}
