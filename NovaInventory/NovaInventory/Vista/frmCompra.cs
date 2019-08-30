using NovaInventory.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaInventory.Vista
{
    public partial class frmCompra : Form
    {

        constructor_Compra agregar = new constructor_Compra();
        public frmCompra()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            cbProveedor_Compra.DataSource = crudCompra.CargarProveedores();
            cbCategoría_Compra.DataSource = crudCompra.Cargarcategoria();

            cbProveedor_Compra.DisplayMember = "NombreProveedor";
            cbProveedor_Compra.ValueMember = "id_proveedor";
            cbCategoría_Compra.DisplayMember = "NombreCategorias";
            cbCategoría_Compra.ValueMember = "";
        }

        private void AgregarCompra()
        {
            agregar.id_compra = Convert.ToInt16(txtid_Compra.Text);
            agregar.id_proveedor = Convert.ToInt16(cbProveedor_Compra.Text);
            agregar.id_articulos = Convert.ToInt16(cbProducto_Compra.Text);
            agregar.Preciounitario = Convert.ToInt16(txtPrecio_Unitario.Text);
            agregar.Precio_Total = Convert.ToInt16(txtTotal.Text);
            agregar.Cantidad = Convert.ToInt16(nUDCantidad.Text);
            agregar.id_usuario = Convert.ToInt16(txtid_usuario.Text);
            agregar.tipo_pago = Convert.ToInt16(cbTipo_Pago.Text);
            agregar.num_factura = Convert.ToInt16(txtNum_factura.Text);
            agregar.descripcion = txtDescripción.Text;
            agregar.fecha_compra = dtpRealización_Compra.Text;

            crudCompra.insertarCompra(agregar);
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            AgregarCompra();
        }
    }
}
