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
        public frmCorreo_RecuContra()
        {
            InitializeComponent();
        }

        private void btnCambiar_Recu_Click(object sender, EventArgs e)
        {
            frmRecuperar_Contraseña Recuperar = new frmRecuperar_Contraseña();
            Recuperar.Show();
            this.Hide();
        }
        public void recuperarporEmail(string email, string nick)
        {
            try
            {
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
                        MessageBox.Show("El usuario y el email han sido encontrados.", "VERIFICACION COMPLETADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MailMessage mail = new MailMessage();
                        mail.To.Add(new MailAddress("herlyvalles@gmail.com"));
                        mail.From = new MailAddress(txtCorreo_Recu.Text);
                        mail.Subject = "Asunto (" + emisotr.Text + ")";
                        mail.Body = "<h1>Su contraseña fue restablesida a " + "nova" + txtUsuario.Text + year + "ingresala en el sistema. </h1>";
                        mail.IsBodyHtml = true;
                        mail.Priority = MailPriority.Normal;

                        SmtpClient smpt = new SmtpClient();
                        smpt.Host = "herlyvalles@gmail.com";
                        smpt.Port = 2525;
                        smpt.EnableSsl = false;
                        smpt.UseDefaultCredentials = false;
                        smpt.Credentials = new NetworkCredential("herlyvalles@gmail.com", "wearegiantslove:3");

                        string output = null;
                        try
                        {
                            smpt.Send(mail);
                            mail.Dispose();
                            output = "Correo electronico enviado";
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
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
