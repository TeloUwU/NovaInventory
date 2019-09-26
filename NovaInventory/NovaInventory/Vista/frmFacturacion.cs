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
        constructorFacturacion agregar = new constructorFacturacion();
        constructorFacturacion actualizar = new constructorFacturacion();
        public frmFacturacion()
        {
            InitializeComponent();
        }
        
       

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            
        }

        public void agregar_factura()
        {

        }
        


        public void CostoApagar()
        {
            
            
        }




        private void frmFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarLista_Click_1(object sender, EventArgs e)
        {
            

        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

