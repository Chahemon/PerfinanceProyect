using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dashboard.Models;
using MongoDB.Driver;

namespace Dashboard
{
    public partial class Main : Form
    {
        private string usuarioId, usuarioNombre, usuarioEmail;
        private bool temaOscuro;
        private int tamLetra;
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

        public Main( string usuarioId, string nombre, string email )
        {
            var ini = new INI("RanConfIniMelvin.ini"); //El archivo ini se lee desde donde se genera
            this.usuarioId = usuarioId;
            this.usuarioNombre = nombre;
            this.usuarioEmail = email;
            InitializeComponent();
            //El archivo .ini necesita de esto para cargar tus preferencias al inicio
            tamLetra = int.Parse(ini.Read("TamLetra","Letra"));
            temaOscuro = bool.Parse(ini.Read("TemaOscuro","Tema"));
            //Inicializa y traza los bordes en el form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panNav.Height = btnInicio.Height;
            panNav.Top = btnInicio.Top;
            panNav.Left = btnInicio.Left;
            //Redondea el boton para cerrar sesion
            btnCloseSession.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, btnCloseSession.Width, btnCloseSession.Height, 6, 6));
            comboBox1.SelectedIndex = int.Parse(ini.Read("TamLetra","Letra")); //Coloca el index del comboBox dependiendo del tamLetra guardado
            //Establece nombre y correo en su respectivo lugar dependiendo del usuario
            label1.Text = nombre;
            label2.Text = email;

            switch (tamLetra)
            {
                case 0:
                    //Casos para letra pequeña
                    labelTItulo.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                    label1.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                    label2.Font = new Font("Microsoft Sans Serif", 6, FontStyle.Bold);
                    btnInicio.Font = new Font("Nirmala UI", 8, FontStyle.Bold);
                    btnEgresos.Font = new Font("Nirmala UI", 8, FontStyle.Bold);
                    btnIngresos.Font = new Font("Nirmala UI", 8, FontStyle.Bold);
                    btnAnalisis.Font = new Font("Nirmala UI", 8, FontStyle.Bold);
                    btnCalendario.Font = new Font("Nirmala UI", 8, FontStyle.Bold);
                    btnOpciones.Font = new Font("Nirmala UI", 8, FontStyle.Bold);
                    break;
                case 1:
                    //Casos para letra mediana (Normal)
                    labelTItulo.Font = new Font("Microsoft Sans Serif", 21, FontStyle.Bold);
                    label1.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                    label2.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
                    btnInicio.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
                    btnEgresos.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
                    btnIngresos.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
                    btnAnalisis.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
                    btnCalendario.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
                    btnOpciones.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
                    break;
                case 2:
                    //Casos para letra grande
                    labelTItulo.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                    label1.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    label2.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                    btnInicio.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                    btnEgresos.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                    btnIngresos.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                    btnAnalisis.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                    btnCalendario.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                    btnOpciones.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                    break;
            }

