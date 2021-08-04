using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosLibrary.ClasesAbstractas;
using VehiculosLibrary.Models;

namespace VehiculosLibrary.Controllers
{
    public class VehiculosController
    {
        List<Vehiculo> listaVehiculos;

        public VehiculosController()
        {
            listaVehiculos = new List<Vehiculo>();
        }

        public List<Vehiculo> ListaVehiculos 
        {
            get { return listaVehiculos; }
        }

        public void AgregarAeronave(string numeroChasis, string numeroMotor)
        {
            // Las clases abstractas ayudan a proteger la creacion de
            // objetos, ya que restringen la creacion a solo los objetos 
            // hijos, ya que crear objetos de tipo Padre o base
            // no tiene sentido ni logica en el programa
            // Vehiculo vehiculo = new Vehiculo();
            Aeronave nuevaAeronave = new Aeronave(numeroChasis, numeroMotor);
            ListaVehiculos.Add(nuevaAeronave);
        }

        public void AgregarBarco(string numeroChasis, string numeroMotor)
        {
            Barco nuevoBarco = new Barco(numeroChasis, numeroMotor);
            ListaVehiculos.Add(nuevoBarco);
        }

        public void AgregarAuto(string numeroChasis, string numeroMotor)
        {
            Auto nuevoAuto = new Auto(numeroChasis, numeroMotor);
            ListaVehiculos.Add(nuevoAuto);
        }

        public void AgregarMoto(string numeroChasis, string numeroMotor)
        {
            Moto nuevoMoto = new Moto(numeroChasis, numeroMotor);
            ListaVehiculos.Add(nuevoMoto);
        }
    }
}
