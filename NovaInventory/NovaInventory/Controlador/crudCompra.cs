using MySql.Data.MySqlClient;
using NovaInventory.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaInventory.Controlador
{
    class crudCompra
    {
        public static int insertarCompra(constructor_Compra agregar)
        {
            int retorno = 0;
            MySqlCommand comandoAgregar;
            try
            {
                comandoAgregar = new MySqlCommand(string.Format("INSERT INTO tbCompras (id_compra,id_proveedor,id_articulos,descripción,Preciounitario,Precio_total,Cantidad,fecha_compra,id_usuario,tipo_de_pago,num_factura) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7}','{8}','{9}','{10}')", agregar.id_compra, agregar.id_proveedor, agregar.id_articulos, agregar.descripcion, agregar.Preiounitario, agregar.Precio_Total, agregar.Cantidad, agregar.fecha_compra, agregar.id_usuario, agregar.tipo_de_pago, agregar.num_factura), Conexion.obtenerconexion());
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
    }
}
