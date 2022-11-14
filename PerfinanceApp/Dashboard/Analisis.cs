using Dashboard.Models;
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
    public partial class Analisis : Form
    {
        private string usuarioId;
        private bool temaOscuro;
        private List<Egreso> lstEgresos;
        private List<Ingreso> lstIngresos;

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

        public Analisis( string usuarioId, List<Egreso> lstEgreso, List<Ingreso> lstIngreso, bool temaOscuro )
        {
            this.usuarioId = usuarioId; 
            this.lstEgresos = lstEgreso;    
            this.lstIngresos = lstIngreso;
            this.temaOscuro = temaOscuro;
            InitializeComponent();
        }

        private void Analisis_Load(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, panel1.Width, panel1.Height, 25, 25));
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, panel2.Width, panel2.Height, 25, 25));

            graficpastel.Titles.Add("Gastos");
            graficpastel.Titles[0].Font = new Font("Nirmala UI", 10, FontStyle.Bold);

            //Propiedades para cambiar de color dependiendo el tema
            var ini = new INI("RanConfIniMelvin.ini");
            temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));
            if(temaOscuro == false)
            {
                this.BackColor = Color.White;
                this.panel1.BackColor = Color.White;
                this.panel2.BackColor = Color.White;
                this.grafic1.BackColor = Color.FromArgb(255, 128, 0);
                this.graficpastel.BackColor = Color.FromArgb(255, 128, 0);
                this.graficpastel.Titles[0].ForeColor = Color.Black;
                //Cambia el color de los charts dependiendo del tema
                this.graficpastel.Legends[0].BackColor = Color.FromArgb(255, 128, 0);
                this.graficpastel.ChartAreas[0].BackColor = Color.FromArgb(255, 128, 0);
                this.grafic1.Legends[0].BackColor = Color.FromArgb(255, 128, 0);
                this.grafic1.ChartAreas[0].BackColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                this.BackColor = Color.FromArgb(46, 51, 73);
                this.panel1.BackColor = Color.FromArgb(37, 42, 64);
                this.panel2.BackColor = Color.FromArgb(37, 42, 64);
                this.grafic1.BackColor = Color.FromArgb(37, 42, 64);
                this.graficpastel.BackColor = Color.FromArgb(37, 42, 64);
                this.graficpastel.Titles[0].ForeColor = Color.White;
                //Cambia el color de los charts usados por partes
                this.graficpastel.Legends[0].BackColor = Color.FromArgb(37, 42, 64);
                this.graficpastel.ChartAreas[0].BackColor = Color.FromArgb(37, 42, 64);
                this.grafic1.Legends[0].BackColor = Color.FromArgb(37, 42, 64);
                this.grafic1.ChartAreas[0].BackColor = Color.FromArgb(37, 42, 64);
            }

            // Grafica Pastel funcionando
            //----------------------------------------------------------------------------------------------------------
            float nComida = 0, nSalud = 0, nEducacion = 0, nTransporte = 0, nOtro = 0,
                  nEntretenimiento = 0, nImpuestos = 0, nServicios = 0, nCuidado_Personal = 0;
            foreach (var list in this.lstEgresos)
            {
                switch (list.Categoria)
                {
                    case "Comida": nComida += list.Valor; break;
                    case "Salud": nSalud += list.Valor; break;
                    case "Educacion": nEducacion += list.Valor; break;
                    case "Transporte": nTransporte += list.Valor; break;
                    case "Entretenimiento": nEntretenimiento += list.Valor; break;
                    case "Impuestos": nImpuestos += list.Valor; break;
                    case "Servicios": nServicios += list.Valor; break;
                    case "Cuidado Personal": nCuidado_Personal += list.Valor; break;
                    case "Otro": nOtro = list.Valor; break;
                }
            }

            string[] lstCategorias = { "Comida", "Salud", "Educacion", "Transporte", "Entretenimiento",
                                       "Impuestos", "Servicios", "Cuidado Personal", "Otro" };
            float[] lstValores = { nComida, nSalud, nEducacion, nTransporte, nEntretenimiento, nImpuestos,
                                   nServicios, nCuidado_Personal, nOtro };

            graficpastel.Series["Series1"].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            graficpastel.Series["Series1"].LabelForeColor = System.Drawing.Color.Gainsboro;

            for (int i = 0; i < lstCategorias.Length; i++)
            {
                if (lstValores[i] > 0)
                    graficpastel.Series["Series1"].Points.AddXY(lstCategorias[i], lstValores[i]);
            }
            //----------------------------------------------------------------------------------------------------------

            // Grafica de Barras

            DateTime now = DateTime.Now;
            int days = DateTime.DaysInMonth(now.Year, now.Month);

            float[] ingresosDias = new float[days];

            List<Ingreso> lstIngresosMes = new List<Ingreso>();

            for (int i = 0; i < lstIngresos.Count; i++)
                if (lstIngresos[i].CreatedAt.Month == now.Month && lstIngresos[i].CreatedAt.Year == now.Year)
                    lstIngresosMes.Add(lstIngresos[i]);

            for (int j = 0; j < lstIngresosMes.Count; j++)
                ingresosDias[lstIngresosMes[j].CreatedAt.Day - 1] += lstIngresosMes[j].Valor;

            grafic1.Series["Ingresos"].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            grafic1.Series["Ingresos"].LabelForeColor = System.Drawing.Color.Gainsboro;

            for (int i = 0; i < ingresosDias.Length; i++)
            {
                grafic1.Series["Ingresos"].Points.AddXY(i+1, ingresosDias[i]);
            }


            /*
            float nEfectivo = 0, nDebito = 0, nCredito = 0, nOtros = 0;
            foreach (var list in this.lstEgresos)
            {
                switch (list.Cuenta)
                {
                    case "Efectivo": nEfectivo += list.Valor; break;
                    case "Debito": nDebito += list.Valor; break;
                    case "Credito": nCredito += list.Valor; break;
                    case "Otros": nOtros += list.Valor; break;
                }
            }

            string[] lstCuentas = { "Efectivo", "Debito", "Credito", "Otros" };
            float[] lstValoresCuentas = { nEfectivo, nDebito, nCredito, nOtros };

            grafic1.Series.Clear();

            for (int i = 0; i < lstCuentas.Length; i++)
            {
                Series series = grafic1.Series.Add(lstCuentas[i]);

                series.Label = lstValoresCuentas[i].ToString();
                series.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
                series.LabelForeColor = System.Drawing.Color.Gainsboro;


                series.Points.Add(lstValoresCuentas[i]);
            }
            */
        }

    }
}
