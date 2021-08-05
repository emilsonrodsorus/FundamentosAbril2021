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

namespace ManejadorVehiculosForms
{
    public partial class ResumenVehiculos : Form
    {
        VehiculosController controller;
        public ResumenVehiculos(VehiculosController controller)
        {
            InitializeComponent();
            this.controller = controller;
            ActualizarLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarLista()
        {
            listBox1.Items.Clear();
            foreach (Vehiculo item in controller.ListaVehiculos)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
