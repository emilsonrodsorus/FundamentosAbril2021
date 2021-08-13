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
using VehiculosLibrary.Interfaces;

namespace ManejadorVehiculosForms
{
    public partial class ResumenVehiculos : Form
    {
        VehiculosController controller;
        public ResumenVehiculos(VehiculosController controller)
        {
            InitializeComponent();
            this.controller = controller;
            ActualizarLista(controller.ListaVehiculos);
            ActualizarComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // por polimorfismo puedo agarrar el item seleccionado
            // que es un objeto y convertirlo a un Ifilter que puede
            // ser cualquier filtro
            IFilter filtroSelected = comboBox1.SelectedItem as IFilter;
            string parametro = textBox1.Text;
            List<Vehiculo> listaFinal = controller.ListaVehiculos;
            if (filtroSelected != null &&
                !string.IsNullOrEmpty(parametro))
            {
                listaFinal = controller.FiltrarLista(filtroSelected, parametro);
            }
            ActualizarLista(listaFinal);
        }

        private void ActualizarLista(List<Vehiculo> listaMostrar)
        {
            listBox1.Items.Clear();
            foreach (Vehiculo item in listaMostrar)
            {
                listBox1.Items.Add(item);
            }
        }

        private void ActualizarComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Mostrar todos");
            foreach (IFilter item in controller.ListaFiltros)
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
