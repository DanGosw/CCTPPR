using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static CCTPPR.Program;

namespace CCTPPR.Formularios
{
    public partial class Login : Form
    {
        private Timer ti;
        MySqlConnection con;

        public Login()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(Exd);
            InitializeComponent();
            ti.Enabled = true;
        }
        private void Exd(object ob, EventArgs evt)
        {
            DateTime xd = DateTime.Now;
            lblhor.Text = xd.ToString("h:mm:ss tt");
            lblfec.Text = xd.ToLongDateString();
        }

        double count = 0;

        private void Login_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("database=CCTPPR;data source=localhost;user id=root;password=dangows");
            txtpass.UseSystemPasswordChar = true;

            pbxd.Image = Image.FromFile(@"C:\Users\CAMARA\source\repos\CCTPPR\CCTPPR\Resources\redes-sociales.gif");
            pbxd.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void chkver_CheckedChanged(object sender, EventArgs e)
        {
            if (txtpass.UseSystemPasswordChar)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        public void log(string usuario, string contra)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select cod_usu, pass from usuarios where cod_usu = @usuario AND pass = @pas", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contra);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                MySqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read())
                {
                    //Globalxd.tipousuario = leer["cargo"].ToString();

                    string textoo = txtusu.Text;
                    Formularios.Loader lod = new Formularios.Loader(textoo);
                    this.Hide();
                    lod.Show();
                }
                else
                {
                    MessageBox.Show("Error de Usuario y/o Contraseñas", "xd");
                    count += 1;
                }
                if (count == 3)
                {
                    MessageBox.Show("Ha excedido el limite, intente de nuevo mas tarde ", "Error de inicio de sesion");
                    Application.Exit();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            log(this.txtusu.Text, this.txtpass.Text);
        }
    }
}
