using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaInventory.Controlador;
using NovaInventory.Modelo;

namespace NovaInventory.Vista
{
    public partial class frmProducto : Form
    {

        Constructor_producto agregar = new Constructor_producto();
        Constructor_producto actualizar = new Constructor_producto();

        public static int idiom;
        public frmProducto()
        {
            InitializeComponent();
        }

        public void ingles()
        {

            if (idiom == 1)
            {
                toolStripLabel1.Text = idioma.ingles.toolStripLabel1;
                id_proveedor.Text = idioma.ingles.id_proveedor;
                lblfecha.Text = idioma.ingles.lblfecha;
                lblforma_de_pago.Text = idioma.ingles.lblforma_de_pago;
                lblcodigo_producto_seriado.Text = idioma.ingles.lblcodigo_producto_seriado;
                id_categoria.Text = idioma.ingles.id_categoria;
                lblproveedores.Text = idioma.ingles.lblproveedores;
                lblprecio.Text = idioma.ingles.lblprecio;
                label2.Text = idioma.ingles.label2;
                label1.Text = idioma.ingles.label1;
                btnAgregar_producto.Text = idioma.ingles.btnAgregar_producto;
                btn_mostrar.Text = idioma.ingles.btn_mostrar;
                btnactualizar_producto.Text = idioma.ingles.btnactualizar_producto;
                btneliminar_producto.Text = idioma.ingles.btneliminar_producto;
                chkenglish.Text = idioma.ingles.chkenglish;
                
            }
            else
            {
                toolStripLabel1.Text = ("Artículos");
                id_proveedor.Text = ("Proveedores:");
                lblfecha.Text = ("Estado:");
                lblforma_de_pago.Text = ("Productos");
                lblcodigo_producto_seriado.Text = ("Bodegas");
                id_categoria.Text = ("Categoria");
                lblproveedores.Text = ("Codigo Artículo");
                lblprecio.Text = ("Modelos:");
                label2.Text = ("Marca:");
                label1.Text = ("Seriado");
                btnAgregar_producto.Text = ("Agregar Artículo");
                btn_mostrar.Text = ("Mostrar Artículo");
                btnactualizar_producto.Text = ("Actualizar Artículo");
                btneliminar_producto.Text = ("Eliminar Artículo");
                chkenglish.Text = ("English Language");
            }

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            MostrarProducto();


            btnactualizar_producto.Enabled = false;
            btneliminar_producto.Enabled = false;
            //txt_serie.Enabled = false;

            cmb_proveedor.DataSource = Funciones_producto.Cargarproveedor();
            cmb_proveedor.DisplayMember = "nombre";
            cmb_proveedor.ValueMember = "id_proveedor";
 
            cmb_estados.DataSource = Funciones_producto.Cargar_estado();
            cmb_estados.DisplayMember = "Estado";
            cmb_estados.ValueMember = "id_estado";

            cmb_productos.DataSource = Funciones_producto.productos();
            cmb_productos.DisplayMember = "producto";
            cmb_productos.ValueMember = "id_producto";

            Cmb_bodegas.DataSource = Funciones_producto.bodega();
            Cmb_bodegas.DisplayMember = "nombre_bodega";
            Cmb_bodegas.ValueMember = "id_bodega";

            comboBox2.DataSource = Funciones_producto.Categoria();
            comboBox2.DisplayMember = "categoria";
            comboBox2.ValueMember = "id_categoria";

            comboBox1.DataSource = Funciones_producto.modelo();
            comboBox1.DisplayMember = "modelo";
            comboBox1.ValueMember = "id_modelo";


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Agregarproducto()
        {
            if (cmb_proveedor.Text.Trim() == "" || txt_marca.Text.Trim() == "" ||
                txt_codigo_art.Text.Trim() == "" || cmb_estados.Text.Trim() == "" ||
                Cmb_bodegas.Text.Trim() == "" ||
                cmb_productos.Text.Trim() == "" || cmb_estados.Text.Trim()=="" )
            {
                MessageBox.Show("COMPLETE TODOS LOS DATOS", "FALTA INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                agregar.id_proveedorehs = Convert.ToInt16(cmb_proveedor.SelectedValue);
                agregar.id_categorias = Convert.ToInt16(comboBox2.SelectedValue);
                agregar.codigo_articulo = txt_codigo_art.Text;
               agregar.id_productos = Convert.ToInt16(cmb_productos.SelectedValue);
                agregar.marca = txt_marca.Text;
                agregar.id_modelos = Convert.ToInt16(comboBox1.SelectedValue);
                agregar.seriado = txt_serie.Text;
                agregar.id_estadoss = Convert.ToInt16(cmb_estados.SelectedValue);
                agregar.id_bodegas = Convert.ToInt16(Cmb_bodegas.SelectedValue);
               
             
                int datos = Funciones_producto.Ingresar_Producto(agregar);
            }
        }
        public void MostrarProducto()
        {
            dgvproducto.DataSource = Funciones_producto.Mostrar_Producto();
        }
        public void LimpiarCampos()
        {
            id_articulo.Clear();
           
            txt_marca.Clear();
            txt_codigo_art.Clear();
            txt_serie.Clear();
        }
        public void ModificarRegistro_de_producto()
        {
            actualizar.id_articulo = Convert.ToInt32(id_articulo.Text);
            actualizar.id_proveedorehs = Convert.ToInt16(cmb_proveedor.SelectedValue);
            actualizar.id_categorias = Convert.ToInt16(comboBox2.SelectedValue);
            actualizar.codigo_articulo = txt_codigo_art.Text;
            actualizar.id_productos = Convert.ToInt16(cmb_productos.SelectedValue);
            actualizar.marca = txt_marca.Text;
            actualizar.id_modelos = Convert.ToInt16(comboBox1.SelectedValue);
            actualizar.seriado = txt_serie.Text;
            actualizar.id_estadoss = Convert.ToInt16(cmb_estados.SelectedValue);
            actualizar.id_bodegas = Convert.ToInt16(Cmb_bodegas.SelectedValue);
            
            Funciones_producto.Actualizar_productos(actualizar);
        }
        public void EliminarRegistro_producto()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el registro del producto?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_producto.Eliminar_productos(Convert.ToInt32(id_articulo.Text));
            }
        }


