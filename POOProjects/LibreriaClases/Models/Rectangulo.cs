using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Models
{
    class Rectangulo : FiguraRectangular
    {
        public Rectangulo(int alto, int largo) : base(alto, largo)
        { }

        public override string ToString()
        {
            return base.ToString() + " soy un rectangulo";
        }
    }
}
