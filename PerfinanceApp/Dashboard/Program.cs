using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var ini = new INI("RanConfIniMelvin.ini");
            //En caso de que no exista nada, se crea un nuevo ini con valores por defecto
            if (!ini.KeyExists("TemaOscuro", "Tema"))
            {
                ini.Write("TemaOscuro", "True", "Tema");
            }
            if (!ini.KeyExists("TamLetra", "Letra"))
            {
                ini.Write("TamLetra", "1", "Letra");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new login());
            } catch (Exception ex)
            {
                MessageBox.Show("Recorcholis!! Algo salio mal D:\nPuede que sea tu conexion a internet\nSi el problema persiste, contactenos!","Perfinance");
                Application.Exit();
                
            }
        }
    }
}
