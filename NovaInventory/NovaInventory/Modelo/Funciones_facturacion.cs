using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaInventory.Config;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NovaInventory.Modelo;
using NovaInventory.Controlador;
using System.Data;

namespace NovaInventory.Modelo
{
    class Funciones_facturacion
    {
        public static int agregar_factura(constructorFacturacion add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdagregar = new MySqlCommand(string.Format("INSERT INTO tbfactura(fecha_factura, Pago_total, estaadoos) VALUES ('{0}','{1}','{2}','{3}')", add.Fecha, add.telefono, add.nit), Conexion.obtenerconexion());
                retorno = Convert.ToInt16(cmdagregar.ExecuteNonQuery());
                if (retorno > 0)
                {
                    MessageBox.Show("La factura se ingreso correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se a dectectado un problema en la base de datos, puede que este en reparaciones. Si el error perciste porfavor comuniquese con el  programador" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

        }

        public static DataTable mostrar_factura()
        {
            DataTable datos;
            try
            {
                string query = "SELECT * FROM tbfactura";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                datos = new DataTable();
                adapter.Fill(datos);
                return datos;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al mostrar la factura por favor consulte al administrador, o vea su conexion, o compruebe su internet" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return datos = new DataTable();
            }
        }
        public static bool actualizar_facturacion(constructorFacturacion upt)
        {
            bool retorno = false;
            try
            {

                MySqlCommand cmdupt = new MySqlCommand(string.Format("UPDATE tbfactura SET  Fecha='{0}', Pago_total='{1}', estaadoos ='{2}' WHERE id_proveedor='{6}' ", upt.Fecha, upt.direccion, upt.telefono, upt.nit, upt.rubro, upt.id_estados, upt.id_proveedor), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupt.ExecuteNonQuery());
                if (true)
                {
                    if (retorno == true)
                    {
                        MessageBox.Show("Los datos de la factura fueron actualizados correctamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Los Datos de la factura no pudieron ser actualizados.", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbfactura WHERE id_factura = '{0}'", id), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("La factura a sido eliminado correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La factura no pudo ser eliminada correctamente", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema, revise su internet o los servicios del servidor, Consulte al programador" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }
    }
}
