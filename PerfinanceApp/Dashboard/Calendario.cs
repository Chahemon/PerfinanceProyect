using Dashboard.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Calendario : Form
    {
        int month, year;
        private string usuarioId;
        private static MongoClient client = new MongoClient("mongodb+srv://Admin:Panitasdel19@clusterpf.ot25ikt.mongodb.net/?retryWrites=true&w=majority");
        private static IMongoDatabase database = client.GetDatabase("test");
        IMongoCollection <Ingreso> ingresosDB = database.GetCollection<Ingreso>("ingresos");
        IMongoCollection <Egreso> egresosDB = database.GetCollection<Egreso>("egresos");

        public Calendario( string usuarioId )
        {
            this.usuarioId = usuarioId;
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMA.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime( year, month, 1 );

            int days = DateTime.DaysInMonth( year, month );

            int dayoftheweek = Convert.ToInt32( startofthemonth.DayOfWeek.ToString( "d" ) ) + 1;

            for ( int i = 1; i < dayoftheweek; i++ )
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanelDayContenedor.Controls.Add( ucblank );
            }

            float [] ingresosDias  = new float[days];
            float [] egresosDias   = new float[days];

            // Lista con todos los Ingresos creados en el mes
            List<Ingreso> lstIngresosUsuario =
                    ingresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            List<Ingreso> lstIngresosMes = new List<Ingreso>();

            for ( int i = 0; i < lstIngresosUsuario.Count; i++ )
                if (lstIngresosUsuario[i].CreatedAt.Month == now.Month && lstIngresosUsuario[i].CreatedAt.Year == now.Year)
                    lstIngresosMes.Add( lstIngresosUsuario [i]);
            

            // Lista con todos los Egresos creados en el mes
            List <Egreso> lstEgresosUsuario =
                    egresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            List <Egreso> lstEgresosMes = new List<Egreso>();

            for (int i = 0; i < lstEgresosUsuario.Count; i++)
                if (lstEgresosUsuario[i].CreatedAt.Month == now.Month && lstEgresosUsuario[i].CreatedAt.Year == now.Year)
                    lstEgresosMes.Add(lstEgresosUsuario[i]);


            
            for ( int j = 0; j < lstIngresosMes.Count; j++ )
                ingresosDias[lstIngresosMes[j].CreatedAt.Day - 1] += lstIngresosMes[j].Valor;
                

            for (int j = 0; j < lstEgresosMes.Count; j++)
                egresosDias[lstEgresosMes[j].CreatedAt.Day - 1] += lstEgresosMes[j].Valor;



            for ( int i = 1; i <= days; i++ )
            {
                
                UserControlDays ucdays = new UserControlDays();
                ucdays.days( i, ingresosDias[i-1] - egresosDias[i-1] );
                flowLayoutPanelDayContenedor.Controls.Add( ucdays );
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDayContenedor.Controls.Clear();

            if(month < 12)
            {
                month++;
            } 
            else
            {
                year++;
                month = 1;
            }
                

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMA.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanelDayContenedor.Controls.Add(ucblank);
            }

            float[] ingresosDias = new float[days];
            float[] egresosDias = new float[days];

            // Lista con todos los Ingresos creados en el mes
            List<Ingreso> lstIngresosUsuario =
                    ingresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            List<Ingreso> lstIngresosMes = new List<Ingreso>();

            for (int i = 0; i < lstIngresosUsuario.Count; i++)
                if (lstIngresosUsuario[i].CreatedAt.Month == month && lstIngresosUsuario[i].CreatedAt.Year == year)
                    lstIngresosMes.Add(lstIngresosUsuario[i]);


            // Lista con todos los Egresos creados en el mes
            List<Egreso> lstEgresosUsuario =
                    egresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            List<Egreso> lstEgresosMes = new List<Egreso>();

            for (int i = 0; i < lstEgresosUsuario.Count; i++)
                if (lstEgresosUsuario[i].CreatedAt.Month == month && lstEgresosUsuario[i].CreatedAt.Year == year)
                    lstEgresosMes.Add(lstEgresosUsuario[i]);



            for (int j = 0; j < lstIngresosMes.Count; j++)
                ingresosDias[lstIngresosMes[j].CreatedAt.Day - 1] += lstIngresosMes[j].Valor;


            for (int j = 0; j < lstEgresosMes.Count; j++)
                egresosDias[lstEgresosMes[j].CreatedAt.Day - 1] += lstEgresosMes[j].Valor;


            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i, ingresosDias[i - 1] - egresosDias[i - 1]);
                flowLayoutPanelDayContenedor.Controls.Add(ucdays);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDayContenedor.Controls.Clear();

            if (month > 1)
            {
                month--;
            }
            else
            {
                year--;
                month = 12;
            }
                

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMA.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanelDayContenedor.Controls.Add(ucblank);
            }

            float[] ingresosDias = new float[days];
            float[] egresosDias = new float[days];

            // Lista con todos los Ingresos creados en el mes
            List<Ingreso> lstIngresosUsuario =
                    ingresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            List<Ingreso> lstIngresosMes = new List<Ingreso>();

            for (int i = 0; i < lstIngresosUsuario.Count; i++)
                if (lstIngresosUsuario[i].CreatedAt.Month == month && lstIngresosUsuario[i].CreatedAt.Year == year)
                    lstIngresosMes.Add(lstIngresosUsuario[i]);


            // Lista con todos los Egresos creados en el mes
            List<Egreso> lstEgresosUsuario =
                    egresosDB.Find(d => d.UsuarioId == this.usuarioId).ToList();

            List<Egreso> lstEgresosMes = new List<Egreso>();

            for (int i = 0; i < lstEgresosUsuario.Count; i++)
                if (lstEgresosUsuario[i].CreatedAt.Month == month && lstEgresosUsuario[i].CreatedAt.Year == year)
                    lstEgresosMes.Add(lstEgresosUsuario[i]);



            for (int j = 0; j < lstIngresosMes.Count; j++)
                ingresosDias[lstIngresosMes[j].CreatedAt.Day - 1] += lstIngresosMes[j].Valor;


            for (int j = 0; j < lstEgresosMes.Count; j++)
                egresosDias[lstEgresosMes[j].CreatedAt.Day - 1] += lstEgresosMes[j].Valor;

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i, ingresosDias[i - 1] - egresosDias[i - 1]);
                flowLayoutPanelDayContenedor.Controls.Add(ucdays);
            }
        }
    }
}
