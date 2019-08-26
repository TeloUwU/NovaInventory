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
using NovaInventory.Modelo;
using NovaInventory.Config;
using NovaInventory.Vista;

namespace NovaInventory.Vista
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        void Validar_Campos()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Existen campos vacíos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Constructor_login login = new Constructor_login(txtUsuario.Text, txtContraseña.Text);
                Constructor_login.usuario = txtUsuario.Text;
                login.clave = Validaciones.md5(txtContraseña.Text);
                bool datos = validar_login.acceso(login);
                if (datos == true)
                {
                    if (txtContraseña.Text == "123456")
                    {
                        FrmClaveDefecto def = new FrmClaveDefecto();
                        def.Show();
                        this.Hide();
                    }
                    else
                    {
                        FrmPrincipal main = new FrmPrincipal();
                        main.Show();
                        this.Hide();
                    }                    
                }

            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Sesion_Click(object sender, EventArgs e)
        {
            Validar_Campos();
        }

        private void lklRecuperar_Contraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperar_Contraseña recu = new frmRecuperar_Contraseña();
            recu.Show();
            this.Hide();
        }

        private void btnCerrar_Login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinmizar_Login_Click(object sender, EventArgs e)
        {
            WindowState  = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
