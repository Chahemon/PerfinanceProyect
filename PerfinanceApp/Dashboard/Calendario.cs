using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Calendario : Form
    {
        int month, year;

        public Calendario()
        {
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

            for ( int i = 1; i <= days; i++ )
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days( i );
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

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
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

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanelDayContenedor.Controls.Add(ucdays);
            }
        }
    }
}
