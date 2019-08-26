using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace NovaInventory.Config
{
    class Conexion
    {
        public static MySqlConnection obtenerconexion()
        {
            string server = "127.0.0.1";
            string database = "DB_NOVAINVENTORY_25";
            string uid = "root";
            string pwd = "";
            MySqlConnection con;
            try
            {
                con = new MySqlConnection("server = " + server +
                                          "; database = " + database +
                                          ";uid = " + uid +
                                          ";pwd = " + pwd);
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE CONEXION porfavor verifique si tiene conexion inter  " + ex, "ERROR DE CONEXION ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return con = new MySqlConnection();

            }
        }
    }
}
