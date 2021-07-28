using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrerias.Models
{
    class Materia
    {
        List<Estudiante> listaEstudiantes;

        public Materia(string nombre, string codigo)
        {
            NombreMateria = nombre;
            CodigoMateria = codigo;
            listaEstudiantes = new List<Estudiante>();
        }

        public string NombreMateria { get; set; }
        public string CodigoMateria { get; set; }
        public Profesor ProfesorMateria { get; set; }
    }
}
