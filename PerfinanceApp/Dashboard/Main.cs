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

namespace Dashboard
{
    public partial class Main : Form
    {
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
        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panNav.Height = btnInicio.Height;
            panNav.Top = btnInicio.Top;
            panNav.Left = btnInicio.Left;
            btnInicio.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panNav.Height = btnInicio.Height;
            panNav.Top = btnInicio.Top;
            panNav.Left = btnInicio.Left;
            btnInicio.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            panNav.Height = btnIngresos.Height;
            panNav.Top = btnIngresos.Top;
            //panNav.Left = btnIngresos.Left;
            btnIngresos.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            panNav.Height = btnEgresos.Height;
            panNav.Top = btnEgresos.Top;
            //panNav.Left = btnEgresos.Left;
            btnEgresos.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            panNav.Height = btnAnalisis.Height;
            panNav.Top = btnAnalisis.Top;
           //panNav.Left = btnAnalisis.Left;
            btnAnalisis.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            panNav.Height = btnCalendario.Height;
            panNav.Top = btnCalendario.Top;
            //panNav.Left = btnCalendario.Left;
            btnCalendario.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            panNav.Height = btnOpciones.Height;
            panNav.Top = btnOpciones.Top;
            //panNav.Left = btnOpciones.Left;
            btnOpciones.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
        }

        private void textBox1_TextSelected(object sender, EventArgs e)
        {
            textBox1.Text = ("");
        }
    }
}
