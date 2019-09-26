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
using NovaInventory.Vista;

namespace NovaInventory.Vista
{
    public partial class frmFacturacion : Form
    {
        public frmFacturacion()
        {
            InitializeComponent();
        }
        string[,] ListaVenta = new string[200, 6];
        int Fila = 0;
       

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            
        }

        public void agregar_factura()
        {


        }

        /// <summary>


        public void CostoApagar()
        {
        }




        private void frmFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            
            
        }
        string jj = Constructor_login.usuario;
        CONSTRUCTORDEFACTURA actu = new CONSTRUCTORDEFACTURA();
        void agregar()
        {
            CONSTRUCTORDEFACTURA agrega = new CONSTRUCTORDEFACTURA();

            agrega.Cantidad = txtCantidad.Text;
            agrega.CostoDetalle = textBox6.Text;
            agrega.Fecha = dtPick.Text;
            agrega.Nombre = dtPick.Text;
            agrega.creado_por = jj;
            int retorno = control_facturacion.agregar_fac(agrega);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarLista_Click_1(object sender, EventArgs e)
        {
            double r, n1, n2;

            n1 = Convert.ToInt16(textBox6.Text);
            n2 = Convert.ToInt16(txtCantidad.Text);
            r = (n1 * n2);
            lblCostoAPagar.Text = Convert.ToString(r);

            agregar();

        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        void actualizar()
        {
            actu.id_factura = Convert.ToInt16(textBox2.Text);
            actu.Nombre = txtNombre.Text;
            actu.CostoDetalle = textBox6.Text;
            actu.Cantidad = txtCantidad.Text;
            actu.Fecha = dtPick.Text;
            actu.creado_por = textBox3.Text;
            actu.id_estado = Convert.ToInt16(cbEstado_Fac.SelectedValue);
            control_facturacion.actualizarfac(actu);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmInventarioExistencias frm = new frmInventarioExistencias();
            frm.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        void eliminar()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el detalle?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                control_facturacion.eliminar(Convert.ToInt32(txtIdArticulo.Text));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
    }

