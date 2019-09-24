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

            Cargar_producto();
            Cargar_marca_producto();
            forma_pago();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Agregarproducto()
        {
            if (cmb_proveedor.Text.Trim() == "" ||
                txt_codigo_art.Text.Trim() == "" || cmb_estados.Text.Trim() == "" ||
                cmb_productos.Text.Trim() == "" )
            {
                MessageBox.Show("COMPLETE TODOS LOS DATOS", "FALTA INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                agregar.nombre_articulo = cmb_proveedor.Text;
               // agregar.codigo_articulo_seriado = txt_modelos.Text;
                agregar.marca = cmb_estados.Text;
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
            cmb_proveedor.SelectedValue = "1";
           // txt_modelos.Clear();
            txt_codigo_art.Clear();
            cmb_estados.SelectedValue = "1";
            //dateTimePicker_fecha.SelectedValue = "1";
           // txt_categoria.Clear();
            cmb_productos.SelectedValue = "1";
        }
        public void ModificarRegistro_de_producto()
        {
            actualizar.id_articulo = Convert.ToInt32(id_articulo.Text);
            actualizar.nombre_articulo = cmb_proveedor.Text;
          //  actualizar.codigo_articulo_seriado = txt_modelos.Text;
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
            cmb_proveedor.Text = this.dgvproducto[1, posicion].Value.ToString();
           // txt_modelos.Text = this.dgvproducto[2, posicion].Value.ToString();
            txt_codigo_art.Text = this.dgvproducto[3, posicion].Value.ToString();
            cmb_estados.Text = this.dgvproducto[4, posicion].Value.ToString();
            //dateTimePicker_fecha.Text = this.dgvproducto[5, posicion].Value.ToString();
            //txt_categoria.Text = this.dgvproducto[5, posicion].Value.ToString();
            cmb_productos.Text = this.dgvproducto[6, posicion].Value.ToString();
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
        void Cargar_producto()
        {
            cmb_proveedor.DataSource = Funciones_producto.Cargar_producto();
            cmb_proveedor.DisplayMember = "nombre_articulo";
            cmb_proveedor.ValueMember = "id_articulo";
        }
        void Cargar_marca_producto()
        {
            //combxmarca.DataSource = Funciones_producto.Cargar_marca_producto();
            //combxmarca.DisplayMember = "Estado_usuario";
            //combxmarca.ValueMember = "id_estado_usuario";
        }
        void forma_pago()
        {
            //combx_producto.DataSource = Funciones_producto.forma_pago();
            //combx_producto.DisplayMember = "tipo_pago";
           // combx_producto.ValueMember = "id_tipo_pago";
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
