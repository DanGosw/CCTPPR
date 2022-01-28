using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTPPR.Formularios
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }
        public Loader(string text)
        {
            InitializeComponent();
            lbltextos.Text = "Bienvenido " + text + ", estamos realizando los \nultimos ajustes en su perfil...";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.cir.Increment(1);
                if (cir.Value == 20)
                {
                    entrada.Text = "Ajustando perfil...";
                }
                if (cir.Value == 40)
                {
                    entrada.Text = "Modificando preferencias...";
                }
                if (cir.Value == 60)
                {
                    entrada.Text = "Agregando imagenes...";
                }
                if (cir.Value == 80)
                {
                    entrada.Text = "Estamos finalizando los ajustes...";
                }
                if (cir.Value == 100)
                {
                    entrada.Text = "Ajustes completamos satisfactoriamente...";
                    timer1.Stop();
                    Menu_Final men = new Menu_Final();

                    men.Show();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void Loader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}