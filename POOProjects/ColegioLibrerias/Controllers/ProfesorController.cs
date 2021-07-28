using ColegioLibrerias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrerias.Controllers
{
    public class ProfesorController
    {
        public List<Profesor> listaProfesores;

        public List<Profesor> ListaProfesores
        {
            get { return listaProfesores; }
        }

        public void AgregarEstudiante(string nombre, string apellido, string ci, string codigoEmp, int horas, double pago)
        {
            Profesor estudiante = new Profesor(nombre, apellido, ci, codigoEmp, horas, pago);

            listaProfesores.Add(estudiante);
        }
    }
}
