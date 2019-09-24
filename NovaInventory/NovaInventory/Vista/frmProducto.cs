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
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            MostrarProducto();

            btnactualizar_producto.Enabled = false;
            btneliminar_producto.Enabled = false;

            //Cargar_producto();
            //Cargar_marca_producto();
            //forma_pago();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Agregarproducto()
        {
            if (cmb_proveedor.Text.Trim() == "" || txt_marca.Text.Trim() == "" ||
                txt_codigo_art.Text.Trim() == "" || cmb_estados.Text.Trim() == "" ||
                Cmb_bodegas.Text.Trim() == "" || txt_serie.Text.Trim() == "" ||
                cmb_productos.Text.Trim() == "" || cmb_estados.Text.Trim()=="" )
            {
                MessageBox.Show("COMPLETE TODOS LOS DATOS", "FALTA INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                agregar.codigo_articulo = txt_codigo_art.Text;
                agregar.marca = txt_marca.Text;
                agregar.seriado = txt_serie.Text;
                agregar.id_bodegas = Convert.ToInt16(Cmb_bodegas.SelectedValue);
                agregar.id_categorias = Convert.ToInt16(comboBox2.SelectedValue);
                agregar.id_modelos = Convert.ToInt16(comboBox1.SelectedValue);
                agregar.id_productos = Convert.ToInt16(cmb_productos.SelectedValue);
                agregar.id_proveedorehs = Convert.ToInt16(cmb_proveedor.SelectedValue);
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
            actualizar.codigo_articulo = txt_codigo_art.Text;
            actualizar.marca = txt_marca.Text;
            actualizar.seriado = txt_serie.Text;
            actualizar.id_bodegas = Convert.ToInt16(Cmb_bodegas.SelectedValue);
            actualizar.id_categorias = Convert.ToInt16(comboBox2.SelectedValue);
            actualizar.id_modelos = Convert.ToInt16(comboBox1.SelectedValue);
            actualizar.id_productos = Convert.ToInt16(cmb_productos.SelectedValue);
            actualizar.id_proveedorehs = Convert.ToInt16(cmb_proveedor.SelectedValue);
            actualizar.marca = cmb_estados.Text;
            
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_proveedor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void combxmarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_estados.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void combxforma_de_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_productos.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void cargar_proveedor()
        {
            cmb_proveedor.DataSource = Funciones_producto.Cargar_producto();
            cmb_proveedor.DisplayMember = "nombre_articulo";
            cmb_proveedor.ValueMember = "id_articulo";
        }
        void cargar_Estado()
        {
            cmb_estados.DataSource = Funciones_usuarios.cargar();
            cmb_estados.DisplayMember = "Estado";
            cmb_estados.ValueMember = "id_estado";
        }
        void cargar_productos()
        {
            //cmb_estados.DataSource = Funciones_usuarios.();
            //cmb_estados.DisplayMember = "Estado";
            //cmb_estados.ValueMember = "id_estado";

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
    }
}
