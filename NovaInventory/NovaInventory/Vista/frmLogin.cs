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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Sesion_Click(object sender, EventArgs e)
        {
            
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

        private void btnMaximizar_Login_Click(object sender, EventArgs e)
        {
            btnMaximizar_Login.Visible = false;
            btnVentana_Login.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void btnVentana_Login_Click(object sender, EventArgs e)
        {
            btnMaximizar_Login.Visible = true;
            btnVentana_Login.Visible = false;
            WindowState = FormWindowState.Minimized;
        }
    }
}
