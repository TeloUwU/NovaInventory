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

namespace NovaInventory.Vista
{
    public partial class frmConfig_Root : Form
    {
        public frmConfig_Root()
        {
            InitializeComponent();
        }

        private void frmConfig_Root_Load(object sender, EventArgs e)
        {

        }

        private void btnSobreescribir_Root_Click(object sender, EventArgs e)
        {
            if (txtClave_Root.Text != txtConfClave_Root.Text)
            {
                MessageBox.Show("Las contraseñas que se ingresaron no coinciden", "Verificar que la contraseña coincida", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
