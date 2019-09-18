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
    public partial class reporte_usu : Form
    {
        public reporte_usu()
        {
            InitializeComponent();
        }

        private void reporte_usu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet4.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DataSet4.DataTable);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {


        }
    }
}
