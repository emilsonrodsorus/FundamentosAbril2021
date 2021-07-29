using ColegioConsole.UIConsole;
using ColegioLibrerias.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioConsole
{
    class Program
    {
        static EstudiantesController mainController;
        static EstudianteConsole estConsole;

        static void Main(string[] args)
        {
            mainController = new EstudiantesController();
            estConsole = new EstudianteConsole(mainController);

            while (true) 
            {
                Console.WriteLine("Elija un menu a trabajar");
                Console.WriteLine("1 Estudiantes");
                Console.WriteLine("2 Profesores");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select) 
                {
                    case 1:
                        estConsole.Continuar = true;
                        ManejarEstudiantes();
                        break;
                    case 2:
                        ManejarProfesores();
                        break;
                }
            }
        }

        private static void ManejarEstudiantes() 
        {
            while (estConsole.Continuar)
            {
                estConsole.MenuPrincipal();
            }
        }

        private static void ManejarProfesores()
        {
            Console.WriteLine("En construccion");
        }
    }
}
