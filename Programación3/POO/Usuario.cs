using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Usuario
    {
        //Propiedades, Características, Atributos

        //Atributos.
        private string apellidos;




        //Propiedades
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido
        {
            set
            {
                apellidos = value;
            }
            get
            {
                return apellidos;
            }

        }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        //Constructores
        public Usuario()
        {
        }

        public Usuario(string codigo, string correo)
        {
            Codigo = codigo;
            Correo = correo;

        }

        public Usuario(string codigo, string nombre, string apellido, int edad, string correo, string contraseña) : this(codigo, nombre)
        {
            Apellido = apellido;
            Edad = edad;
            Correo = correo;
            Contraseña = contraseña;
        }

        //Métodos

        public string GetNombreCompleto(string nombre, string apellidos)
        {
            string nombreCompleto = nombre + " " + apellidos;
            return nombreCompleto;
        }

    }
}
