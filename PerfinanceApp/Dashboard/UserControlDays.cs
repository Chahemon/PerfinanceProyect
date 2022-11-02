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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days( int numday, float balance )
        {
            labelDays.Text = numday.ToString();
            labelBalance.Text = balance.ToString();
            
            if( balance > 0)
            {
                labelBalance.ForeColor = Color.Green;
                labelBalance.Text = "+" + labelBalance.Text;
            } else if ( balance < 0)
                labelBalance.ForeColor = Color.Red;

        }

    }
}
