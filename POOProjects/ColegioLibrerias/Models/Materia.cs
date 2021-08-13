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

        public List<Estudiante> ListaEstudiantes {
            get 
            {
                return listaEstudiantes;
            }

            set 
            {
                listaEstudiantes = value;
            }
        }

        public string NombreMateria { get; set; }
        public string CodigoMateria { get; set; }
        public Profesor ProfesorMateria { get; set; }

        public List<Estudiante> getListaEstudiantes()
        {
            return listaEstudiantes;
        }

        public void setListaEstudiantes(List<Estudiante> nuevaLista)
        {
            listaEstudiantes = nuevaLista;
        }
    }
}
