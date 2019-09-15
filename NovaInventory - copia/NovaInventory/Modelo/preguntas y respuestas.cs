using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using NovaInventory.Controlador;
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
        public static int agregar_re(constructor_de_respuestas add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdagregar = new MySqlCommand(string.Format("INSERT INTO tbusuarios(preguntas, Respuesta, usuarioss) VALUES ('{0}','{1}','{2}')", add.preguntas, add.Respuesta, add.usuarioss), Conexion.obtenerconexion());
                retorno = Convert.ToInt16(cmdagregar.ExecuteNonQuery());
                if (retorno > 0)
                {
                    MessageBox.Show("Caracteres correctos", "preguntas y respuestas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error en la base de datos" + ex, "Error en Preguntas y respuestas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
        }
    }

}
