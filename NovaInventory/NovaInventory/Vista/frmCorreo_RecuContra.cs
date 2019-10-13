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
using NovaInventory.Modelo;
using NovaInventory.Config;
using System.Net;
using System.Net.Mail;


namespace NovaInventory.Vista
{
    public partial class frmCorreo_RecuContra : Form
    {
        public static int idiom;
        public frmCorreo_RecuContra()
        {
            InitializeComponent();
        }

        private void btnCambiar_Recu_Click(object sender, EventArgs e)
        {
        }
       // public void recuperarporEmail(string email, string nick)
        public void recuperarporEmail()
        {
            try
            {
                string nick = txtUsuario.Text;
                string email = txtCorreo_Recu.Text;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbusuarios WHERE nickname = BINARY @nickname AND  correo = BINARY @correo", Conexion.obtenerconexion());
                cmd.Parameters.AddWithValue("nickname", nick);
                cmd.Parameters.AddWithValue("correo", email);
                int veri = Convert.ToInt16(cmd.ExecuteScalar());
                if (veri>0)
                {
                    DateTime hoy = DateTime.Today;
                    int year = hoy.Year;
                    if (nick == txtUsuario.Text && email == txtCorreo_Recu.Text)
                    {
                        MessageBox.Show("El usuario y el email han sido encontrados.", "VERIFICACION COMPLETADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MailMessage mail = new MailMessage();
                        
                        mail.To.Add(new MailAddress(txtCorreo_Recu.Text)); 
                        mail.From = new MailAddress("herlyvalles@gmail.com");
                        mail.Subject = "Asunto (" + emisotr.Text + ")";
                        string contra = "nova" + txtUsuario.Text + year;
                        mail.Body = "<h1>Su contraseña fue restablecida a " +  contra + " ingresela en el sistema. </h1>";
                        mail.IsBodyHtml = true;
                        mail.Priority = MailPriority.Normal;


                        bool retorno = false;
                        string output = null;
                        try
                        {
                            SmtpClient smpt = new SmtpClient();
                            smpt.Host = "smtp.gmail.com";

                            //smpt.UseDefaultCredentials = true;
                            smpt.Credentials = new NetworkCredential("herlyvalles@gmail.com", "ffqtjqwsvjouuxyo");

                            smpt.Port = 587;
                            smpt.EnableSsl = true;

                            smpt.Send(mail);
                            mail.Dispose();
                            output = "Correo electronico enviado";
                            String encriptada = Validaciones.md5(contra);
                            //Actualiza contrasena en la base busca el codigo porque eos hace falta , no impora si l emantas la contra por correo si no actualizas en la base de datos no servira 
                            MySqlCommand cmdupt = new MySqlCommand(string.Format("UPDATE tbusuarios SET  contraseña_usuario='{0}'  WHERE Correo='{1}' and nickname ='{2}'", encriptada, email,nick  ), Conexion.obtenerconexion());
                            retorno = Convert.ToBoolean(cmdupt.ExecuteNonQuery());
                            Console.WriteLine("Fin estado " + retorno);
                            Console.WriteLine("Fin estado " + encriptada);
                            Console.WriteLine("Ingres *" + contra+"* Sin los asteriscos" );
                        }       
                        catch (Exception ex)
                        {
                            output = "Error enviando Correo:" + ex.Message;

                        }
                        Console.WriteLine(output);
                    }
                    }


             
                else
                {
                    MessageBox.Show("Usuario o email no encontrado.", "Verifque su información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error critico" + ex);
            }

        }
        private void btenviar_Correo_Click(object sender, EventArgs e)
        {
            //public void recuperarporEmail(string email, string nick)
            recuperarporEmail();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void checkBox_correo_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox_correo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_correo.Checked == true)
            {
                idiom = 1;
            }
            else
            {
                idiom = 0;
            }
            ingles();
        }

        public void ingles()
        {

            if (idiom == 1)
            {
                emisotr.Text = idioma.ingles.nueva_contraseña;
                checkBox_correo.Text = idioma.ingles.check_correo;
                button1.Text = idioma.ingles.Regresar;
                lblCorreoElectronico.Text = idioma.ingles.Correp;
                lblUser1.Text = idioma.ingles.usuari;
                lblCorreoElectronico.Text = idioma.ingles.Ingresa_correo;
                btenviar_Correo.Text = idioma.ingles.Enviar;


            }
            else
            {
                emisotr.Text = ("Nueva Contraseña");
                checkBox_correo.Text = ("Idioma Español");
                button1.Text = ("Regresar al LOGIN");
                lblCorreoElectronico.Text = ("Correo Electronico");
                lblUser1.Text = ("Usuario");
                lblCorreoElectronico.Text = ("Ingresa tu Correo Electronico");
                btenviar_Correo.Text = ("Enviar Correo Electronico");
            }
        }



        private void frmCorreo_RecuContra_Load(object sender, EventArgs e)
        {

        }
    }
}
