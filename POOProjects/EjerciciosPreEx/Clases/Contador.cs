using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPreEx.Clases
{
    public class Contador
    {
        private int count;

        public Contador() 
        {
            count = 0; 
        }
        public Contador(int inicio)
        {
            count = inicio;
        }

        public int Count { get { return count; } }

        public void IncrementarContador()
        {
            count++;
        }
        public void DecrementarContador()
        {
            count--;
        }

        public void OperarContador(int valor)
        {
            count = count + valor;
        }

        public void FuncionContar(int limite)
        {
            for (int contando = 1; contando <= limite; contando++)
            {
                Console.WriteLine(contando);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}", count);
        }
    }
}
