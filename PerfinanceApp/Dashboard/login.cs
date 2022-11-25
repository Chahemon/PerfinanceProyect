using Dashboard.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Reflection.Emit;

namespace Dashboard
{
    public partial class login : Form
    {
        private static MongoClient client = new MongoClient("mongodb+srv://Admin:Panitasdel19@clusterpf.ot25ikt.mongodb.net/?retryWrites=true&w=majority");
        private static IMongoDatabase database = client.GetDatabase("test");
        private static IMongoCollection <Usuarios> usuariosDB = database.GetCollection<Usuarios>("usuarios");
            
        public login()
        {
            var ini = new INI("RanConfIniMelvin.ini");
            InitializeComponent();
            //Carga el usuario anterior, en caso de que se haya guardado uno
            bool checkedBox = bool.Parse(ini.Read("Checked", "LastUserSaved"));
            LastLoggedUser.Checked = checkedBox;
            if (LastLoggedUser.Checked == true)
            {
                string usr = ini.Read("User", "LastUser");
                textUsuario.Text = usr;
                textUsuario.ForeColor = Color.White;
                string psw = ini.Read("Pass", "LastUser");
                textContra.Text = psw;
                textContra.UseSystemPasswordChar = true;
                textContra.ForeColor = Color.White;
            }
            bool temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));
            //Bordes para el form main
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //Bordeado de los textBox
            textContra.BorderStyle = BorderStyle.FixedSingle;
            textContra.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, textContra.Width, textContra.Height, 6, 6));
            textUsuario.BorderStyle = BorderStyle.FixedSingle;
            textUsuario.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, textUsuario.Width, textUsuario.Height, 6, 6));
            //Bordeado para el boton
            btnAcceder.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, btnAcceder.Width, btnAcceder.Height, 6, 6));
            EtiquetaInfo.Hide();
            EtiquetaInfo2.Hide();

            //Condiciones para los temas
            if (temaOscuro == true)
            {
                //Tema oscuro
                this.BackColor = Color.FromArgb(24, 30, 54);
                this.btnAcceder.BackColor = Color.FromArgb(46, 51, 73);
                this.textContra.BackColor = Color.FromArgb(24, 30, 100);
                this.textUsuario.BackColor = Color.FromArgb(24, 30, 100);
                this.label1.BackColor = Color.FromArgb(24, 30, 54);
                this.label1.ForeColor = Color.White;
                button2.ForeColor = Color.White;
                button3.ForeColor = Color.White;
            }
            else
            {
                //tema claro
                this.BackColor = Color.FromArgb(220, 220, 220);
                this.btnAcceder.BackColor = Color.FromArgb(236, 124, 38);
                this.textContra.BackColor = Color.FromArgb(255, 164, 32);
                this.textUsuario.BackColor = Color.FromArgb(255, 164, 32);
                this.label1.BackColor = Color.FromArgb(220, 220, 220);
                this.label1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;
            }
        }

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

        //---------------------------- Propiedades que permiten el mover el form --------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //--------------------------------------------------------------------------------------------------------------

        //----------------------------- Metodo del boton "Acceder" ------------------------------------------------------
        private void btnAcceder_Click(object sender, EventArgs e)
        { 
            String email = textUsuario.Text;
            String contraseña = textContra.Text;

            List <Usuarios> lst = usuariosDB.Find( d => d.Email == email).ToList();
            
            if (lst.Any()) {
                if (BCrypt.Net.BCrypt.Verify(contraseña, lst[0].Password)) {
                    Main main = new Main( lst[0].Id, lst[0].Nombre, lst[0].Email );
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                } else {
                    EtiquetaInfo2.Hide();
                    EtiquetaInfo.Show();
                }
            } else {
                EtiquetaInfo.Hide();
                EtiquetaInfo2.Show();
            }
        }
        //---------------------------------------------------------------------------------------------------------------

        //-------------------- Metodos para simular un placeholder en los textBox del Login -----------------------------
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
            if (textUsuario.Text == "" && LastLoggedUser.Checked == false) {
                textUsuario.Text = "USUARIO";
                textUsuario.ForeColor = Color.FromArgb(140,140,140);
            }
            EtiquetaInfo.Hide();
            EtiquetaInfo2.Hide();
        }

        private void textContra_Enter(object sender, EventArgs e)
        {
            if (textContra.Text == "CONTRASEÑA")
            {
                textContra.Text = "";
                textContra.ForeColor = Color.White;
                textContra.UseSystemPasswordChar = true; 
            }
        }

        private void textContra_Leave(object sender, EventArgs e)
        {
            if (textContra.Text == "" && LastLoggedUser.Checked == false)
            {
                textContra.Text = "CONTRASEÑA";
                textContra.ForeColor = Color.FromArgb(140, 140, 140);
                textContra.UseSystemPasswordChar = false;
            }
            EtiquetaInfo.Hide();
            EtiquetaInfo2.Hide();
        }
        //---------------------------------------------------------------------------------------------------------

        private void recoverPasswordLabel_Click(object sender, EventArgs e)
        {
            //Implementar la reedireccion a la pagina web con el proposito de recuperar la contraseña
        }

        //---------------------------------- Evento que detecta cuando se presiona enter --------------------------------
        private void textContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnAcceder_Click(sender, e);
            }
        }
        //---------------------------------------------------------------------------------------------------------------

        private void water()
        {
            //string water = " is here!! ";
            //string boo = " ~( -.- ~) ";
        }

        //----------------------------- Eventos para el boton de cierre del form ----------------------------------------
        private void buttonClosePointed(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;  //Al pasar el mouse por el boton se vuelve rojo
        }
        private void buttonCloseDisapointed(object sender, EventArgs e)
        {
            var ini = new INI("RanConfIniMelvin.ini");
            bool temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));
            if (temaOscuro == false)
            {
                button2.ForeColor = Color.Black;
            }
            else
            {
                button2.ForeColor = Color.White;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  //Evento para el boton 'X' (cierra el form main)
        }
        //---------------------------------------------------------------------------------------------------------------

        //---------------------------- Eventos para boton minimizar -----------------------------------------------------
        private void buttonMinimizePointed(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Gray;
        }
        private void buttonMinimizeDisapointed(object sender, EventArgs e)
        {
            var ini = new INI("RanConfIniMelvin.ini");
            bool temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));
            if (temaOscuro == false)
            {
                button3.ForeColor = Color.Black;
            }
            else
            {
                button3.ForeColor = Color.White;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  //Evento para el boton '-' (Minimiza el form main)
        }
        //---------------------------------------------------------------------------------------------------------------

        private void btnAcceder_MouseEnter(object sender, EventArgs e)
        {
            var ini = new INI("RanConfIniMelvin.ini");
            bool temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));
            if (temaOscuro == false)
            {
                btnAcceder.BackColor = Color.FromArgb(255,128,0);
            }
            else
            {
                btnAcceder.BackColor = Color.FromArgb(46, 51, 90) ;
            }
        }
        private void btnAcceder_MouseLeave(object sender, EventArgs e)
        {
            var ini = new INI("RanConfIniMelvin.ini");
            bool temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));
            if (temaOscuro == false)
            {
                btnAcceder.BackColor = Color.FromArgb(236, 124, 38);
            }
            else
            {
                btnAcceder.BackColor = Color.FromArgb(46, 51, 73);
            }
        }

        //------------------------------------- Evento para el checkBox "Recordar Usuario" -----------------------------------
        private void LastLoggedUser_CheckedChanged(object sender, EventArgs e)
        {
            var ini = new INI("RanConfIniMelvin.ini");
            if ( LastLoggedUser.Checked == true && textContra.Text != "CONTRASEÑA" && textUsuario.Text != "USUARIO" )
            {
                var usr = textUsuario.Text;
                var psw = textContra.Text;
                ini.Write("User", usr, "LastUser");
                ini.Write("Pass", psw, "LastUser");
                //Guarda el estado del checkbox, si lo marcas permanecera asi 
                ini.Write("Checked", "true", "LastUserSaved");
            } 
            if ( LastLoggedUser.Checked == false )
            {
                //Si desmarcas el checkbox este permanecera asi
                ini.Write("Checked", "false", "LastUserSaved");
                //No queremos usuarios guardados, asi que matamos este ;p
                ini.Write("User", "", "LastUser");
                ini.Write("Pass", "", "LastUser");
            }
        }
        //-------------------------------------------------------------------------------------------------------------------

        // ------------------ Eventos para los linkLabel del login (te redireccionan a nuestra pagina!!! :D) ------------------
        private void recoverPasswordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://perfinance.levmin.tech/olvide-password");
        }

        private void RegisterLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://perfinance.levmin.tech/registrar");
        }
        //------------------------------------------------------------------------------------------------------------------
    }
}