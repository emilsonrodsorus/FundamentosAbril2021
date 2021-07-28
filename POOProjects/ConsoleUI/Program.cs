using LibreriaClases.Controllers;
using LibreriaClases.Models;
// using LibreriaClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static LineaController lineaController;
        static void Main(string[] args)
        {

            //LibreriaClases.Models.Cuadrado cuadrado1 = new LibreriaClases.Models.Cuadrado(15);
            //Rectangulo rectangulo1 = new Rectangulo(5, 10);
            //FiguraRectangularController controllerFigura = new FiguraRectangularController();
            //Console.WriteLine(controllerFigura.CalcularCuadrado(15));
            //Console.WriteLine(controllerFigura.CalcularRectangulo(5, 10));
            // EmpleadoController controllerEmp = new EmpleadoController();
            //lineaController = new LineaController();
            //while (true) 
            //{
            //    Console.WriteLine("Ingrese 1 si desea agregar un punto");
            //    Console.WriteLine("Ingrese 2 si desea calcular la distancia de los puntos");
            //    int seleccion = Convert.ToInt32(Console.ReadLine());
            //    switch (seleccion) 
            //    {
            //        case 1:
            //            AgregarPunto();
            //            break;
            //        case 2:
            //            CalcularDistancia();
            //            break;
            //    }
            //}


            NumeroFraccion fraccion1 = new NumeroFraccion(5, 2);
            NumeroFraccion fraccion2 = new NumeroFraccion(2, 3);
            fraccion1.Multiplicar(fraccion2);
            Console.WriteLine(fraccion1);
            fraccion1.Simplificar();
            Console.WriteLine(fraccion1);
        }

        public static void AgregarPunto()
        {
            Console.WriteLine("Ingrese eje X");
            int ejeX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese eje Y");
            int ejeY = Convert.ToInt32(Console.ReadLine());
            lineaController.IngresarPunto(ejeX, ejeY);
        }

        public static void CalcularDistancia()
        {
            double result = lineaController.CalcularDistancia();
            if (result == -1)
            {
                Console.WriteLine("No tenemos los puntos necesarios");
            }
            else 
            {
                Console.WriteLine("La distancia entre ambos puntos es {0}", result);
            }
        }
    }
}
