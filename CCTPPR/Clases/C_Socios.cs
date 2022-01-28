using MySql.Data.MySqlClient;
using System.Data;

namespace CCTPPR.Clases
{
    public class C_Socios
    {
        Conexion conec = new Conexion();

        private string codS;
        private string nomb;
        private string apat;
        private string amat;
        private string rucS;
        private string dniJ;
        private string telE;
        private string emaS;
        private string empr;
        private string tipE;
        private string desE;
        private string nomR;
        private string patR;
        private string matR;
        private string telR;

        #region metodos get y set
        public string CodS { get => codS; set => codS = value; }
        public string Nomb { get => nomb; set => nomb = value; }
        public string Apat { get => apat; set => apat = value; }
        public string Amat { get => amat; set => amat = value; }
        public string RucS { get => rucS; set => rucS = value; }
        public string DniJ { get => dniJ; set => dniJ = value; }
        public string Empr { get => empr; set => empr = value; }
        public string TipE { get => tipE; set => tipE = value; }
        public string DesE { get => desE; set => desE = value; }
        public string EmaS { get => emaS; set => emaS = value; }
        public string TelE { get => telE; set => telE = value; }

        //imagen del socio
        public byte Soc { get; set; }
        public string NomR { get => nomR; set => nomR = value; }
        public string PatR { get => patR; set => patR = value; }
        public string MatR { get => matR; set => matR = value; }
        public string TelR { get => telR; set => telR = value; }
        public byte Rep { get; set; }

        //imagen del representante

        #endregion
        public void grabar (byte[] socio, byte[] repre)
        {
            MySqlCommand cmd = new MySqlCommand();
            conec.conectar();
            cmd.Connection = conec.con;
            cmd.CommandText = "insert into socios (nombre_soc, ape_pat_soc, ape_mat_soc, ruc_soc, ruc_dni_so, tel_soc, ema_soc, nom_emp_soc, tip_empre_soc, desc_empre,imagen_soc, nom_repre, a_pat_repre, a_mat_repre, tel_repre, imagen_repre) " +
                "values ('" + nomb + "','" + apat + "','" + amat + "','" + rucS + "', '" + dniJ + "', '" + telE + "', '" + emaS + "', '" + empr + "', '" + tipE + "', '" + desE + "', @imagen_soc , '" + nomR + "', '" + patR + "', '" + matR + "', '" + telR + "', @imagen_repre)";
            cmd.Parameters.AddWithValue("imagen_soc", socio);
            cmd.Parameters.AddWithValue("imagen_repre", repre);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void actualizar (byte[] socio, byte[] repre)
        {
            MySqlCommand cmd = new MySqlCommand();
            conec.conectar();
            cmd.Connection = conec.con;
            cmd.CommandText = "update socios set nombre_soc ='" + nomb + "', ape_pat_soc ='" + apat + "', ape_mat_soc='" + amat + "', ruc_soc='" + rucS + "', ruc_dni_so='" + dniJ + "', tel_soc='" + telE + "', ema_soc='" + emaS + "', nom_emp_soc='" + empr + "', " +
                "tip_empre_soc='" + tipE + "', desc_empre='" + desE + "', imagen_soc = @imagen_soc, nom_repre='" + nomR + "', a_pat_repre='" + patR + "', a_mat_repre='" + matR + "', tel_repre='" + telR + "', imagen_repre= @imagen_repre where cod_soc = '" + codS + "'";
            cmd.Parameters.AddWithValue("imagen_soc", socio);
            cmd.Parameters.AddWithValue("imagen_repre", repre);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void eliminar()
        {
            MySqlCommand cmd = new MySqlCommand();
            conec.conectar();
            cmd.Connection = conec.con;
            cmd.CommandText = "delete from socios where cod_soc = '" + codS + "'";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public DataTable mostrar()
        {
            MySqlCommand cmd = new MySqlCommand();
            conec.conectar();
            cmd.Connection = conec.con;
            cmd.CommandText = "select * from socios";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable buscarnomape(string ingr)
        {
            MySqlCommand cmd = new MySqlCommand();
            conec.conectar();
            cmd.Connection = conec.con;
            cmd.CommandText = "select * from socios where nombre_soc like '%" + ingr + "%'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}