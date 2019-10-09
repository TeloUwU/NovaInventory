using MySql.Data.MySqlClient;
using NovaInventory.Config;
using NovaInventory.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaInventory.Modelo
{
    class inventario
    {
        public static DataTable mostrar_producto()
        {
            DataTable datos;
            try
            {
                string query = "SELECT  tb.id_producto, tb.producto, ad.categoria from productos tb, categoria ad where tb.id_categorias = ad.id_categoria";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                datos = new DataTable();
                adapter.Fill(datos);
                return datos;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error al mostrar porfavor consulte al programador" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return datos = new DataTable();
            }

        }
        public static bool actualizar_productos(constructor_productos upt)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupt = new MySqlCommand(string.Format("UPDATE productos SET producto ='{0}', id_categorias ='{1}'  WHERE  id_producto='{2}'", upt.producto, upt.id_categorias, upt.id_producto), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupt.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Los datos fueron actualizados correctamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo contactar con la base de datos" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
