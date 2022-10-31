using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dashboard.Models;
using MongoDB.Driver;

namespace Dashboard
{
    public partial class Main : Form
    {
        private string usuarioId;
        private static MongoClient client = new MongoClient("mongodb+srv://Admin:Panitasdel19@clusterpf.ot25ikt.mongodb.net/?retryWrites=true&w=majority");
        private static IMongoDatabase database = client.GetDatabase("test");
        private static IMongoCollection<Usuarios> usuariosDB = database.GetCollection<Usuarios>("ingresos");

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

        //Evento que permite el movimiento del form
        private void arrastrarFormMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //-----------------------------------------------------------------------------------------------------

        public Main( string usuarioId )
        {
            this.usuarioId = usuarioId;
            InitializeComponent();
            //Inicializa y traza los bordes en el form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panNav.Height = btnInicio.Height;
            panNav.Top = btnInicio.Top;
            panNav.Left = btnInicio.Left;
            btnInicio.BackColor = Color.FromArgb(46, 51, 73);
        }

        //------------------------------------ Evento del boton inicio -------------------------------------------------
        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Inicio() );
            labelTItulo.Text = "Inicio";
            panNav.Height = btnInicio.Height;
            panNav.Top = btnInicio.Top;
            panNav.Left = btnInicio.Left;
            btnInicio.BackColor = Color.FromArgb(46, 51, 73);
        }
        //--------------------------------------------------------------------------------------------------------------

        //------------------------------------ Evento del boton Ingresos -----------------------------------------------
        private void btnIngresos_Click(object sender, EventArgs e)
        {
            labelTItulo.Text = "Ingresos";
            IMongoCollection<Ingreso> ingresosDB = database.GetCollection<Ingreso>("ingresos");
            List<Ingreso> lstIngresos = ingresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            abrirFormHija( new Ingresos( usuarioId, lstIngresos ));
            panNav.Height = btnIngresos.Height;
            panNav.Top = btnIngresos.Top;
            btnIngresos.BackColor = Color.FromArgb(46, 51, 73);
            btnInicio.BackColor = Color.FromArgb(24, 30, 54);

        }
        //--------------------------------------------------------------------------------------------------------------

        //---------------------------------------- Evento del boton Egresos --------------------------------------------
        private void btnEgresos_Click(object sender, EventArgs e)
        {
            labelTItulo.Text = "Egresos";
            IMongoCollection<Egreso> egresosDB = database.GetCollection<Egreso>("egresos");
            List<Egreso> lstEgresos = egresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            abrirFormHija( new Egresos( usuarioId, lstEgresos ) );
            panNav.Height = btnEgresos.Height;
            panNav.Top = btnEgresos.Top;
            btnEgresos.BackColor = Color.FromArgb(46, 51, 73);
            btnInicio.BackColor = Color.FromArgb(24, 30, 54);
        }
        //--------------------------------------------------------------------------------------------------------------

        //---------------------------------------- Evento del boton Analisis -------------------------------------------
        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            labelTItulo.Text = "Analisis";
            IMongoCollection<Egreso> egresosDB = database.GetCollection<Egreso>("egresos");
            List<Egreso> lstEgresos = egresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            IMongoCollection<Ingreso> ingresosDB = database.GetCollection<Ingreso>("ingresos");
            List<Ingreso> lstIngresos = ingresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            abrirFormHija( new Analisis( usuarioId, lstEgresos, lstIngresos ) );

            panNav.Height = btnAnalisis.Height;
            panNav.Top = btnAnalisis.Top;
            btnAnalisis.BackColor = Color.FromArgb(46, 51, 73);
            btnInicio.BackColor = Color.FromArgb(24, 30, 54);
        }
        //--------------------------------------------------------------------------------------------------------------

        //----------------------------------------- Evento del boton Calendario ----------------------------------------
        private void btnCalendario_Click(object sender, EventArgs e)
        {
            labelTItulo.Text = "Calendario";

            abrirFormHija(new Calendario());
            panNav.Height = btnCalendario.Height;
            panNav.Top = btnCalendario.Top;
            //panNav.Left = btnCalendario.Left;
            btnCalendario.BackColor = Color.FromArgb(46, 51, 73);
            btnInicio.BackColor = Color.FromArgb(24, 30, 54);
        }
        //--------------------------------------------------------------------------------------------------------------

        //----------------------------------------- Evento del boton Opciones ------------------------------------------
        private void btnOpciones_Click(object sender, EventArgs e)
        {
            labelTItulo.Text = "Opciones";

            abrirFormHija(new Opciones());
            panNav.Height = btnOpciones.Height;
            panNav.Top = btnOpciones.Top;
            //panNav.Left = btnOpciones.Left;
            btnOpciones.BackColor = Color.FromArgb(46, 51, 73);
            btnInicio.BackColor = Color.FromArgb(24, 30, 54);
        }
        //--------------------------------------------------------------------------------------------------------------

        //------------------------ Evento que selecciona el boton inicio al comenzar el programa -----------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }
        //--------------------------------------------------------------------------------------------------------------

        //----------------------------------- Eventos leave para los botones (Estetica) --------------------------------
        private void btnInicio_Leave(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnIngresos_Leave(object sender, EventArgs e)
        {
            btnIngresos.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnEgresos_Leave(object sender, EventArgs e)
        {
            btnEgresos.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnAnalisis_Leave(object sender, EventArgs e)
        {
            btnAnalisis.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnCalendario_Leave(object sender, EventArgs e)
        {
            btnCalendario.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnOpciones_Leave(object sender, EventArgs e)
        {
            btnOpciones.BackColor = Color.FromArgb(24, 30, 54);
        }
        //--------------------------------------------------------------------------------------------------------------

        //-------------------------- Evento para barra busqueda (necesita ser mejorado) --------------------------------
        private void textBox1_TextSelected(object sender, EventArgs e)
        {
            textBox1.Text = ("");
        }
        //--------------------------------------------------------------------------------------------------------------

        //------ Evento que nos permite abrir los form externos a este, util para no estar ocultando cosas -------------
        private void abrirFormHija ( object formhija )
        {
            if ( this.panelControlador.Controls.Count > 0 )
                this.panelControlador.Controls.RemoveAt( 0 );

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelControlador.Controls.Add(fh);
            this.panelControlador.Tag = fh;
            fh.Show();
        }
        //--------------------------------------------------------------------------------------------------------------

        //----------------------------- Eventos para el boton de cierre del form ----------------------------------------
        private void buttonClosePointed(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;  //Al pasar el mouse por el boton se vuelve rojo
        }
        private void buttonCloseDisapointed(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;  //Al quitar el mouse vuelve al color blanco
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //---------------------------------------------------------------------------------------------------------------  
    }
}
