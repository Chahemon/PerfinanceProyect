using Dashboard.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class AgregarEgreso : Form
    {
        private static MongoClient client = new MongoClient("mongodb+srv://Admin:Panitasdel19@clusterpf.ot25ikt.mongodb.net/?retryWrites=true&w=majority");
        private static IMongoDatabase database = client.GetDatabase("test");

        private string usuarioId;
        private DataGridView tabla;

        //------------------------------- Propiedades del bordeado del form ------------------------------------
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse
          );
        //------------------------------------------------------------------------------------------------------

        //----------------------- Propiedades que nos permiten arrastrar el form -------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Evento que se encarga de mover el form
        private void arrastrarFormEgreso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //-----------------------------------------------------------------------------------------------------

        public AgregarEgreso( string usuarioId, DataGridView tabla )
        {
            this.usuarioId = usuarioId;
            this.tabla = tabla;
            InitializeComponent();
            //Hace realidad de que tu form tenga bordes muy suaves
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public void CargarTabla()
        {
            IMongoCollection<Egreso> egresosDB = database.GetCollection<Egreso>("egresos");
            List<Egreso> lstEgresos = egresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();
            tabla.Rows.Clear();

            foreach (var list in lstEgresos)
            {
                DataGridViewRow row = (DataGridViewRow)tabla.Rows[0].Clone();
                row.Cells[0].Value = list.Cuenta;       // Cuenta
                row.Cells[1].Value = list.Categoria;    // Categoria
                row.Cells[2].Value = list.Valor;        // Cantidad
                row.Cells[3].Value = list.Descripcion;  // Descripción
                row.Cells[4].Value = list.CreatedAt;    // Fecha
                tabla.Rows.Add(row);
            }
        }

        //Evento para cerrar el form
        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Agregar Egreso 

            // Conectamos a la tabla Egreso
            IMongoCollection<Egreso> egresoDB = database.GetCollection<Egreso>("egresos");

            // Obtenemos la informacion y la guardamos

            // Creamos un Objeto con la información
            var egreso = new Egreso() { UsuarioId = this.usuarioId,
                                        Cuenta = "Efectivo", Categoria = "Comida", Valor = 550,
                                        Descripcion = "Comida del dia", CreatedAt = DateTime.Today };
            // La almacenamos en la base de datos
            egresoDB.InsertOne(egreso);

            CargarTabla();

            this.Dispose();
        }
    }
}
