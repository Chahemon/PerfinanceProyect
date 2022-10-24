using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    internal class BotonCircular : Button
    {
        //Metodo para hacer un bonito boton circular
        //CUIDADO SI MODIFICAS ALGO!!
        protected override void OnPaint(PaintEventArgs pntEvent)
        {
            GraphicsPath graph = new GraphicsPath();
            graph.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(graph);
            base.OnPaint(pntEvent);
        }
    }
}
