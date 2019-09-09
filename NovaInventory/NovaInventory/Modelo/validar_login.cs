using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaInventory.Config;
using NovaInventory.Controlador;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace NovaInventory.Modelo
{
    class validar_login
    {
        public static bool acceso(Constructor_login log)
        {
            log.clave = Validaciones.md5(log.clave);
            bool retorno = false;
            string query = "SELECT * FROM tbusuarios WHERE nickname = ?user AND contraseña_usuario = ?pass";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.obtenerconexion());
                cmdselect.Parameters.Add(new MySqlParameter("user", Constructor_login.usuario));
                cmdselect.Parameters.Add(new MySqlParameter("pass", log.clave));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retorno == true)
                {
                    int estado = 1;
                    string query2 = "SELECT * FROM tbusuarios WHERE nickname = ?user AND contraseña_usuario = ?pass AND id_estaado = ?state";
                    MySqlCommand cmdselect2 = new MySqlCommand(query2, Conexion.obtenerconexion());
                    cmdselect2.Parameters.Add(new MySqlParameter("user", Constructor_login.usuario));
                    cmdselect2.Parameters.Add(new MySqlParameter("pass", log.clave));
                    cmdselect2.Parameters.Add(new MySqlParameter("state", estado));
                    retorno = Convert.ToBoolean(cmdselect2.ExecuteScalar());
                    if (retorno == true)
                    {
                        int intentos = 0;
                        MySqlCommand cmdreset = new MySqlCommand(string.Format("UPDATE tbusuarios SET intentos = '{0}' WHERE nickname = '{1}'", intentos, Constructor_login.usuario), Conexion.obtenerconexion());
                        int rest = Convert.ToInt16(cmdreset.ExecuteNonQuery());
                        MySqlDataReader _reader = cmdselect.ExecuteReader();
                        while (_reader.Read())
                        {
                            Constructor_login.id_usuario = _reader.GetString(0);
                            Constructor_login.nombre = _reader.GetString(2) + " ";
                            Constructor_login.apellido = _reader.GetString(3) + " ";
                            Constructor_login.nivel = _reader.GetInt16(11);
                            if (rest >= 1)
                            {
                                MessageBox.Show("Bienvenido Usuario " + Constructor_login.usuario, "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                    else
                    {
                        MySqlDataReader reader = cmdselect.ExecuteReader();
                        while (reader.Read())
                        {
                            int intentos = 0;
                            intentos = reader.GetInt16(12) + 1;
                            if (intentos > 5)
                            {
                                int bloqueo = 3;
                                MySqlCommand cmdblock = new MySqlCommand(string.Format("UPDATE tbusuarios SET id_estados = '{0}' WHERE nickname = '{1}'", bloqueo, Constructor_login.usuario), Conexion.obtenerconexion());
                                int verificacion = Convert.ToInt32(cmdblock.ExecuteNonQuery());
                                if (verificacion >= 1)
                                {
                                    MessageBox.Show("Usuario Bloqueado.  Para desbloquear al usuario contacte a un administrador", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbusuarios (SET intentos = '{0}' WHERE nickname = '{1}'", intentos, Constructor_login.usuario), Conexion.obtenerconexion());
                                int verificacion = Convert.ToInt32(cmdupdate.ExecuteNonQuery());
                                if (verificacion >= 1)
                                {
                                    MessageBox.Show("La contraseña proporcionada es incorrecto o el usuario no esta activo ", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                            }


                        }

                    }
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña ingresado no son los correctos", "Verifique los campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en el servidor" + ex, "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return retorno;
            }
            finally
            {
                Conexion.obtenerconexion().Close();
            }

        }
    }
}
