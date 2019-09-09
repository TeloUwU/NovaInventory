﻿using MySql.Data.MySqlClient;
using NovaInventory.Config;
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
            Usuario_Comprador();
        }

        public int Usuario_Comprador()
        {
            string nombreVIS = Constructor_login.nombre;
            string apellidoVIS = Constructor_login.apellido;
            int retorno = 0;
            try
            {
                MySqlCommand usuario = new MySqlCommand(string.Format("SELECT id_usuarios FROM tbusuarios WHERE nombre_usuario = '" + nombreVIS + "' AND apellido_usuario = '" + apellidoVIS + "';"), Conexion.obtenerconexion());
                txtid_usuario.Text = Convert.ToString(usuario.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("EL usuario que ha accedido no ha sido cargado correctamente por el programa, consulte con el tecnico" + ex, "Error de carga de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public int Proveedor()
        {
            string nombre = cbProveedor_Compra.Text;
            int retorno = 0;
            try
            {
                MySqlCommand proveedor = new MySqlCommand(string.Format("SELECT id_proveedor FROM tbproveedor WHERE nombre = " + nombre + ";"), Conexion.obtenerconexion());
                string Envio_Proveedor = Convert.ToString(proveedor.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proveedor seleccionado no se ha ingresado junto al producto, llame a un tecnico" + ex, "Carga Proveedor Fallida", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return retorno;
            }
        }

        public int Producto()
        {
            string nombre = cbProducto_Compra.Text;
            int retorno = 0;
            try
            {
                MySqlCommand producto = new MySqlCommand(string.Format("SELECT id_producto FROM productos WHERE producto = " + nombre + ";"), Conexion.obtenerconexion());
                string Envio_Producto = Convert.ToString(producto.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proveedor seleccionado no se ha ingresado junto al producto, llame a un tecnico" + ex, "Carga Proveedor Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return retorno;
            }
        }

        public int Tipo_pago()
        {
            string nombre = cbTipo_Pago.Text;
            int retorno = 0;
            try
            {
                MySqlCommand tipopago = new MySqlCommand(string.Format("SELECT id_tipo_pago FROM tbtipo_pago WHERE tipo_pago = " + nombre + ";"), Conexion.obtenerconexion());
                string Envio_Tipo = Convert.ToString(tipopago.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proveedor seleccionado no se ha ingresado junto al producto, llame a un tecnico" + ex, "Carga Proveedor Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return retorno;
            }
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
            if ( cbProveedor_Compra.Text.Trim() == "" || cbProducto_Compra.Text.Trim() == "" || txtPrecio_Unitario.Text.Trim() == "" ||
                txtTotal.Text.Trim() == "" || nUDCantidad.Text.Trim() == "" || txtid_usuario.Text.Trim() == "" || cbTipo_Pago.Text.Trim() == "" ||
                txtNum_factura.Text.Trim() == "" || txtDescripción.Text.Trim() == "")
            {
                MessageBox.Show("Algúnos campos estan vacíos, por favor llenelos todos", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregar.id_proveedor = Convert.ToInt16(Proveedor());
                agregar.id_producto = Convert.ToInt16(Producto());
                agregar.Preciounitario = Convert.ToInt16(txtPrecio_Unitario.Text);
                agregar.Precio_Total = Convert.ToInt16(txtTotal.Text);
                agregar.Cantidad = Convert.ToInt16(nUDCantidad.Text);
                agregar.id_usuario = Convert.ToInt16(txtid_usuario.Text);
                agregar.tipo_pago = Convert.ToInt16(Tipo_pago());
                agregar.num_factura = Convert.ToInt16(txtNum_factura.Text);
                agregar.descripcion = txtDescripción.Text;
                agregar.fecha_compra = dtpRealización_Compra.Text;

                int datos = crudCompra.insertarCompra(agregar);
            }
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
            Total();
        }
        
        

        public void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }
            
        public void Total()
        {
            if (txtPrecio_Unitario.Text.Trim() == "")
            {
                txtPrecio_Unitario.Text = "1.00";
            }

            int Precio_Unitario = Convert.ToInt16(txtPrecio_Unitario.Text);
            int Cantidad_Producto = Convert.ToInt16(nUDCantidad.Value);
            string Total = Convert.ToString(Precio_Unitario * Cantidad_Producto);
            txtTotal.Text = Total;

        }
    }
}
