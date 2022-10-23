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
    public partial class Calendario : Form
    {
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

            DateTime startofthemonth = new DateTime( now.Year, now.Month, 1 );

            int days = DateTime.DaysInMonth( now.Year, now.Month );

            int dayoftheweek = Convert.ToInt32( startofthemonth.DayOfWeek.ToString( "d" ) );

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

    }
}
