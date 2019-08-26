using NovaInventory.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using NovaInventory.Controlador;


namespace NovaInventory.Vista
{
    public partial class frmConfig_Root : Form
    {
        constructor_primer_usuario actualizar = new constructor_primer_usuario();

        public frmConfig_Root()
        {
            InitializeComponent();
        }

        private void btnSobreescribir_Root_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
            ModificarRegistro();
            btnSobreescribir_Root.Enabled = false;
            Mostrar_Root();
        }
        public void ModificarRegistro()
        {
            actualizar.id_usuarios = Convert.ToInt32(txtid_Root.Text);
            actualizar.nombre_usuario = txtNombre_Root.Text;
            actualizar.apellido_usuario = txtApellidos_Root.Text;
            actualizar.empresa = Convert.ToInt32(cmbEmpresa_Root.Text);
            actualizar.telefono = txt_cel_Root.Text;
            actualizar.Correo = txtEmail_Root.Text;
            actualizar.id_tipo_usuarios = Convert.ToInt32(cmbTipoUsuario_Root.Text);
            actualizar.id_estados = Convert.ToInt32(cmbEstado_Root.Text);
            actualizar.usuario = (txtUsuario_Root.Text);
            actualizar.id_tipo_usuarios = Convert.ToInt32(cmbTipoUsuario_Root.Text);
            actualizar.contraseña_usuario = txtClave_Root.Text;

        }


        public void Mostrar_Root()
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            openCargarImagen.Filter = "Archivos de Imagen(.jpg)|*.jpg|Archivos de Imagen(.png)|*.png|Archivos de Imegen(.jpeg)|*.jpeg|Todos los archivos|*.*";  
            DialogResult resultado = openCargarImagen.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                pbFoto_Root.Image = Image.FromFile(openCargarImagen.FileName);
            }
        }

        private void BtnExaminar_Root_Click(object sender, EventArgs e)
        {
            openCargarImagen.Filter = "Archivos de Imagen(.jpg)|*.jpg|Archivos de Imagen(.png)|*.png|Archivos de Imegen(.jpeg)|*.jpeg|Todos los archivos|*.*";  
            DialogResult resultado = openCargarImagen.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                pbFoto_Root.Image = Image.FromFile(openCargarImagen.FileName);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (
               txtNombre_Root.Text.Trim() == "" || txtApellidos_Root.Text.Trim() == "" ||
               maskDui_Root.Text.Trim() == "" || dtNacimiento_Root.Text.Trim() == "" ||
               cmbEmpresa_Root.Text.Trim() == "" || txt_cel_Root.Text.Trim() == "" ||
               txtEmail_Root.Text.Trim() == "" || cmbTipoUsuario_Root.Text.Trim() == "" ||
               cmbEstado_Root.Text.Trim() == "" || txtUsuario_Root.Text.Trim() == "" ||
               txtClave_Root.Text.Trim() == "" || txtConfClave_Root.Text.Trim() == "" ||
               pbFoto_Root.Image == null)
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Complete todos los campos ya que son requeridos para iniciar el sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                constructor_primer_usuario empresa = new constructor_primer_usuario();
                empresa.nombre_usuario = txtNombre_Root.Text;
                empresa.apellido_usuario = txtApellidos_Root.Text;
                empresa.nit = maskDui_Root.Text;
                empresa.empresa = Convert.ToInt32(cmbEmpresa_Root.Text);
                empresa.telefono = txt_cel_Root.Text;
                empresa.Correo = txtEmail_Root.Text;
                empresa.id_tipo_usuarios = Convert.ToInt32(cmbTipoUsuario_Root.Text);
                empresa.id_estados = Convert.ToInt32(cmbEstado_Root.Text);
                empresa.usuario = txtUsuario_Root.Text;
                empresa.contraseña_usuario = txtClave_Root.Text;

                //int estado = 1;
                empresa.id_estados = Convert.ToInt32(cmbEstado_Root);

                MemoryStream mestre = new MemoryStream();
                pbFoto_Root.Image.Save(mestre, ImageFormat.Jpeg);
                byte[] aByte = mestre.ToArray();
                string imagen = Convert.ToBase64String(aByte);
                empresa.Foto_usuario = imagen;

                int retorno = control_empresa.registrarempresa(empresa);
                if (retorno >= 1)
                {
                    FrmPrimerUsuario primerusuario = new FrmPrimerUsuario();
                    primerusuario.Show();
                    this.Hide();
                }
            }
        }

        //private void frmConfig_Root_Load(object sender, EventArgs e)
        //{
        //    Actualizar_Root.Cargar_empresa();
        //    {
        //        cmbEmpresa_Root.DataSource = Actualizar_Root.Cargar_empresa();
        //        cmbEmpresa_Root.DisplayMember = "nombre";
        //        cmbEmpresa_Root.ValueMember = "";
        //    }

        //    Actualizar_Root.Cargar_tipo_usuario();
        //    {
        //        cmbEmpresa_Root.DataSource = Actualizar_Root.Cargar_tipo_usuario();
        //        cmbEmpresa_Root.DisplayMember = "";
        //        cmbEmpresa_Root.ValueMember = "id_profesor";
        //    }

        //    Actualizar_Root.Estado();
        //    {
        //        cmbEmpresa_Root.DataSource = Actualizar_Root.Estado();
        //        cmbEmpresa_Root.DisplayMember = "";
        //        cmbEmpresa_Root.ValueMember = "id_profesor";
        //    }
        //}


    }
}
