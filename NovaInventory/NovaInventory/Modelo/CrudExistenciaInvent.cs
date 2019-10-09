using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaInventory.Controlador;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using NovaInventory.Config;

namespace NovaInventory.Modelo
{
    class CrudExistenciaInvent
    {
        public static int insertarExistencia(ConstructorExistencias_Inventario agregar)
        {
            int retorno = 0;
            try
            {
                MySqlCommand comandoAgregar = new MySqlCommand(string.Format("INSERT INTO existencias_inventario (id_exixtencia_inventario, id_articuloss, id_bodega, serie, cantidad, Precio_unitario, Precio_total, Desde, Hasta) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", agregar.id_exixtencia_inventario, agregar.id_articuloss, agregar.id_bodega, agregar.serie, agregar.cantidad, agregar.Precio_unitario, agregar.Precio_total, agregar.Desde, agregar.Hasta), Conexion.obtenerconexion());
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
                MessageBox.Show("Hubo un error al insertar los productos en el inventario," + ex, "Error de Inserción",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return retorno;
            }
        }

        public static bool actualizarFechaExistencia(ConstructorExistencias_Inventario actualizar)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE existencias_inventario SET Hasta = '" + actualizar.Hasta + "' WHERE id_exixtencia_inventario = '" + actualizar.id_exixtencia_inventario + "';"), Conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("La existencia se ha modificado de manera exitosa", "Existencia Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La existencia no fue actualizada", "Actualización fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err, ocurrio un problema al intentar actualizar la compra , revise que los servicios esten activos y su conección a internet" + ex, "Puro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }


    }
}
