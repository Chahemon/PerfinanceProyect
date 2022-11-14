using Dashboard.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dashboard
{
    public partial class AgregarIngreso : Form
    {   
        //--------------------------------------- Declaracion de Variables -----------------------------------------------
        private static MongoClient client = new MongoClient("mongodb+srv://Admin:Panitasdel19@clusterpf.ot25ikt.mongodb.net/?retryWrites=true&w=majority");
        private static IMongoDatabase database = client.GetDatabase("test");
        private string usuarioId;
        private DataGridView tabla;
        private bool temaOscuro;
        //----------------------------------------------------------------------------------------------------------------

        //------------------------------ Propiedades del bordeado del form --------------------------------
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse
          );
        //-------------------------------------------------------------------------------------------------

        //----------------------- Propiedades que nos permiten arrastrar el form --------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Evento que mueve el form
        private void arrastrarFormIngreso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //-------------------------------------------------------------------------------------------------

        public AgregarIngreso( string usuarioId, DataGridView tabla, bool temaOscuro)
        {
            this.usuarioId = usuarioId;
            this.tabla = tabla;
            var ini = new INI("RanConfIniMelvin.ini");
            InitializeComponent();
            temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));
            //traza los bordes en el formulario para que se vea redondito
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 25, 25));

            if(temaOscuro == false)
            {
                panel1.BackColor = Color.FromArgb(255,128,0);
                comboBoxCuentaIngreso.BackColor = Color.FromArgb(255, 128, 0);
                comboBoxCategoria.BackColor = Color.FromArgb(255, 128, 0);
                txtBoxCantidad.BackColor = Color.FromArgb(255, 128, 0);
                txtBoxDescripcion.BackColor = Color.FromArgb(255, 128, 0);
                btnAgregar.BackColor = Color.FromArgb(255, 165, 0);
                botonSalirIngresos.BackColor = Color.FromArgb(255, 165, 0);
            }
            else
            {
                panel1.BackColor = Color.FromArgb(24, 30, 54);
                comboBoxCuentaIngreso.BackColor = Color.FromArgb(24, 30, 54);
                comboBoxCategoria.BackColor = Color.FromArgb(24, 30, 54);
                txtBoxCantidad.BackColor = Color.FromArgb(24, 30, 54);
                txtBoxDescripcion.BackColor = Color.FromArgb(24, 30, 54);
                btnAgregar.BackColor = Color.FromArgb(46, 51, 73);
                botonSalirIngresos.BackColor = Color.FromArgb(46, 51, 73);
            }
        }

        //------------------------------- Metodo para cargar la tabla de ingresos ----------------------------------------
        public void CargarTabla()
        {
            IMongoCollection<Ingreso> ingresosDB = database.GetCollection<Ingreso>("ingresos");
            List<Ingreso> lstIngresos = ingresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();
            tabla.Rows.Clear();

            this.tabla.AllowUserToAddRows = true;
            
            foreach (var list in lstIngresos)
            {
                DataGridViewRow row = (DataGridViewRow)tabla.Rows[0].Clone();
                row.Cells[0].Value = list.Cuenta;       // Cuenta
                row.Cells[1].Value = list.Categoria;    // Categoria
                row.Cells[2].Value = list.Valor;        // Cantidad
                row.Cells[3].Value = list.Descripcion;  // Descripción
                row.Cells[4].Value = list.CreatedAt;    // Fecha
                tabla.Rows.Add(row);
            }

            this.tabla.AllowUserToAddRows = false;
        }
        //----------------------------------------------------------------------------------------------------------------

        //--------------------------------- Evento para el boton "Agregar" -----------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            IMongoCollection <Ingreso> ingresosDB = database.GetCollection<Ingreso>("ingresos");

            // Obtenemos la informacion y la guardamos
            //string cuenta = txtBoxCuenta.Text;
            string cuenta = "";
            string categoria = "";
            float valor = 0f;
            string descripcion = "";

            // Obtenemos la informacion y la guardamos
            if (comboBoxCuentaIngreso.SelectedIndex == -1)
            {
                label6.Text = "Seleccione una Cuenta";
                label6.Visible = true;
            }
            else
            {
                cuenta = comboBoxCuentaIngreso.SelectedItem.ToString();
            }

            if (comboBoxCategoria.SelectedIndex == -1)
            {
                label6.Text = "Seleccione una Categoria";
                label6.Visible = true;
            }
            else
            {
                categoria = comboBoxCategoria.SelectedItem.ToString();
            }

            if (txtBoxCantidad.Text == "")
            {
                label6.Text = "Ingrese un Monto $ ";
                label6.Visible = true;
            }
            else
            {
                valor = float.Parse(txtBoxCantidad.Text);
            }

            if (txtBoxDescripcion.Text == "")
            {
                label6.Text = "Agrege una Descripción";
                label6.Visible = true;
            }
            else
            {
                descripcion = txtBoxDescripcion.Text;
            }
            DateTime fecha = dateTimePicker.Value;

            // Creamos un Objeto con la información
            var ingreso = new Ingreso() { UsuarioId = this.usuarioId,
                                          Cuenta = cuenta,
                                          Categoria = categoria,
                                          Valor = valor,
                                          Descripcion = descripcion,
                                          CreatedAt = fecha };
            if (ingreso.Cuenta.Equals("") || ingreso.Categoria.Equals("") ||
                ingreso.Valor.ToString().Equals("") || ingreso.Descripcion.ToString().Equals(""))
            {
                label6.Visible = true;
            }
            else
            {
                // La almacenamos en la base de datos
                ingresosDB.InsertOne(ingreso);

                CargarTabla();

                this.Dispose();
            }
        }
        //----------------------------------------------------------------------------------------------------------------
        
        //----------- Evento para el txtBox "Cantidad", aqui se define que solo se puede usar un solo "." ----------------
        private void txtBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //----------------------------------------------------------------------------------------------------------------
        
        //------------------------------------ Evento para el boton cerrar -----------------------------------------------
        private void botonSalirIngresos_Click(object sender, EventArgs e)
        {
            this.Dispose(); //Simplemente cierra el form
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //----------------------------------------------------------------------------------------------------------------

        //---------------------------------- Eventos para simular un placeholder -----------------------------------------
        private void categoriaPlaceholder_mouseEnter (object sender, EventArgs e)
        {
            //Condicional para el comboBox de "Categorias"
            if (comboBoxCategoria.Text == "-- SELECCIONE UNA --")
            {
                comboBoxCategoria.Text = "";
                comboBoxCategoria.ForeColor = Color.White;
            }
        }
        private void categoriaPlaceholder_mouseLeave(object sender, EventArgs e)
        {
            //Condicional para el comboBox de "Categoria"
            if (comboBoxCategoria.Text == "")
            {
                comboBoxCategoria.Text = "-- SELECCIONE UNA --";
                comboBoxCategoria.ForeColor = Color.Silver;
            }
        }
        private void cuentaPlaceholder_mouseEnter(object sender, EventArgs e)
        {
            //Condicional para el comboBox de "Cuenta"
            if (comboBoxCuentaIngreso.Text == "-- SELECCIONE UNA --")
            {
                comboBoxCuentaIngreso.Text = "";
                comboBoxCuentaIngreso.ForeColor = Color.White;
            }
        }
        private void cuentaPlaceholder_mouseLeave(object sender, EventArgs e)
        {
            //Condicion para comboBox llamado "comboBoxCuenta"
            if (comboBoxCuentaIngreso.Text == "")
            {
                comboBoxCuentaIngreso.Text = "-- SELECCIONE UNA --";
                comboBoxCuentaIngreso.ForeColor = Color.Silver;
            }
        }
        //----------------------------------------------------------------------------------------------------------------

        //--------------------------------------- Evita que los comboBox sean editados -----------------------------------
        private void comboBoxCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void comboBoxCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        //----------------------------------------------------------------------------------------------------------------

        //----------------------------- Eventos para el boton de cierre del form ----------------------------------------
        private void buttonClosePointed(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;  //Al pasar el mouse por el boton se vuelve rojo
        }
        private void buttonCloseDisapointed(object sender, EventArgs e)
        {
            if (temaOscuro == false)
            {
                button2.ForeColor = Color.Black; //Al quitar el mouse se vuelve color negro
            }
            else
            {
                button2.ForeColor = Color.White;  //Al quitar el mouse vuelve al color blanco
            }
        }
        //---------------------------------------------------------------------------------------------------------------
    }
}
