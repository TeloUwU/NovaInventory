using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace NovaInventory.Vista
{
    public partial class frmItervencionAdmin_RecuContra : Form
    {
        public frmItervencionAdmin_RecuContra()
        {
            InitializeComponent();
        }
        MySqlConnection cn = new MySqlConnection("Server = localhost; Uid = root; password = ; Database = db_novainventory_25");
        MySqlCommand cmd = new MySqlCommand();

        private void panelUsuario_Root_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEnviar_Contra_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "select count(*) from tbusuarios where nickname = '" + txtUsuario_Root.Text + "'";
                int valor = int.Parse(cmd.ExecuteScalar().ToString());
                //Comparamos si el valor recibido es 1 entonces existe si no NO
                if (valor == 1)
                {
                    frmNuevaContraseña frm = new frmNuevaContraseña();
                    frm.Show();
                    this.Hide();
                    MessageBox.Show("Usuario Root");
                }
                else { labelMensaje.Text = "El usuario no existe"; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en encontrar usuario" + ex, "Error de encontrame al usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cn.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

