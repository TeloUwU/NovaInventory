using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaInventory.Vista;
using MySql.Data.MySqlClient;
using NovaInventory.Controlador;
using NovaInventory.Modelo;
using NovaInventory.Config;

namespace NovaInventory.Vista
{
    public partial class frmConfig_Root : Form
    {
        Constructor_Root actualizar = new Constructor_Root();

        private string nombre = "Maria";

        public frmConfig_Root()
        {
            InitializeComponent();

            //string query = "SELECT * FROM tbusuarios WHERE id_tipo_usuarios = 1";
            //MySqlCommand cmdselect = new MySqlCommand(query, Conexion.obtenerconexion());
            //MySqlDataReader reader;
            ////Ejecutas , lees  y asignas el registro 
            //reader = cmdselect.ExecuteReader();
            //cmbEmpresa_Root.Items.Add(//cmbEmpresareader);
            //reader =
            //Creas query
           
            string query = "SELECT * FROM tbusuarios WHERE id_tipo_usuarios = 1";
            MySqlCommand cmdselect = new MySqlCommand(query, Conexion.obtenerconexion());
            MySqlDataReader reader;
            //Ejecutas , lees  y asignas el registro 
            reader = cmdselect.ExecuteReader();

            //vERIFICAS QUE NO ESTE VACIO
            //Reader es un vector que depende de los campos de la base de datos.
            //En este caso reader 2 es el valor del campo 2 de la base de datos en este caso nombre de usuairo  
            if (reader.Read())
            {
                //asignas dependienteo de la posicion del campo en la tabla de la ba
                txtNombre_Root.Text = reader[2].ToString();
                txtApellidos_Root.Text = reader[3].ToString();
                maskDui_Root.Text = reader[2].ToString();
                dtNacimiento_Root.Text = reader[2].ToString();
                cmbEmpresa_Root.Text = reader[2].ToString();
                txt_cel_Root.Text = reader[2].ToString();
                txtEmail_Root.Text = reader[2].ToString();
                cmbTipoUsuario_Root.Text = reader[2].ToString();
                cmbEstado_Root.Text = reader[12].ToString();
                txtUsuario_Root.Text = reader[1].ToString();
            }
            

        }

        private void frmConfig_Root_Load(object sender, EventArgs e)
        {

        }

        private void btnSobreescribir_Root_Click(object sender, EventArgs e)
        {
            if (txtClave_Root.Text != txtConfClave_Root.Text)
            {
                MessageBox.Show("Las contraseñas que se ingresaron no coinciden", "Verificar que la contraseña coincida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtClave_Root.Text == txtConfClave_Root.Text)
            {
                MessageBox.Show("La contraseña que se ingreso fue actualizada correctamente","Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtConfClave_Root_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_Root_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCargarImagen_Root_Click(object sender, EventArgs e)
        {
            openCargarImagen.Filter = "Archivos de Imagen(.jpg)|*.jpg|Archivos de Imagen(.png)|*.png|Archivos de Imegen(.jpeg)|*.jpeg|Todos los archivos|*.*";  
            DialogResult resultado = openCargarImagen.ShowDialog();
            if (resultado == DialogResult.OK)// el open caragr imagen sale de una herramienta llamada open file dialog
            {
                pbFoto_Root.Image = Image.FromFile(openCargarImagen.FileName);
            }
        }

        public void ModificarRegistro()
        {
            actualizar.id_usuario = Convert.ToInt32(txtid_Root.Text);
            actualizar.nombre_usuario = txtNombre_Root.Text;
            actualizar.apellido_usuario = txtApellidos_Root.Text;
            actualizar.dui = maskDui_Root.Text;
            actualizar.fecha_de_nacimiento = dtNacimiento_Root.Text;
            //actualizar. empresa= cmbEmpresa_Root.Text;
            actualizar.telefono = txt_cel_Root.Text;
            actualizar.Correo = txtEmail_Root.Text;
            //actualizar.id_tipo_usuarios = cmbTipoUsuario_Root.Text;
            //actualizar.id_estados = cmbEstado_Root.text;
            actualizar.usuario = txtUsuario_Root.Text;
            //actualizar.Foto_usuario = pbFoto_Root.Image;
            actualizar.contraseña_usuario = txtClave_Root.Text;
            actualizar.fecha_de_nacimiento = dtNacimiento_Root.Text;
            actualizar.nickname = txtUsuario_Root.Text;
            Actualizar_Root.Actualizar_usuario_root(actualizar);
        }

        public void LimpiarCampos()
        {
            txtid_Root.Clear();
            txtNombre_Root.Clear();
            txtApellidos_Root.Clear();
            maskDui_Root.Clear();
            //dtNacimiento_Root.Clear();
            cmbEmpresa_Root.SelectedValue = "1";
            txt_cel_Root.Clear();
            txtEmail_Root.Clear();
            cmbTipoUsuario_Root.SelectedValue="1";
            cmbEstado_Root.SelectedValue = "1";
            txtUsuario_Root.Clear();
            pbFoto_Root.Image.Clone();
            cmbEmpresa_Root.SelectedValue = "1";
            txtClave_Root.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre_Root.Text == "" || txtApellidos_Root.Text == "" || maskDui_Root.Text == "" || dtNacimiento_Root.Text == "" || cmbEmpresa_Root.Text == "" || txt_cel_Root.Text == "" || txtEmail_Root.Text == "" || cmbTipoUsuario_Root.Text == "" || cmbEstado_Root.Text == "" || txtUsuario_Root.Text == "" )
            {
                MessageBox.Show("No pueden quedar campos vacios", "Complete toda la información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pbFoto_Root.Image == null)
            {
                MessageBox.Show("La foto no puede quedar vacia", "Agrege la foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtClave_Root.Text != txtConfClave_Root.Text)
                {
                    MessageBox.Show("Las contraseñas que se ingresaron no coinciden", "Verificar que la contraseña coincida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            ModificarRegistro();
            LimpiarCampos();
            button_actualizar.Enabled = false;
           

           
        }

        private void cmbEmpresa_Root_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEmpresa_Root.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbTipoUsuario_Root_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTipoUsuario_Root.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbEstado_Root_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstado_Root.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void toolStripButton_regresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frm = new FrmPrincipal();
            frm.Show();
            this.Hide();
        }

        private void txtClave_Root_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
