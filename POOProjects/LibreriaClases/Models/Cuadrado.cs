using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Models
{
    class Cuadrado : FiguraRectangular
    {
        public Cuadrado(int lado) : base(lado, lado) 
        { }

        public override string ToString()
        {
            return base.ToString() + " soy un cuadrado";
        }
    }
}
