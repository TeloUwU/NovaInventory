using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaInventory.Controlador
{
    class Constructor_proveedor
    {
        public int id_proveedor { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string nit { get; set; }
        public string rubro { get; set; }
        public int id_estados { get; set; }
    }
}
