using Dashboard.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace Dashboard
{
    public partial class Egresos : Form
    {
        private string usuarioId;
        private List<Egreso> lstEgresos;

        public Egresos( string usuarioId, List<Egreso> lstEgreso)
        {
            this.usuarioId  = usuarioId;
            this.lstEgresos = lstEgreso;

            InitializeComponent();
            //Muestra un tip de lo que hace al posicionar el mouse en el boton
            ToolTip tooltip = new System.Windows.Forms.ToolTip();
            tooltip.SetToolTip(botonCircular1, "Agregar egreso");
        }

        //Evento del boton
        private void button1_Click(object sender, EventArgs e)
        {
            AgregarEgreso ventana = new AgregarEgreso( usuarioId, this.dataGridView );
            ventana.ShowDialog();
        }

        public void CargarTabla()
        {
            
            foreach (var list in lstEgresos)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                row.Cells[0].Value = list.Cuenta;        // Cuenta
                row.Cells[1].Value = list.Categoria;     // Categoria
                row.Cells[2].Value = list.Valor;         // Cantidad
                row.Cells[3].Value = list.Descripcion;   // Cantidad
                row.Cells[4].Value = list.CreatedAt;         // Cantidad
                dataGridView.Rows.Add(row);
            }
        }

        private void Egresos_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}
