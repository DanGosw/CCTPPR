using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTPPR
{
    public partial class Aportaciones : Form
    {
        public Aportaciones()
        {
            InitializeComponent();
        }

        string mon = "S/. ";

        Clases.C_Aportaciones a = new Clases.C_Aportaciones(); 

        private void DatosLlenar()
        {
            a.Cod = txtcodA.Text;
            a.Can = mon + txtcanA.Text ;
            a.Año = cboañoA.Text;
            a.Mes = cbomesA.Text;
            a.Tip = cbotipD.Text;
            a.Nro = txtnroD.Text;
        }
        private void limpiar()
        {
            txtcodA.Text = null;
            txtcanA.Text = null;
            txtdaS.Text = null;
            txtnroD.Text = null;
            txtsoc.Text = null;
            cboañoA.SelectedIndex = 0;
            cbomesA.SelectedIndex = 0;
            cbotipD.SelectedIndex = 0;
        }
        private void Aportaciones_Load(object sender, EventArgs e)
        {
            cboañoA.SelectedIndex = 0;
            cbomesA.SelectedIndex = 0;
            cbotipD.SelectedIndex = 0;

            dgvdatos.DataSource = a.mostrar();
        }

        private void Verifica_Agregar()
        {
            if (string.IsNullOrEmpty(txtcanA.Text))
            {
                MessageBox.Show("Por favor escriba un monto de Aporte Valido", "Error D:");
            }
            if (string.IsNullOrEmpty(txtnroD.Text))
            {
                MessageBox.Show("El campo de Nro. de Documento no debe estar vacio", "Error D:");
            }
            if(cbomesA.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un Mes Valido", "Error D:");
            } 
            if(cboañoA.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un Año Valido", "Error D:");
            }
            if(cbotipD.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un Tipo de comprobante valido", "Error D:");
            }
            if (string.IsNullOrEmpty(txtsoc.Text))
            {
                MessageBox.Show("El campo del codigo del Socio no debe estar vacio", "Error D:");
            }
            else
            {
                int x = Convert.ToInt32(MessageBox.Show("¿Deseas Grabar el nuevo Registro?", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (x == 6)
                {
                    DatosLlenar();
                    string soc = txtsoc.Text;
                    a.grabarrr(soc);
                    limpiar();
                    dgvdatos.DataSource = a.mostrar();
                }
            }
        }

        private void Verifica_Actualizar()
        {
            if (string.IsNullOrEmpty(txtcanA.Text))
            {
                MessageBox.Show("Por favor escriba un monto de Aporte Valido", "Error D:");
            }
            if (string.IsNullOrEmpty(txtnroD.Text))
            {
                MessageBox.Show("El campo de Nro. de Documento no debe estar vacio", "Error D:");
            }
            if (cbomesA.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un Mes Valido", "Error D:");
            }
            if (cboañoA.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un Año Valido", "Error D:");
            }
            if (cbotipD.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un Tipo de comprobante valido", "Error D:");
            }
            if (string.IsNullOrEmpty(txtsoc.Text))
            {
                MessageBox.Show("El campo del codigo del Socio no debe estar vacio", "Error D:");
            }
            else
            {
                int x = Convert.ToInt32(MessageBox.Show("¿Deseas Modificar el Registro seleccionado?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (x == 6)
                {
                    DatosLlenar();
                    string soc = txtsoc.Text;
                    a.modificar(soc);
                    limpiar();
                    dgvdatos.DataSource = a.mostrar();
                }
            }
        }

        private void Verifica_Eliminar()
        {
            if (string.IsNullOrEmpty(txtcodA.Text))
            {
                MessageBox.Show("Seleccione en el registro una fila para eliminar", "Error D:");
            }

            else
            {
                int x = Convert.ToInt32(MessageBox.Show("¿Deseas eliminar el Registro seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (x == 6)
                {
                    DatosLlenar();
                    a.eliminar();
                    limpiar();
                    dgvdatos.DataSource = a.mostrar();
                }
            }
        }

        private void dgvdatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodA.Text = dgvdatos.CurrentRow.Cells[0].Value.ToString();
            txtcanA.Text = dgvdatos.CurrentRow.Cells[1].Value.ToString();
            cboañoA.Text = dgvdatos.CurrentRow.Cells[2].Value.ToString();
            cbomesA.Text = dgvdatos.CurrentRow.Cells[3].Value.ToString();
            cbotipD.Text = dgvdatos.CurrentRow.Cells[4].Value.ToString();
            txtnroD.Text = dgvdatos.CurrentRow.Cells[5].Value.ToString();
            txtsoc.Text = dgvdatos.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Buscar_Aporte bus = new Buscar_Aporte();
            bus.ShowDialog();

            txtcodA.Text = bus.cod;
            txtcanA.Text = bus.can;
            cboañoA.Text = bus.año;
            cbomesA.Text = bus.mes;
            cbotipD.Text = bus.tip;
            txtnroD.Text = bus.nro;
            txtsoc.Text = bus.soc;
        }

        private void btnsocio_Click(object sender, EventArgs e)
        {
            BuscarSocios bus = new BuscarSocios();
            bus.ShowDialog();

            txtsoc.Text = bus.codS;
            txtdaS.Text = bus.nomS + " " + bus.patS + " " + bus.matS;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Verifica_Agregar();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Verifica_Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Verifica_Eliminar();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}