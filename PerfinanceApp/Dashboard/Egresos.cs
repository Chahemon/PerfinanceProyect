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
        private bool temaOscuro;
        private List<Egreso> lstEgresos;

        public Egresos( string usuarioId, List<Egreso> lstEgreso, bool temaOscuro)
        {
            this.usuarioId  = usuarioId;
            this.lstEgresos = lstEgreso;

            InitializeComponent();
            //Muestra un tip de lo que hace al posicionar el mouse en el boton
            ToolTip tooltip = new System.Windows.Forms.ToolTip();
            tooltip.SetToolTip(botonCircular1, "Agregar egreso");
            tooltip.SetToolTip(botonCircular2, "Eliminar egreso");
            //Con esto se cambia el color de los headers del DataGridView (las tablas pues xd)
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73); //Estoy seguro de que es gris
            dataGridView.EnableHeadersVisualStyles = false;
            //Cambia el color de los bordes de las celdas
            dataGridView.GridColor = Color.FromArgb(46, 51, 73);
            
            // Cambiar el tema de la aplicación
            this.temaOscuro = temaOscuro;
            if (temaOscuro == false)
            {
                this.BackColor = Color.White;
                dataGridView.BackgroundColor = Color.White;
                //Cambia el color de los botones
                botonCircular1.BackColor = Color.White;
                botonCircular2.BackColor = Color.White;
                //Con esto se cambia el color de los headers del DataGridView (las tablas pues xd)
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(46, 51, 73);
                dataGridView.EnableHeadersVisualStyles = false;
                //Cambia el color de las celdas
                dataGridView.DefaultCellStyle.BackColor = Color.White;
                dataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(46, 51, 73);
                //Cambia el color de los bordes de las celdas
                dataGridView.GridColor = Color.FromArgb(46, 51, 73);
            }
            else
            {
                this.BackColor = Color.FromArgb(46, 51, 73);
                dataGridView.BackgroundColor = Color.FromArgb(46, 51, 73);
                //Cambia el color de los botones
                botonCircular1.BackColor = Color.FromArgb(24, 30, 54);
                botonCircular2.BackColor = Color.FromArgb(24, 30, 54);
                //Con esto se cambia el color de los headers del DataGridView (las tablas pues xd)
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73); //Estoy seguro de que es gris
                dataGridView.EnableHeadersVisualStyles = false;
                //Cambia el color de las celdas
                dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);
                dataGridView.DefaultCellStyle.ForeColor = Color.White;
                //Cambia el color de los bordes de las celdas
                dataGridView.GridColor = Color.FromArgb(46, 51, 73);
            }
        }

        //Evento del boton
        private void button1_Click(object sender, EventArgs e)
        {
            AgregarEgreso ventana = new AgregarEgreso( usuarioId, this.dataGridView, temaOscuro);
            ventana.ShowDialog();
        }

        public void CargarTabla()
        {
            this.dataGridView.AllowUserToAddRows = true;

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

            this.dataGridView.AllowUserToAddRows = false;
        }

        private void Egresos_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void botonCircular2_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;
            Egreso egresoEliminar = new Egreso();

            egresoEliminar.Cuenta = (string)dataGridView.Rows[row].Cells[0].Value;          // Cuenta
            egresoEliminar.Categoria = (string)dataGridView.Rows[row].Cells[1].Value;       // Categoria
            egresoEliminar.Valor = (float)dataGridView.Rows[row].Cells[2].Value;            // Cantidad
            egresoEliminar.Descripcion = (string)dataGridView.Rows[row].Cells[3].Value;     // Descripción
            egresoEliminar.CreatedAt = (DateTime)dataGridView.Rows[row].Cells[4].Value;     // Fecha

            string Id = "";

            foreach (var list in lstEgresos)
            {
                if (list.Cuenta == egresoEliminar.Cuenta &&
                     list.Categoria == egresoEliminar.Categoria &&
                     list.Valor == egresoEliminar.Valor &&
                     list.Descripcion == egresoEliminar.Descripcion &&
                     list.CreatedAt == egresoEliminar.CreatedAt)
                     Id = list.Id;
            }

            MongoClient client = new MongoClient("mongodb+srv://Admin:Panitasdel19@clusterpf.ot25ikt.mongodb.net/?retryWrites=true&w=majority");
            IMongoDatabase database = client.GetDatabase("test");
            IMongoCollection<Egreso> egresosDB = database.GetCollection<Egreso>("egresos");

            try
            {
                egresosDB.DeleteOne(d => d.Id == Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            List<Egreso> lstEgresosNueva = egresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();
            this.lstEgresos = lstEgresosNueva;

            dataGridView.Rows.Clear();
            CargarTabla();
        }
    }
}
