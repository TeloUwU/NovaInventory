using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaInventory.Controlador;
using MySql.Data.MySqlClient;
using NovaInventory.Config;

namespace NovaInventory.Modelo
{
    class Actualizar_empresa
    {
        public static bool actualizarusu(constructor_para_celulares upt)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupt = new MySqlCommand(string.Format("UPDATE tbusuarios SET = numeros_tel '{0}'",upt.numeros_tel), Conexion.obtenerconexion());
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
    }
}
      
