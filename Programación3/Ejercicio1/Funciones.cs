using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {

            LimpiarControles();

        }

        private void LimpiarControles()
        {
            Numero1TextBox.Clear();
            Numero2TextBox.Clear();
            ResultadoLabel.Text = "";
        }

        private int Sumar(int Valor1, int Valor2)
        {
            return Valor1 + Valor2;
        }

        private int Resta(int Valor1, int Valor2)
        {
            int Resta = Valor1 - Valor2;
            return Resta;
        }

        private int Multiplicar(int Valor1, int Valor2)
        {
            return Valor1 * Valor2;
        }

        private int Dividir(int Valor1, int Valor2)
        {
            return Valor1 / Valor2;
        }

        private void SumaButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Sumar(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }

        private void RestasButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Resta(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Multiplicar(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Dividir(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }
    }
}
