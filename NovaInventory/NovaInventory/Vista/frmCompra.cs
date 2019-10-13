using MySql.Data.MySqlClient;
using NovaInventory.Config;
using NovaInventory.idioma;
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
        public static int idiom;

        constructor_Compra agregar = new constructor_Compra();

        constructor_Compra actualizar = new constructor_Compra();

        ConstructorExistencias_Inventario Ingr = new ConstructorExistencias_Inventario();

        ConstructorExistencias_Inventario Act = new ConstructorExistencias_Inventario();




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
            dgvCompras.Columns[1].Visible = false;
            dgvCompras.Columns[5].HeaderText = "Precio Unitario";
            dgvCompras.Columns[6].HeaderText = "Precio Total";
            dgvCompras.Columns[8].HeaderText = "Fecha de Compra";
            dgvCompras.Columns[9].HeaderText = "Usuario Comprador";
            dgvCompras.Columns[10].HeaderText = "Tipo de Pago";
            dgvCompras.Columns[11].HeaderText = "Numero de Factura";
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

        private void CargarBodega()
        {
            cbBodega.DataSource = crudCompra.Bodega();
            cbBodega.DisplayMember = "id_bodega";
            cbBodega.ValueMember = "bodegas";
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
                agregar.id_producto = Convert.ToInt16(txtid_articulo.Text);
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

        
        
            //int NumProd = Convert.ToInt16("SELECT cantidad FROM existencias_inventario;");
            //int PrecioUnitario = Convert.ToInt16("SELECT Precio_unitario FROM existencias_inventario;");
            //int TotalInvertido = Convert.ToInt16("SELECT Precio_total FROM existencias_inventario;");
        


        

        public void AgregarExistencia()
        {
            //int nuevoNumProd = Convert.ToInt16(NumProd + nUDCantidad.Value);
            //int nuevoPrecioTotal = Convert.ToInt16(TotalInvertido + txtTotal.Text);
            //string nuevoPrecio = Convert.ToString(nuevoPrecioTotal / nuevoNumProd);
            Ingr.id_articuloss = Convert.ToInt16(txtid_articulo.Text);
            Ingr.id_bodega = Convert.ToInt16(cbBodega.Text);
            Ingr.serie = Convert.ToString(txtNumeroSerie.Text);
            //Ingr.cantidad = nuevoNumProd;
            //Ingr.Precio_unitario = Convert.ToInt16(nuevoPrecio);
            //Ingr.Precio_total = nuevoPrecioTotal;
            Ingr.Desde = Convert.ToString(dtpRealización_Compra);

            
        }

        public void ActualizarExistencia()
        {
            Act.Hasta = Convert.ToString(dtpRealización_Compra.Text);
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

        public int Validarproducto()
        {
            int retorno = 0;
            try
            {

                MySqlCommand existe = new MySqlCommand(string.Format("SELECT id_exixtencia_inventario FROM existencias_inventario WHERE id_articuloss = '" + txtid_articulo + "';"), Conexion.obtenerconexion());
                retorno = Convert.ToInt16(existe.ExecuteScalar());
                if (retorno >= 1)
                {
                    ActualizarExistencia();
                    AgregarExistencia();
                }
                else
                {
                    AgregarExistencia();   
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no se ha ingresado ni actualizado en la base de datos" + ex, "Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return retorno;
            }
        }

        

        private void cbProducto_Compra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void nUDCantidad_ValueChanged(object sender, EventArgs e)
        {
            Total();
        }

        
        
        

        public void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

   

      

        

    public void Total()
        {
            

            if (txtPrecio_Unitario.Text == "")
            {
                txtPrecio_Unitario.Text = "0";
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
            mostrarcComprass();
            
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Total();
            
        }

        public void mostrarcComprass()
        {
            int posicion;
            posicion = this.dgvCompras.CurrentRow.Index;
            txtid_Compra.Text = dgvCompras[0, posicion].Value.ToString();
            txtid_usuario.Text = dgvCompras[1, posicion].Value.ToString();
            txtid_proveedor.Text = dgvCompras[2, posicion].Value.ToString();
            txtid_producto.Text = dgvCompras[3, posicion].Value.ToString();
            txtid_modelo.Text = dgvCompras[4, posicion].Value.ToString();
            txtDescripción.Text = dgvCompras[5, posicion].Value.ToString();
            txtPrecio_Unitario.Text = dgvCompras[6, posicion].Value.ToString();
            txtTotal.Text = dgvCompras[7, posicion].Value.ToString();
            nUDCantidad.Text = dgvCompras[8, posicion].Value.ToString();
            dtpRealización_Compra.Text = dgvCompras[9, posicion].Value.ToString();
            txtUsuario_queCompro.Text = dgvCompras[10, posicion].Value.ToString();
            txtid_tipopago.Text = dgvCompras[11, posicion].Value.ToString();
            txtNum_factura.Text = dgvCompras[12, posicion].Value.ToString();

            btnActualizar_Compra.Enabled = true;

            txtUsuario_queCompro.Visible = true;
            lblUsuarioCOmpro.Visible = true;
        }

        

        private void btnActualizar_Compra_Click(object sender, EventArgs e)
        {
            actualizar.id_compra = Convert.ToInt16(txtid_Compra.Text);
            actualizar.id_usuario_mod = Convert.ToInt16(txtid_usuario.Text);
            actualizar.precio_unitario_mod = Convert.ToInt16(txtPrecio_Unitario.Text);
            actualizar.total_mod = Convert.ToInt16(txtTotal.Text);
            actualizar.cantidad_mod = Convert.ToInt16(nUDCantidad.Value);

            bool datos = crudCompra.ActualizarCompra(actualizar);
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
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecio_Unitario_TextChanged(object sender, EventArgs e)
        {
            Total();
        }

        public void ingle()
        {
            if (idiom == 1)
            {

                label1.Text = idioma.ingles.bt_pro;
                label4.Text = idioma.ingles.btn_productos;
                label2.Text = idioma.ingles.nose_mo;
                label10.Text = idioma.ingles.hola;
                label3.Text = idioma.ingles.barraza;
                label5.Text = idioma.ingles.andrea;
                label6.Text = idioma.ingles.maria;
                label8.Text = idioma.ingles.turcios;
                lblUsuarioCOmpro.Text = idioma.ingles.barquero;
                label9.Text = idioma.ingles.btn_bo;
                btnAgregarCompra.Text = idioma.ingles.sandor;
                btnMostrar.Text = idioma.ingles.brix;
                btnActualizar_Compra.Text = idioma.ingles.sara;
                toolStripButton2.Text = idioma.ingles.toolStripButton2;
                toolStripButton1.Text = idioma.ingles.garcia;
                button4.Text = idioma.ingles.verkardEX;
            }
            else
            {
                label1.Text = ("Proveedor");
                label4.Text = ("Producto");
                label2.Text = ("Modelo");
                label10.Text = ("Tipo de Pago");
                label3.Text = ("Numero de Serie");
                label5.Text = ("Cantidad");
                label6.Text = ("Precio Unitario");
                label8.Text = ("Descripción");
                lblUsuarioCOmpro.Text = ("Usuario que realizo la Compra");
                label9.Text = ("Bodega Contenedora");
                toolStripButton2.Text = ("Cerrar Formulario");
                toolStripButton1.Text = ("Formulario Compras");
                btnAgregarCompra.Text = ("Hacer Compra");
                btnMostrar.Text = ("Mostrar Compras");
                btnActualizar_Compra.Text = ("Actualizar Compra");
                button4.Text = ("Ver Kardex");
            }

        }

        private void chkcompras_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcompras.Checked == true)
            {
                idiom = 1;
            }
            else
            {
                idiom = 0;
            }
            ingle();
        }
    }
}
