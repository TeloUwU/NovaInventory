using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using NovaInventory.Config;

namespace NovaInventory.Modelo
{
    class Validar_primer_uso
    {
        public static bool verificar_emo()
        {
            bool retorno = false;
            string query = " SELECT * FROM Datos_empresa";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception EX)
            {
                MessageBox.Show("No se puede acceder a la base de datos porfavor comunicarce  con el administrador de turno ", EX + "error unico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;

            }

        }
        public static bool verificar_usu()
        {

            bool retorno = false;
            string query = " SELECT * FROM tbusuarios";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo verificar el usuario", ex + "error unico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }
    }
}
