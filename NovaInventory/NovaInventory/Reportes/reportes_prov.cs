using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaInventory.Reportes
{
    public partial class reportes_prov : Form
    {
        public reportes_prov()
        {
            InitializeComponent();
        }

        private void reportes_prov_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_proveedor.tbproveedor' Puede moverla o quitarla según sea necesario.
            this.tbproveedorTableAdapter.Fill(this.DataSet_proveedor.tbproveedor);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        
        }
    }
}
