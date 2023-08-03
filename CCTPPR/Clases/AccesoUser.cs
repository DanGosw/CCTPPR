using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTPPR.Clases
{
    public class AccesoUser
    {
        Conexion con = new Conexion();

        private string nom;
        private string dia;
        private string hor;

        public string Nom { get => nom; set => nom = value; }
        public string Dia { get => dia; set => dia = value; }
        public string Hor { get => hor; set => hor = value; }

        public void Grabar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                con.conectar();
                cmd.Connection = con.con;
                cmd.CommandText = "insert into registro_usuario (nom_user, dia_inicio, hora_inicio) values ('" + nom + "','" + dia + "','" + hor + "')";
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error D:");
            }
        }
    }
}
