using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaInventory.Modelo;
using NovaInventory.Controlador;

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
                login.clave = txtContraseña.Text;
                bool datos = validar_login.acceso(login);
                if (datos == true)
                {
                    FrmPrincipal main = new FrmPrincipal();
                    main.Show();
                    this.Hide();
                    
                }

            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Validar_primer_uso.verificar_emo() == true)
            {
                if (Validar_primer_uso.verificar_usu() == true)
                {
                    btnPrimer_Uso.Visible = false;
                }
                else
                {
                    pbLogo_Login.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtContraseña.Enabled = false;
                    btnPrimer_Uso.Visible = true;
                    btnPrimer_Uso.Text = "Primer Usuario";
                }
            }
            else
            {
                pbLogo_Login.Enabled = false;
                txtUsuario.Enabled = false;
                txtContraseña.Enabled = false;
                btnPrimer_Uso.Visible = true;
            }
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
            if (btnPrimer_Uso.Text == "Primer Uso")
            {
                FrmPrimerUso primer_uso = new FrmPrimerUso();
                primer_uso.Show();
                this.Hide();
            }
            else
            {
                FrmPrimerUsuario primer_usuario = new FrmPrimerUsuario();
                primer_usuario.Show();
                this.Hide();
            }
            
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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
