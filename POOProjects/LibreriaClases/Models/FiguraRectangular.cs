using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Models
{
    public class FiguraRectangular
    {

        public FiguraRectangular(int alto, int largo)
        {
            Alto = alto;
            Largo = largo;
        }

        public int Alto { get; set; }
        public int Largo { get; set; }

        public int CalcularArea()
        {
            return Alto * Largo;
        }

        public int CalcularPerimetro()
        {
            return 2 * Alto + 2 * Largo;
        }

        public override string ToString()
        {
            return string.Format("Mi area es: {0} y mi perimetro es: {1}",
                CalcularArea(), CalcularPerimetro());
        }
    }
}
