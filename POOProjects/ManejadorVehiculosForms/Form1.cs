using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehiculosLibrary.Controllers;

namespace ManejadorVehiculosForms
{
    public partial class Form1 : Form
    {
        VehiculosController controller;
        public Form1()
        {
            InitializeComponent();
            controller = new VehiculosController();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AutosForm formAutos = new AutosForm(controller);
            formAutos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AvionesForm formAviones = new AvionesForm(controller);
            formAviones.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResumenVehiculos resumenForm = new ResumenVehiculos(controller);
            resumenForm.Show();
        }
    }
}
