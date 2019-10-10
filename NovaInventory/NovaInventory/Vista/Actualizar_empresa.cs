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

namespace NovaInventory.Vista
{
    public partial class Actualizar_empresa : Form
    {

        constructor actualizar = new constructor();
        public Actualizar_empresa()
        {
            InitializeComponent();
        }

        private void BtnExaminar_Gestor_Click(object sender, EventArgs e)
        {
            Cargar_imagen.Filter = "Archivos de Imagen (.jpg)|*.jpg|Archivos de Imagen (.png)|*.png|Archivos de Imagen (.jpeg)|*.jpeg|Todos los archivos|*.*";
            DialogResult resultdo = Cargar_imagen.ShowDialog();
            if (resultdo == DialogResult.OK)
            {
                pbLogo_Gestor.Image = Image.FromFile(Cargar_imagen.FileName);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Modificar_empresa()
        {

            actualizar. = TxtEmpresa_Gestor.Text;
            actualizar.apellido_usuario = txtApellidos_Root.Text;
            actualizar.dui = maskDui_Root.Text;
            actualizar.fecha_de_nacimiento = dtNacimiento_Root.Text;
            actualizar.empresa = Convert.ToInt16(cmbEmpresa_Root.SelectedValue);
            actualizar.telefono = txt_cel_Root.Text;
            actualizar.Correo = txtEmail_Root.Text;

            actualizar.id_estados = Convert.ToInt16(cmbEstado_Root.SelectedValue);
            actualizar.usuario = txtUsuario_Root.Text;

            MemoryStream ms = new MemoryStream();
            pbFoto_Root.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            string decoded = Convert.ToBase64String(aByte);
            actualizar.Foto_usuario = decoded;

            actualizar.contraseña_usuario = Validaciones.md5(txtClave_Root.Text);
            actualizar.fecha_de_nacimiento = dtNacimiento_Root.Text;
            actualizar.nickname = txtUsuario_Root.Text;
            Actualizar_Root.Actualizar_usuario_root(actualizar);
        }

        private void btnmodificar_empresa_Click(object sender, EventArgs e)
        {
            if (TxtEmpresa_Gestor.Text == "" || txt_email.Text == "" || txt_telefono.Text == "" || txtnit.Text == "" || txt_direccion.Text == "" || txt_representante_legal.Text == "" || cb_tipo_empresa.Text == "")
            {
                MessageBox.Show("No pueden quedar campos vacios", "Complete toda la información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                ModificarRegistro();
                LimpiarCampos();
                button_actualizar.Enabled = false;
            }

        }
    }
}
