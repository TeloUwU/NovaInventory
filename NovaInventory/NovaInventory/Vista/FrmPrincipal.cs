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
using MySql.Data.MySqlClient;
using System.IO;
using NovaInventory.Config;

namespace NovaInventory.Vista
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            string query = "SELECT * FROM tbusuarios WHERE id_usuarios =" + Constructor_login.id_usuario;
            MySqlCommand cmdselect = new MySqlCommand(query, Conexion.obtenerconexion());
            MySqlDataReader reader;
            reader = cmdselect.ExecuteReader();
            if (reader.Read())
            {
                byte[] image = Convert.FromBase64String(reader[6].ToString());
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
            }

            //string query1 = "SELECT * FROM datos_empresa WHERE id_datos_empresa = 1 ";
            //MySqlCommand cmdselect1 = new MySqlCommand(query1, Conexion.obtenerconexion());
            //MySqlDataReader reader1;
            //reader1 = cmdselect1.ExecuteReader();
            //if (reader1.Read())
            //{
            //    byte[] imagse = Convert.FromBase64String(reader[4].ToString());
            //    MemoryStream ms1 = new MemoryStream(imagse);
            //    pictureBox3.Image = Image.FromStream(ms1);
            //}
        }
        Form currentForm;
        void admin()
        {
            archivoToolStripMenuItem.Visible = false;
            buscarToolStripMenuItem.Visible = false;
            inventarioToolStripMenuItem.Visible = false;
            facturaciónToolStripMenuItem.Visible = false;
            gráficosYReportesToolStripMenuItem.Visible = false;
            button11.Visible = false;
            button12.Visible = true;
            button14.Visible = false;
            button15.Visible = true;
            button6.Visible = false;
            button5.Visible = false;
            ;
        }
        void bodeguero()
        {
            archivoToolStripMenuItem.Visible = false;
            buscarToolStripMenuItem.Visible = true;
            administraciónToolStripMenuItem.Visible = false; 
            inventarioToolStripMenuItem.Visible = true;
            facturaciónToolStripMenuItem.Visible = false;
            gráficosYReportesToolStripMenuItem.Visible = false;
            button11.Visible = true;
            button12.Visible = false;
            button14.Visible = true;
            button15.Visible = false;

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
            button11.Visible = false;
            button12.Visible = false;
            button14.Visible = true;
            button15.Visible = false;

        }
        void inve()
        {
            archivoToolStripMenuItem.Visible = false;
            buscarToolStripMenuItem.Visible = false;
            inventarioToolStripMenuItem.Visible = true;
            facturaciónToolStripMenuItem.Visible = false;
            gráficosYReportesToolStripMenuItem.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button14.Visible = false;
            button15.Visible = true;
            button7.Visible = false;
            btn_compras.Visible = false;
 
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            PanelSidebar.Visible = false;
            configuracion();
            lblNombres_Usuario.Text = Constructor_login.nombre;
            lblApellidos_Usuario.Text = Constructor_login.apellido;
            label2.Text= Constructor_login.nombre;
            label4.Text = Constructor_login.apellido;
            label5.Text = Constructor_login.usuario;

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
        private void configuracion()
        {
            panel_administracion_inv.Visible = false;
            panel_administracion.Visible = false;
            panel_administracion.Visible = false;
            panel_inventario.Visible = false;
            panel1.Visible = false;
        }
        private void hide_con()
        {
            if (panel_inventario.Visible == true)
                panel_inventario.Visible = false;
            if (panel_administracion_inv.Visible == true)
                panel_administracion_inv.Visible = false;
            if (panel_administracion.Visible == true)
                panel_administracion.Visible = false;
            if (panel_administracion.Visible == true)
                panel_administracion.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
        }
        private void show_con(Panel sub)
        {
            if (sub.Visible == false)
            {
                hide_con();
                sub.Visible = true;
            }
            else
            {
                sub.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmConfig_Root>();
            
            button6.BackColor = Color.FromArgb(192, 0, 192);
            hide_con();
        }

      
        private void button6_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<frmConfig_Root>();
            hide_con();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmFacturacion>();
            hide_con();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAdministracion_Empresa>();
            hide_con();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCompra>();
            hide_con();
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
            hide_con();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmProveedores>();
            hide_con();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            AbrirFormulario<frmInventarioExistencias>();
            hide_con();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            show_con(panel_administracion_inv);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            show_con(panel_administracion);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            show_con(panel_inventario);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            show_con(panel1);
        }

        private void btn_articulos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmProducto>();
            hide_con();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCategoria>();
            hide_con();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmBodegas>();
            hide_con();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<frmFacturacion>();
            hide_con();
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCompra>();
            hide_con();
        }

        //private void pictureBox3_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario<frmGenerarQR>();
        //}
    }
}
