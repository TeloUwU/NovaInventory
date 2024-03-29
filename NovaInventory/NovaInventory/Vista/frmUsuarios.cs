﻿using System;
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
using NovaInventory.Controlador;
using NovaInventory.Modelo;
using NovaInventory.Config;
using NovaInventory.Reportes;
using NovaInventory.idioma;
using MySql.Data.MySqlClient;

namespace NovaInventory.Vista
{
    public partial class frmUsuarios : Form
    {
        public static int idiom;
        constructor_primer_usuario agregar = new constructor_primer_usuario();
        constructor_primer_usuario actualizar = new constructor_primer_usuario();
        constructor_de_respuestas ac = new constructor_de_respuestas();
        public frmUsuarios()
        {
            InitializeComponent();
        }
        public void agregarusu()
        {
            string clave = txtUsuario.Text + 2019;
            clave = Validaciones.md5(clave);
            agregar.usuario = txtUsuario.Text;
            agregar.nombre_usuario = txtNombres_Usuario.Text;
            agregar.apellido_usuario = txtApellidos_Usuario.Text;
            agregar.contraseña_usuario = clave;
            agregar.telefono = txtTelefono_Usuario.Text;
            agregar.Correo = txtCorreo_Usuario.Text;
            agregar.dui = txtDUI_Usuario.Text;
            agregar.nit = txtNIT_Usuario.Text;
            agregar.id_estados = Convert.ToInt32(cbEstado_Usuario.SelectedValue);
            agregar.id_tipo_usuarios = Convert.ToInt32(cbTipo_Usuario.SelectedValue);
            int intentos = 1;
            agregar.intentos = Convert.ToString(intentos);
            agregar.empresa = Convert.ToInt32(cmb_emp.SelectedValue);
            MemoryStream ms = new MemoryStream();
            pbFoto_Usuario.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            string imagen = Convert.ToBase64String(aByte);
            agregar.Foto_usuario = imagen;
            int retorno = Funciones_usuarios.agregar_usu(agregar);
            MessageBox.Show("La contraseña Por defecto es: ", txtUsuario.Text + 2019);
         


        }
        public void mostrar()
        {
            dgvMostrar_Usuarios.DataSource = Funciones_usuarios.mostrar_usu();
        }
        public void actualizares()
        {
            actualizar.id_usuarios = Convert.ToInt16(txtid_Usuario.Text);
            actualizar.nombre_usuario = txtNombres_Usuario.Text;
            actualizar.usuario = txtUsuario.Text;
            actualizar.apellido_usuario = txtApellidos_Usuario.Text;
            actualizar.Correo = txtCorreo_Usuario.Text;
            actualizar.telefono = txtTelefono_Usuario.Text;
            actualizar.dui = txtDUI_Usuario.Text;
            actualizar.nit = txtNIT_Usuario.Text;
            actualizar.id_tipo_usuarios = Convert.ToUInt16(cbTipo_Usuario.SelectedValue);
            actualizar.id_estados = Convert.ToUInt16(cbEstado_Usuario.SelectedValue);
            actualizar.empresa = Convert.ToUInt16(cmb_emp.SelectedValue);
            MemoryStream ms = new MemoryStream();
            pbFoto_Usuario.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            string imagen = Convert.ToBase64String(aByte);
            actualizar.Foto_usuario = imagen;
            ac.usuarioss = Convert.ToInt16( txtid_Usuario.Text);
            Funciones_usuarios.actualizarusu(actualizar);
        }
        public void eliminarusu()
        {

            if (MessageBox.Show("¿Esta seguro que desea eliminar el usuario?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_usuarios.eliminarusu(Convert.ToInt32(txtid_Usuario.Text));
            }
        }
        public void limpiar()
        {
            txtUsuario.Clear();
            txtNombres_Usuario.Clear();
            txtApellidos_Usuario.Clear();
            txtTelefono_Usuario.Clear();
            txtDUI_Usuario.Clear();
            txtNIT_Usuario.Clear();
            txtCorreo_Usuario.Clear();
            pbFoto_Usuario.Image.Dispose();
            pbFoto_Usuario.Image = null;
        }


        private void btnCerrar_AdminUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtApellidos_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregarusu();
            mostrar();
            mostrar();
            limpiar();
        }

