using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosLibrary.ClasesAbstractas;
using VehiculosLibrary.Implements;
using VehiculosLibrary.Interfaces;
using VehiculosLibrary.Models;

namespace VehiculosLibrary.Controllers
{
    public class VehiculosController
    {
        List<Vehiculo> listaVehiculos;
        List<IFilter> listaDeFiltros;

        public VehiculosController()
        {
            listaVehiculos = new List<Vehiculo>();
            CargarFiltros();
        }

        public List<Vehiculo> ListaVehiculos 
        {
            get { return listaVehiculos; }
        }

        public List<IFilter> ListaFiltros
        {
            get { return listaDeFiltros; }
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

        public List<Vehiculo> FiltrarLista(IFilter filtro, string parametro)
        {
            // es una funcion lambda que tiene que ver con la programacion
            // funcional, las funciones lambda declaran sus parametros antes
            // de la ejecucion o antes del simbolo => despues de ese simbolo
            // se declara la funcionalidad
            return listaVehiculos.Where(vh => filtro.FiltrarPor(vh, parametro)).ToList();
        }

        private void CargarFiltros()
        {
            listaDeFiltros = new List<IFilter>();
            listaDeFiltros.Add(new FiltroPorTipo());
            listaDeFiltros.Add(new FiltroPorNumeroChasis());
            listaDeFiltros.Add(new FiltroPorNumeroMotor());
        }
    }
}
