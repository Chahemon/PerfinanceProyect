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
    
    public partial class Ingresos : Form
    {

        private string usuarioId;

        public Ingresos( string usuarioId )
        {
            this.usuarioId = usuarioId;
            InitializeComponent();
            //Muestra un tip de lo que hace al posicionar el mouse en el boton
            ToolTip tooltip = new System.Windows.Forms.ToolTip();
            tooltip.SetToolTip(botonCircular1, "Agregar Ingreso ");



        }

        //Evento del boton
        private void botonCircular1_Click(object sender, EventArgs e)
        {
            AgregarIngreso ventana = new AgregarIngreso(usuarioId);
            ventana.ShowDialog();
        }
    }
}
