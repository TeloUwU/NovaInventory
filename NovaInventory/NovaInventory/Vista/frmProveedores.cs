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
using NovaInventory.Reportes;

namespace NovaInventory.Vista
{
    public partial class frmProveedores : Form

    {
        string uno = Constructor_login.nombre;
        Constructor_proveedor agre = new Constructor_proveedor();
        Constructor_proveedor act = new Constructor_proveedor();
        public frmProveedores()
        {
            InitializeComponent();
        }
        void agregarpro()
        {
            agre.nombre = txtnombre.Text;
            agre.nit = txtNIt.Text;
            agre.rubro = txtRubro.Text;
            agre.id_estados = Convert.ToInt16(cbEstado.SelectedValue.ToString());
            agre.telefono = txtTelefono.Text;
            agre.direccion = txtdireccion.Text;
            agre.Creado_por = uno;
            int retorno = Control_de_proveedores.agregar_usu(agre);
            cbEstado.Enabled = false;

        }
        void limpro()
        {
            txtnombre.Clear();
            txtRubro.Clear();
            txtTelefono.Clear();
            txtNIt.Clear();
            txtdireccion.Clear();
        }
        void mostrar()
        {
            dataGridView1.DataSource = Control_de_proveedores.mostrar_pro();
            cbEstado.Enabled = false;

        }

        void actuali()
        {
            act.id_proveedor = Convert.ToInt16(txtid_proveedor.Text);
            act.nombre = txtnombre.Text;
            act.direccion = txtdireccion.Text;
            act.telefono = txtTelefono.Text;
            act.nit = txtNIt.Text;
            act.rubro = txtRubro.Text;
            act.id_estados =Convert.ToInt16(cbEstado.SelectedValue.ToString());
            Control_de_proveedores.actualizarusu(act);
            cbEstado.Enabled = false;

        }
        void tocar()
        {
            int posision;
            posision = this.dataGridView1.CurrentRow.Index;
            txtid_proveedor.Text = this.dataGridView1[0, posision].Value.ToString();
            txtnombre.Text = this.dataGridView1[1, posision].Value.ToString();
            txtdireccion.Text = this.dataGridView1[2, posision].Value.ToString();
            txtTelefono.Text = this.dataGridView1[3, posision].Value.ToString();
            txtNIt.Text = this.dataGridView1[4, posision].Value.ToString();
            txtRubro.Text = this.dataGridView1[5, posision].Value.ToString();

            cbEstado.Enabled = true;


        }
        void eliminar()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el proveedor?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Control_de_proveedores.eliminar(Convert.ToInt32(txtid_proveedor.Text));
            }
            cbEstado.Enabled = false;

        }
        private void frmProveedores_Load(object sender, EventArgs e)
        {
            txt_creado_por.Text = uno;
            txt_creado_por.Enabled = false;
            cbEstado.Enabled = false;
            mostrar();
            cbEstado.DataSource = Control_de_proveedores.cargar();
            cbEstado.DisplayMember = "Estado";
            cbEstado.ValueMember = "id_estado";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actuali();
            limpro();
            mostrar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarpro();
            limpro();
            mostrar();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tocar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            limpro();
            mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportes_prov ne = new reportes_prov();
            ne.Show();
            this.Hide();
        }
    }
}
