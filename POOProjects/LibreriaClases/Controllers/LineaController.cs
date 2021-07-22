using LibreriaClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Controllers
{
    public class LineaController
    {
        Punto Punto1 { get; set; }
        Punto Punto2 { get; set; }

        public void IngresarPunto(int coorX, int coorY)
        {
            if (Punto1 == null)
            {
                Punto1 = new Punto(coorX, coorY);
            }else if(Punto2 == null)
            {
                Punto2 = new Punto(coorX, coorY);
            }
        }

        public double CalcularDistancia()
        {
            double result = -1;
            if (Punto1 != null && Punto2 != null)
            {
                double difCoordx = Math.Pow((Punto2.Ejex - Punto1.Ejex), 2);
                double difCoordy = Math.Pow((Punto2.Ejey - Punto1.Ejey), 2);
                result = Math.Sqrt(difCoordx + difCoordy);
            }
            
            return result;
        }
    }
}
