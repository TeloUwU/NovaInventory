using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaInventory.Controlador;

namespace NovaInventory.Vista
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        Form currentForm;
        void admin()
        {
            archivoToolStripMenuItem.Visible = false;
            buscarToolStripMenuItem.Visible = false;
            inventarioToolStripMenuItem.Visible = false;
            facturaciónToolStripMenuItem.Visible = false;
            gráficosYReportesToolStripMenuItem.Visible = false;
            button2.Visible = false;
            button4.Visible = true;
            button4.Location = new Point(0, 135);

            button8.Visible = false;
            button7.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button3.Visible = true;
            button3.Location = new Point(0, 177);
            ;
        }
        void bodeguero()
        {
            archivoToolStripMenuItem.Visible = false;
            buscarToolStripMenuItem.Visible = true;
            inventarioToolStripMenuItem.Visible = true;
            facturaciónToolStripMenuItem.Visible = false;
            gráficosYReportesToolStripMenuItem.Visible = false;
            button2.Visible = true;
            button2.Location = new Point(0, 135);
            button4.Visible = false;
            button8.Visible = true;
            button8.Location = new Point(0,177);
            button7.Visible = false;
            button9.Visible = true;
            button9.Location = new Point(0, 219);
            button10.Visible = true;
            button10.Location = new Point(0, 261);
            button5.Visible = false;
            button6.Visible = false;
            button3.Visible = false;
        }
        void caja()
        {
            archivoToolStripMenuItem.Visible = false;
            buscarToolStripMenuItem.Visible = true;
            buscarToolStripMenuItem1.Visible = false;
            agregarProveedorToolStripMenuItem.Visible = false;
            agregarBodegaToolStripMenuItem.Visible = false;
            inventarioToolStripMenuItem.Visible = false;
            facturaciónToolStripMenuItem.Visible = false;
            gráficosYReportesToolStripMenuItem.Visible = false;
            button2.Visible = true;
            button2.Location = new Point(0, 135);
            button4.Visible = false;
            button8.Visible = false;
            button7.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button3.Visible = false;
        }
        void inve()
        {
            archivoToolStripMenuItem.Visible = false;
            buscarToolStripMenuItem.Visible = false;
            inventarioToolStripMenuItem.Visible = true;
            facturaciónToolStripMenuItem.Visible = false;
            gráficosYReportesToolStripMenuItem.Visible = false;
            button2.Visible = true;
            button2.Location = new Point(0, 135);
            button4.Visible = false;
            button8.Visible = false;
            button7.Visible = false;
            button9.Visible = false;
            button10.Visible = true;
            button10.Location = new Point(0, 177);
            button5.Visible = false;
            button6.Visible = false;
            button3.Visible = false;
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            PanelSidebar.Visible = false;

            lblNombres_Usuario.Text = Constructor_login.nombre;
            lblApellidos_Usuario.Text = Constructor_login.apellido;
            if (Constructor_login.nivel == 1) 
            {
                label1.Text = ("Root");
            }
            else if (Constructor_login.nivel== 2)
            {
                admin();
                label1.Text = ("Administrador");
            }
            else if (Constructor_login.nivel == 3)
            {
                bodeguero();
                label1.Text = ("Bodeguero");
            }
            else if (Constructor_login.nivel == 4)
            {
                caja();
                label1.Text = ("Cajero");
            }
            else if (Constructor_login.nivel == 5)
            {

                label1.Text = ("Gerente de inventario");
            }
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

        private void PanelContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmConfig_Root>();
            
            button6.BackColor = Color.FromArgb(192, 0, 192);
        }

      
        private void button6_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<frmConfig_Root>();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmFacturacion>();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAdministracion_Empresa>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCompra>();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void controlDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmUsuarios>();
        }

        private void agregarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmProveedores>();
        }

        private void ingresarNuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCompra>();
        }

        private void agregarBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmBodegas>();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCompra>();
        }

        private void inventarioGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmInventarioExistencias>();
        }

        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCompra>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<recuContra_ReinicioAdmin>();
        }

        private void PanelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void agregarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCompra>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmUsuarios>();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmProveedores>();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmInventarioExistencias>();
        }
    }
}
