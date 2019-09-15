using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaInventory.Modelo;
using NovaInventory.Controlador;
using MySql.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections;

namespace NovaInventory.Vista
{
    public partial class frmPreguntasSeguridad_RecuperarContra : Form
    {
        public frmPreguntasSeguridad_RecuperarContra()
        {
            InitializeComponent();
        }
        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmRecuperar_Contraseña Recuperar = new frmRecuperar_Contraseña();
            Recuperar.Show();
            this.Close();
        }


        MySqlConnection cn = new MySqlConnection("Server = localhost; Uid = root; password = ; Database = db_novainventory_25");
        MySqlCommand cmd = new MySqlCommand();
        private void frmPreguntasSeguridad_RecuperarContra_Load(object sender, EventArgs e)
        {
            cbPregunta_1.DataSource = preguntas_y_respuestas.cargar();
            cbPregunta_1.DisplayMember = "pregunta";
            cbPregunta_1.ValueMember = "id_pregunta";
            cbPregunta_1.SelectedValue = "1";

            cbPregunta_2.DataSource = preguntas_y_respuestas.cargar();
            cbPregunta_2.DisplayMember = "pregunta";
            cbPregunta_2.ValueMember = "id_pregunta";
            cbPregunta_2.SelectedValue = "2";

            cbPregunta_3.DataSource = preguntas_y_respuestas.cargar();
            cbPregunta_3.DisplayMember = "pregunta";
            cbPregunta_3.ValueMember = "id_pregunta";
            cbPregunta_3.SelectedValue = "3";

            cbPregunta_4.DataSource = preguntas_y_respuestas.cargar();
            cbPregunta_4.DisplayMember = "pregunta";
            cbPregunta_4.ValueMember = "id_pregunta";
            cbPregunta_4.SelectedValue = "4";
        }

        private void btnCambiar_Recu_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Preguntas_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = lblUsuario.Text;
                if (cbPregunta_1.Text != cbPregunta_2.Text && cbPregunta_1.Text != cbPregunta_3.Text && cbPregunta_1.Text != cbPregunta_4.Text
                    && cbPregunta_2.Text != cbPregunta_3.Text && cbPregunta_2.Text != cbPregunta_4.Text &&
                    cbPregunta_3.Text != cbPregunta_4.Text)
                {
                    Console.WriteLine("asdfa"+ cbPregunta_1.SelectedValue);
                    int idpregunta1 = (int)cbPregunta_1.SelectedValue;
                    int idpregunta2 = (int)cbPregunta_2.SelectedValue;
                    int idpregunta3 = (int)cbPregunta_3.SelectedValue;
                    int idpregunta4 = (int)cbPregunta_4.SelectedValue;
                    constructor_de_respuestas respt1 = new constructor_de_respuestas(usuario, idpregunta1);
                    respt1.asignarRespuesta();
                    Console.WriteLine(respt1.Respuesta);
                    constructor_de_respuestas respt2 = new constructor_de_respuestas(usuario, idpregunta2);
                    respt2.asignarRespuesta();
                    constructor_de_respuestas respt3 = new constructor_de_respuestas(usuario, idpregunta3);
                    respt3.asignarRespuesta();
                    constructor_de_respuestas respt4 = new constructor_de_respuestas(usuario, idpregunta4);
                    respt4.asignarRespuesta();

                    string pgta1 = txtRespuesta_1.Text;
                    Boolean comparacion1 = pgta1.ToUpper().Equals(respt1.Respuesta.ToUpper());
                    Console.WriteLine(comparacion1);
                    string pgta2 = txtRespuesta_2.Text;
                    Boolean comparacion2 = pgta2.ToUpper().Equals(respt2.Respuesta.ToUpper());
                    Console.WriteLine(comparacion2);
                    string pgta3 = txtRespuesta_3.Text;
                    Boolean comparacion3 = pgta3.ToUpper().Equals(respt3.Respuesta.ToUpper());
                    Console.WriteLine(comparacion3);
                    string pgta4 = txtRepuesta_4.Text;
                    Boolean comparacion4 = pgta4.ToUpper().Equals(respt4.Respuesta.ToUpper());
                    Console.WriteLine(comparacion4);
                    Console.WriteLine(pgta1.ToUpper().CompareTo(respt1.Respuesta.ToUpper()));
                    if (comparacion1 && comparacion2 && comparacion3 && comparacion4)
                    {
                        Console.WriteLine("Son iguales");
                        frmPreguntaSeguridad_RecuContra frm_rec = new frmPreguntaSeguridad_RecuContra();
                        frm_rec.Show();
                        this.Close();
                    }
                    else
                    {
                        Console.WriteLine("Son diferentes");
                    }


                }
                else
                {
                    MessageBox.Show("Seleccione preguntas diferentes.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            cn.Open();
            cmd.Connection = cn;

            try
            {
                cmd.CommandText = "select count(*) from tbrespuesta where respuesta = '" + txtRespuesta_1.Text +"'";
                int valor = int.Parse(cmd.ExecuteScalar().ToString());
                //Comparamos si el valor recibido es 1 entonces existe si no NO

                if (valor == 1)
                {
                    frmPreguntasSeguridad_RecuperarContra frm = new frmPreguntasSeguridad_RecuperarContra();
                    frm.Show();
                    this.Hide();
                }
                else { labelMensaje.Text = "La respuesta es incorrecta o no existe"; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en encontrar usuario" + ex, "Error de encontrame al usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cn.Close();

        }
    }
}
