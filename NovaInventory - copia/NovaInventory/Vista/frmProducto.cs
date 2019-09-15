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
            if (combx_producto.Text.Trim() == "" || txtcodigo_producto.Text.Trim() == "" ||
                txtproveedores.Text.Trim() == "" || combxmarca.Text.Trim() == "" ||
                dateTimePicker_fecha.Text.Trim() == "" || txt_precio.Text.Trim() == "" ||
                combxforma_de_pago.Text.Trim() == "" )
            {
                MessageBox.Show("COMPLETE TODOS LOS DATOS", "FALTA INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                agregar.nombre_articulo = combx_producto.Text;
                agregar.codigo_articulo_seriado = txtcodigo_producto.Text;
                agregar.marca = combxmarca.Text;
                int datos = Funciones_producto.Ingresar_Producto(agregar);
            }
        }
        public void MostrarProducto()
        {
            dgvproducto.DataSource = Funciones_producto.Mostrar_Producto();
        }
        public void LimpiarCampos()
        {
            id_producto.Clear();
            combx_producto.SelectedValue = "1";
            txtcodigo_producto.Clear();
            txtproveedores.Clear();
            combxmarca.SelectedValue = "1";
            //dateTimePicker_fecha.SelectedValue = "1";
            txt_precio.Clear();
            combxforma_de_pago.SelectedValue = "1";
        }
        public void ModificarRegistro_de_producto()
        {
            actualizar.id_articulo = Convert.ToInt32(id_producto.Text);
            actualizar.nombre_articulo = combx_producto.Text;
            actualizar.codigo_articulo_seriado = txtcodigo_producto.Text;
            actualizar.marca = combxmarca.Text;
            
            Funciones_producto.Actualizar_productos(actualizar);
        }
        public void EliminarRegistro_producto()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el registro del producto?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_producto.Eliminar_productos(Convert.ToInt32(id_producto.Text));
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
            id_producto.Text = this.dgvproducto[0, posicion].Value.ToString();
            combx_producto.Text = this.dgvproducto[1, posicion].Value.ToString();
            txtcodigo_producto.Text = this.dgvproducto[2, posicion].Value.ToString();
            txtproveedores.Text = this.dgvproducto[3, posicion].Value.ToString();
            combxmarca.Text = this.dgvproducto[4, posicion].Value.ToString();
            dateTimePicker_fecha.Text = this.dgvproducto[5, posicion].Value.ToString();
            txt_precio.Text = this.dgvproducto[5, posicion].Value.ToString();
            combxforma_de_pago.Text = this.dgvproducto[6, posicion].Value.ToString();
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
            combx_producto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void combxmarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            combxmarca.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void combxforma_de_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            combxforma_de_pago.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void Cargar_producto()
        {
            combx_producto.DataSource = Funciones_producto.Cargar_producto();
            combx_producto.DisplayMember = "nombre_articulo";
            combx_producto.ValueMember = "id_articulo";
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
