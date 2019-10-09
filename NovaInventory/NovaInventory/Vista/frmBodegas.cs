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
    public partial class frmBodegas : Form
    {
        public static int idiom;
        public frmBodegas()
        {
            InitializeComponent();
        }
       
        string jj = Constructor_login.nombre;
        Constructor_bodega actu = new Constructor_bodega();
        void agre()
        {
            Constructor_bodega agrega = new Constructor_bodega();
            agrega.codigo_bodega = txtCodigo_Bodega.Text;
            agrega.nombre_bodega = txtNombre_Bodega.Text;
            agrega.direccion = txtDirección.Text;
            agrega.fecha_alta = dateTimePicker1.Text;
            agrega.creado_por = jj;
            agrega.id_estado = Convert.ToInt16(cbEstado_Bodega.SelectedValue);
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
            actu.id_estado = Convert.ToInt16(cbEstado_Bodega.SelectedValue);
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

        public void ingles()
        {

            if (idiom == 1)
            {
                toolStripButton1.Text = idioma.ingles.Gestion_bodegas;
                chkGestion_bodega.Text = idioma.ingles.chkenglish;
                toolStripButton2.Text = idioma.ingles.StringCerrar;
                label2.Text = idioma.ingles.Codigo_bodega;
                label3.Text = idioma.ingles.estado;
                button5.Text = idioma.ingles.Reporte;
                label1.Text = idioma.ingles.Direccion;
                label4.Text = idioma.ingles.Nombre;
                fecha.Text = idioma.ingles.label6;
                button1.Text = idioma.ingles.Agregar_bodega;
                button2.Text = idioma.ingles.Ver_bodega;
                button3.Text = idioma.ingles.Actualizar_bodega;
                button4.Text = idioma.ingles.Eliminar_bodega;


            }
            else
            {
                toolStripButton1.Text = ("Gestion de Bodegas");
                chkGestion_bodega.Text = ("English Language:");
                toolStripButton2.Text = ("Cerrar Formulario");
                label2.Text = ("Codigo de Bodega");
                label3.Text = ("Estado");
                button5.Text = ("Reporte");
                label1.Text = ("Dirección");
                label4.Text = ("Nombre:");
                fecha.Text = ("Creado Por:");
                button1.Text = ("Agregar Bodega");
                button2.Text = ("Ver Bodega ");
                button3.Text = ("Actualizar Bodega ");
                button4.Text = ("Eliminar Bodega ");


            }
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
            cbEstado_Bodega.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agre();
            mostra();
            cbEstado_Bodega.Enabled = false;

            lim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostra();
            cbEstado_Bodega.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizar();
            lim();
            cbEstado_Bodega.Enabled = false;

            mostra();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eli();
            cbEstado_Bodega.Enabled = false;

            lim();
            mostra();
            
        }

        private void dgvBodegas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toca();
            cbEstado_Bodega.Enabled = true;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmPrincipal no = new FrmPrincipal();
            no.Show();
            this.Hide();
        }

        private void txtCodigo_Bodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_bodega ny = new frm_bodega();
            ny.Show();
            this.Hide();
        }

        private void chkGestion_bodega_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGestion_bodega.Checked == true)
            {
                idiom = 1;
            }
            else
            {
                idiom = 0;
            }
            ingles();

        }
    }
}
