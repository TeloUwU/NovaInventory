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
    public partial class FrmPrimerUso : Form
    {
        public FrmPrimerUso()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            /*Hay que validar boton para que cuando se registre la empresa
             se pueda activar el groupbox de telefono, donde inicialmente el groupbox
             de telefono estará inhabilitado.*/
            grpContactos.Enabled = true;
        }

        private void FrmPrimerUso_Load(object sender, EventArgs e)
        {
            grpContactos.Enabled = false;
        }
    }
}
