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
using NovaInventory.Vista;
using NovaInventory.Config;
using NovaInventory.idioma;

namespace NovaInventory.Vista
{
    public partial class recuContra_ReinicioAdmin : Form
    {
        public recuContra_ReinicioAdmin()
        {
            InitializeComponent();
        }
        public static int idiom;
        constructor_primer_usuario actualizar = new constructor_primer_usuario();
        
        void act()
        {
            string clave = "nova"+txtUsuario.Text + 2019;
            clave = Validaciones.md5(clave);
            actualizar.id_usuarios =Convert.ToInt32( textBox1.Text);
            actualizar.contraseña_usuario = clave;
            contraypreguntas.actualizar_contra(actualizar);
            MessageBox.Show("La nueva contraseña es "+ "nova"+txtUsuario.Text+2019);
        }
        void pon()
        {
            int posision;
            posision = this.dgvMostrar_Usuarios.CurrentRow.Index;
            textBox1.Text = this.dgvMostrar_Usuarios[0, posision].Value.ToString();
            txtUsuario.Text = this.dgvMostrar_Usuarios[1, posision].Value.ToString();
        }
        void lim()
        {
           txtUsuario.Clear();
            textBox1.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            act();


        }
         void mostrar()
        {
            dgvMostrar_Usuarios.DataSource = Funciones_usuarios.mostrar_usu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void recuContra_ReinicioAdmin_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void dgvMostrar_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pon();
        }
        void ingle()
        {
            if (idiom == 1)
            {
                label1.Text = ingles.mecago;
                label2.Text = ingles.hh;
                button1.Text = ingles.ca;
                button4.Text = ingles.h;
            }
            else
            {
                label1.Text = ("Administración de Usuarios");
                label2.Text = ("Nombre del usuario:");
                button1.Text = ("Mostrar Usuarios");
                button4.Text = ("Clave Default");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                idiom = 1;
            }
            else
            {
                idiom = 0;
            }
            ingle();
        }
    }
}
