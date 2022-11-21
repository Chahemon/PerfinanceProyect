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
using System.Windows.Forms.DataVisualization.Charting;

namespace Dashboard
{
    public partial class Ingresos : Form
    {
        private string usuarioId;
        private bool temaOscuro;
        private List<Ingreso> lstIngresos;

        public Ingresos(string usuarioId, List<Ingreso> lstIngreso, bool temaOscuro)
        {
            this.usuarioId = usuarioId;
            this.lstIngresos = lstIngreso;
            InitializeComponent();
            //Muestra un tip de lo que hace al posicionar el mouse en el boton
            ToolTip tooltip = new System.Windows.Forms.ToolTip();
            tooltip.SetToolTip(botonCircular1, "Agregar Ingreso");
            tooltip.SetToolTip(botonCircular2, "Eliminar Ingreso");
            //Cambia el color de los headers de la tabla (dataGridView)
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73); //color gris... eso creo
            dataGridView.EnableHeadersVisualStyles = false;
            //Cambia el color de los bordes de las celdas
            dataGridView.GridColor = Color.FromArgb(46, 51, 73);
            // Cambiar el tema de la aplicación
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
        private void botonCircular1_Click(object sender, EventArgs e)
        {
            AgregarIngreso ventana = new AgregarIngreso(usuarioId, this.dataGridView, temaOscuro);
            ventana.ShowDialog();
        }

        private void botonCircular2_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView.CurrentCell.RowIndex;
                Ingreso ingresoEliminar = new Ingreso();

                ingresoEliminar.Cuenta = (string)dataGridView.Rows[row].Cells[0].Value;          // Cuenta
                ingresoEliminar.Categoria = (string)dataGridView.Rows[row].Cells[1].Value;          // Categoria
                ingresoEliminar.Valor = (float)dataGridView.Rows[row].Cells[2].Value;          // Cantidad
                ingresoEliminar.Descripcion = (string)dataGridView.Rows[row].Cells[3].Value;          // Descripción
                ingresoEliminar.CreatedAt = (DateTime)dataGridView.Rows[row].Cells[4].Value;          // Fecha

                string Id = "";

                foreach (var list in lstIngresos)
                {
                    if (list.Cuenta == ingresoEliminar.Cuenta &&
                         list.Categoria == ingresoEliminar.Categoria &&
                         list.Valor == ingresoEliminar.Valor &&
                         list.Descripcion == ingresoEliminar.Descripcion &&
                         list.CreatedAt == ingresoEliminar.CreatedAt)
                        Id = list.Id;
                }

                MongoClient client = new MongoClient("mongodb+srv://Admin:Panitasdel19@clusterpf.ot25ikt.mongodb.net/?retryWrites=true&w=majority");
                IMongoDatabase database = client.GetDatabase("test");
                IMongoCollection<Ingreso> ingresosDB = database.GetCollection<Ingreso>("ingresos");

                try
                {
                    ingresosDB.DeleteOne(d => d.Id == Id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                List<Ingreso> lstIngresosNueva = ingresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();
                this.lstIngresos = lstIngresosNueva;

                dataGridView.Rows.Clear();
                CargarTabla();
            } catch ( Exception error )
            {
                Console.WriteLine(error);
            }

        }

        public void CargarTabla()
        {
            this.dataGridView.AllowUserToAddRows = true;

            foreach (var list in lstIngresos)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                row.Cells[0].Value = list.Cuenta;       // Cuenta
                row.Cells[1].Value = list.Categoria;    // Categoria
                row.Cells[2].Value = list.Valor;        // Cantidad
                row.Cells[3].Value = list.Descripcion;  // Descripción
                row.Cells[4].Value = list.CreatedAt;    // Fecha             
                dataGridView.Rows.Add(row);
            }

            this.dataGridView.AllowUserToAddRows = false;
        }

        //Evento para cargar la tabla actual de ingresos
        private void Ingresos_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

    }
}