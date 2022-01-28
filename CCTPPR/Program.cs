using System;
using System.Windows.Forms;

namespace CCTPPR
{
    static class Program
    {
        //public static class Globalxd
        //{
        //    public static string tipousuario;
        //}
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Formularios.Login main = new Formularios.Login();
            main.FormClosed += MainForm_Closed; // agrega esto aquí
            main.Show();
            Application.Run();
        }

        private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }
        }
    }
}
