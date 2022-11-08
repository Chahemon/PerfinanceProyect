﻿using Dashboard.Models;
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

        public Analisis( string usuarioId, List<Egreso> lstEgreso, List<Ingreso> lstIngreso, bool temaOscuro )
        {
            this.usuarioId = usuarioId; 
            this.lstEgresos = lstEgreso;    
            this.lstIngresos = lstIngreso;
            this.temaOscuro = temaOscuro;
            //Decidi retirar el bordeado de los dataGridView porque le ponia algo negro en los bordes y quedaba feo
            InitializeComponent();
        }

        private void Analisis_Load(object sender, EventArgs e)
        {
            // Grafica Pastel funcionando (Necesitamos agregar mas categorias y hacerla mas bonita)
            //----------------------------------------------------------------------------------------------------------
            graficpastel.Titles.Add("Gastos");

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
