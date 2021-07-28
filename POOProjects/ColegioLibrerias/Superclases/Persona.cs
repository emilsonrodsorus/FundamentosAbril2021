using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrerias.Superclases
{
    public class Persona
    {
        public Persona(string nombre, string apellido, string ci)
        {
            Nombre = nombre;
            Apellido = apellido;
            CI = ci;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CI { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} - ci {2}",Nombre, Apellido, CI );
        }
    }
}
