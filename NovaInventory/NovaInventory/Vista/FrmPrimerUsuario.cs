using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaInventory.Config;
using NovaInventory.Controlador;
using NovaInventory.Modelo;

namespace NovaInventory.Vista
{
    public partial class FrmPrimerUsuario : Form
    {
        public FrmPrimerUsuario()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtCarne.Text) || string.IsNullOrWhiteSpace(txtClave.Text) || string.IsNullOrWhiteSpace(txtConfClave.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtRespuesta1.Text) || string.IsNullOrWhiteSpace(txtRespuesta2.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(txt_cel.Text))
            {
                MessageBox.Show("Llene todos los campos ", "WARNIG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               
                    constructor_primer_usuario usuario = new constructor_primer_usuario();
                    usuario.usuario = txtUsuario.Text;
                    usuario.nombre_usuario = txtUsuario.Text;
                    usuario.apellido_usuario = txtApellidos.Text;
                    usuario.Correo = txtEmail.Text;
                    usuario.nit = txtCarne.Text;
                    usuario.telefono = txt_cel.Text;
                    string intentos = "0";
                    usuario.intentos = intentos;
                    if (txtClave.Text==txtConfClave.Text)
                    {
                        usuario.contraseña_usuario = txtClave.Text;
                    }
                    MemoryStream ms = new MemoryStream();
                    pbFoto.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();
                    string imagen = Convert.ToBase64String(aByte);
                    usuario.Foto_usuario = imagen;
                    int retorno = control_usuario.registro_usuario(usuario);

                if (retorno >= 1)
                {
                    if (MessageBox.Show("¿Ya has terminado de registrar tu usuario?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmPrimerUsuario primer_usuario = new FrmPrimerUsuario();
                        primer_usuario.Show();
                        this.Hide();
                    }
                }
                
            }
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            CargarImagen.Filter = "Archivos de Imagen (.jpg)|*.jpg|Archivos de Imagen (.png)|*.png|Archivos de Imagen (.jpeg)|*.jpeg|Todos los archivos|*.*";
            DialogResult resultdo = CargarImagen.ShowDialog();
            if (resultdo == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(CargarImagen.FileName);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }
    }
}
