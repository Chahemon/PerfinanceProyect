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
            //Cambia el color de los headers de la tabla (dataGridView)
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73); //color gris... eso creo
            dataGridView.EnableHeadersVisualStyles = false;
            //Cambia el color de los bordes de las celdas
            dataGridView.GridColor = Color.FromArgb(46, 51, 73);
        }

        //Evento del boton
        private void botonCircular1_Click(object sender, EventArgs e)
        {
            AgregarIngreso ventana = new AgregarIngreso(usuarioId, this.dataGridView );
            ventana.ShowDialog();
        }

        public void CargarTabla()
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

        //Evento para cargar la tabla actual de ingresos
        private void Ingresos_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}