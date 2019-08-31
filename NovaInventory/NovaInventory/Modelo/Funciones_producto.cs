using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaInventory.Modelo;
using NovaInventory.Controlador;
using NovaInventory.Config;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace NovaInventory.Modelo
{
    class Funciones_producto
    {
        public static int Ingresar_Producto(Constructor_producto add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO articulos(nombre_articulo, codigo_articulo, marca) VALUES'(0)', '(1)', '(2)')", add.nombre_articulo, add.codigo_articulo_seriado, add.marca), Conexion.obtenerconexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("El producto se ha ingresado exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El producto no pudo ser registrado,intente de nuevo y verifique que los datos sean correctos", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error critico de conexion: " + e, "Fallo de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable Mostrar_Producto()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM articulos";
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
        public static bool Actualizar_productos(Constructor_producto upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE SET nombre_articulo = '{0}', codigo_articulo = '{1}',marca = '{2}' WHERE id_articulo = '{5}'", upd.nombre_articulo, upd.codigo_articulo_seriado, upd.marca), Conexion.obtenerconexion());
            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un problema, revise su internet o los servicios del servidor, Consulte al Administrador " + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
            return retorno;

        }
        public static bool Eliminar_productos(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM articulos WHERE id_articulo = '{0}'", id), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El registro de producto se a eliminado correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro del producto no se ha eliminado correctamente", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un problema, revise su internet o los servicios del servidor, Consulte al Administrador" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable Cargar_producto()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM articulos";
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

        //public static DataTable Cargar_marca_producto()
        //{
        //    DataTable data = new DataTable();

        //    try
        //    {
        //        string query = "SELECT id_estado_usuario, CONCAT(Estado_usuario) AS Estado_usuario FROM Estado_usuario";
        //        MySqlCommand cargar = new MySqlCommand(query, Conexion.obtenerconexion());
        //        MySqlDataAdapter cmd = new MySqlDataAdapter(cargar);

        //        cmd.Fill(data);

        //        return data;
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(" " + e);

        //        return data = new DataTable();
        //    }
        //}
    //        public static DataTable forma_pago()
    //    {
    //        DataTable data = new DataTable();

    //        try
    //        {
    //            string query = "SELECT id_tipo_pago, CONCAT(tipo_pago) AS tipo_pago FROM tipo_pago";
    //            MySqlCommand cargar = new MySqlCommand(query, Conexion.obtenerconexion());
    //            MySqlDataAdapter cmd = new MySqlDataAdapter(cargar);

    //            cmd.Fill(data);

    //            return data;
    //        }
    //        catch (Exception e)
    //        {
    //            MessageBox.Show(" " + e);

    //            return data = new DataTable();
    //        }
            
    //    }
    }
}
