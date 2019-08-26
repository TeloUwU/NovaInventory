﻿using NovaInventory.Controlador;
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

        }

        private void AgregarCompra()
        {
            int id_compra = Convert.ToInt16(txtid_Compra.Text);
            int id_proveedor = Convert.ToInt16(cbProveedor_Compra.Text);
            int id_articulo = Convert.ToInt16(cbProducto_Compra.Text);
            int Precio_Unitario = Convert.ToInt16(txtPrecio_Unitario.Text);
            int total = Convert.ToInt16(txtTotal.Text);
            int cantidad = Convert.ToInt16(nUDCantidad.Text);
            int usuario = Convert.ToInt16(txtid_usuario.Text);
            int tipo_pago = Convert.ToInt16(cbTipo_Pago.Text);
            int numero_fact = Convert.ToInt16(txtNum_factura.Text);

            agregar.id_compra = id_compra;
            agregar.id_proveedor = id_proveedor;
            agregar.id_articulos = id_articulo;
            agregar.descripcion = txtDescripción.Text;
            agregar.Preiounitario = Precio_Unitario;
            agregar.Precio_Total = total;
            agregar.Cantidad = cantidad;
            agregar.fecha_compra = dtpRealización_Compra.Text;
            agregar.id_usuario = usuario;
            agregar.tipo_de_pago = tipo_pago;
            agregar.num_factura = numero_fact;
            
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            AgregarCompra();
        }
    }
}
