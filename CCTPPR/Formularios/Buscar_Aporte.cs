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
    public partial class Buscar_Aporte : Form
    {
        public Buscar_Aporte()
        {
            InitializeComponent();
        }

        public string cod, mes, año, tip, nro, soc;

        private void dgvdatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cod = dgvdatos.CurrentRow.Cells[0].Value.ToString();
            año = dgvdatos.CurrentRow.Cells[1].Value.ToString();
            mes = dgvdatos.CurrentRow.Cells[2].Value.ToString();
            tip = dgvdatos.CurrentRow.Cells[3].Value.ToString();
            nro = dgvdatos.CurrentRow.Cells[4].Value.ToString();
            soc = dgvdatos.CurrentRow.Cells[5].Value.ToString();
            Close();
        }

        Clases.C_Aportaciones xd = new Clases.C_Aportaciones();

        private void txtcodS_TextChanged(object sender, EventArgs e)
        {
            string valor = txtcodS.Text;
            dgvdatos.DataSource = xd.Buscar_Aporte(valor);
        }

        private void Buscar_Aporte_Load(object sender, EventArgs e)
        {
            this.dgvdatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
