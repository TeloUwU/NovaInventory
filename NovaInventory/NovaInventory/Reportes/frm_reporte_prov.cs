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
    public partial class frm_reporte_prov : Form
    {
        public frm_reporte_prov()
        {
            InitializeComponent();
        }

        private void frm_reporte_prov_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.tbProveedor' Puede moverla o quitarla según sea necesario.
            this.tbProveedorTableAdapter.Fill(this.DataSet1.tbProveedor);
            // TODO: esta línea de código carga datos en la tabla 'DataSet4.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DataSet4.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
