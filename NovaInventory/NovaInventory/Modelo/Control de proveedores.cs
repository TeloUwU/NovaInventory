using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using NovaInventory.Config;
using NovaInventory.Controlador;


namespace NovaInventory.Modelo
{
    class Control_de_proveedores
    {

        public static int agregar_usu(Constructor_proveedor add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdagregar = new MySqlCommand(string.Format("INSERT INTO tbproveedor(nombre, direccion, telefono, nit, rubro, id_estados) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", add.nombre, add.direccion, add.telefono, add.nit, add.rubro, add.id_estados), Conexion.obtenerconexion());
                retorno = Convert.ToInt16(cmdagregar.ExecuteNonQuery());
                if (retorno > 0)
                {
                    MessageBox.Show("El Proveedor se ingreso correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se a dectectado un problema en la base de datos, puede que este en reparaciones. Si el error perciste porfavor comuniquese con el  programador" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

        }


        //    public static DataTable cargar()
        //    {
        //        DataTable datos = new DataTable();

        //        try
        //        {
        //            string query = "SELECT id_estado, CONCAT(Estado) AS Estado FROM estado";
        //            MySqlCommand mcdquery = new MySqlCommand(query, Conexion.obtenerconexion());
        //            MySqlDataAdapter adaptar = new MySqlDataAdapter(mcdquery);
        //            adaptar.Fill(datos);
        //            return datos;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("oops, no se pudieron cargar los datos de la base de datos porfavor comunicarse con el programador" + ex, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return datos;
        //        }
        //    }
        //}

        public static DataTable Mostrar_proveedor()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
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
        public static bool Actualizar_proveedor(Constructor_proveedor upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE  SET nombre = '{0}', WHERE id_proveedor = '{4}'", upd.nombre, upd.direccion, upd.telefono, upd.nit, upd.rubro, upd.id_proveedor), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
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
        public static bool Eliminarproveedor(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tb WHERE id_proveedor = '{0}'", id), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El registro se a eliminado correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro no se eliminado correctamente", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Oops! ha ocurrido un problema, revise su internet o los servicios del servidor, Consulte al Administrador" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }
    }
}

