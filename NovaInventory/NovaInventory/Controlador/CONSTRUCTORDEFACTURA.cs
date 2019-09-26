using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaInventory.Controlador
{
    class CONSTRUCTORDEFACTURA
    {

        public int id_factura { get; set; }
        public string Cantidad { get; set; }
        public string CostoDetalle { get; set; }
        public string direccion { get; set; }
        public string fecha_alta { get; set; }
        public int id_estado { get; set; }
        public string creado_por { get; set; }
    }
}
