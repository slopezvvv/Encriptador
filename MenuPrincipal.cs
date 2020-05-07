using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encriptador
{
    public partial class MenuPrincipal : Form
    {
        private int[] _libreta = new int[] { 27, 5, 8, 22, 7 };
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        // Evento que se ejecutará cuando haga click en el botón encriptar
        private void _botonEncriptar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Boton encriptar");

            string textoPlano = _inputTexto.Text;

            if (textoPlano.Length == _libreta.Length)
            {
                string cifrado = string.Empty;
                int i = 0;
                foreach(char c in textoPlano)
                {
                    int resultado = (int)c;

                    resultado += _libreta[i];
                    resultado %= 27;

                    cifrado += (char)resultado;

                    i++;
                }

                MessageBox.Show("El mensaje cifrado es: " + cifrado);
            }
            else
            {
                MessageBox.Show("El mensaje no se puede encriptar");
                _inputTexto.Text = string.Empty;
                _inputTexto.Focus();
            }
        }

        // Evento que se ejecutará cuando haga click en el botón descencriptar
        private void _botonDescencriptar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Boton descencriptar");
        }
    }
}
