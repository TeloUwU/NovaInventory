using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using NovaInventory.Vista;

namespace NovaInventory.Vista
{
    public partial class frmComprobUsuario : Form
    {
        public frmComprobUsuario()
        {
            InitializeComponent();
        }
        MySqlConnection cn = new MySqlConnection("Server = localhost; Uid = root; password = ; Database = DB_NOVAINVENTORY_25");
        MySqlCommand cmd = new MySqlCommand();

        private void ComprobUsuarioPreguntas_Load(object sender, EventArgs e)
        {

        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {

            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "select count(*) from tbusuarios where nickname = '" + txtUsuarios.Text + "'";
                int valor = int.Parse(cmd.ExecuteScalar().ToString());
                cn.Close();
                if (valor == 1)
                {
                    frmPreguntasSeguridad_RecuperarContra frm = new frmPreguntasSeguridad_RecuperarContra();
                    frm.lblUsuario.Text = txtUsuarios.Text;
                    frm.Show();
                    this.Hide();
                }

                else { labelMensaje.Text = "El usuario no existe"; }
            }//Fin del try 
            catch (Exception ex)
            {
                MessageBox.Show("Error en encontrar usuario" + ex, "Error al encontrar al usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}


