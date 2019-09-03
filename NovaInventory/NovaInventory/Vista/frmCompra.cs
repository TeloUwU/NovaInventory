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
            CargarProveedor();
            CargarProducto();
            CargarModelo();
            CargartipoPago();
        }

        private void CargartipoPago()
        {
            cbTipo_Pago.DataSource = crudCompra.tipoPago();
            cbTipo_Pago.ValueMember = "pago";
            cbTipo_Pago.DisplayMember = "tipo_pago";
        }

        private void CargarProveedor()
        {
            cbProveedor_Compra.DataSource = crudCompra.CargarProveedores();
            cbProveedor_Compra.ValueMember = "nombre_proveedor"; 
            cbProveedor_Compra.DisplayMember = "id_proveedor";
        }

        private void CargarProducto()
        {
            cbProducto_Compra.DataSource = crudCompra.CargarProducto();
            cbProducto_Compra.DisplayMember = "id_producto"; 
            cbProducto_Compra.ValueMember = "producto";
        }

        private void CargarModelo()
        {
            cbModelo_Compra.DataSource = crudCompra.CargarModelo();
            cbModelo_Compra.DisplayMember = "id_modelos";
            cbModelo_Compra.ValueMember = "modelo";
        }

        public void AgregarCompra()
        {
            agregar.id_compra = Convert.ToInt16(txtid_Compra.Text);
            agregar.id_proveedor = Convert.ToInt16(cbProveedor_Compra.Text);
            agregar.id_producto = Convert.ToInt16(cbProducto_Compra.Text);
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

        private void cbProducto_Compra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void nUDCantidad_ValueChanged(object sender, EventArgs e)
        {
            
        }

        public void txtPrecio_Unitario_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void txtTotal_TextChanged(object sender, EventArgs e)
        {
            Total();
        }

        public void Total()
        {
            int Precio_Unitario = Convert.ToInt16(txtPrecio_Unitario.Text);
            int Cantidad_Producto = Convert.ToInt16(nUDCantidad.Value);
            string Total = Convert.ToString(Precio_Unitario * Cantidad_Producto);
            txtTotal.Text = Total;
        }
    }
}
