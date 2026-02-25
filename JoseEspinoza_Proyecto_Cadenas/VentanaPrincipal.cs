using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}

