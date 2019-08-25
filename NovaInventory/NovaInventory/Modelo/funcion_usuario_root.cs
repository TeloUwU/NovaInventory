using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaInventory.Modelo
{
    class funcion_usuario_root
    {
        public static bool Actualizar_usuario_root()
        {
            bool retorno = false;
            try
            {
                //MySqlCommand cmdupd = new MySqlCommand(string.Format("U
                if (retorno == true)
                {
                    MessageBox.Show("Datos actualizados correctamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los Datos no pudieron ser actualizados.", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Oops! ha ocurrido un problema, revise su internet o los servicios del servidor, Consulte al Administrador " + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
