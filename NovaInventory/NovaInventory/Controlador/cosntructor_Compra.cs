using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaInventory.Controlador
{
    class constructor_Compra
    {
        public int id_compra { get; set; }
        public int id_proveedor { get; set; }
        public int id_articulos { get; set; }
        public string descripcion { get; set; }
        public int Preciounitario { get; set; }
        public int Precio_Total { get; set; }
        public int Cantidad { get; set; }
        public string fecha_compra { get; set; }
        public int id_usuario { get; set; }
        public int tipo_pago { get; set; }
        public int id_usuario_mod { get; set; }
        public int precio_unitario_mod { get; set; }
        public int total_mod { get; set; }
        public int cantidad_mod { get; set; }
        public int num_factura { get; set; }
    }
}
