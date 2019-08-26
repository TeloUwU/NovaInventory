using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaInventory.Config;
using NovaInventory.Controlador;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace NovaInventory.Modelo
{
    class control_usuario
    {
        public static int registro_usuario(constructor_primer_usuario usu)
        {
            int retorno = 0;
            string query = "SELECT * FROM tbusuarios WHERE nombre = ?param1 OR nit = ?param2";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.obtenerconexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", usu.usuario));
                cmdselect.Parameters.Add(new MySqlParameter("param2", usu.nit));
                bool existencia = Convert.ToBoolean(cmdselect.ExecuteNonQuery());
                if (existencia == false)
                {
                    MessageBox.Show("La empresa o el numero de nit ya estan regitrado en la base de datos", "no se puede guardar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand comandoAgregar = new MySqlCommand(string.Format("INSERT INTO tbusuarios(nickname, nombre_usuario, apellido_usuario, contraseña_usuario, telefono, Foto_usuario, Correo, nit, fecha_de_nacimiento, id_estados, id_tipo_usuarios, intentos, empresa)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", usu.usuario, usu.nombre_usuario, usu.apellido_usuario, usu.contraseña_usuario, usu.telefono, usu.Foto_usuario, usu.Correo, usu.nit, usu.fecha_de_nacimiento, usu.id_estados, usu.id_tipo_usuarios, usu.intentos, usu.empresa), Conexion.obtenerconexion());
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
        public static DataTable cargarUSU()
        {
            DataTable datos = new DataTable();

            try
            {
                string query = "SELECT id_tipo_usuario, CONCAT(tipo_usuario) AS tipo_usuario FROM Tipo_usuario";
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
                string query = "SELECT id_estado_usuario, CONCAT(Estado_usuario) AS Estado_usuario FROM estado_usuario";
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

    }


}
