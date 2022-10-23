﻿using Dashboard.Models;
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
    public partial class AgregarIngreso : Form
    {

        private static MongoClient client = new MongoClient("mongodb+srv://Admin:Panitasdel19@clusterpf.ot25ikt.mongodb.net/?retryWrites=true&w=majority");
        private static IMongoDatabase database = client.GetDatabase("test");
        //private static IMongoCollection<Usuarios> usuariosDB = database.GetCollection<Usuarios>("ingresos");
        private string usuarioId;

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

        public AgregarIngreso( string usuarioId )
        {
            this.usuarioId = usuarioId;
            InitializeComponent();
            //traza los bordes en el formu
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IMongoCollection <Ingreso> ingresosDB = database.GetCollection<Ingreso>("ingresos");

            // Obtenemos la informacion y la guardamos
            
            float valor = float.Parse(txtBoxCantidad.Text);
            string categoria = comboBoxCategoria.SelectedItem.ToString();

            // Creamos un Objeto con la información
            var ingreso = new Ingreso() { CreatedAt = DateTime.Now, Valor = valor,  Categoria = categoria, UsuarioId = this.usuarioId };
            // La almacenamos en la base de datos
            ingresosDB.InsertOne( ingreso );

            this.Close();
        }

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

        //Evento para el boton cerrar
        private void botonSalirIngresos_Click(object sender, EventArgs e)
        {
            this.Dispose(); //Simplemente cierra el form
        }

        private void categoriaPlaceholder_mouseEnter (object sender, EventArgs e)
        {
            if (comboBoxCategoria.Text == "SELECCIONE O ESCRIBA UNA")
            {
                comboBoxCategoria.Text = "";
                comboBoxCategoria.ForeColor = Color.White;
            }
        }

        private void categoriaPlaceholder_mouseLeave(object sender, EventArgs e)
        {
            if (comboBoxCategoria.Text == "")
            {
                comboBoxCategoria.Text = "SELECCIONE O ESCRIBA UNA";
                comboBoxCategoria.ForeColor = Color.Silver;
            }
        }
    }
}
