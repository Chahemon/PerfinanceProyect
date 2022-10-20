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
using MongoDB.Driver;
using Dashboard.Models;

namespace Dashboard
{
    public partial class login : Form
    {
        
        private static MongoClient client = new MongoClient("mongodb+srv://Hector:(contraseña)@cluster0.rv4yzet.mongodb.net/?retryWrites=true&w=majority");
        private static IMongoDatabase database = client.GetDatabase("uptask");
        private static IMongoCollection <Usuarios> usuariosDB = database.GetCollection<Usuarios>("usuarios");
            
        public login()
        {   
         
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void textUsuario_Click(object sender, EventArgs e)
        {
            textUsuario.Text = ("");
        }

        private void textContra_Click(object sender, EventArgs e)
        {
            textContra.Text = ("");
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            String email = textUsuario.Text;
            String contraseña = textContra.Text;

            List <Usuarios> lst = usuariosDB.Find( d => d.Email == email).ToList();


            if (lst.Any()) {


                if (BCrypt.Net.BCrypt.Equals(lst[0].Password, contraseña) )
                    Console.WriteLine("Contraseña CORRECTA");
                else
                    Console.WriteLine("Contraseña INCORRECTA");

            } else {
                Console.WriteLine("NO SE ENCONTRO UNU");
            } 

        }
    }
}
