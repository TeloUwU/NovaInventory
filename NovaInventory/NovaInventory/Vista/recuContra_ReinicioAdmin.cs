﻿using System;
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

namespace NovaInventory.Vista
{
    public partial class recuContra_ReinicioAdmin : Form
    {
        public recuContra_ReinicioAdmin()
        {
            InitializeComponent();
        }
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
    }
}
