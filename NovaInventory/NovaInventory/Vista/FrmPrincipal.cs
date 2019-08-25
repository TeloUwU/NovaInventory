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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            PanelSidebar.Visible = false;
            btnAdministrar_Empresas.Visible = false;
            btnConfig_Root.Visible = false;
        }

        private void panelDeNavegaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PanelSidebar.Visible == true)
            {
                PanelSidebar.Visible = false;
                panelDeNavegaciónToolStripMenuItem.Text = "Mostrar panel de navegación";
            }
            else
            {
                PanelSidebar.Visible = true;
                panelDeNavegaciónToolStripMenuItem.Text = "Ocultar panel de navegación";
            }
            
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show("Esta seguro que desea cerrar la aplicación?", "Salir del programa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Confirmacion == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnConfiguación_Sistema_Click(object sender, EventArgs e)
        {
            if (btnAdministrar_Empresas.Visible == true && btnConfig_Root.Visible == true)
            {
                btnAdministrar_Empresas.Visible = false;
                btnConfig_Root.Visible = false;

            }
            else
            {
                btnConfig_Root.Visible = true;
                btnAdministrar_Empresas.Visible = true;
                btnAdministrar_Empresas.Location = new Point(23, 527);
                btnConfig_Root.Location = new Point(23, 461);

            }
        }

        private void btnConfig_Root_Click(object sender, EventArgs e)
        {

        }
    }
}
