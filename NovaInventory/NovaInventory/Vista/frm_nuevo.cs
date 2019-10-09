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



namespace NovaInventory.Vista
{
    public partial class frm_nuevo : Form
    {
        public frm_nuevo()
        {
            InitializeComponent();
        }
        Constructor_login log;
        constructor_primer_usuario act = new constructor_primer_usuario();
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de la contraseña ingresada?","Pregunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txt_cont.Text)||string.IsNullOrWhiteSpace(txt_contf.Text))
                {
                    MessageBox.Show("Llene todos los campos");
                    
                }
                else
                {
                    if (txt_cont.Text == txt_contf.Text)
                    {

                        txt_cont.Text = Validaciones.md5(txt_cont.Text);
                        act.id_usuarios = Convert.ToInt16(id.Text);
                        act.contraseña_usuario = txt_cont.Text;
                        contraypreguntas.actualizar_contra(act);
                        agregar_preguntas fr = new agregar_preguntas();
                        fr.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Las contaseñas no son iguales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
               
            }
           
        }

        private void frm_nuevo_Load(object sender, EventArgs e)
        {
            id.Text = Constructor_login.id_usuario;
            label5.Text = Constructor_login.usuario;
        }
    }
}
