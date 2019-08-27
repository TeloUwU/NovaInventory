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
        Form currentForm;
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            PanelSidebar.Visible = false;
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
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()

        {
            Form formulario;
            formulario = PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    PanelContenedor.Controls.Remove(currentForm);
                }
                currentForm = formulario;
                PanelContenedor.Controls.Add(formulario);
                PanelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmFacturacion>();
        }

        private void btnCerrar_Principal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Principal_Click(object sender, EventArgs e)
        {
            btnMaximizar_Principal.Visible = false;
            btnVentana_Principal.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Principal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVentana_Principal_Click(object sender, EventArgs e)
        {
            btnMaximizar_Principal.Visible = true;
            btnVentana_Principal.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void lblNombres_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void lblApellidos_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void PanelContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
