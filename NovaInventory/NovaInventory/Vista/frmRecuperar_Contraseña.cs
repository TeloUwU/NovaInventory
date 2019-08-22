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
    public partial class frmRecuperar_Contraseña : Form
    {
        public frmRecuperar_Contraseña()
        {
            InitializeComponent();
        }

        private void pbCorreo_Recu_Click(object sender, EventArgs e)
        {

        }

        private void pbPreguntas_Recu_Click(object sender, EventArgs e)
        {
            frmPreguntasSeguridad_RecuperarContra pregunta = new frmPreguntasSeguridad_RecuperarContra();
            pregunta.Show();
            this.Hide();
        }
    }
}
