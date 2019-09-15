using MySql.Data.MySqlClient;
using NovaInventory.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaInventory.Vista;
using NovaInventory.Modelo;

namespace NovaInventory.Controlador
{
    class crudCompra
    {



        public static int insertarCompra(constructor_Compra agregar)
        {
            int retorno = 0;
            try
            {
                MySqlCommand comandoAgregar = new MySqlCommand(string.Format("INSERT INTO tbCompras (id_compra, id_proveedor, id_articulos, descripcion, Preciounitario, Precio_total, Cantidad, fecha_compra, id_usuario, tipo_de_pago, num_factura) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", agregar.id_compra, agregar.id_proveedor, agregar.id_producto, agregar.descripcion, agregar.Preciounitario, agregar.Precio_Total, agregar.Cantidad, agregar.fecha_compra, agregar.id_usuario, agregar.tipo_pago, agregar.num_factura), Conexion.obtenerconexion());
                retorno = Convert.ToInt16(comandoAgregar.ExecuteNonQuery());
                if (retorno >= 0)
                {
                    MessageBox.Show("La compra se ha agregado correctamente.", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La compra no pudo ser registrada, verifique los datos", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err, ha ocurrido un error en la realización de la Compra, consulte al administrador y considere los posibles errores \n -No hay Internet \n -El servidor no posee los servicios activos \n -sin acceso al servidor" + ex, "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static DataTable CargarProveedores()
        {
            DataTable datos = new DataTable();
            string query = "SELECT nombre AS nombre_proveedor FROM tbproveedor";
            MySqlCommand cmdquery = new MySqlCommand(query, Conexion.obtenerconexion());
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdquery);
                adapter.Fill(datos);
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err, ha ocurrido un error a la hora de mostrar los Proveedores" + ex, "Error Insolito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return datos;
            }
        }

        public static DataTable CargarProducto()
        {
            DataTable datos = new DataTable();
            string query = "SELECT producto AS producto FROM productos";
            MySqlCommand cmdquery = new MySqlCommand(query, Conexion.obtenerconexion());
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdquery);
                adapter.Fill(datos);
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La carga de los productos ha fallado" + ex, "Falla de descarga de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return datos;
            }
        }

        public static DataTable CargarModelo()
        {
            DataTable datos = new DataTable();
            string query = "SELECT modelo AS modelo FROM modelos";
            MySqlCommand cmdquery = new MySqlCommand(query, Conexion.obtenerconexion());
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdquery);
                adapter.Fill(datos);
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La carga de modelos de los productos ha fallado" + ex, "Falla de descarga de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return datos;
            }
        }
        public static DataTable tipoPago()
        {
            DataTable datos = new DataTable();
            string query = "SELECT tipo_pago AS pago FROM tbtipo_pago";
            MySqlCommand cmdquery = new MySqlCommand(query, Conexion.obtenerconexion());
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdquery);
                adapter.Fill(datos);
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La carga de modelos de los productos ha fallado" + ex, "Falla de descarga de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return datos;
            }
        }

        public static DataTable Compras()
        {
            DataTable datos = new DataTable();
            string query = "SELECT id_compra, nombre, producto, modelo, descripcion, Preciounitario, Precio_total, Cantidad, fecha_compra, CONCAT(nombre_usuario,' ',apellido_usuario), tipo_pago, num_factura FROM tbcompras INNER JOIN tbproveedor, articulos, productos, modelos, tbusuarios, tbtipo_pago WHERE tbcompras.id_proveedor = tbproveedor.id_proveedor AND tbcompras.id_articulos = articulos.id_articulo AND articulos.id_productos = productos.id_producto AND articulos.id_modelos = modelos.id_modelo AND tbcompras.id_usuario = tbusuarios.id_usuarios AND tbcompras.tipo_de_pago = tbtipo_pago.id_tipo_pago;";
            MySqlCommand cmdselect = new MySqlCommand(query, Conexion.obtenerconexion());
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(datos);
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err los datos no pudieron ser obtenidos, consulte con el Tecnico" + ex, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return datos;
            }
            finally
            {
                Conexion.obtenerconexion().Close();
            }
        }

        public static bool ActualizarCompra(constructor_Compra upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE tbcompras SET id_usuario_mod = '{0}', precio_unitario_mod = '{1}', total_mod = '{2}', Cantidad_mod = '{3}' WHERE id_compra = '{4}'", upd.id_usuario_mod,upd.precio_unitario_mod,upd.total_mod,upd.cantidad_mod,upd.id_usuario_mod),Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("La compra se ha modificado de manera exitosa","Compra Corregida",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La compra no fue actualizada","Actualización fallida",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err, ocurrio un problema al intentar actualizar la compra , revise que los servicios esten activos y su conección a internet" + ex,"Puro Crítico",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
 