using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Models
{
    class Punto
    {

        public Punto(int coordX, int coordY)
        {
            Ejex = coordX;
            Ejey = coordY;
        }

        public int Ejex { get; set; }
        public int Ejey { get; set; }
    }
}
