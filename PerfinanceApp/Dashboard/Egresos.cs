using Dashboard.Models;
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
    public partial class Egresos : Form
    {
        private string usuarioId;

        public Egresos( string usuarioId )
        {
            this.usuarioId = usuarioId;
            InitializeComponent();
            //Muestra un tip de lo que hace al posicionar el mouse en el boton
            ToolTip tooltip = new System.Windows.Forms.ToolTip();
            tooltip.SetToolTip(botonCircular1, "Agregar egreso");
        }

        //Evento del boton
        private void button1_Click(object sender, EventArgs e)
        {
            AgregarEgreso ventana = new AgregarEgreso( usuarioId );
            ventana.ShowDialog();
        }
    }
}
