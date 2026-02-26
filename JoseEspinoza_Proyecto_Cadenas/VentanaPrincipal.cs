using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace JoseEspinoza_Proyecto_Cadenas
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void botonOpcionesTop_Click(object sender, EventArgs e)
        {
            activaOpcionesTop();
        }

        private void botonOpcionesBot_Click(object sender, EventArgs e)
        {
            activaOpcionesBot();
        }

        private void botonResetTop_Click(object sender, EventArgs e)
        {
            resetearTop();
        }

        private void botonResetBot_Click(object sender, EventArgs e)
        {
            resetearBot();
        }

        private void boton1Letra_Click(object sender, EventArgs e)
        {
            string resultado = Palabra.PrimeraLetrayFinal(campoPalabra.Text);
            campoResultados.Text = resultado;
        }

        private void botonReves_Click(object sender, EventArgs e)
        {
            string reves = Palabra.imprimirAlreves(campoPalabra.Text);
            campoResultados.Text = reves;
        }

        private void botonPosicion_Click(object sender, EventArgs e)
        {
            /*string numeroTecleado = Interaction.InputBox("Introduce un número", "Buscar posición de la letra", "");
            string resultado = Palabra.posicionLetra(campoPalabra.Text, numeroTecleado);
            campoResultados.Text = "La posición " + numeroTecleado + " es: " + resultado;*/
            string numeroTecleado = Interaction.InputBox("Introduce un número", "Buscar posición de letra", "");

            if (!string.IsNullOrEmpty(numeroTecleado))
            {
                string resultado = Palabra.posicionLetra(this.campoPalabra.Text, numeroTecleado);
                if (string.IsNullOrEmpty(resultado))
                {
                    MessageBox.Show("Error: La posición introducida no es válida o está fuera de rango.",
                                    "Error de Posición",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    this.campoResultados.Text = "La letra en la posición " + numeroTecleado + " es: " + resultado;
                }
            }
        }

        private void botonComparar_Click(object sender, EventArgs e)
        {
            string resultado = Palabra.CompararPalabras(campoPalabra.Text);
            campoResultados.Text = resultado;
            if (string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show("No se ha introducido la segunda palabra.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void botonLetraxLetra_Click(object sender, EventArgs e)
        {
            campoResultados.Text = Palabra.ImprimeLetraPorLetra(campoPalabra.Text);
        }

        private void botonInverso_Click(object sender, EventArgs e)
        {
            campoResultados.Text = Palabra.ImprimeLetraPorLetraInverso(campoPalabra.Text);
        }
    }
}

