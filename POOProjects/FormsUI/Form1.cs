using LibreriaClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errorMessage = "Este campo es requerido";
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text))
            {
                this.label4.Visible = true;
                this.label5.Visible = true;
                this.label4.Text = errorMessage;
                this.label5.Text = errorMessage;
            }
            else 
            {
                int alto = Convert.ToInt32(textBox1.Text);
                int lado = Convert.ToInt32(textBox2.Text);
                Rectangulo rectangulo1 = new Rectangulo(alto, lado);
                textBox3.Text = rectangulo1.ToString();
                this.label4.Visible = false;
                this.label5.Visible = false;
            }
        }

        private void CambiarColor(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.YellowGreen;
        }

        private void RestaurarColor(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.White;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int alto = Convert.ToInt32(textBox1.Text);
            Cuadrado cuadrado1 = new Cuadrado(alto);
            textBox3.Text = cuadrado1.ToString();
        }
    }
}
