using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using NovaInventory.Config;
using NovaInventory.Controlador;

namespace NovaInventory.Modelo
{
    class Control_de_proveedores
    {

        public static int agregar_usu(Constructor_proveedor add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdagregar = new MySqlCommand(string.Format("INSERT INTO tbproveedor(nombre, direccion, telefono, nit, rubro, id_estados) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", add.nombre, add.direccion, add.telefono, add.nit, add.rubro, add.id_estados),Conexion.obtenerconexion());
                retorno = Convert.ToInt16(cmdagregar.ExecuteNonQuery());
                if (retorno > 0)
                {
                    MessageBox.Show("El Proveedor se ingreso correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se a dectectado un problema en la base de datos, puede que este en reparaciones. Si el error perciste porfavor comuniquese con el  programador" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

        }


        public static DataTable cargar()
        {
            DataTable datos = new DataTable();

            try
            {
                string query = "SELECT id_estado, CONCAT(Estado) AS Estado FROM estado";
                MySqlCommand mcdquery = new MySqlCommand(query, Conexion.obtenerconexion());
                MySqlDataAdapter adaptar = new MySqlDataAdapter(mcdquery);
                adaptar.Fill(datos);
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("oops, no se pudieron cargar los datos de la base de datos porfavor comunicarse con el programador" + ex, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return datos;
            }
        }
    }
}
