using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosLibrary.ClasesAbstractas
{
    public abstract class Vehiculo
    {

        public Vehiculo(string numeroChasis, string numeroMotor)
        {
            NumeroChasis = numeroChasis;
            NumeroMotor = numeroMotor;
        }

        public string NumeroChasis { get; set; }
        public string Placa { get; set; }
        public string NumeroMotor { get; set; }
        public string NombreRepresentante { get; set; }
        public string Marca { get; set; }


        public override string ToString()
        {
            return string.Format("Marca: {0}, Numero Chasis: {1}, Numero Motor: {2}, Placa: {3}",
                Marca, NumeroChasis, NumeroMotor, Placa);
        }
    }
}
