using System;
using System.Linq;
using System.Windows.Forms;

namespace CCTPPR
{
    public partial class Menu_Final : Form
    {
        public Menu_Final()
        {
            InitializeComponent();
            PanelOcultar();
        }

        private void PanelOcultar()
        {
            panelConsultas.Visible = false;
            panelProcesos.Visible = false;
            menuMantenimiento.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (panelConsultas.Visible == true)
                panelConsultas.Visible = false;

            if (panelProcesos.Visible == true)
                panelProcesos.Visible = false;

            if (menuMantenimiento.Visible == true)
                menuMantenimiento.Visible = false;
        }

        private void ShowMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            ShowMenu(menuMantenimiento);
        }

        private void btnsocios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Socios>();

            ocultarSubMenu();
            soc.Visible = true;
        }

        private void btnaportaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Aportaciones>();

            ocultarSubMenu();
            aporta.Visible = true;

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ShowMenu(panelProcesos);

        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            ShowMenu(panelConsultas);

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();

        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();

        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelcontenedor.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                           //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelcontenedor.Controls.Add(formulario);
                panelcontenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForm);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Aportaciones"] == null)
            
                soc.Visible = false;

            if (Application.OpenForms["Socios"] == null)
            
                aporta.Visible = false;
        }

        private void Menu_Final_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}