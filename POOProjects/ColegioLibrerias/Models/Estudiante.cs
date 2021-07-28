using ColegioLibrerias.Superclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrerias.Models
{
    public class Estudiante : Persona
    {
        public Estudiante(string nombre, string apellido, string ci, string codigoEst, int curso) :
            base(nombre, apellido, ci)
        {
            CodigoEstudiante = codigoEst;
            Curso = curso;
        }

        public string CodigoEstudiante { get; set; }
        public int Curso { get; set; }
    }
}
