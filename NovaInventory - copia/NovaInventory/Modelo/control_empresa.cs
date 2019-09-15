using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaInventory.Controlador;
using NovaInventory.Config;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace NovaInventory.Controlador
{
    class control_empresa
    {
        public static int registrarempresa(Constructor_empresa emp)
        {
            int retorno = 0;
            string query = "SELECT * FROM Datos_empresa WHERE nombre = ?param1 OR nit = ?param2";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.obtenerconexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", emp.nombre));
                cmdselect.Parameters.Add(new MySqlParameter("param2", emp.nit));
                bool existencia = Convert.ToBoolean(cmdselect.ExecuteNonQuery());
                if (existencia == false)
                {
                    MessageBox.Show("La empresa o el numero de nit ya estan regitrado en la base de datos", "no se puede guardar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand comandoAgregar = new MySqlCommand(string.Format("INSERT INTO Datos_empresa(nombre, email, foto_empresa, nit, direccion, Representante, tipo_empresa)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", emp.nombre, emp.email, emp.foto_empresa, emp.nit, emp.direccion, emp.representante, emp.tipo_empresa), Conexion.obtenerconexion());
                    retorno = Convert.ToInt32(comandoAgregar.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("La empresa se registro exitosamente", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Guardar la empresa porfavor verifique si la base de datos esta activa si es asi comuniquese con el administrador " + ex, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static int Agregar_tel(constructor_para_celulares ag)
        {
            int retorno = 0;
            try
            {
                MySqlCommand comandoagregar = new MySqlCommand(string.Format("INSERT INTO numeros_telefonicos(numeros_tel, empresas)VALUES('{0}','{1}')", ag.numeros_tel, ag.empresas), Conexion.obtenerconexion());
                retorno = Convert.ToInt32(comandoagregar.ExecuteNonQuery());
                if (retorno > 0)
                {
                    MessageBox.Show("Se a ingresado el numero de telefono", "GUARDADO EXITOSAMENTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return retorno;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se a dectectado un problema en la base de datos, puede que este en reparaciones. Si el error perciste porfavor comuniquese con el  programador" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

        }
        public static DataTable mostrar_cel()
        {
            DataTable datos;
            try
            {
                string query = "SELECT * FROM  numeros_telefonicos";
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
        public static bool Eliminar_num(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM numeros_telefonicos WHERE id_num_tel = '{0}'", id), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El numero de telefono a sido eliminado correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El numero de telefono no pudo ser eliminado correctamente", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un problema, revise su internet o los servicios del servidor, Consulte al programador" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }
        public static int Id(constructor_para_celulares jj)
        {
            int datos = 0;
            try
            {
                string query5 = "SELECT id_datos_empresa FROM  Datos_empresa";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query5, jj.id_num_tel), Conexion.obtenerconexion());
                datos = Convert.ToInt16(cmdselect.ExecuteScalar());
                if (datos >= 1)
                {
                    MessageBox.Show("se pudo contactar con su empresa", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return datos;
            }
            catch (Exception)
            {
                MessageBox.Show("no se pudo contactar con su empresa", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return datos;
            }

        }
    }

}
