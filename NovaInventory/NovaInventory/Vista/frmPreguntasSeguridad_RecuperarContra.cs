using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaInventory.Vista
{
    public partial class frmPreguntasSeguridad_RecuperarContra : Form
    {
        public frmPreguntasSeguridad_RecuperarContra()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmRecuperar_Contraseña Recuperar = new frmRecuperar_Contraseña();
            Recuperar.Show();
            this.Close();
        }

        private void frmPreguntasSeguridad_RecuperarContra_Load(object sender, EventArgs e)
        {

        }

        private void btnCambiar_Recu_Click(object sender, EventArgs e)
        {

        }
    }
}
