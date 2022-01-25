using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTPPR
{
    public partial class BuscarSocios : Form
    {
        public BuscarSocios()
        {
            InitializeComponent();
        }
        Clases.C_Socios xd = new Clases.C_Socios();
        public string codS, nomS, patS, matS, rucS, dniJ, telS, emaS, empr, tipo, desc, nomR, patR, matR, telR;

        public Image imaS, imaR;

        private void dgvdatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codS = dgvdatos.CurrentRow.Cells[0].Value.ToString();
            nomS = dgvdatos.CurrentRow.Cells[1].Value.ToString();
            patS = dgvdatos.CurrentRow.Cells[2].Value.ToString();
            matS = dgvdatos.CurrentRow.Cells[3].Value.ToString();
            rucS = dgvdatos.CurrentRow.Cells[4].Value.ToString();
            dniJ = dgvdatos.CurrentRow.Cells[5].Value.ToString();
            telS = dgvdatos.CurrentRow.Cells[6].Value.ToString();
            emaS = dgvdatos.CurrentRow.Cells[7].Value.ToString();
            empr = dgvdatos.CurrentRow.Cells[8].Value.ToString();
            tipo = dgvdatos.CurrentRow.Cells[9].Value.ToString();
            desc = dgvdatos.CurrentRow.Cells[10].Value.ToString();


            //usamos los valores creadoa anteriormente y con ello mandamos los datos al form padre
            //el cual va a recibir la imagen y demas datos dependiendo a la fila seleccionada
            if (this.dgvdatos.CurrentRow.Cells[11].Value != DBNull.Value)
            {
                byte[] bytes = (byte[])this.dgvdatos.CurrentRow.Cells[11].Value;
                if (bytes != null)
                {
                    MemoryStream xdd = new MemoryStream(bytes);
                    imaS = Image.FromStream(xdd);
                }
                else
                {
                    imaS = null;
                }

            }

            nomR = dgvdatos.CurrentRow.Cells[12].Value.ToString();
            patR = dgvdatos.CurrentRow.Cells[13].Value.ToString();
            matR = dgvdatos.CurrentRow.Cells[14].Value.ToString();
            telR = dgvdatos.CurrentRow.Cells[15].Value.ToString();

            if (this.dgvdatos.CurrentRow.Cells[16].Value != DBNull.Value)
            {
                byte[] bytesRepre = (byte[])this.dgvdatos.CurrentRow.Cells[16].Value;
                if (bytesRepre != null)
                {
                    MemoryStream ms = new MemoryStream(bytesRepre);
                    imaR = Image.FromStream(ms);
                }
                else
                {
                    imaR = null;
                }

            }


            this.DialogResult = DialogResult.OK; 
            Close();
        }

        private void txtcodS_TextChanged(object sender, EventArgs e)
        {
            string valor = txtcodS.Text;
            dgvdatos.DataSource = xd.buscarnomape(valor);
        }

        private void BuscarSocios_Load(object sender, EventArgs e)
        {
            this.dgvdatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}