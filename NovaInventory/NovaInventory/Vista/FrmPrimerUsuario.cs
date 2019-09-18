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
            if (string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtClave.Text) || string.IsNullOrWhiteSpace(txtConfClave.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtRespuesta1.Text) ||
                string.IsNullOrWhiteSpace(txtRespuesta2.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(txt_cel.Text) || string.IsNullOrWhiteSpace(maskDui.Text))

            {
                MessageBox.Show("Llene todos los campos ", "WARNIG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                if (txtClave.Text == txtConfClave.Text)
                {
                    txtConfClave.Text = Validaciones.md5(txtConfClave.Text);
                    txtClave.Text = Validaciones.md5(txtClave.Text);

                   
            

                    constructor_primer_usuario usuario = new constructor_primer_usuario();
                    usuario.usuario = txtUsuario.Text;
                    usuario.nombre_usuario = txtNombres.Text;
                    usuario.apellido_usuario = txtApellidos.Text;
                    usuario.contraseña_usuario = txtClave.Text;
                    usuario.Correo = txtEmail.Text;
                    usuario.dui = maskDui.Text;
                    usuario.telefono = txt_cel.Text;
                    usuario.fecha_de_nacimiento = dtNacimiento.Text;
                    string intentos = "0";
                    usuario.intentos = intentos;
                    usuario.id_estados = Convert.ToInt32(cmbEstado.SelectedValue);
                    usuario.id_tipo_usuarios = Convert.ToInt32(cmbTipoUsuario.SelectedValue);
                    usuario.empresa = Convert.ToInt32(cmbEmpresa.SelectedValue);
                    MemoryStream ms = new MemoryStream();
                    pbFoto.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();
                    string imagen = Convert.ToBase64String(aByte);
                    usuario.Foto_usuario = imagen;
                    int retorno = control_usuario.registro_usuario(usuario);

                    //constructor_primer_usuario ne= new constructor_primer_usuario ();
                    //ne.id_usuarios= Convert.ToInt16( toolStripTextBox1.Text);
                    int usu = 6 ;
                    constructor_de_respuestas res = new constructor_de_respuestas();
                    constructor_de_respuestas res2 = new constructor_de_respuestas();
                    constructor_de_respuestas res3 = new constructor_de_respuestas();
                    constructor_de_respuestas res4 = new constructor_de_respuestas();

                    res.Respuesta = txtRespuesta1.Text;
                    res.preguntas = Convert.ToInt32(cmbPregunta1.SelectedValue);
                    res.usuarioss = usu;
                    int retornar = preguntas_y_respuestas.agregar_re(res);

                    res2.Respuesta = txtRespuesta2.Text;
                    res2.preguntas = Convert.ToInt32(cmbPregunta2.SelectedValue);
                    res2.usuarioss = usu;
                    int retorna = preguntas_y_respuestas.agregar_re(res2);

                    res3.Respuesta = textBox1.Text;
                    res3.preguntas = Convert.ToInt32(cmbPregunta3.SelectedValue);
                    res3.usuarioss = usu;
                    int retornara = preguntas_y_respuestas.agregar_re(res3);

                    res4.Respuesta = textBox2.Text;
                    res4.preguntas = Convert.ToInt32(cmbPregunta4.SelectedValue);
                    res4.usuarioss = usu;
                    int retornas = preguntas_y_respuestas.agregar_re(res4);

                    BtnGuardar.Visible = false;
                    button1.Visible = true;
                  
                }
                else
                {
                    MessageBox.Show("La contraseña  no es la misma porfavor corrijala y pongala denuevo", "La contraseña no es la misma");
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

        private void FrmPrimerUsuario_Load(object sender, EventArgs e)
        {

        }

        private void FrmPrimerUsuario_Load_1(object sender, EventArgs e)
        {
            

            cmbTipoUsuario.DataSource = Funciones_usuarios.cargarUSU();
            cmbTipoUsuario.DisplayMember = "tipo_usuario";
            cmbTipoUsuario.ValueMember = "id_tipo_usuario";

            cmbEstado.DataSource = Funciones_usuarios.cargar();
            cmbEstado.DisplayMember = "Estado";
            cmbEstado.ValueMember = "id_estado";

            cmbEmpresa.DataSource = Funciones_usuarios.cargar1();
            cmbEmpresa.DisplayMember = "nombre";
            cmbEmpresa.ValueMember = "id_datos_empresa";

            cmbPregunta1.DataSource = preguntas_y_respuestas.cargar();
            cmbPregunta1.DisplayMember = "pregunta";
            cmbPregunta1.ValueMember = "id_pregunta";


            cmbPregunta2.DataSource = preguntas_y_respuestas.cargar();
            cmbPregunta2.DisplayMember = "pregunta";
            cmbPregunta2.ValueMember = "id_pregunta";
         

            cmbPregunta3.DataSource = preguntas_y_respuestas.cargar();
            cmbPregunta3.DisplayMember = "pregunta";
            cmbPregunta3.ValueMember = "id_pregunta";
         

            cmbPregunta4.DataSource = preguntas_y_respuestas.cargar();
            cmbPregunta4.DisplayMember = "pregunta";
            cmbPregunta4.ValueMember = "id_pregunta";
           

            cmbEstado.Enabled = false;
            cmbTipoUsuario.Enabled = false;
            button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin primer_uso = new frmLogin();
            primer_uso.Show();
            this.Hide();
        }
    }
}
