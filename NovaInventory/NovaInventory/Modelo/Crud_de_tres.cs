using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using NovaInventory.Config;
using System.Windows.Forms;
using System.Data;
using NovaInventory.Controlador;
using NovaInventory.Modelo;

namespace NovaInventory.Modelo
{
    class Crud_de_tres
    {
        public static int agregar_categoria(costructor_categoria add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand agrega = new MySqlCommand(string.Format("INSERT INTO categoria(categoria)VALUES('{0}')", add.categoria), Conexion.obtenerconexion());
                retorno = Convert.ToInt32(agrega.ExecuteNonQuery());

                if (retorno > 0)
                {
                    MessageBox.Show("La categoria se a ingresado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo contactar con la base de datos" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }
        public static DataTable mostra_categoria()
        {
            DataTable datos;
            try
            {
                string query = "SELECT * FROM categoria";
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
        public static bool actualizar_cat(costructor_categoria upt)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupt = new MySqlCommand(string.Format("UPDATE categoria SET categoria ='{0}' WHERE  id_categoria='{1}'", upt.categoria, upt.id_categoria), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupt.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Los datos fueron actualizados correctamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo contactar con la base de datos" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool eliminar_cate(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdel = new MySqlCommand(string.Format("DELETE FROM categoria WHERE id_categoria='{0}'", id), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Los datos fueron eliminados correctamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo contactar con la base de datos" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static int agregar_productos(constructor_productos add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand agrega = new MySqlCommand(string.Format("INSERT INTO productos(producto, id_categorias)VALUES('{0}','{1}')", add.producto, add.id_categorias), Conexion.obtenerconexion());
                retorno = Convert.ToInt32(agrega.ExecuteNonQuery());

                if (retorno > 0)
                {
                    MessageBox.Show("El producto se a ingresado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo contactar con la base de datos" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }
        public static DataTable mostrar_producto()
        {
            DataTable datos;
            try
            {
                string query = "SELECT  tb.id_producto, tb.producto, ad.categoria from productos tb, categoria ad where tb.id_categorias = ad.id_categoria";
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
        public static bool actualizar_productos(constructor_productos upt)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupt = new MySqlCommand(string.Format("UPDATE productos SET producto ='{0}', id_categorias ='{1}'  WHERE  id_producto='{2}'", upt.producto, upt.id_categorias, upt.id_producto), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupt.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Los datos fueron actualizados correctamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo contactar con la base de datos" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool eliminar_productos(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdel = new MySqlCommand(string.Format("DELETE FROM productos WHERE  id_producto = '{0}'", id), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Los datos fueron eliminados correctamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo contactar con la base de datos" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static int agregar_modelo(costructor_modelos add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand agrega = new MySqlCommand(string.Format("INSERT INTO modelos(modelo, id_producto)VALUES('{0}', '{1}')", add.modelo, add.id_producto), Conexion.obtenerconexion());
                retorno = Convert.ToInt32(agrega.ExecuteNonQuery());

                if (retorno > 0)
                {
                    MessageBox.Show("La categoria se a ingresado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo contactar con la base de datos" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }
        public static DataTable mostra_modelo()
        {
            DataTable datos;
            try
            {
                string query = "SELECT  tb.id_modelo, tb.modelo, ad.producto  from modelos tb, productos ad where tb.id_producto = ad.id_producto";
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
        public static bool actualizar_modelo(costructor_modelos upt)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupt = new MySqlCommand(string.Format("UPDATE modelos SET modelo ='{0}', id_producto ='{1}' WHERE  id_modelo='{2}'", upt.modelo, upt.id_producto, upt.id_modelo), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupt.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Los datos fueron actualizados correctamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo contactar con la base de datos" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool eliminar_modelo(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdel = new MySqlCommand(string.Format("DELETE FROM modelos WHERE id_modelo='{0}'", id), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Los datos fueron eliminados correctamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo contactar con la base de datos" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

    }
}
