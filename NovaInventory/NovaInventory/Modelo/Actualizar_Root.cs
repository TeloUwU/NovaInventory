using System;
using NovaInventory.Config;
using NovaInventory.Controlador;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace NovaInventory.Modelo
{
    class Actualizar_Root
    {
        public static bool Actualizar_usuario_root(Constructor_Root upd)
        {
            bool retorno = false;

            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE tbusuarios SET nickname = '{0}', nombre_usuario = '{1}', apellido_usuario = '{2}', contraseña_usuario = '{3}', telefono = '{4}', Foto_usuario = '{5}', Correo = '{6}', dui = '{7}', id_estaado = '{8}', intentos = '{9}', empresa = '{10}' WHERE  nickname = '{11}'", upd.usuario, upd.nombre_usuario, upd.apellido_usuario, upd.contraseña_usuario, upd.telefono, upd.Foto_usuario, upd.Correo, upd.dui, upd.id_estados, upd.intentos, upd.empresa, upd.usuario), Conexion.obtenerconexion());
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
        public static DataTable CargarEnmpresa()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM Datos_empresa";
                MySqlCommand cargar_2 = new MySqlCommand(query, Conexion.obtenerconexion());//MysqlCommand hacer consulta a la base de datos
                MySqlDataAdapter again2 = new MySqlDataAdapter(cargar_2);
                data = new DataTable();
                again2.Fill(data);

                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);

                return data = new DataTable();
            }
        }

        public static DataTable CargarEstado()
        {
            DataTable data = new DataTable();

            try
            {
                string query = "SELECT id_estado, CONCAT(Estado) AS Estado FROM Estado";
                MySqlCommand cargar = new MySqlCommand(query, Conexion.obtenerconexion());
                MySqlDataAdapter cmd = new MySqlDataAdapter(cargar);

                cmd.Fill(data);

                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);

                return data = new DataTable();
            }
        }



    }

}


      


