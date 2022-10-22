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

namespace Dashboard
{
    public partial class AgregarIngreso : Form
    {

        private static MongoClient client = new MongoClient("mongodb+srv://Admin:Panitasdel19@clusterpf.ot25ikt.mongodb.net/?retryWrites=true&w=majority");
        private static IMongoDatabase database = client.GetDatabase("test");
        //private static IMongoCollection<Usuarios> usuariosDB = database.GetCollection<Usuarios>("ingresos");

        private string usuarioId;

        public AgregarIngreso( string usuarioId )
        {
            this.usuarioId = usuarioId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IMongoCollection <Ingreso> ingresosDB = database.GetCollection<Ingreso>("ingresos");

            // Obtenemos la informacion y la guardamos
            
            float valor = float.Parse(txtBoxCantidad.Text);
            string categoria = comboBoxCategoria.SelectedText;

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
    }
}
