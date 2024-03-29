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

namespace NovaInventory.Vista
{
    public partial class frmUsuarios : Form
    {
        constructor_primer_usuario agregar = new constructor_primer_usuario();
        constructor_primer_usuario actualizar = new constructor_primer_usuario();
        public frmUsuarios()
        {
            InitializeComponent();
        }
        public void agregarusu()
        {
            agregar.usuario = txtUsuario.Text;
            agregar.nombre_usuario = txtNombres_Usuario.Text;
            agregar.apellido_usuario = txtApellidos_Usuario.Text;
            string clave = txtCorreo_Usuario.Text + 2019;
            agregar.contraseña_usuario = clave;
            agregar.Correo = txtCorreo_Usuario.Text;
            agregar.dui = txtDUI_Usuario.Text;
            agregar.nit = txtNIT_Usuario.Text;
            agregar.id_estados = Convert.ToInt32(cbEstado_Usuario.SelectedValue.ToString());
            agregar.id_tipo_usuarios = Convert.ToInt32(cbTipo_Usuario.SelectedValue.ToString());
            int intentos = 1;
            agregar.intentos = Convert.ToString(intentos);
            agregar.empresa = Convert.ToInt32(cmb_emp.SelectedValue.ToString());

            MemoryStream ms = new MemoryStream();
            pbFoto_Usuario.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            string imagen = Convert.ToBase64String(aByte);
            agregar.Foto_usuario = imagen;
            int retorno = Funciones_usuarios.agregar_usu(agregar);


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
            actualizar.dui = txtDUI_Usuario.Text;
            actualizar.nit = txtNIT_Usuario.Text;



            MemoryStream ms = new MemoryStream();
            pbFoto_Usuario.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            string imagen = Convert.ToBase64String(aByte);
            actualizar.Foto_usuario = imagen;
            Funciones_usuarios.actualizarusu(actualizar);
        }
        public void eliminarusu()
        {

            if (MessageBox.Show("¿Esta seguro que desea eliminar el usuario?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                control_empresa.Eliminar_num(Convert.ToInt32(txtid_Usuario.Text));
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
            txtTelefono_Usuario.Text = this.dgvMostrar_Usuarios[4, posision].Value.ToString();
            pbFoto_Usuario.ImageLocation = this.dgvMostrar_Usuarios[6, posision].ValueType.ToString();
            txtCorreo_Usuario.Text = this.dgvMostrar_Usuarios[7, posision].Value.ToString();
            txtDUI_Usuario.Text = this.dgvMostrar_Usuarios[8, posision].Value.ToString();
            txtNIT_Usuario.Text = this.dgvMostrar_Usuarios[9, posision].Value.ToString();
            cbEstado_Usuario.Text = this.dgvMostrar_Usuarios[11, posision].Value.ToString();
            cbTipo_Usuario.Text = this.dgvMostrar_Usuarios[12, posision].Value.ToString();
            cmb_emp.Text = this.dgvMostrar_Usuarios[14, posision].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizares();
            mostrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eliminarusu();
            mostrar();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            mostrar();
            cbTipo_Usuario.DataSource = Funciones_usuarios.cargarUSU();
            cbTipo_Usuario.DisplayMember = "tipo_usuario";
            cbTipo_Usuario.ValueMember = "id_tipo_usuario";

            cbEstado_Usuario.DataSource = Funciones_usuarios.cargar();
            cbEstado_Usuario.DisplayMember = "Estado_usuario";
            cbEstado_Usuario.ValueMember = "id_estado_usuario";

            cmb_emp.DataSource = Funciones_usuarios.cargar1();
            cmb_emp.DisplayMember = "nombre";
            cmb_emp.ValueMember = "id_datos_empresa";
        }

        private void cbEstado_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
