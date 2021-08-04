using ColegioLibrerias.Models;
using ColegioLibrerias.Superclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrerias.Controllers
{
    public class EstudiantesController
    {
        public List<Estudiante> listaEstudiantes;

        public EstudiantesController()
        {
            listaEstudiantes = new List<Estudiante>();
        }

        public List<Estudiante> ListaEstudiantes { 
            get { return listaEstudiantes; }
        }

        public void AgregarEstudiante(string nombre, string apellido, string ci, string codigoEst, int curso)
        {
            Persona persona = new Persona(nombre, apellido, ci);
            Estudiante estudiante = new Estudiante(nombre, apellido, ci, codigoEst, curso);

            listaEstudiantes.Add(estudiante);
        }
    }
}
