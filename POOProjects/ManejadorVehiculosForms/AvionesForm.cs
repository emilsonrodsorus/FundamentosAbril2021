using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehiculosLibrary.ClasesAbstractas;
using VehiculosLibrary.Controllers;
using VehiculosLibrary.Models;

namespace ManejadorVehiculosForms
{
    public partial class AvionesForm : Form
    {

        VehiculosController controller;
        public AvionesForm(VehiculosController controller)
        {
            InitializeComponent();
            this.controller = controller;
            ActualizarLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigoChasis = textBox1.Text;
            string codigoMotor = textBox2.Text;
            controller.AgregarAeronave(codigoChasis, codigoMotor);
            ActualizarLista();
            ClearFields();
        }
        private void ActualizarLista()
        {
            listBox1.Items.Clear();
            foreach (Vehiculo item in controller.ListaVehiculos)
            {
                if (item is Aeronave)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void ClearFields()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }
    }
}
