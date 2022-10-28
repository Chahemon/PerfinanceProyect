using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void BotonCambiarTema_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Cambio el estado del boton";
        }
    }
}
