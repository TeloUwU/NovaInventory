using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaInventory.Vista
{
    public partial class frmRecuperar_Contraseña : Form
    {
        public static int idiom;
        public frmRecuperar_Contraseña()
        {
            InitializeComponent();
        }

        private void pbCorreo_Recu_Click(object sender, EventArgs e)
        {
            frmCorreo_RecuContra frm = new frmCorreo_RecuContra();
            frm.Show();
            this.Hide();
        }

        private void pbPreguntas_Recu_Click(object sender, EventArgs e)
        {
            frmPreguntasSeguridad_RecuperarContra pregunta = new frmPreguntasSeguridad_RecuperarContra();
            pregunta.Show();
            this.Close(); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Close();
        }

        private void pbPreguntas_Recu_Click_1(object sender, EventArgs e)
        {
            frmPreguntasSeguridad_RecuperarContra Pregunta = new frmPreguntasSeguridad_RecuperarContra();
            Pregunta.Show();
            
            this.Close();
        }

        private void pbPreguntas_Click(object sender, EventArgs e)
        {
            //frmPreguntasSeguridad_RecuperarContra frm = new frmPreguntasSeguridad_RecuperarContra();
            //frm.Show();
            frmComprobUsuario comprobarU = new frmComprobUsuario();
            comprobarU.Show();
            this.Hide();
        }

        private void pbIntervenciónAdmi_Recu_Click(object sender, EventArgs e)
        {
            frmItervencionAdmin_RecuContra frm = new frmItervencionAdmin_RecuContra();
            frm.Show();
            this.Hide();
        }

        private void checkBox_recuperar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_recuperar.Checked == true)
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
                label1.Text = idioma.ingles.seleccione;
                label2.Text = idioma.ingles.preguntas_seguridad;
                label3.Text = idioma.ingles.correo;
                label4.Text = idioma.ingles.intervencion;
                checkBox_recuperar.Text = idioma.ingles.checkrecuperar;


            }
            else
            {
                label1.Text = ("Seleccione el metodo de recuperación de Contraseña que desea utilizar");
                label2.Text = ("Preguntas de Seguridad");
                label3.Text = ("Correo Electronico");
                label4.Text = ("Intervención del Administrador");
                checkBox_recuperar.Text = ("Idioma Español");

            }

        }


        private void frmRecuperar_Contraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
