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
        private bool temaOscuro = true;
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

            /*if (temaOscuro == false)
            {
                btnInicio.BackColor = Color.FromArgb(24, 30, 54);
            }
            else
            {
                btnInicio.BackColor = Color.FromArgb(46, 51, 73);
            }*/
        }

        //------------------------------------ Evento del boton inicio -------------------------------------------------
        private void btnInicio_Click(object sender, EventArgs e)
        {
            IMongoCollection<Egreso> egresosDB = database.GetCollection<Egreso>("egresos");
            List<Egreso> lstEgresos = egresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            IMongoCollection<Ingreso> ingresosDB = database.GetCollection<Ingreso>("ingresos");
            List<Ingreso> lstIngresos = ingresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            this.panelControlador.Visible = true;
            abrirFormHija(new Inicio(lstEgresos, lstIngresos, temaOscuro, usuarioId) );
            labelTItulo.Text = "Inicio";
            panNav.Height = btnInicio.Height;
            panNav.Top = btnInicio.Top;
            panNav.Left = btnInicio.Left;
            
            //Color que indica que está seleccionado
            if(temaOscuro == false)
            {
                btnInicio.BackColor = Color.FromArgb(255, 156, 56);
            }
            else
            {
                btnInicio.BackColor = Color.FromArgb(46, 51, 73);
            }
        }
        //--------------------------------------------------------------------------------------------------------------

        //------------------------------------ Evento del boton Ingresos -----------------------------------------------
        private void btnIngresos_Click(object sender, EventArgs e)
        {
            this.panelControlador.Visible = true;
            labelTItulo.Text = "Ingresos";
            IMongoCollection<Ingreso> ingresosDB = database.GetCollection<Ingreso>("ingresos");
            List<Ingreso> lstIngresos = ingresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            abrirFormHija( new Ingresos( usuarioId, lstIngresos, temaOscuro ));
            panNav.Height = btnIngresos.Height;
            panNav.Top = btnIngresos.Top;

            //Color que indica que está seleccionado
            if (temaOscuro == false)
            {
                btnIngresos.BackColor = Color.FromArgb(255, 156, 56);
            }
            else
            {
                btnIngresos.BackColor = Color.FromArgb(46, 51, 73);
            }
        }
        //--------------------------------------------------------------------------------------------------------------

        //---------------------------------------- Evento del boton Egresos --------------------------------------------
        private void btnEgresos_Click(object sender, EventArgs e)
        {
            this.panelControlador.Visible = true;
            labelTItulo.Text = "Egresos";
            IMongoCollection<Egreso> egresosDB = database.GetCollection<Egreso>("egresos");
            List<Egreso> lstEgresos = egresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            abrirFormHija( new Egresos( usuarioId, lstEgresos, temaOscuro ) );
            panNav.Height = btnEgresos.Height;
            panNav.Top = btnEgresos.Top;

            //Color que indica que está seleccionado
            if (temaOscuro == false)
            {
                btnEgresos.BackColor = Color.FromArgb(255, 156, 56);
            }
            else
            {
                btnEgresos.BackColor = Color.FromArgb(46, 51, 73);
            }
        }
        //--------------------------------------------------------------------------------------------------------------

        //---------------------------------------- Evento del boton Analisis -------------------------------------------
        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            this.panelControlador.Visible = true;
            labelTItulo.Text = "Analisis";
            IMongoCollection<Egreso> egresosDB = database.GetCollection<Egreso>("egresos");
            List<Egreso> lstEgresos = egresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            IMongoCollection<Ingreso> ingresosDB = database.GetCollection<Ingreso>("ingresos");
            List<Ingreso> lstIngresos = ingresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            abrirFormHija( new Analisis( usuarioId, lstEgresos, lstIngresos, temaOscuro ) );

            panNav.Height = btnAnalisis.Height;
            panNav.Top = btnAnalisis.Top;

            //Color que indica que está seleccionado
            if (temaOscuro == false)
            {
                btnAnalisis.BackColor = Color.FromArgb(255, 156, 56);
            }
            else
            {
                btnAnalisis.BackColor = Color.FromArgb(46, 51, 73);
            }
        }
        //--------------------------------------------------------------------------------------------------------------

        //----------------------------------------- Evento del boton Calendario ----------------------------------------
        private void btnCalendario_Click(object sender, EventArgs e)
        {
            this.panelControlador.Visible = true;
            labelTItulo.Text = "Calendario";

            abrirFormHija(new Calendario( this.usuarioId, temaOscuro));
            panNav.Height = btnCalendario.Height;
            panNav.Top = btnCalendario.Top;

            //Color que indica que está seleccionado
            if (temaOscuro == false)
            {
                btnCalendario.BackColor = Color.FromArgb(255, 156, 56);
            }
            else
            {
                btnCalendario.BackColor = Color.FromArgb(46, 51, 73);
            }
        }
        //--------------------------------------------------------------------------------------------------------------

        //----------------------------------------- Evento del boton Opciones ------------------------------------------
        private void btnOpciones_Click(object sender, EventArgs e)
        {
            labelTItulo.Text = "Opciones";

            //abrirFormHija(new Opciones( ref this.temaOscuro ));
            this.panelControlador.Visible = false;
            panNav.Height = btnOpciones.Height;
            panNav.Top = btnOpciones.Top;
            //panNav.Left = btnOpciones.Left;

            //Color que indica que está seleccionado
            if (temaOscuro == false)
            {
                btnOpciones.BackColor = Color.FromArgb(255, 156, 56);
            }
            else
            {
                btnOpciones.BackColor = Color.FromArgb(46, 51, 73);
            }
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
            if(this.temaOscuro)
                btnInicio.BackColor = Color.FromArgb(24, 30, 54);
            else
                btnInicio.BackColor = Color.FromArgb(255, 128, 0);
        }
        private void btnIngresos_Leave(object sender, EventArgs e)
        {
            if (this.temaOscuro)
                btnIngresos.BackColor = Color.FromArgb(24, 30, 54);
            else
                btnIngresos.BackColor = Color.FromArgb(255, 128, 0);
        }
        private void btnEgresos_Leave(object sender, EventArgs e)
        {
            if (this.temaOscuro)
                btnEgresos.BackColor = Color.FromArgb(24, 30, 54);
            else
                btnEgresos.BackColor = Color.FromArgb(255, 128, 0);
        }
        private void btnAnalisis_Leave(object sender, EventArgs e)
        {
            if (this.temaOscuro)
                btnAnalisis.BackColor = Color.FromArgb(24, 30, 54);
            else
                btnAnalisis.BackColor = Color.FromArgb(255, 128, 0);
        }
        private void btnCalendario_Leave(object sender, EventArgs e)
        {
            if (this.temaOscuro)
                btnCalendario.BackColor = Color.FromArgb(24, 30, 54);
            else
                btnCalendario.BackColor = Color.FromArgb(255, 128, 0);
        }
        private void btnOpciones_Leave(object sender, EventArgs e)
        {
            if (this.temaOscuro)
                btnOpciones.BackColor = Color.FromArgb(24, 30, 54);
            else
                btnOpciones.BackColor = Color.FromArgb(255, 128, 0);
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
            if (temaOscuro == false)
            {
                button1.ForeColor = Color.Black; //Al quitar el mouse se vuelve color negro
            }
            else
            {
                button1.ForeColor = Color.White;  //Al quitar el mouse vuelve al color blanco
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelControlador_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotonCambiarTema_CheckedChanged(object sender, EventArgs e)
        {
            if ( this.BotonCambiarTema.Checked )
            {
                this.temaOscuro = false;
                this.BackColor = Color.White;
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                this.panel1.ForeColor = Color.White;

                // Cambio de Botones
                this.btnInicio.BackColor = Color.FromArgb(255, 128, 0);
                this.btnIngresos.BackColor = Color.FromArgb(255, 128, 0);
                this.btnEgresos.BackColor = Color.FromArgb(255, 128, 0);
                this.btnAnalisis.BackColor = Color.FromArgb(255, 128, 0);
                this.btnCalendario.BackColor = Color.FromArgb(255, 128, 0);
                this.btnOpciones.BackColor = Color.FromArgb(255, 128, 0);

                this.btnInicio.ForeColor     = Color.White;
                this.btnIngresos.ForeColor   = Color.White;
                this.btnEgresos.ForeColor    = Color.White;
                this.btnAnalisis.ForeColor   = Color.White;
                this.btnCalendario.ForeColor = Color.White;
                this.btnOpciones.ForeColor   = Color.White;

                //Cambio del color panNav
                panNav.BackColor = Color.FromArgb(158, 161, 176);

                //Cambio del icono de usuario
                pictureBox1.Image = Dashboard.Properties.Resources.icone_utilisateur_white;

                // Label Globales
                this.labelTItulo.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label3.ForeColor = Color.Black;
            }
            else
            {
                this.temaOscuro = true;
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
                this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

                // Cambio de Botones
                this.btnInicio.BackColor = Color.FromArgb(46, 51, 73);
                this.btnIngresos.BackColor = Color.FromArgb(46, 51, 73);
                this.btnEgresos.BackColor = Color.FromArgb(46, 51, 73);
                this.btnAnalisis.BackColor = Color.FromArgb(46, 51, 73);
                this.btnCalendario.BackColor = Color.FromArgb(46, 51, 73);
                this.btnOpciones.BackColor = Color.FromArgb(46, 51, 73);

                this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                this.btnIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                this.btnEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                this.btnAnalisis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                this.btnCalendario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                this.btnOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

                // Cambio del color panNav
                panNav.BackColor = Color.Coral;

                //Cambio del icono de usuario
                pictureBox1.Image = Dashboard.Properties.Resources.icone_utilisateur_orange;

                // Label Globales
                this.labelTItulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
                this.label1.ForeColor = Color.FromArgb(255, 128, 0);
                this.label3.ForeColor = Color.FromArgb(255, 128, 0);
            }
        }
        //---------------------------------------------------------------------------------------------------------------  
    }
}
