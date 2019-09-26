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
        //string jj = constructorFacturacion.;
        CONSTRUCTORDEFACTURA actu = new CONSTRUCTORDEFACTURA();
        void agregar()
        {
            CONSTRUCTORDEFACTURA agrega = new CONSTRUCTORDEFACTURA();
            agrega.Cantidad = txtCantidad.Text;
            agrega.CostoDetalle = txtPrecio.Text;
            //agrega. = txtDirección.Text;
            agrega.fecha_alta = dateTimePicker1.Text;
           // agrega.creado_por = jj;
            //agrega.id_estado = Convert.ToInt16(cbEstado_Bodega.SelectedValue);
            //int retorno = txtIdArticulo(agrega);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarLista_Click_1(object sender, EventArgs e)
        {
            agregar();

        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

