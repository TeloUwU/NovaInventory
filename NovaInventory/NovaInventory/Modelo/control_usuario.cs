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
    class control_usuario
    {
        public static int registro_usuario(constructor_primer_usuario usu)
        {
            int retorno = 0;
            string query = "SELECT * FROM Datos_empresa WHERE nombre = ?param1 OR nit = ?param2";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.obtenerconexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", usu.nickname));
                cmdselect.Parameters.Add(new MySqlParameter("param2", usu.nit));
                bool existencia = Convert.ToBoolean(cmdselect.ExecuteNonQuery());
                if (existencia == false)
                {
                    MessageBox.Show("La empresa o el numero de nit ya estan regitrado en la base de datos", "no se puede guardar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand comandoAgregar = new MySqlCommand(string.Format("INSERT INTO Datos_empresa(nickname, nombre_usuario, apellido_usuario, contraseña_usuario, telefono, Foto_usuario, Correo, nit, id_estados, id_tipo_usuarios, intentos, empresa)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", usu.nickname, usu.nombre_usuario, usu.apellido_usuario, usu.contraseña_usuario, usu.telefono, usu.Foto_usuario, usu.Correo, usu.nit, usu.id_estados, usu.id_tipo_usuarios, usu.intentos, usu.empresa), Conexion.obtenerconexion());
                    retorno = Convert.ToInt32(comandoAgregar.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("Se a ingresado el primer usuario con exito", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Guardar el usuario/a porfavor verifique si la base de datos esta activa si es asi comuniquese con el administrador " + ex, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
