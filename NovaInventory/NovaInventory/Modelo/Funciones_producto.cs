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
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO articulos(id_proveedorehs, id_categoriass, codigo_articulo, id_productos, marca, id_modelos, seriado, id_estadoss, id_bodegas) VALUES'(0)', '(1)', '(2)','(3)','(4)','(5)','(6)','(7)','(8)')", add.id_proveedorehs, add.id_categorias, add.codigo_articulo, add.id_productos, add.marca, add.id_modelos, add.seriado, add.id_estadoss, add.id_bodegas), Conexion.obtenerconexion());
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
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE articulos SET id_proveedorehs = '{0}', id_categoriass = '{1}',codigo_articulo = '{2}' , id_productos = '{3}', marca = '{4}', id_modelos = '{5}', seriado = '{6}', id_estadoss = '{7}', id_bodegas = '{8}' WHERE id_articulo = '{9}'", upd.id_proveedorehs, upd.id_categorias, upd.codigo_articulo, upd.id_productos, upd.marca, upd.id_modelos, upd.seriado, upd.id_estadoss, upd.id_bodegas, upd.id_articulo), Conexion.obtenerconexion());
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
        public static DataTable Cargar_estado()
        {
            DataTable data = new DataTable();

            try
            {
                string query = "SELECT id_proveedor, CONCAT(Estado) AS Estado FROM estado";
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

        public static DataTable Cargarproveedor()
        {
            DataTable data = new DataTable();

            try
            {
                string query = "SELECT id_estado, CONCAT(nombre) AS nombre FROM tbproveedor";
                MySqlCommand cargar = new MySqlCommand(query, Conexion.obtenerconexion());
                MySqlDataAdapter cmd = new MySqlDataAdapter(cargar);

                cmd.Fill(data);

                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);

                return data;
            }
        }
        public static DataTable productos()
        {
            DataTable data = new DataTable();

            try
            {
                string query = "SELECT id_producto, CONCAT(producto) AS producto FROM productos";
                MySqlCommand cargar = new MySqlCommand(query, Conexion.obtenerconexion());
                MySqlDataAdapter cmd = new MySqlDataAdapter(cargar);

                cmd.Fill(data);

                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);

                return data;
            }

        }
        public static DataTable bodega()
        {
            DataTable data = new DataTable();

            try
            {
                string query = "SELECT id_bodega, CONCAT(nombre_bodega) AS nombre_bodega FROM tbbodega";
                MySqlCommand cargar = new MySqlCommand(query, Conexion.obtenerconexion());
                MySqlDataAdapter cmd = new MySqlDataAdapter(cargar);

                cmd.Fill(data);

                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);

                return data;
            }
        }
        public static DataTable Categoria()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT id_categoria, CONCAT(categoria) AS categoria FROM categoria";
                MySqlCommand cargar = new MySqlCommand(query, Conexion.obtenerconexion());
                MySqlDataAdapter cmd = new MySqlDataAdapter(cargar);

                cmd.Fill(data);

                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);

                return data;
            }
        }
        public static DataTable modelo()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT id_modelo, CONCAT(modelo) AS modelo FROM modelos";
                MySqlCommand cargar = new MySqlCommand(query, Conexion.obtenerconexion());
                MySqlDataAdapter cmd = new MySqlDataAdapter(cargar);

                cmd.Fill(data);

                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);

                return data;
            }
        }
      
        

    }
}
