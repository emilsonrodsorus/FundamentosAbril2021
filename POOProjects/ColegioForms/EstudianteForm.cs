using ColegioLibrerias.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegioForms
{
    public partial class EstudianteForm : Form
    {
        EstudiantesController estudianteController;
        // este controller se crea ahora en el form1

        public EstudianteForm(EstudiantesController controller)
        {
            InitializeComponent();
            // estudianteController = new EstudiantesController();
            estudianteController = controller;
            ActualizarLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string ci = textBox3.Text;
            string codigo = textBox4.Text;
            int curso = Convert.ToInt32( textBox5.Text);
            estudianteController.AgregarEstudiante(nombre, apellido, ci, codigo, curso);
            ActualizarLista();
        }

        private void ActualizarLista() 
        {
            listBox1.Items.Clear();
            foreach (var estudiante in estudianteController.ListaEstudiantes)
            {
                listBox1.Items.Add(estudiante.ToString());
            }
        }
    }
}
