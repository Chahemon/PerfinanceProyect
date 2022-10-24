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

    public partial class Ingresos : Form
    {

        private string usuarioId;
        private List<Ingreso> lstIngresos;

        public Ingresos(string usuarioId, List<Ingreso> lstIngreso)
        {
            this.usuarioId = usuarioId;
            this.lstIngresos = lstIngreso;
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

        //Evento para cargar la tabla actual de ingresos
        private void Ingresos_Load(object sender, EventArgs e)
        {
            foreach (var list in lstIngresos)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                row.Cells[0].Value = list.Categoria;     // Categoria
                row.Cells[1].Value = list.CreatedAt;      // Fecha
                row.Cells[2].Value = list.Valor;        // Cantidad
                dataGridView.Rows.Add(row);
            }
        }
    }
}