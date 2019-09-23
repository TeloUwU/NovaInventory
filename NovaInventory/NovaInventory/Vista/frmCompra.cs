using MySql.Data.MySqlClient;
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

        constructor_Compra actualizar = new constructor_Compra();
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

            btnActualizar_Compra.Enabled = false;
            
            
            VerCompras();
        }

        private void VerCompras()
        {
            dgvCompras.DataSource = crudCompra.Compras();
            dgvCompras.Columns[0].Visible = false;
            dgvCompras.Columns[5].HeaderText = "Precio Unitario";
            dgvCompras.Columns[6].HeaderText = "Precio Total";
            dgvCompras.Columns[8].HeaderText = "Fecha de Compra";
            dgvCompras.Columns[9].HeaderText = "Usuario Comprador";
            dgvCompras.Columns[10].HeaderText = "Tipo de Pago";
            dgvCompras.Columns[11].HeaderText = "Numero de Factura";
            if (dgvCompras.DataSource == null)
            {
                MessageBox.Show("No hay datos para mostrar :/", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                MySqlCommand proveedor = new MySqlCommand(string.Format("SELECT id_proveedor FROM tbproveedor WHERE nombre = '" + nombre + "';"), Conexion.obtenerconexion());
                txtid_proveedor.Text = Convert.ToString(proveedor.ExecuteScalar());
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
                MySqlCommand producto = new MySqlCommand(string.Format("SELECT id_producto FROM productos WHERE producto = '" + nombre + "';"), Conexion.obtenerconexion());
                txtid_producto.Text = Convert.ToString(producto.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("la compra no se ha realizado por la selección de producto, llame a un tecnico" + ex, "Carga Proveedor Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return retorno;
            }
        }

        public int Tipo_pago()
        {
            string nombre = cbTipo_Pago.Text;
            int retorno = 0;
            try
            {
                MySqlCommand tipopago = new MySqlCommand(string.Format("SELECT id_tipo_pago FROM tbtipo_pago WHERE tipo_pago = '" + nombre + "';"), Conexion.obtenerconexion());
                txtid_tipopago.Text = Convert.ToString(tipopago.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Tipo de pago seleccionado no se ha ingresado junto a la compra, llame a un tecnico" + ex, "Carga Proveedor Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return retorno;
            }
        }

        public int Modelo_Seleccionado()
        {
            string nombre = cbModelo_Compra.Text;
            int retorno = 0;
            try
            {
                MySqlCommand Modelo = new MySqlCommand(string.Format("SELECT id_modelo FROM modelos WHERE modelo = '" + nombre + "';"), Conexion.obtenerconexion());
                txtid_modelo.Text = Convert.ToString(Modelo.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Modelo del producto seleccionado ha tenido problemas a la hora de ingresarse y en consecuencia no se ha realizado la compra, llame a un tecnico" + ex, "Carga Proveedor Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return retorno;
            }
        }

        public int ingresar_articulo()
        {
            string producto = txtid_producto.Text;
            string modelo = txtid_modelo.Text;
            int retorno = 0;
            try
            {
                MySqlCommand Modelo = new MySqlCommand(string.Format("SELECT id_articulo FROM articulos WHERE id_productos = '" + producto + "' AND id_modelos = '" + modelo + "';"), Conexion.obtenerconexion());
                txtid_articulo.Text = Convert.ToString(Modelo.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Modelo del producto seleccionado ha tenido problemas a la hora de ingresarse y en consecuencia no se ha realizado la compra, llame a un tecnico" + ex, "Carga Proveedor Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                agregar.id_proveedor = Convert.ToInt16(txtid_proveedor.Text);
                agregar.id_producto = Convert.ToInt16(txtid_producto.Text);
                agregar.Preciounitario = Convert.ToInt16(txtPrecio_Unitario.Text);
                agregar.Precio_Total = Convert.ToInt16(txtTotal.Text);
                agregar.Cantidad = Convert.ToInt16(nUDCantidad.Text);
                agregar.id_usuario = Convert.ToInt16(txtid_usuario.Text);
                agregar.tipo_pago = Convert.ToInt16(txtid_tipopago.Text);
                agregar.num_factura = Convert.ToInt16(txtNum_factura.Text);
                agregar.descripcion = txtDescripción.Text;
                agregar.fecha_compra = dtpRealización_Compra.Text;

                int datos = crudCompra.insertarCompra(agregar);
            }
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            Proveedor();
            Producto();
            Tipo_pago();
            Modelo_Seleccionado();
            ingresar_articulo();
            AgregarCompra();
            VerCompras();
        }

        private void cbProducto_Compra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void nUDCantidad_ValueChanged(object sender, EventArgs e)
        {
            
        }

        public void validar_primeracompra()
        {
            MySqlCommand validar = new MySqlCommand(string.Format(""), Conexion.obtenerconexion(););
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
            else
            {
                int Precio_Unitario = Convert.ToInt16(txtPrecio_Unitario.Text);
                int Cantidad_Producto = Convert.ToInt16(nUDCantidad.Value);
                string Total = Convert.ToString(Precio_Unitario * Cantidad_Producto);
                txtTotal.Text = Total;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            VerCompras();
        }

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posición;
            posición = this.dgvCompras.CurrentRow.Index;
            
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvCompras.CurrentRow.Index;
            txtid_Compra.Text = dgvCompras[0, posicion].Value.ToString();
            txtid_proveedor.Text = dgvCompras[1, posicion].Value.ToString();
            txtid_producto.Text = dgvCompras[2, posicion].Value.ToString();
            txtid_modelo.Text = dgvCompras[3, posicion].Value.ToString();
            txtDescripción.Text = dgvCompras[4, posicion].Value.ToString();
            txtPrecio_Unitario.Text = dgvCompras[5, posicion].Value.ToString();
            txtTotal.Text = dgvCompras[6, posicion].Value.ToString();
            nUDCantidad.Text = dgvCompras[7, posicion].Value.ToString();
            dtpRealización_Compra.Text = dgvCompras[8, posicion].Value.ToString();
            txtid_usuario.Text = dgvCompras[9, posicion].Value.ToString();
            txtid_tipopago.Text = dgvCompras[10, posicion].Value.ToString();
            txtNum_factura.Text = dgvCompras[11, posicion].Value.ToString();

            btnActualizar_Compra.Enabled = true;
            btnAgregarCompra.Enabled = false;
            cbModelo_Compra.Enabled = false;
            cbProducto_Compra.Enabled = false;
            cbProveedor_Compra.Enabled = false;
            cbModelo_Compra.Enabled = false;
            cbTipo_Pago.Enabled = false;
            txtDescripción.Enabled = false;
            txtNum_factura.Enabled = false;
            dtpRealización_Compra.Visible = true;

            Total();
        }

        private void btnActualizar_Compra_Click(object sender, EventArgs e)
        {
            actualizar.id_compra = Convert.ToInt16(txtid_Compra.Text);
            agregar.id_usuario_mod = Convert.ToInt16(txtid_usuario.Text);
            agregar.precio_unitario_mod = Convert.ToInt16(txtPrecio_Unitario.Text);
            agregar.total_mod = Convert.ToInt16(txtTotal.Text);
            agregar.cantidad_mod = Convert.ToInt16(nUDCantidad.Text); 

        }

        public void LimpiarTodo()
        {
            txtTotal.Clear();
            nUDCantidad.Text = "0";
            txtPrecio_Unitario.Clear();
            txtDescripción.Clear();
            
        }

        private void txtNum_factura_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecio_Unitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else
            {
                Total();
            }
        }
    }
}
