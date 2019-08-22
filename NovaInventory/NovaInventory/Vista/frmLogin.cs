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
    }
}
