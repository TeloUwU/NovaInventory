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
using NovaInventory.Config;

namespace NovaInventory.Vista
{
    public partial class frmNuevaContraseña : Form
    {
        constructorecuperacion constructor = new constructorecuperacion();
        public frmNuevaContraseña()
        {
            InitializeComponent();
        }
        MySqlConnection cn = new MySqlConnection("Server = localhost; Uid = root; password = ; Database = novainventorybase");
        MySqlCommand cmd = new MySqlCommand();

        private void frmNuevaContraseña_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEnviar_Contra_Click(object sender, EventArgs e)
        {
            {
                cn.Open();
                cmd.Connection = cn;
                try
                {
                    cmd.CommandText = "select count(*) from tbusuarios where nickname = '" + txtUsuario.Text + "'";
                    int valor = int.Parse(cmd.ExecuteScalar().ToString());
                    //Comparamos si el valor recibido es 1 entonces existe si no NO
                    if (valor == 1)
                    {

                        string sqlupdate = "UPDATE count (*) from tbusuarios where contraseña_usuario = '" + txtContraseña + "'";
                        MessageBox.Show("Contraseña Ingresada exitosamente", "Ingresando al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else { labelMensaje.Text = "El usuario no existe"; }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en encontrar usuario" + ex, "Error de encontrame al usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                cn.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


