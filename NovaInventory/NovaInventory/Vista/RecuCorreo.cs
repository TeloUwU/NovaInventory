using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaInventory.Vista
{
    public partial class RecuCorreo : Form
    {
        public RecuCorreo()
        {
            InitializeComponent();
        }




        private void btnRecuperarContrasena_Click(object sender, EventArgs e)
        {
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("Server = localhost; Uid = root; password = ; Database = db_novainventory_25");

            {

                MySqlCommand cmd = new MySqlCommand("ValidarCorreo", cn);
                cmd.Parameters.AddWithValue("@correo", txtCorreoElectronico.Text);
                try
                {
                    cn.Open();
                    MySqlDataReader lector = cmd.ExecuteReader();
                    if (lector.Read())
                    {
                        GenerarNuevaContrasena(txtCorreoElectronico.Text);
                    }
                    else
                    {
                        MessageBox.Show("Correo no encontrado");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }


        public void GenerarNuevaContrasena(string email)
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            int nuevaContrasena = rd.Next(100000, 999999);
            MySqlConnection cn = new MySqlConnection("Server = localhost; Uid = root; password = ; Database = db_novainventory_25");
            MySqlCommand cmd = new MySqlCommand("NuevaContrasena", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@correo", email);
            cmd.Parameters.AddWithValue("@contrasena", nuevaContrasena);
            try
            {
                cn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas != 0)
                {
                    EnviarCorreoContrasena(nuevaContrasena, email);
                }
            }
            catch
            {

            }
        }



        private void EnviarCorreoContrasena(int contrasenaNueva, string correo)
        {
            string contraseña = this.Contrasena;
            string mensaje = string.Empty;
            //Creando el correo electronico
            string destinatario = correo;
            string remitente = "herlyvalles@gmail.com";
            string asunto = "Nueva contraseña";
            string cuerpoDelMesaje = "Su nueva contraseña es" + " " + Convert.ToString(contrasenaNueva);
            MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoDelMesaje);


            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("Tu correo", contraseña);

            try
            {
                Task.Run(() =>
                {

                    smtp.Send(ms);
                    ms.Dispose();
                    MessageBox.Show("Correo enviado, sirvase revisar su bandeja de entrada");
                }
                );

                MessageBox.Show("Esta tarea puede tardar unos segundos, por favor espere.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo electronico: " + ex.Message);
            }
        }
        public string Contrasena
        {
            get
            { return "tu contraseña"; }
        }
    }
    }
    

