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
    public partial class FuncionesDeTexto : Form
    {
        public FuncionesDeTexto()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox.Text;

            //Obtener la longitud de la cadena ingresada.
            LongitudTextBox.Text = cadena.Length.ToString();

            //Obtener el primer elemento o caracter.
            PrimerCaracterTextBox.Text = cadena.Substring(0, 1);

            //Obtener el último elemento o caracter.
            UltimoCaracterTextBox.Text = cadena.Substring(cadena.Length - 1, 1);

            //Obtener el Rango elemento o caracter.
            RangoTextBox.Text = cadena.Substring(5, 15);

            //Convertir a mayúsculas.
            MayusculasTextBox.Text = cadena.ToUpper();

            //Convertir a minúsculas.
            MinusculasTextBox.Text = cadena.ToLower();

            //Reemplazar elemento o caracter.
            ReemplazarTextBox.Text = cadena.Replace("a", "4");

            //Convertir el primer letra a mayúscula.
            PrimeraMTextBox.Text = cadena.Substring(0, 1).ToUpper() + cadena.Substring(1, cadena.Length -1).ToLower();
        }
    }
}
