using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaInventory.Config;
using NovaInventory.Modelo;
using NovaInventory.Controlador;

namespace NovaInventory.Modelo
{
    class control_facturacion
    {
        public static int agregar_fac(CONSTRUCTORDEFACTURA add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdagregar = new MySqlCommand(string.Format("INSERT INTO facturacion(id_factura, id_usuarioos, fecha_factura, Pago_total, estaadoos) VALUES ('{0}','{1}','{2}','{3}','{4}')", add.id_factura, add.creado_por,add.Fecha,add.CostoDetalle,add.id_estado), Conexion.obtenerconexion());
                retorno = Convert.ToInt16(cmdagregar.ExecuteNonQuery());
                if (retorno > 0)
                {
                    MessageBox.Show("El producto se ha ingresado correctamente a la factura", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se a dectectado un problema en la base de datos, puede que este en reparaciones. Si el error perciste porfavor comuniquese con el  programador" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
        }


        public static DataTable mostrar_fac()
        {
            DataTable datos;
            try
            {
                string query = "SELECT * FROM facturacion";
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

        public static bool actualizarfac(CONSTRUCTORDEFACTURA upt)
        {
            bool retorno = false;
            try
            {

                MySqlCommand cmdupt = new MySqlCommand(string.Format("UPDATE facturacion SET  id_factura='{0}', id_usuarioos='{1}', fecha_factura='{2}', Pago_total='{3}', estaadoos='{4}') VALUES ('{0}','{1}','{2}','{3}','{4}') WHERE id_bodega='{5}' ", upt.id_factura, upt.creado_por, upt.Fecha, upt.CostoDetalle, upt.id_estado), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupt.ExecuteNonQuery());
                if (true)
                {
                    if (retorno == true)
                    {
                        MessageBox.Show("Los datos fueron actualizados correctamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Los Datos no pudieron ser actualizados.", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return retorno;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema, revise su internet o los servicios del servidor, Consulte al programador " + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool eliminar(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM facturacion WHERE id_factura = '{0}'", id), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("La bodega a sido eliminado correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La bodega no pudo ser eliminado correctamente", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema, revise su internet o los servicios del servidor, Consulte al programador" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
