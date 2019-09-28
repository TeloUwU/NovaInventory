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
    public partial class frm_usuarios_report : Form
    {
        public frm_usuarios_report()
        {
            InitializeComponent();
        }

        private void frm_usuarios_report_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'data_usu.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.data_usu.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
