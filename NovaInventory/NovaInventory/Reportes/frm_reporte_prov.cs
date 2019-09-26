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

            this.reportViewer1.RefreshReport();
        }
    }
}
