using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NovaInventory.Config;
using NovaInventory.Controlador;

namespace NovaInventory.Vista
{
    public partial class frm_Actualizar_empresa : Form
    {
        public frm_Actualizar_empresa()
        {
            InitializeComponent();
        }

        private void TxtEditar_Empresa_TextChanged(object sender, EventArgs e)
        {

        }
        constructor_para_celulares agregar = new constructor_para_celulares();
        public void agregarCEL()
        {
            if (string.IsNullOrWhiteSpace(txtEditar_cel.Text))
            {
                MessageBox.Show("Digite un numero de telefono para poder agregarlo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                agregar.numeros_tel = txtEditar_cel.Text;
                int id = control_empresa.Id(agregar);
                agregar.empresas = id;
                int datos = control_empresa.Agregar_tel(agregar);
            }
        }

        public void mostrarCEL()
        {
            dgv_Contactos.DataSource = control_empresa.mostrar_cel();
        }
        public void limpiar()
        {
            txtEditar_cel.Clear();
        }
        private void btnAgregarTelefono_Gestor_Click(object sender, EventArgs e)
        {
            if (txtEditar_cel.Text == "    -    ")
            {
                MessageBox.Show("Llena los campos de telefono", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                agregarCEL();
                mostrarCEL();
                txtEditar_cel.Clear();
            }

        }
        
        public void eliminar()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el numero de telefono?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                control_empresa.Eliminar_num(Convert.ToInt32(txtEditar_cel.Text));
            }
        }


        private void btnEliminarTelefono_Gestor_Click(object sender, EventArgs e)
        {

            eliminar();
            mostrarCEL();
            mostrarCEL();
            txtEditar_cel.Clear();
            txtEditar_cel.Clear();
        }
        MySqlConnection cn = new MySqlConnection("Server = localhost; Uid = root; password = ; Database = DB_NOVAINVENTORY_25");
        MySqlCommand cmd = new MySqlCommand();
        private void button2_Click(object sender, EventArgs e)
        {
            {
                cn.Open();
                cmd.Connection = cn;
                try
                {
                    cmd.CommandText = "select count(*) from datos_empresa where nombre = '" + TxtEditar_Empresa.Text + "'";
                    int valor = int.Parse(cmd.ExecuteScalar().ToString());
                    //MessageBox.Show("Registro actualizado para el usuario " + valor, "Contraseña actualizada exitosamente ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Comparamos si el valor recibido es 1 entonces existe si no NO
                    if (valor == 1)
                    {
                        string empresa = this.TxtEditar_Empresa.Text;
                        //MySqlCommand cmdupt = new MySqlCommand(string.Format("UPDATE tbusuarios SET = nickname '{0}', nombre_usuario '{1}', apellido_usuario'{2}', contraseña_usuario'{3}', telefono '{4}', Foto_usuario'{5}', Correo'{6}', dui'{7}', nit'{8}'", upt.usuario, upt.nombre_usuario, upt.apellido_usuario, upt.contraseña_usuario, upt.telefono, upt.Foto_usuario, upt.Correo, upt.dui, upt.nit), Conexion.obtenerconexion());
                        string sqlUpdate = "update datos_empresa set nombre = '" + empresa + "'";
                        MySqlCommand cmd = new MySqlCommand(sqlUpdate, cn);
                        //MySqlCommand cmd = new MySqlCommand(string.Format(), cn);

                        Boolean retorno = Convert.ToBoolean(cmd.ExecuteNonQuery());
                        MessageBox.Show("Registro actualizado para la empresa " + empresa, "Contraseña actualizada exitosamente ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                cn.Close();

            }
        }
    }
}
