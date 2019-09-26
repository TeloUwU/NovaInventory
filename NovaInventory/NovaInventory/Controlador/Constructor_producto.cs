using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaInventory.Controlador
{
    class Constructor_producto
    {
        public int id_articulo { get; set; }
        public int id_categorias { get; set; }
        public string codigo_articulo { get; set; }
        public int id_productos{ get; set; }
        public int id_proveedorehs { get; set; }
        public string marca { get; set; }
        public int id_modelos { get; set; }
        public string seriado { get; set; }
        public int id_estadoss { get; set; }
        public int  id_bodegas { get; set; }

        public Constructor_producto() { }
    }
}
