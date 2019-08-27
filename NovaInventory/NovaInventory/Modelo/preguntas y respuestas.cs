using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using NovaInventory.Config;

namespace NovaInventory.Modelo
{
    class preguntas_y_respuestas
    {
        public static DataTable cargar()
        {
            DataTable datos = new DataTable();
            string query = "SELECT id_pregunta, CONCAT(pregunta) AS pregunta FROM tbpreguntas";
            MySqlCommand mcdquery = new MySqlCommand((query), Conexion.obtenerconexion());
            try
            {
                MySqlDataAdapter adaptar = new MySqlDataAdapter(mcdquery);
                adaptar.Fill(datos);
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("oops, No se pudo cargar las preguntas contacte con el programador para solucionarlo" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return datos;
            }
        }
    }
}
