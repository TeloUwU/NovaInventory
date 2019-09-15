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
    public partial class frmBodegas : Form
    {
        public frmBodegas()
        {
            InitializeComponent();
        }
       
        string jj = Constructor_login.usuario;
        Constructor_bodega actu = new Constructor_bodega();
        void agre()
        {
            Constructor_bodega agrega = new Constructor_bodega();
            agrega.codigo_bodega = txtCodigo_Bodega.Text;
            agrega.nombre_bodega = txtNombre_Bodega.Text;
            agrega.direccion = txtDirección.Text;
            agrega.fecha_alta = dateTimePicker1.Text;
            agrega.creado_por = jj;
            agrega.id_estado = Convert.ToInt16(cbEstado_Bodega.SelectedValue.ToString());
            int retorno = control_de_bodega.agregar_usu(agrega);
        }
        void mostra()
        {
            dgvBodegas.DataSource = control_de_bodega.mostrar_pro();
        }
        void actualizar()
        {
            actu.id_bodega = Convert.ToInt16(txtId_Bodega.Text);
            actu.codigo_bodega = txtCodigo_Bodega.Text;
            actu.nombre_bodega = txtNombre_Bodega.Text;
            actu.direccion = txtDirección.Text;
            actu.fecha_alta = dateTimePicker1.Text;
            actu.id_estado = Convert.ToInt16(cbEstado_Bodega.SelectedValue.ToString());
            control_de_bodega.actualizarusu(actu);
        }
        void eli()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar la bodega?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                control_de_bodega.eliminar(Convert.ToInt32(txtId_Bodega.Text));
            }
        }
        void toca ()
        {
            int posision;
            posision = this.dgvBodegas.CurrentRow.Index;
            txtId_Bodega.Text = this.dgvBodegas[0, posision].Value.ToString();
            txtCodigo_Bodega.Text = this.dgvBodegas[1, posision].Value.ToString();
            txtNombre_Bodega.Text = this.dgvBodegas[2, posision].Value.ToString();
            txtDirección.Text = this.dgvBodegas[3, posision].Value.ToString();
        }
        void lim()
        {
            txtCodigo_Bodega.Clear();
            txtNombre_Bodega.Clear();
            txtDirección.Clear();
        }
        private void frmBodegas_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            mostra();
            txt_creado_por.Text = jj;
            txt_creado_por.Enabled = false;
            cbEstado_Bodega.DataSource = control_de_bodega.cargar();
            cbEstado_Bodega.DisplayMember = "Estado";
            cbEstado_Bodega.ValueMember = "id_estado";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agre();
            mostra();
            lim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostra();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizar();
            lim();
            mostra();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eli();
            lim();
            mostra();
            
        }

        private void dgvBodegas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toca();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmPrincipal no = new FrmPrincipal();
            no.Show();
            this.Hide();
        }
    }
}
