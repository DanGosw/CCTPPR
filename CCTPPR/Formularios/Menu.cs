using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
namespace CCTPPR
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        //{
        //    Form formulario;
        //    formulario = panel1.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
        //                                                                      //si el formulario/instancia no existe
        //    if (formulario == null)
        //    {
        //        formulario = new MiForm();
        //        formulario.TopLevel = false;
        //        formulario.FormBorderStyle = FormBorderStyle.None;
        //        formulario.Dock = DockStyle.Fill;
        //        panel1.Controls.Add(formulario);
        //        panel1.Tag = formulario;
        //        formulario.Show();
        //        formulario.BringToFront();
        //        formulario.FormClosed += new FormClosedEventHandler(CloseForm);
        //    }
        //    //si el formulario/instancia existe
        //    else
        //    {
        //        formulario.BringToFront();
        //    }
        //}

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            //if (Application.OpenForms["Aportaciones"] == null)

            //if (Application.OpenForms["Socios"] == null)
            //    {

            //    }                                
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Socios>();
        }

        private void aportacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Aportaciones>();
        }
    }
}