        private void btnSeleccionarFoto_Usuario_Click(object sender, EventArgs e)
        {
            CargarImagen.Filter = "Archivos de Imagen (.jpg)|*.jpg|Archivos de Imagen (.png)|*.png|Archivos de Imagen (.jpeg)|*.jpeg|Todos los archivos|*.*";
            DialogResult resultdo = CargarImagen.ShowDialog();
            if (resultdo == DialogResult.OK)
            {
                pbFoto_Usuario.Image = Image.FromFile(CargarImagen.FileName);
            }
        }

        private void dgvMostrar_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            int posision;
            posision = this.dgvMostrar_Usuarios.CurrentRow.Index;
            txtid_Usuario.Text = this.dgvMostrar_Usuarios[0, posision].Value.ToString();
            txtUsuario.Text = this.dgvMostrar_Usuarios[1, posision].Value.ToString();
            txtNombres_Usuario.Text = this.dgvMostrar_Usuarios[2, posision].Value.ToString();
            txtApellidos_Usuario.Text = this.dgvMostrar_Usuarios[3, posision].Value.ToString();
            txtTelefono_Usuario.Text = this.dgvMostrar_Usuarios[5, posision].Value.ToString();
            byte[] image = Convert.FromBase64String(this.dgvMostrar_Usuarios[6, posision].Value.ToString());
            MemoryStream ms = new MemoryStream(image);
            pbFoto_Usuario.Image = Image.FromStream(ms);
            txtCorreo_Usuario.Text = this.dgvMostrar_Usuarios[7, posision].Value.ToString();
            txtDUI_Usuario.Text = this.dgvMostrar_Usuarios[8, posision].Value.ToString();
            txtNIT_Usuario.Text = this.dgvMostrar_Usuarios[9, posision].Value.ToString();
            cbEstado_Usuario.Text = Convert.ToString(this.dgvMostrar_Usuarios[11, posision].Value.ToString());
            cbTipo_Usuario.Text = Convert.ToString(this.dgvMostrar_Usuarios[12, posision].Value.ToString());



        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizares();
            mostrar();
            limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eliminarusu();
            mostrar();
            limpiar();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            mostrar();
            cbTipo_Usuario.DataSource = Funciones_usuarios.cargarUSU1();
            cbTipo_Usuario.DisplayMember = "tipo_usuario";
            cbTipo_Usuario.ValueMember = "id_tipo_usuario";

            cbEstado_Usuario.DataSource = Funciones_usuarios.cargar();
            cbEstado_Usuario.DisplayMember = "Estado";
            cbEstado_Usuario.ValueMember = "id_estado";

            cmb_emp.DataSource = Funciones_usuarios.cargar1();
            cmb_emp.DisplayMember = "nombre";
            cmb_emp.ValueMember = "id_datos_empresa";

            this.dgvMostrar_Usuarios.Columns[0*0].Visible = false;
        }

        private void cbEstado_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_usuarios_report mm = new frm_usuarios_report();
            mm.Show();
            this.Hide();
        }
        void ingle()
        {
            if (idiom == 1)
            {
                label2.Text = ingles.userrrrrrrrrrrrrrrrrrrrr;
                label3.Text = ingles.APELLIDOS;
                label4.Text = ingles.USUARRRIO;
                label5.Text = ingles.TELEEEE;
                label6.Text = ingles.FOOOOOOOOOOTOOO;
                label7.Text = ingles.CORREEEEOOO;
                label10.Text = ingles.ESTADOS_UNIDOS;
                label11.Text = ingles.TIPOSDEUSEEEER;
                label12.Text = ingles.empresa;
                label1.Text = ingles.administracionusuarios;
                btnSeleccionarFoto_Usuario.Text = ingles.BTNSELECCIONARFOTOUSUAIRO;
                button1.Text = ingles.BUTON1;
                button2.Text = ingles.BUTON2;
                button3.Text = ingles.BUTON3;
                button4.Text = ingles.BUTON4;
                button5.Text = ingles.BUTON5;
            }
            else
            {
                label2.Text = ("Nombres del Usuario:");
                label3.Text = ("Apellidos del Usuario:");
                label4.Text = ("Usuario:");
                label5.Text = ("Telefono:");
                label6.Text = ("Foto:");
                label7.Text = ("Correo:");
                label10.Text = ("Estado:");
                label11.Text = ("Tipo de Usuario:");
                label12.Text = ("Empresa:");
                label1.Text = ("Administración de Usuarios");
                btnSeleccionarFoto_Usuario.Text = ("Seleccionar Foto");
                button1.Text = ("Agregar Usuario");
                button2.Text = ("Mostrar Usuario");
                button3.Text = ("Actualizar Usuario");
                button4.Text = ("Eliminar Usuario");
                button5.Text = ("Reporte");
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
