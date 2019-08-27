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
    class Actualizar_Root
    {
        public static bool Actualizar_usuario_root(constructor_primer_usuario upd)
        {
            bool retorno = false;

            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE SET nickname = '{0}', nombre_usuario = '{1}', apellido_usuario = '{2}', contraseña_usuario = '{3}', telefono = '{4}', Foto_usuario = '{5}', Correo = '{6}', nit = '{7}', id_estados = '{8}', intentos = '{9}', empresa = '{10}', dui = '{11}' WHERE id_usuarios = '{12}'", upd.usuario, upd.nombre_usuario, upd.apellido_usuario, upd.contraseña_usuario, upd.telefono, upd.Foto_usuario, upd.Correo, upd.nit, upd.id_estados, upd.intentos, upd.empresa, upd.nit, upd.id_usuarios), Conexion.obtenerconexion());
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

        public static DataTable Mostrar_usuario_Root()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_usuarios FROM tbusuarios ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                return data;
            }
            catch (Exception)
            {

                MessageBox.Show("A ocurrido un error en la obtencion de datos,consulte con su administrador.", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
            finally
            {
                Conexion.obtenerconexion().Close();
            }
        }
//        public static DataTable Cargar_empresa()
//        {
//            DataTable datos = new DataTable();
//            string query = "SELECT id_profesor, CONCAT(nombre,' ',apellidos)As NombreDocente FROM tbempresa";
//            MySqlCommand cmdquery = new MySqlCommand(query, Conexion.obtenerconexion());
//            try
//            {
//                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdquery);
//                adapter.Fill(datos);
//                return datos;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Oops!,ha ocurriodo al momento de cargar a los docentes al sistema, consulte con el administrador" + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return datos;
//            }
//        }

//        public static DataTable Cargar_tipo_usuario()
//        {
//            DataTable datos = new DataTable();
//            string query = "SELECT id_profesor, CONCAT(nombre,' ',apellidos)As NombreDocente FROM tbprofesores";
//            MySqlCommand cmdquery = new MySqlCommand(query, Conexion.obtenerconexion());
//            try
//            {
//                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdquery);
//                adapter.Fill(datos);
//                return datos;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Oops!,ha ocurriodo al momento de cargar a los usuarios al sistema, consulte con el administrador" + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return datos;
//            }
//        }

//        public static DataTable Estado()
//        {
//            DataTable datos = new DataTable();
//            string query = "SELECT id_, CONCAT(nombre,' ',apellidos)As NombreDocente FROM tbusuarios";
//            MySqlCommand cmdquery = new MySqlCommand(query, Conexion.obtenerconexion());
//            try
//            {
//                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdquery);
//                adapter.Fill(datos);
//                return datos;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Oops!,ha ocurriodo al momento de cargar a los usuarios al sistema, consulte con el administrador" + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return datos;
//            }
      }
    
}
