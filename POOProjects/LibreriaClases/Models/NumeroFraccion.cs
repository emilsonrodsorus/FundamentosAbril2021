using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases.Models
{
    public class NumeroFraccion
    {
        public NumeroFraccion(int numerador, int denominador) 
        {
            Numerador = numerador;
            Denominador = denominador;
        }

        public int Numerador { get; set; }
        public int Denominador { get; set; }

        public void Multiplicar(NumeroFraccion fraccion)
        {
            Numerador = Numerador * fraccion.Numerador;
            Denominador = Denominador * fraccion.Denominador;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", Numerador, Denominador);
        }

        public void Simplificar()
        {
            int count = 2;
            bool esMayor = count > Numerador && count > Denominador;
            while (!esMayor)
            {
                if (Numerador % count == 0 &&
                    Denominador % count == 0)
                {
                    Numerador = Numerador / count;
                    Denominador = Denominador / count;
                }
                else 
                {
                    count++;
                }
                esMayor = count > Numerador && count > Denominador;
            }
        }
    }
}
