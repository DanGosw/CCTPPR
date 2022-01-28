using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTPPR.Clases
{
    public class C_Aportaciones
    {
        Conexion con = new Conexion();

        private string cod;
        private string can;
        private string mes;
        private string año;
        private string tip;
        private string nro;
        public string Cod { get => cod; set => cod = value; }
        public string Can { get => can; set => can = value; }
        public string Mes { get => mes; set => mes = value; }
        public string Año { get => año; set => año = value; }
        public string Tip { get => tip; set => tip = value; }
        public string Nro { get => nro; set => nro = value; }

        public void grabarrr(string soc)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand();
                con.conectar();
                cmd.Connection = con.con;
                cmd.CommandText = "insert into aportaciones (can_aporte, año_apor,mes_apor , tip_doc, nro_doc, cod_soc) values ('" + can + "','" + año + "','" + mes + "','" + tip + "','" + nro + "', '" + soc + "')";
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error D:");
            }
        }
        public void modificar(string soc)
        {
            MySqlCommand cmd = new MySqlCommand();

            con.conectar();
            cmd.Connection = con.con;
            cmd.CommandText = "update aportaciones set can_aporte ='" + can + "', año_apor ='" + año + "', mes_apor ='" + mes + "', tip_doc='" + tip + "', nro_doc  = '" + nro + "', cod_soc = '" + soc + "' where cod_apor = '" + cod + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public void eliminar()
        {
            MySqlCommand cmd = new MySqlCommand();

            con.conectar();
            cmd.Connection = con.con;
            cmd.CommandText = "delete from aportaciones where cod_apor = '" + cod + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public DataTable mostrar()
        {
            MySqlCommand cmd = new MySqlCommand();
            con.conectar();
            cmd.Connection = con.con;
            cmd.CommandText = "select * from aportaciones";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public DataTable Buscar_Aporte(string ingr)
        {
            MySqlCommand cmd = new MySqlCommand();
            con.conectar();
            cmd.Connection = con.con;
            cmd.CommandText = "select * from aportaciones where mes_apor like '%" + ingr + "%'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
