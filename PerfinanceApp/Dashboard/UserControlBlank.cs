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
    public partial class UserControlBlank : UserControl
    {
        
        public UserControlBlank()
        {
            //aaaaaaaaaaaaaaaaa despues de 10 horas pude cambiar el color de esta porqueria
            //Me siento feliz haberlo podido lograr
            var ini = new INI("RanConfIniMelvin.ini");
            InitializeComponent();
            bool temaOscuro = bool.Parse(ini.Read("TemaOscuro", "Tema"));

            if(temaOscuro == false)
            {
                this.BackColor = Color.FromArgb(255, 156, 56);
            }
            else
            {
                this.BackColor = Color.FromArgb(46, 51, 73);
            }
        }
    }
}
