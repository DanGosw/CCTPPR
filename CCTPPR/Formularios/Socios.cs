using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTPPR
{
    public partial class Socios : Form
    {
        public Socios()
        {
            InitializeComponent();
        }
        private void llenar()
        {
            //socio
            os.CodS = txtcodS.Text;
            os.Nomb = txtnomS.Text;
            os.Apat = txtpatS.Text;
            os.Amat = txtmatS.Text;
            os.RucS = txtrucS.Text;
            os.DniJ = txtJdniS.Text;
            os.Empr = txtempS.Text;
            os.TipE = txttipEmS.Text;
            os.DesE = txtmens.Text;
            os.EmaS = txtemaS.Text;
            os.TelE = txtnroS.Text;

            //Representante
            os.NomR = txtnomR.Text;
            os.PatR = txtpatR.Text;
            os.MatR = txtmatR.Text;
            os.TelR = txtnroR.Text;
        }

        Clases.C_Socios os = new Clases.C_Socios();

        private void Socios_Load(object sender, EventArgs e)
        {
            dgvdatos.DataSource = os.mostrar();
        }

        private void dgvdatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodS.Text = dgvdatos.CurrentRow.Cells[0].Value.ToString();
            txtnomS.Text = dgvdatos.CurrentRow.Cells[1].Value.ToString();
            txtpatS.Text = dgvdatos.CurrentRow.Cells[2].Value.ToString();
            txtmatS.Text = dgvdatos.CurrentRow.Cells[3].Value.ToString();
            txtrucS.Text = dgvdatos.CurrentRow.Cells[4].Value.ToString();
            txtJdniS.Text = dgvdatos.CurrentRow.Cells[5].Value.ToString();
            txtnroS.Text = dgvdatos.CurrentRow.Cells[6].Value.ToString();
            txtemaS.Text = dgvdatos.CurrentRow.Cells[7].Value.ToString();
            txtempS.Text = dgvdatos.CurrentRow.Cells[8].Value.ToString();
            txttipEmS.Text = dgvdatos.CurrentRow.Cells[9].Value.ToString();
            txtmens.Text = dgvdatos.CurrentRow.Cells[10].Value.ToString();

            byte[] img = (byte[])dgvdatos.CurrentRow.Cells[11].Value;
            MemoryStream ms = new MemoryStream(img);
            picSoc.Image = Image.FromStream(ms);

            txtnomR.Text = dgvdatos.CurrentRow.Cells[12].Value.ToString();
            txtpatR.Text = dgvdatos.CurrentRow.Cells[13].Value.ToString();
            txtmatR.Text = dgvdatos.CurrentRow.Cells[14].Value.ToString();
            txtnroR.Text = dgvdatos.CurrentRow.Cells[15].Value.ToString();

            byte[] imagen_soc = (byte[])dgvdatos.CurrentRow.Cells[16].Value;
            MemoryStream memory = new MemoryStream(imagen_soc);
            picRep.Image = Image.FromStream(memory);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(MessageBox.Show("¿Deseas Actualizar los Registros?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (x == 6)
            {
                MemoryStream ms = new MemoryStream();
                picSoc.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();


                MemoryStream rep = new MemoryStream();
                picRep.Image.Save(rep, ImageFormat.Jpeg);
                byte[] byteRep = rep.ToArray();

                llenar();
                os.actualizar(aByte, byteRep);
                LimpiarTexto();
                dgvdatos.DataSource = os.mostrar();
            }
        }

        private void LimpiarTexto()
        {
            if (picSoc.Image != null)
            {
                picSoc.Image = CCTPPR.Properties.Resources.user_image;
            }
            if (picRep.Image != null)
            {
                picRep.Image = CCTPPR.Properties.Resources.user_image;
            }

            txtcodS.Text = "";
            txtnomS.Text = "";
            txtpatS.Text = "";
            txtmatS.Text = "";
            txtrucS.Text = "";
            txtJdniS.Text = "";
            txtempS.Text = "";
            txttipEmS.Text = "";
            txtmens.Text = "";
            txtnroS.Text = "";
            txtemaS.Text = "";

            txtnomR.Text = "";
            txtpatR.Text = "";
            txtmatR.Text = "";
            txtnroR.Text = "";
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(MessageBox.Show("¿Deseas Eliminar los Registros?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (x == 6)
                {
                    llenar();
                    os.eliminar();
                    LimpiarTexto();
                    dgvdatos.DataSource = os.mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar");
                MessageBox.Show("Debera eliminar primero el aporte asociado al socio", "Error");
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(MessageBox.Show("¿Deseas Grabar el nuevo Registro?", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (x == 6)
            {
                MemoryStream ms = new MemoryStream();
                picSoc.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();


                MemoryStream rep = new MemoryStream();
                picRep.Image.Save(rep, ImageFormat.Jpeg);
                byte[] byteRep = rep.ToArray();


                llenar();
                os.grabar(aByte, byteRep);
                LimpiarTexto();
                dgvdatos.DataSource = os.mostrar();
            }
        }

        private void btnactualizar_Click_1(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(MessageBox.Show("¿Deseas Actualizar los Registros?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (x == 6)
            {
                MemoryStream ms = new MemoryStream();
                picSoc.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();


                MemoryStream rep = new MemoryStream();
                picRep.Image.Save(rep, ImageFormat.Jpeg);
                byte[] byteRep = rep.ToArray();

                llenar();
                os.actualizar(aByte, byteRep);
                LimpiarTexto();
                dgvdatos.DataSource = os.mostrar();
            }
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(MessageBox.Show("¿Deseas Eliminar los Registros?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (x == 6)
                {
                    llenar();
                    os.eliminar();
                    LimpiarTexto();
                    dgvdatos.DataSource = os.mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar");
                MessageBox.Show("Debera eliminar primero el aporte asociado al socio", "Error");
            }
        }

        private void BtnSoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                picSoc.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                picRep.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            BuscarSocios bus = new BuscarSocios();
            bus.ShowDialog();

            txtcodS.Text = bus.codS;
            txtnomS.Text = bus.nomS;
            txtpatS.Text = bus.patS;
            txtmatS.Text = bus.matS;
            txtrucS.Text = bus.rucS;
            txtJdniS.Text = bus.dniJ;
            txtempS.Text = bus.empr;
            txttipEmS.Text = bus.tipo;
            txtmens.Text = bus.desc;
            txtnroS.Text = bus.telS;
            txtemaS.Text = bus.emaS;

            txtnomR.Text = bus.nomR;
            txtpatR.Text = bus.patR;
            txtmatR.Text = bus.matR;
            txtnroR.Text = bus.telR;
            txtcodS.Text = bus.codS;

            picSoc.Image = bus.imaS;
            picRep.Image = bus.imaR;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}