using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaInventory.Modelo;
using NovaInventory.Controlador;

namespace NovaInventory.Vista
{
    public partial class frmProveedores : Form
    {
        Constructor_proveedor agregar = new Constructor_proveedor();
        Constructor_proveedor actualizar = new Constructor_proveedor();
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            Mostrar_proveedor();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            cbEstado.DataSource = Control_de_proveedores.cargar();
            cbEstado.DisplayMember = "Estado";
            cbEstado.ValueMember = "id_estado";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
            ModificarRegistro();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;
            Mostrar_proveedor();
        }

        public void Agregar_proveedor()
        {
            if (txtnombre.Text.Trim() == "" || txtRubro.Text.Trim() == "" ||
                txtNIt.Text.Trim() == "" || txtTelefono.Text.Trim() == "" )
            {
                MessageBox.Show("COMPLETE TODOS LOS DATOS", "FALTA INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                agregar.nombre = txtnombre.Text;
                agregar.rubro = txtRubro.Text;
                agregar.nit = txtNIt.Text;
                agregar.telefono = txtTelefono.Text;
                int datos = Control_de_proveedores.agregar_usu(agregar);
            }
        }
        public void Mostrar_proveedor()
        {
            dataGridView1.DataSource = Control_de_proveedores.Mostrar_proveedor();
        }
        public void LimpiarCampos()
        {
            txtid_proveedor.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txtNIt.Clear();
            txtRubro.Clear();
            txtTelefono.Clear();
        }
        public void ModificarRegistro()
        {
            actualizar.id_proveedor = Convert.ToInt32(txtid_proveedor.Text);
            actualizar.nombre = txtnombre.Text;
            actualizar.direccion = txtdireccion.Text;
            actualizar.nit = txtNIt.Text;
            actualizar.rubro = txtRubro.Text;
            actualizar.telefono = txtTelefono.Text;
            Control_de_proveedores.Actualizar_proveedor(actualizar);
        }
        public void EliminarRegistro()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Control_de_proveedores.Eliminarproveedor(Convert.ToInt32(txtid_proveedor.Text));
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_proveedor();
            Mostrar_proveedor();
            LimpiarCampos();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Mostrar_proveedor();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dataGridView1.CurrentRow.Index;
            txtid_proveedor.Text = this.dataGridView1[0, posicion].Value.ToString();
            txtnombre.Text = this.dataGridView1[1, posicion].Value.ToString();
            txtdireccion.Text = this.dataGridView1[2, posicion].Value.ToString();
            txtNIt.Text = this.dataGridView1[3, posicion].Value.ToString();
            txtRubro.Text = this.dataGridView1[4, posicion].Value.ToString();
            txtTelefono.Text = this.dataGridView1[5, posicion].Value.ToString();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
            LimpiarCampos();
            Mostrar_proveedor();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;
        }
    }
}
