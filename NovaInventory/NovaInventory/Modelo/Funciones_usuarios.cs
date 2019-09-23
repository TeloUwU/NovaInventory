using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaInventory.Config;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using NovaInventory.Controlador;

namespace NovaInventory.Modelo
{
    class Funciones_usuarios
    {
        public static int agregar_usu(constructor_primer_usuario add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdagregar = new MySqlCommand(string.Format("INSERT INTO tbusuarios(nickname, nombre_usuario, apellido_usuario, contraseña_usuario, telefono, Foto_usuario, Correo, dui, nit, id_estaado, id_tipo_usuarios, intentos, empresa) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", add.usuario, add.nombre_usuario, add.apellido_usuario, add.contraseña_usuario, add.telefono, add.Foto_usuario, add.Correo, add.dui, add.nit, add.id_estados, add.id_tipo_usuarios, add.intentos, add.empresa), Conexion.obtenerconexion());
                retorno = Convert.ToInt16(cmdagregar.ExecuteNonQuery());
                if (retorno > 0)
                {
                    MessageBox.Show("El usuario se ingreso correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se a dectectado un problema en la base de datos, puede que este en reparaciones. Si el error perciste porfavor comuniquese con el  programador" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

        }
        public static DataTable mostrar_usu()
        {
            DataTable datos;
            try
            {
                string query = "SELECT  tb.id_usuarios, tb.nickname, tb.nombre_usuario, tb.apellido_usuario, tb.contraseña_usuario, tb.telefono, tb.Foto_usuario, tb.Correo, tb.dui, tb.nit, tb.fecha_de_nacimiento, te.Estado, h.tipo_usuario,tb.intentos  , dd.nombre FROM tbusuarios tb, estado te, tipo_usuario h, datos_empresa dd WHERE tb.id_estaado = te.id_estado AND tb.id_tipo_usuarios = h.id_tipo_usuario  AND tb.empresa = dd.id_datos_empresa AND tb.id_tipo_usuarios > 1";
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
        public static bool actualizarusu(constructor_primer_usuario upt)
        {
            bool retorno = false;
            try
            {
                constructor_de_respuestas ni = new constructor_de_respuestas();
                MySqlCommand cmdupt = new MySqlCommand(string.Format("UPDATE tbusuarios SET nickname ='{0}', nombre_usuario ='{1}', apellido_usuario ='{2}', telefono = '{3}',Foto_usuario = '{4}', Correo ='{5}', dui = '{6}', nit = '{7}', id_estaado = '{8}', id_tipo_usuarios = '{9}', empresa  = '{10}' WHERE id_usuarios='{11}' ", upt.usuario, upt.nombre_usuario, upt.apellido_usuario, upt.telefono , upt.Foto_usuario, upt.Correo, upt.dui, upt.nit, upt.id_estados, upt.id_tipo_usuarios, upt.empresa, upt.id_usuarios), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupt.ExecuteNonQuery());
             
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
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema, revise su internet o los servicios del servidor, Consulte al programador " + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool eliminarusu(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbusuarios WHERE id_usuarios = '{0}'", id), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El usuario a sido eliminado correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El usuario  no pudo ser eliminado correctamente", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema, revise su internet o los servicios del servidor, Consulte al programador" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }
        public static DataTable cargarUSU()
        {
            DataTable datos = new DataTable();

            try
            {
                string query = "SELECT id_tipo_usuario, CONCAT(tipo_usuario) AS tipo_usuario FROM Tipo_usuario  ";
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

        public static DataTable cargarUSU1()
        {
            DataTable datos = new DataTable();

            try
            {
                string query = "SELECT id_tipo_usuario, CONCAT(tipo_usuario) AS tipo_usuario FROM Tipo_usuario WHERE id_tipo_usuario > 1  ";
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
        public static DataTable cargar1()
        {
            DataTable datos = new DataTable();

            try
            {
                string query = "SELECT id_datos_empresa, CONCAT(nombre) AS nombre FROM Datos_empresa";
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
        public static bool actualizar (constructor_primer_usuario nuevo)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupt = new MySqlCommand(string.Format("UPDATE tbusuarios SET  id_usuarios='{0}', contraseña_usuario ='{1}'", nuevo.id_usuarios, nuevo.contraseña_usuario), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupt.ExecuteNonQuery());
                if (retorno == true)
                {
                 MessageBox.Show("Los datos fueron actualizados correctamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema, revise su internet o los servicios del servidor, Consulte al programador " + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return retorno;
            }

        }
    }




}
