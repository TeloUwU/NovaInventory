using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using NovaInventory.Config;
using System.Data;

namespace NovaInventory.Modelo
{
    class Validar_prodictos
    {
        public static bool verificar_categoria()
        {
            bool retorno = false;
            string query = "SELECT * FROM categoria";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo contactar con la base de datos"+ ex,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool verificar_productos()
        {
            bool retorno = false;
            string query = "SELECT * FROM productos";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo contactar con la base de datos" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable cargar()
        {
            DataTable data = new DataTable();
            string query = "SELECT id_categoria, CONCAT(categoria) AS categoria FROM categoria";
            MySqlCommand mcdquery = new MySqlCommand((query) ,Conexion.obtenerconexion());
            try
            {
                MySqlDataAdapter adaptar = new MySqlDataAdapter(mcdquery);
                adaptar.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo contactar con la base de datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }
        public static DataTable cargar1()
        {
            DataTable data = new DataTable();
            string query = "SELECT id_producto, CONCAT(producto) AS producto FROM productos";
            MySqlCommand mcdquery = new MySqlCommand((query), Conexion.obtenerconexion());
            try
            {
                MySqlDataAdapter adaptar = new MySqlDataAdapter(mcdquery);
                adaptar.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo contactar con la base de datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }

    }
}
