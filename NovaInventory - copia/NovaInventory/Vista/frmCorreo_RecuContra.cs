using MySql.Data.MySqlClient;
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

namespace NovaInventory.Vista
{
    public partial class frmCorreo_RecuContra : Form
    {
        public frmCorreo_RecuContra()
        {
            InitializeComponent();
        }

        private void btnCambiar_Recu_Click(object sender, EventArgs e)
        {
            frmRecuperar_Contraseña Recuperar = new frmRecuperar_Contraseña();
            Recuperar.Show();
            this.Hide();
        }
        public void recuperarporEmail(string email, string nick)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE nick = BINARY @nick AND  email = BINARY @email", Conexion.obtenerconexion());
                cmd.Parameters.AddWithValue("nick", nick);
                cmd.Parameters.AddWithValue("email", email);
                MySqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    //AgregarNuevaContraseña(txtCorreo_Recu.Text);

                }

                else
                {
                    MessageBox.Show("Usuario o email no encontrado.", "Verifque su información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error critico" + ex);
            }

        }
        private void btenviar_Correo_Click(object sender, EventArgs e)
        {

        }
    }
}
