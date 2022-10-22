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
            var ingreso = new Ingreso() { CreatedAt = DateTime.Now, Valor = 10f,  Categoria = "Sueldo", UsuarioId = this.usuarioId };

            ingresosDB.InsertOne( ingreso );

        }

    }
}
