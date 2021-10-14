using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Usuario usuario = new Usuario("CRUZ", "cesarcruz@poo.com");

            Usuario usuario = new Usuario();
            usuario.Codigo = "CRUZ";
            usuario.Correo = "cesarcruz@poo.com";
            usuario.Nombre = "CÉSAR";
            usuario.Apellido = "CRUZ";

            MessageBox.Show(usuario.GetNombreCompleto(usuario.Nombre, usuario.Apellido));

        }
    }
}
