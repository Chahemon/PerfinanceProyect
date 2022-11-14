using Dashboard.Models;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Dashboard
{
    public partial class Inicio : Form
    {
        private bool temaOscuro;
        private List<Egreso> lstEgresos;
        private List<Ingreso> lstIngresos;
        private string usuarioId;

        //------------------------------- Propiedades para bordear ------------------------------------
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

        public Inicio(List<Egreso> lstEgreso, List<Ingreso> lstIngreso, bool temaOscuro, string usuarioId, int tamLetra)
        {
            var ini = new INI("RanConfIniMelvin.ini");
            temaOscuro = bool.Parse(ini.Read("TemaOscuro","Tema"));
            tamLetra = int.Parse(ini.Read("TamLetra","Letra"));
            this.usuarioId = usuarioId;
            this.lstEgresos = lstEgreso;
            this.lstIngresos = lstIngreso;  
            InitializeComponent();

            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, panel5.Width, panel5.Height, 25, 25));
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, panel6.Width, panel6.Height, 25, 25));
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, panel4.Width, panel4.Height, 25, 25));

            // para manejar el tema
            if (temaOscuro == false)
            {
                this.BackColor = Color.White;
                panel5.BackColor = Color.FromArgb(255, 128, 0);
                this.graficInicio.BackColor = Color.FromArgb(255, 128, 0);

                panel6.BackColor = Color.FromArgb(255, 128, 0);
                label5.ForeColor = Color.White;

                panel4.BackColor = Color.FromArgb(255, 128, 0);
                this.graficInicio.ChartAreas[0].BackColor = Color.FromArgb(255, 128, 0);

            }
            else
            {
                this.BackColor = Color.FromArgb( 46, 51, 73 );
                panel5.BackColor = Color.FromArgb( 37, 42, 64 );
                this.graficInicio.BackColor = Color.FromArgb( 37, 42, 64 );
                this.graficInicio.ChartAreas[0].BackColor = Color.FromArgb(37, 42, 64);
            }

            switch (tamLetra)
            {
                case 0:
                    label4.Font = new Font("Nirmala UI", 12);
                    label9.Font = new Font("Nirmala UI", 12);
                    label5.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
                    label7.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
                    label6.Font = new Font("Nirmala UI", 8);
                    label8.Font = new Font("Nirmala UI", 8);
                    label12.Font = new Font("Nirmala UI", 12);
                    label11.Font = new Font("Nirmala UI", 8);
                    break;
                case 1:
                    label4.Font = new Font("Nirmala UI", 14);
                    label9.Font = new Font("Nirmala UI", 14);
                    label5.Font = new Font("Microsoft Sans Serif", 21, FontStyle.Bold);
                    label7.Font = new Font("Microsoft Sans Serif", 21, FontStyle.Bold);
                    label6.Font = new Font("Nirmala UI", 10);
                    label8.Font = new Font("Nirmala UI", 10);
                    label12.Font = new Font("Nirmala UI", 14);
                    label11.Font = new Font("Nirmala UI", 10);
                    break;
                case 2:
                    label4.Font = new Font("Nirmala UI", 16);
                    label9.Font = new Font("Nirmala UI", 16);
                    label5.Font = new Font("Microsoft Sans Serif", 23, FontStyle.Bold);
                    label7.Font = new Font("Microsoft Sans Serif", 23, FontStyle.Bold);
                    label6.Font = new Font("Nirmala UI", 12);
                    label8.Font = new Font("Nirmala UI", 12);
                    label12.Font = new Font("Nirmala UI", 16);
                    label11.Font = new Font("Nirmala UI", 12);
                    break;
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // Grafica de Barras

            DateTime now = DateTime.Now;
            int days = DateTime.DaysInMonth(now.Year, now.Month);

            float[] egresosDias = new float[days];

            List<Egreso> lstEgresosMes = new List<Egreso>();

            for (int i = 0; i < lstEgresos.Count; i++)
                if (lstEgresos[i].CreatedAt.Month == now.Month && lstEgresos[i].CreatedAt.Year == now.Year)
                    lstEgresosMes.Add(lstEgresos[i]);

            for (int j = 0; j < lstEgresosMes.Count; j++)
                egresosDias[lstEgresosMes[j].CreatedAt.Day - 1] += lstEgresosMes[j].Valor;

            graficInicio.Series["Gastos"].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            graficInicio.Series["Gastos"].LabelForeColor = System.Drawing.Color.Gainsboro;

            for (int i = 0; i < egresosDias.Length; i++)
            {
                graficInicio.Series["Gastos"].Points.AddXY(i + 1, egresosDias[i]);
            }

            // Balance de la Cuenta

            float TotalIngresos = 0, TotalEgresos = 0;
            
            foreach (var list in lstIngresos)
                TotalIngresos += list.Valor;

            foreach (var list in lstEgresos)
                TotalEgresos += list.Valor;

            float Balance = TotalIngresos - TotalEgresos;
            

            if ( Balance > 0 )
            {
                this.label5.Text = "+$" + Balance.ToString();
                this.label5.ForeColor = Color.Green;
            }
            else if ( Balance < 0 )
            {
                this.label5.Text = "$" + Balance.ToString();
                this.label5.ForeColor = Color.Red;
            }
            else
            {
                this.label5.Text = "-" + Balance.ToString().Replace('-','$');
                this.label5.ForeColor = Color.FromArgb(255, 128, 0);
            }

            // Calculando nomina

            float Nomina = 0;
            float Contador = 0;

            foreach (var list in lstIngresos)
            {
                if (list.Categoria == "Sueldo")
                {
                    Nomina += list.Valor;
                    Contador++;
                }
            }

            if( Nomina != 0 )
            {
                Console.WriteLine(Nomina);
                Console.WriteLine(Contador);
                Nomina = Nomina / Contador;
                Console.WriteLine(Nomina);
                Console.WriteLine(Contador);
            }

            this.label7.Text = "+$" + Nomina.ToString("0.##");

        }

    }
}