        private void btnAgregar_producto_Click(object sender, EventArgs e)
        {
            Agregarproducto();
            MostrarProducto();
            LimpiarCampos();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            MostrarProducto();
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvproducto.CurrentRow.Index;
            id_articulo.Text = this.dgvproducto[0, posicion].Value.ToString();
            cmb_proveedor.Text = Convert.ToString(this.dgvproducto[1, posicion].Value.ToString());
            comboBox2.Text = Convert.ToString(this.dgvproducto[2, posicion].Value.ToString());
            txt_codigo_art.Text = this.dgvproducto[3, posicion].Value.ToString();
            cmb_productos.Text = Convert.ToString( this.dgvproducto[4, posicion].Value.ToString());
            txt_marca.Text = this.dgvproducto[5, posicion].Value.ToString();
            comboBox1.Text = Convert.ToString( this.dgvproducto[6, posicion].Value.ToString());
            txt_serie.Text = this.dgvproducto[7, posicion].Value.ToString();
            cmb_estados.Text = Convert.ToString(this.dgvproducto[8, posicion].Value.ToString());
            Cmb_bodegas.Text = Convert.ToString(this.dgvproducto[9, posicion].Value.ToString());
            btnactualizar_producto.Enabled = true;
            btneliminar_producto.Enabled = true;
            btnAgregar_producto.Enabled = false;
        }

        private void btnactualizar_producto_Click(object sender, EventArgs e)
        {
            ModificarRegistro_de_producto();
            ModificarRegistro_de_producto();
            btnactualizar_producto.Enabled = false;
            btneliminar_producto.Enabled = false;
            btnAgregar_producto.Enabled = true;
            MostrarProducto();
        }

        private void btneliminar_producto_Click(object sender, EventArgs e)
        {
            EliminarRegistro_producto();
            LimpiarCampos();
            MostrarProducto();
            btnactualizar_producto.Enabled = false;
            btneliminar_producto.Enabled = false;
            btnAgregar_producto.Enabled = true;
        }

  

        private void combxforma_de_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_productos.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void lblproducto_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblprecio_Click(object sender, EventArgs e)
        {

        }

        private void chkenglish_CheckedChanged(object sender, EventArgs e)
        {
            if (chkenglish.Checked == true)
            {
                idiom = 1;
            }
            else
            {
                idiom = 0;
            }
            ingles();
        }

        private void txt_serie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
