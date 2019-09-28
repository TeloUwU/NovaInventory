using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaInventory.Controlador
{
    class ConstructorExistencias_Inventario
    {
        public int id_exixtencia_inventario { get; set; }
        public int id_articuloss { get; set; }
        public int id_bodega { get; set; }
        public string serie { get; set; }
        public int cantidad { get; set; }
        public int Precio_unitario { get; set; }
        public int Precio_total { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }

        public ConstructorExistencias_Inventario() { }
    }
}
