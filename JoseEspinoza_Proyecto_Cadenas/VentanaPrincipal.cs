using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static JoseEspinoza_Proyecto_Cadenas.Texto;
using static JoseEspinoza_Proyecto_Cadenas.Palabra;
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
            campoResultados.Text = PrimeraLetrayFinal(campoPalabra.Text);
            
        }

        private void botonReves_Click(object sender, EventArgs e)
        {
            campoResultados.Text = imprimirAlreves(campoPalabra.Text);
           
        }

        private void botonPosicion_Click(object sender, EventArgs e)
        {
            campoResultados.Text = posicionLetra(campoPalabra.Text);
            //Este código es como se debéria haber realizado correctamente, hacer aqui todo lo correspondiente a lo que se imprimra en la interfaz.
            /*
             if (!string.IsNullOrEmpty(numeroTecleado))
             {
                 string resultado = posicionLetra(campoPalabra.Text, numeroTecleado);
                 if (string.IsNullOrEmpty(resultado))
                 {
                     MessageBox.Show("Error: La posición introducida no es válida o está fuera de rango.",
                                     "Error de Posición",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                 }
                 else
                 {
                     campoResultados.Text = "La letra en la posición " + numeroTecleado + " es: " + resultado;
                 }
             }*/
        }

        private void botonComparar_Click(object sender, EventArgs e)
        {
            campoResultados.Text = CompararPalabras(campoPalabra.Text);
            /*
            string resultado = CompararPalabras(campoPalabra.Text);
            campoResultados.Text = resultado;
            if (string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show("No se ha introducido la segunda palabra.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }*/
        }

        private void botonLetraxLetra_Click(object sender, EventArgs e)
        {
           campoResultados.Text = ImprimeLetraPorLetra(campoPalabra.Text);
        }

        private void botonInverso_Click(object sender, EventArgs e)
        {
           campoResultados.Text = ImprimeLetraPorLetraInverso(campoPalabra.Text);
        }

        private void botonContar_Click(object sender, EventArgs e)
        {
            string texto = campoTexto.Text;

             labelPalabras.Text = contarPalabras(texto).ToString();
             labelVocales.Text = contarVocales(texto).ToString();
             labelConsonantes.Text = contarConsonantes(texto).ToString();
            
        }

        private void botonPalabraxPalabra_Click(object sender, EventArgs e)
        {
            campoResultados2.Text = imprimirPalabraxPalabra(campoTexto.Text);
        }

        private void botonPalabraInversa_Click(object sender, EventArgs e)
        {
           campoResultados2.Text = imprimirPalabraxPalabraInverso(campoTexto.Text);
        }

        private void botonMapVocales_Click(object sender, EventArgs e)
        {
           campoResultados2.Text = mapaVocales(campoTexto.Text);
        }

        private void botonMapConsonantes_Click(object sender, EventArgs e)
        {
           campoResultados2.Text = mapaConsonantes(campoTexto.Text);
        }
    }
}

