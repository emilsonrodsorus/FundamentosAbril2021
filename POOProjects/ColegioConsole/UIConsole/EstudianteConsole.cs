using ColegioLibrerias.Controllers;
using ColegioLibrerias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioConsole.UIConsole
{
    class EstudianteConsole
    {
        EstudiantesController mainController;
        
        public EstudianteConsole(EstudiantesController controller)
        {
            mainController = controller;
            Continuar = true;
        }

        public bool Continuar { get; set; }

        public void MenuPrincipal()
        {
            Console.WriteLine("Elija un menu a trabajar");
            Console.WriteLine("1 Agregar Estudiantes");
            Console.WriteLine("2 Ver Lista Estudiantes");
            Console.WriteLine("3 salir");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    AgregarEstudiante();
                    break;
                case 2:
                    MostrarLista();
                    break;
                case 3:
                    Continuar = false;
                    break;
            }
        }

        public void AgregarEstudiante()
        {
            Console.WriteLine("Ingrese el Nombre Estudiante");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido Estudiante");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el Codigo Estudiante");
            string codigo = Console.ReadLine();
            Console.WriteLine("Ingrese el CI Estudiante");
            string ci = Console.ReadLine();
            Console.WriteLine("Ingrese el Curso Estudiante");
            int curso = Convert.ToInt32(Console.ReadLine());
            mainController.AgregarEstudiante(nombre, apellido, ci, codigo, curso);
        }
        public void MostrarLista()
        {
            foreach (Estudiante estudiante in mainController.ListaEstudiantes)
            {
                Console.WriteLine(estudiante);
            }
        }
    }
}
