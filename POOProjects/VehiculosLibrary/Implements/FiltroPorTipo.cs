using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosLibrary.ClasesAbstractas;
using VehiculosLibrary.Interfaces;
using VehiculosLibrary.Models;

namespace VehiculosLibrary.Implements
{
    public class FiltroPorTipo : IFilter
    {
        public bool FiltrarPor(Vehiculo vehiculo, string parametro)
        {
            switch (parametro) 
            {
                case "Auto":
                    return vehiculo is Auto;
                case "Aeronave":
                    return vehiculo is Aeronave;
            }

            return false;
        }

        public override string ToString()
        {
            return "Filtro por Tipo";
        }
    }
}
