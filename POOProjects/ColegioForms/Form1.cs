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
    public partial class Form1 : Form
    {
        EstudianteForm estudianteForm;
        EstudiantesController estudianteController;
        ProfesorForm profesorForm;
        public Form1()
        {
            InitializeComponent();
            estudianteController = new EstudiantesController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            estudianteForm = new EstudianteForm(estudianteController);
            estudianteForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            profesorForm = new ProfesorForm();
            profesorForm.Show();
        }
    }
}
