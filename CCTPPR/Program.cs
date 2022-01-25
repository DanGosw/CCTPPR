using System;
using System.Windows.Forms;

namespace CCTPPR
{
    static class Program
    {
        public static class Globalxd
        {
            public static string tipousuario;
        }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formularios.Login());
        }
    }
}
