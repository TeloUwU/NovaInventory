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

namespace NovaInventory.Vista
{
    public partial class agregar_preguntas : Form
    {
        public agregar_preguntas()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ya has terminado de responder? ¿no has duplicado preguntas verdad?", "Preguntas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (textBox1.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" )
                {
                    MessageBox.Show("Llene todo los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    constructor_de_respuestas agr = new constructor_de_respuestas();
                    constructor_de_respuestas res2 = new constructor_de_respuestas();
                    constructor_de_respuestas res3 = new constructor_de_respuestas();
                    constructor_de_respuestas res4 = new constructor_de_respuestas();
                    agr.Respuesta = textBox1.Text;
                    agr.preguntas = Convert.ToInt16(comboBox1.SelectedValue);
                    agr.usuarioss = Convert.ToInt16(textBox5.Text);
                    res2.Respuesta = textBox4.Text;
                    res2.preguntas = Convert.ToInt16(comboBox2.SelectedValue);
                    res2.usuarioss = Convert.ToInt16(textBox5.Text);
                    res3.Respuesta = textBox2.Text;
                    res3.preguntas = Convert.ToInt16(comboBox3.SelectedValue); 
                    res3.usuarioss = Convert.ToInt16(textBox5.Text);
                    res4.Respuesta = textBox3.Text;
                    res4.preguntas = Convert.ToInt16(comboBox4.SelectedValue); 
                    res4.usuarioss = Convert.ToInt16(textBox5.Text);
                    int retorno = preguntas_y_respuestas.agregar_re(agr);
                    int retor = preguntas_y_respuestas.agregar_re(res2);
                    int re = preguntas_y_respuestas.agregar_re(res3);
                    int rep = preguntas_y_respuestas.agregar_re(res4);
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    this.Hide();
                    
                }
            }
            


        }

        private void agregar_preguntas_Load(object sender, EventArgs e)
        {
            textBox5.Text = Constructor_login.id_usuario;
            comboBox1.DataSource = preguntas_y_respuestas.cargar();
            comboBox1.DisplayMember = "pregunta";
            comboBox1.ValueMember = "id_pregunta";


            comboBox2.DataSource = preguntas_y_respuestas.cargar();
            comboBox2.DisplayMember = "pregunta";
            comboBox2.ValueMember = "id_pregunta";


            comboBox3.DataSource = preguntas_y_respuestas.cargar();
            comboBox3.DisplayMember = "pregunta";
            comboBox3.ValueMember = "id_pregunta";


            comboBox4.DataSource = preguntas_y_respuestas.cargar();
            comboBox4.DisplayMember = "pregunta";
            comboBox4.ValueMember = "id_pregunta";

        }
    }
}
