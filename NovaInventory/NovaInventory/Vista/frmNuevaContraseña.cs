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
        MySqlConnection cn = new MySqlConnection("Server = localhost; Uid = root; password = ; Database = DB_NOVAINVENTORY_25");
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
                    //MessageBox.Show("Registro actualizado para el usuario " + valor, "Contraseña actualizada exitosamente ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Comparamos si el valor recibido es 1 entonces existe si no NO
                    if (valor == 1)
                    {
                        txtContraseña.Text = Validaciones.md5(txtContraseña.Text);
                        string contraseña = this.txtContraseña.Text;
                        string usuario = this.txtUsuario.Text;
                        //MySqlCommand cmdupt = new MySqlCommand(string.Format("UPDATE tbusuarios SET = nickname '{0}', nombre_usuario '{1}', apellido_usuario'{2}', contraseña_usuario'{3}', telefono '{4}', Foto_usuario'{5}', Correo'{6}', dui'{7}', nit'{8}'", upt.usuario, upt.nombre_usuario, upt.apellido_usuario, upt.contraseña_usuario, upt.telefono, upt.Foto_usuario, upt.Correo, upt.dui, upt.nit), Conexion.obtenerconexion());
                        string sqlUpdate = "update tbusuarios set contraseña_usuario = '" + contraseña + "' where nickname = '" + usuario + "'";
                        MySqlCommand cmd = new MySqlCommand(sqlUpdate, cn);
                        //MySqlCommand cmd = new MySqlCommand(string.Format(), cn);
                        
                        Boolean retorno = Convert.ToBoolean(cmd.ExecuteNonQuery());
                        MessageBox.Show("Registro actualizado para el usuario " + usuario,"Contraseña actualizada exitosamente " , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }

                    else { labelMensaje.Text = "El usuario no existe"; }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en encontrar usuario" + ex, "Error al encontrar al usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                cn.Close();
                
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }
    }
}


