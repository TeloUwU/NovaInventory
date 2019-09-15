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
        

        private void ComprobUsuarioPreguntas_Load(object sender, EventArgs e)
        {

        }
        MySqlConnection cn = new MySqlConnection("Server = localhost; Uid = root; password = ; Database = db_novainventory_25");
        MySqlCommand cmd = new MySqlCommand();


        private void btnComprobar_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd.Connection = cn;

            try
            {
                cmd.CommandText = "select count(*) from tbusuarios where nickname = '" + txtUsuarios.Text + "'";
                int valor = int.Parse(cmd.ExecuteScalar().ToString());
                //Comparamos si el valor recibido es 1 entonces existe si no NO
                if (valor == 1)
                {
                    frmPreguntasSeguridad_RecuperarContra frm = new frmPreguntasSeguridad_RecuperarContra();
                    frm.Show();
                    this.Hide();
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
    }