            if (temaOscuro == false)
            {
                //Carga el tema dependiendo de lo que se lea en el .ini
                //Condicion para tema claro
                BotonCambiarTema.Checked = true;
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

                this.btnInicio.ForeColor = Color.White;
                this.btnIngresos.ForeColor = Color.White;
                this.btnEgresos.ForeColor = Color.White;
                this.btnAnalisis.ForeColor = Color.White;
                this.btnCalendario.ForeColor = Color.White;
                this.btnOpciones.ForeColor = Color.White;
                this.button1.ForeColor = Color.Black;
                this.comboBox1.ForeColor = Color.Black; //Color de la letra del comboBox
                this.comboBox1.BackColor = Color.White; // Color del fondo del comboBox

                //Cambio del color panNav
                panNav.BackColor = Color.FromArgb(158, 161, 176);

                //Cambio del icono de usuario
                pictureBox1.Image = Dashboard.Properties.Resources.icone_utilisateur_white;

                // Label Globales
                this.labelTItulo.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label3.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
            }
            else
            {
                //Condicion para tema oscuro
                BotonCambiarTema.Checked = false;
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
                this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

                // Cambio de Botones
                this.btnInicio.BackColor = Color.FromArgb(24, 30, 54);
                this.btnIngresos.BackColor = Color.FromArgb(24, 30, 54);
                this.btnEgresos.BackColor = Color.FromArgb(24, 30, 54);
                this.btnAnalisis.BackColor = Color.FromArgb(24, 30, 54);
                this.btnCalendario.BackColor = Color.FromArgb(24, 30, 54);
                this.btnOpciones.BackColor = Color.FromArgb(24, 30, 54);
                this.button1.ForeColor = Color.White;
                this.comboBox1.ForeColor = Color.White; //Color de la letra del comboBox
                this.comboBox1.BackColor = Color.FromArgb(46, 51, 73); // Color del fondo del comboBox

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
                this.label4.ForeColor = Color.FromArgb(255, 128, 0);
            }
        }

        //------------------------------------ Evento del boton inicio -------------------------------------------------
        private void btnInicio_Click(object sender, EventArgs e)
        {
            var ini = new INI("RanConfIniMelvin.ini");
            temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));

            IMongoCollection<Egreso> egresosDB = database.GetCollection<Egreso>("egresos");
            List<Egreso> lstEgresos = egresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            IMongoCollection<Ingreso> ingresosDB = database.GetCollection<Ingreso>("ingresos");
            List<Ingreso> lstIngresos = ingresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            this.panelControlador.Visible = true;
            abrirFormHija(new Inicio(lstEgresos, lstIngresos, temaOscuro, usuarioId, tamLetra) );
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
            btnOpciones_Leave(null, e);
        }
        //--------------------------------------------------------------------------------------------------------------

        //------------------------------------ Evento del boton Ingresos -----------------------------------------------
        private void btnIngresos_Click(object sender, EventArgs e)
        {
            var ini = new INI("RanConfIniMelvin.ini");
            temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));

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
            btnInicio_Leave(null, e);
            btnOpciones_Leave(null, e);
        }
        //--------------------------------------------------------------------------------------------------------------

        //---------------------------------------- Evento del boton Egresos --------------------------------------------
        private void btnEgresos_Click(object sender, EventArgs e)
        {
            var ini = new INI("RanConfIniMelvin.ini");
            temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));

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
            btnInicio_Leave(null, e);
            btnOpciones_Leave(null, e);
        }
        //--------------------------------------------------------------------------------------------------------------

        //---------------------------------------- Evento del boton Analisis -------------------------------------------
        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            var ini = new INI("RanConfIniMelvin.ini");
            temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));

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
            btnInicio_Leave(null, e);
            btnOpciones_Leave(null, e);
        }
        //--------------------------------------------------------------------------------------------------------------

        //----------------------------------------- Evento del boton Calendario ----------------------------------------
        private void btnCalendario_Click(object sender, EventArgs e)
        {
            var ini = new INI("RanConfIniMelvin.ini");
            temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));

            this.panelControlador.Visible = true;
            labelTItulo.Text = "Calendario";

            abrirFormHija(new Calendario( this.usuarioId, temaOscuro, tamLetra));
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
            btnInicio_Leave(null, e);
            btnOpciones_Leave(null, e);
        }
        //--------------------------------------------------------------------------------------------------------------

        //----------------------------------------- Evento del boton Opciones ------------------------------------------
        private void btnOpciones_Click(object sender, EventArgs e)
        {
            var ini = new INI("RanConfIniMelvin.ini");
            temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));

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
            btnInicio_Leave(null, e);
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
            var ini = new INI("RanConfIniMelvin.ini");
            temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));

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

        //---------------------------------------------------------------------------------------------------------------

        //------------------------- Evento que controla los items seleccionados del comboBox ----------------------------
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentVal = comboBox1.SelectedIndex;
            var ini = new INI("RanConfIniMelvin.ini"); //Archivo ini que se lee para guardar configuraciones
            switch (currentVal){
                case 0:
                    //Casos para letra pequeña
                    labelTItulo.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                    label1.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                    label2.Font = new Font("Microsoft Sans Serif", 6, FontStyle.Bold);
                    btnInicio.Font = new Font("Nirmala UI", 8, FontStyle.Bold);
                    btnEgresos.Font = new Font("Nirmala UI", 8, FontStyle.Bold);
                    btnIngresos.Font = new Font("Nirmala UI", 8, FontStyle.Bold);
                    btnAnalisis.Font = new Font("Nirmala UI", 8, FontStyle.Bold);
                    btnCalendario.Font = new Font("Nirmala UI", 8, FontStyle.Bold);
                    btnOpciones.Font = new Font("Nirmala UI", 8, FontStyle.Bold);
                    ini.Write("TamLetra","0","Letra");
                    break;
                case 1:
                    //Casos para letra mediana (Normal)
                    labelTItulo.Font = new Font("Microsoft Sans Serif", 21, FontStyle.Bold);
                    label1.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                    label2.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
                    btnInicio.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
                    btnEgresos.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
                    btnIngresos.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
                    btnAnalisis.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
                    btnCalendario.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
                    btnOpciones.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
                    ini.Write("TamLetra", "1","Letra");
                    break;
                case 2:
                    //Casos para letra grande
                    labelTItulo.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                    label1.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    label2.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                    btnInicio.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                    btnEgresos.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                    btnIngresos.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                    btnAnalisis.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                    btnCalendario.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                    btnOpciones.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                    ini.Write("TamLetra", "2","Letra");
                    break;
            }
        }

        //---------------------------------------------------------------------------------------------------------------


        //--------------------------------- Eventos para el tema -----------------------------------------------------
        private void BotonCambiarTema_CheckedChanged(object sender, EventArgs e)
        {
            var ini = new INI("RanConfIniMelvin.ini"); //Archivo ini que se lee para guardar configuraciones
            if ( this.BotonCambiarTema.Checked )
            {
                ini.Write("TemaOscuro", "false","Tema"); //Propiedad que establece el tema en claro
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
                btnCloseSession.BackColor = Color.FromArgb(255, 128, 0);

                this.btnInicio.ForeColor     = Color.White;
                this.btnIngresos.ForeColor   = Color.White;
                this.btnEgresos.ForeColor    = Color.White;
                this.btnAnalisis.ForeColor   = Color.White;
                this.btnCalendario.ForeColor = Color.White;
                this.btnOpciones.ForeColor   = Color.White;
                this.button1.ForeColor = Color.Black;
                this.comboBox1.ForeColor = Color.Black; //Color de la letra del comboBox
                this.comboBox1.BackColor = Color.White; // Color del fondo del comboBox

                //Cambio del color panNav
                panNav.BackColor = Color.FromArgb(158, 161, 176);

                //Cambio del icono de usuario
                pictureBox1.Image = Dashboard.Properties.Resources.icone_utilisateur_white;

                // Label Globales
                this.labelTItulo.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label3.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
            }
            else
            {
                ini.Write("TemaOscuro", "true","Tema"); //Propiedad del ini que establece el tema en oscuro
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
                this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

                // Cambio de Botones
                this.btnInicio.BackColor = Color.FromArgb(24, 30, 54);
                this.btnIngresos.BackColor = Color.FromArgb(24, 30, 54);
                this.btnEgresos.BackColor = Color.FromArgb(24, 30, 54);
                this.btnAnalisis.BackColor = Color.FromArgb(24, 30, 54);
                this.btnCalendario.BackColor = Color.FromArgb(24, 30, 54);
                this.btnOpciones.BackColor = Color.FromArgb(46, 51, 73);
                this.button1.ForeColor = Color.White;

                this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                this.btnIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                this.btnEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                this.btnAnalisis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                this.btnCalendario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                this.btnOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                btnCloseSession.BackColor = Color.FromArgb(24, 30, 54);
                this.comboBox1.ForeColor = Color.White; //Color de la letra del comboBox
                this.comboBox1.BackColor = Color.FromArgb(46, 51, 73); // Color del fondo del comboBox

                // Cambio del color panNav
                panNav.BackColor = Color.Coral;

                //Cambio del icono de usuario
                pictureBox1.Image = Dashboard.Properties.Resources.icone_utilisateur_orange;

                // Label Globales
                this.labelTItulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
                this.label1.ForeColor = Color.FromArgb(255, 128, 0);
                this.label3.ForeColor = Color.FromArgb(255, 128, 0);
                this.label4.ForeColor = Color.FromArgb(255, 128, 0);
            }
        }

        //---------------------------------- Evento para el boton cerrar sesion -----------------------------------------
        private void btnCloseSession_Click(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------- 

        //------------------------------------ Eventos para el boton cerrar sesion --------------------------------------
        private void btnCloseSession_MouseEnter(object sender, EventArgs e)
        {
            btnCloseSession.BackColor = Color.FromArgb(255,0,0); //Color rojo
        }

        private void btnCloseSession_MouseLeave(object sender, EventArgs e)
        {
            var ini = new INI("RanConfIniMelvin.ini");
            temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));

            if (temaOscuro == true)
            {
                btnCloseSession.BackColor = Color.FromArgb(24, 30, 54); //Color tema oscuro
            }
            else
            {
                btnCloseSession.BackColor = Color.FromArgb(255, 128, 0); //Color tema claro
            }
        }
        //---------------------------------------------------------------------------------------------------------------
    }
}
