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
            // ------------------------------------- Confg for Ini file (DONT MODIFY!!) ----------------------------------------
            var ini = new INI("RanConfIniMelvin.ini");
            //En caso de que no exista nada, se crea un nuevo ini con valores por defecto
            if (!ini.KeyExists("MadeBy", "PerfinanceIniFile"))
            {
                ini.Write("MadeBy", "Water with much love, if you want edit the file, do it", "PerfinanceIniFile");
            }
            if (!ini.KeyExists("TemaOscuro", "Tema"))
            {
                ini.Write("TemaOscuro", "True", "Tema");
            }
            if (!ini.KeyExists("TamLetra", "Letra"))
            {
                ini.Write("TamLetra", "1", "Letra");
            }
            //Condiciones para guardar el ultimo usuario registrado
            if (!ini.KeyExists("User", "LastUser"))
            {
                ini.Write("User", "", "LastUser");
            }
            if (!ini.KeyExists("Pass", "LastUser"))
            {
                ini.Write("Pass", "", "LastUser");
            }
            if (!ini.KeyExists("Checked", "LastUserSaved"))
            {
                ini.Write("Checked", "false", "LastUserSaved");
            }
            // -----------------------------------------------------------------------------------------------------------------

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new login());
            } catch (Exception ex)
            {
                MessageBox.Show("Recorcholis!! Algo salio mal D:\nVerifica que el programa se ejecute como administrador\nTambien revisa que cuentes con acceso a internet\nSi el problema persiste, contactenos en nuestra pagina!\n\nAtte: Perfinance","Perfinance");
                Application.Exit();
                
            }
        }
    }
}
