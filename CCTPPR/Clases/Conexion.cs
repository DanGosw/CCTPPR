using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace CCTPPR.Clases
{
    public class Conexion
    {
        public MySqlConnection con;
        public void conectar()
        {
            try
            {
                con = new MySqlConnection("database=cctppr; data source=localhost; user id=root; pwd=dangows");
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Error BD");
            }
        }
    }
}
