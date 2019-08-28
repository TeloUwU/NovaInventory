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
using System.IO;
using MySql.Data;

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
            MySqlConnection cn = new MySqlConnection("Server = localhost; Uid = root; password = ; Database = DB_NOVAINVENTORY_25");
            MySqlCommand cmd = new MySqlCommand();
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
                maskDui_Root.Text = reader[8].ToString();
                txtUsuario_Root.Text = reader[1].ToString();
                // dtNacimiento_Root.Text = reader[10].ToString();
                cmbEmpresa_Root.Text = reader[14].ToString();
                txt_cel_Root.Text = reader[5].ToString();
                txtEmail_Root.Text = reader[7].ToString();
                cmbEstado_Root.Text = reader[11].ToString();
                // pbFoto_Root.Image = reader[6].ToString();



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
                
                
                string contraseña = txtClave_Root.Text;
                string contra = txtConfClave_Root.Text;

                 string sqlUpdate = "update tbusuarios set contraseña_usuario = '" + contraseña + "' where id = txtConfClave_Root ";
                MySqlCommand cmd = new MySqlCommand(sqlUpdate);
                //int datos = Convert.ToI(cmd.ExecuteNonQuery());
               
                MessageBox.Show("La contraseña que se ingreso fue actualizada correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    string cn = this.txtConfClave_Root.Text;
                    //MySqlCommand cmdupt = new MySqlCommand(string.Format("UPDATE tbusuarios SET = nickname '{0}', nombre_usuario '{1}', apellido_usuario'{2}', contraseña_usuario'{3}', telefono '{4}', Foto_usuario'{5}', Correo'{6}', dui'{7}', nit'{8}'", upt.usuario, upt.nombre_usuario, upt.apellido_usuario, upt.contraseña_usuario, upt.telefono, upt.Foto_usuario, upt.Correo, upt.dui, upt.nit), Conexion.obtenerconexion());
                    //string sqlUpdate = "update tbusuarios set contraseña_usuario = '" + contraseña + "' where nickname = '" + contraseña + "'";
                    MySqlCommand c = new MySqlCommand(sqlUpdate);
                    //MySqlCommand cmd = new MySqlCommand(string.Format(), cn);

                   // Boolean retorno = Convert.ToBoolean(cmd.ExecuteNonQuery());
                    MessageBox.Show("Registro actualizado para el usuario ", "Contraseña actualizada exitosamente ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                catch (Exception ex)
                {
                    MessageBox.Show("Error en encontrar usuario" + ex, "Error al encontrar al usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               // cn.Close();

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
            if (resultado == DialogResult.OK)// el open cargar imagen sale de una herramienta llamada open file dialog
            {
                pbFoto_Root.Image = Image.FromFile(openCargarImagen.FileName);
            }
        }

        public void ModificarRegistro()
        {
           // actualizar.id_usuario = Convert.ToInt32(txtid_Root.Text);
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
            cmbEstado_Root.SelectedValue = "1";
            txtUsuario_Root.Clear();
            //pbFoto_Root.Image.Clone();
            cmbEmpresa_Root.SelectedValue = "1";
            txtClave_Root.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre_Root.Text == "" || txtApellidos_Root.Text == "" || maskDui_Root.Text == "" || dtNacimiento_Root.Text == "" || cmbEmpresa_Root.Text == "" || txt_cel_Root.Text == "" || txtEmail_Root.Text == "" || cmbEstado_Root.Text == "" || txtUsuario_Root.Text == "")
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

        void CargarEmpresa()
        {
            cmbEmpresa_Root.DataSource = Actualizar_Root.CargarEnmpresa();
            cmbEmpresa_Root.DisplayMember = "nombre";
            cmbEmpresa_Root.ValueMember = "id_datos_empresa";
        }
        void CargarEstado()
        {
            cmbEstado_Root.DataSource = Actualizar_Root.CargarEstado();
            cmbEstado_Root.DisplayMember = "Estado_usuario";
            cmbEstado_Root.ValueMember = "id_estado_usuario";
        }

        private void txtClave_Root_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void frmConfig_Root_Load_1(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtNacimiento_Root_ValueChanged(object sender, EventArgs e)
        {

        }
        string query = "SELECT * FROM tbusuarios WHERE id_tipo_usuarios = 1";
        MySqlDataReader reader;

        private void frmConfig_Root_Load_2(object sender, EventArgs e)
        {
            CargarEmpresa();
            CargarEstado();

            //string query = "SELECT * FROM tbusuarios WHERE contraseña_usuario = 1";
            //byte[] image = Convert.FromBase64String(reader.GetString(0));
            //MemoryStream mas = new MemoryStream(image);
            //pbFoto_Root.Image = Image.FromStream(mas);

            //MemoryStream mas = new MemoryStream();
            //byte[] image = Convert.FromBase64String(reader.GetString(0));
            //MemoryStream mas = new MemoryStream(image);
            //pbFoto_Root.Image = Image.FromStream(mas);

        }
    }
}
