using LibreriaClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Controllers
{
    public class FiguraRectangularController
    {
        public string CalcularCuadrado(int lado)
        {
            Cuadrado cuadrado1 = new Cuadrado(lado);
            return cuadrado1.ToString();
        }

        public string CalcularRectangulo(int lado, int alto)
        {
            Rectangulo rectangulo1 = new Rectangulo(lado, alto);
            return rectangulo1.ToString();
        }
    }
}
