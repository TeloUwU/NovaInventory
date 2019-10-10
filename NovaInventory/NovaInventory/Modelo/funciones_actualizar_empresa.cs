using System;
using NovaInventory.Config;
using NovaInventory.Controlador;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace NovaInventory.Modelo
{
    class funciones_actualizar_empresa
    {
        public static bool Actualizar_empresa(constructor_de_respuestas upd)
        {
            bool retorno = false;

            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE datos_empresa SET nombre= '{0}', email = '{1}', telefono = '{2}', foto_empresa = '{3}', nit = '{4}', direccion = '{5}', Representante = '{6}', tipo_empresa = '{7}' WHERE  id_datos_empresa ='{8}'",upd.), Conexion.obtenerconexion);
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("los datos han sido actualizados correctamente.", "El proceso ha sido completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los Datos no pudieron ser actualizados.", "El proceso no fue completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un problema, revise los servicios del servidor o el internet, Consulte al Administrador " + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
