using Dashboard.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace Dashboard
{
    public partial class login : Form
    {
        
        private static MongoClient client = new MongoClient("mongodb+srv://Admin:Panitasdel19@clusterpf.ot25ikt.mongodb.net/?retryWrites=true&w=majority");
        private static IMongoDatabase database = client.GetDatabase("test");
        private static IMongoCollection <Usuarios> usuariosDB = database.GetCollection<Usuarios>("usuarios");
            
        public login()
        {   
         
            InitializeComponent();
        }

        //---------------------------- Propiedades que permiten el mover el form ---------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //--------------------------------------------------------------------------------------------------

        //Evento para el boton 'X' (cierra el form main)
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Evento para el boton '-' (Minimiza el form main)
        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // (El pa) Hacer mejoras en el login ( Visuales )  

            String email = textUsuario.Text;
            String contraseña = textContra.Text;

            List <Usuarios> lst = usuariosDB.Find( d => d.Email == email).ToList();
            
            if (lst.Any()) {
                if (BCrypt.Net.BCrypt.Verify(contraseña , lst[0].Password)) {
                    Main main = new Main( lst[0].Id );
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                } else {
                    Console.WriteLine("Contraseña INCORRECTA"); // (El pa) Hacer que esto se muestre en el login
                }
            } else {
                Console.WriteLine("NO EXISTE UNA CUENTA REGISTRADA CON ESE GMAIL"); // (El pa) Hacer que esto se muestre en el login
            } 
        }

        //-------------------- Metodos para simular un placeholder en los textBox del Login -------------------------
        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (textUsuario.Text == "USUARIO")
            {
                textUsuario.Text = "";
                textUsuario.ForeColor = Color.White;
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Text == "") {
                textUsuario.Text = "USUARIO";
                textUsuario.ForeColor = Color.Silver;
            }
        }

        private void textContra_Enter(object sender, EventArgs e)
        {
            if (textContra.Text == "CONTRASEÑA")
            {
                textContra.Text = "";
                textContra.ForeColor = Color.White;
            }
        }

        private void textContra_Leave(object sender, EventArgs e)
        {
            if (textContra.Text == "")
            {
                textContra.Text = "CONTRASEÑA";
                textContra.ForeColor = Color.Silver;
            }
        }
    }
}
