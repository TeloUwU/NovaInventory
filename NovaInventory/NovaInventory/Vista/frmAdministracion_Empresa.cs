using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using NovaInventory.Config;
using NovaInventory.Controlador;
using NovaInventory.Modelo;
using System.Drawing.Imaging;
using System.IO;

namespace NovaInventory.Vista
{
    public partial class frmAdministracion_Empresa : Form
    {
        constructor_para_celulares actualizar = new constructor_para_celulares();
        public frmAdministracion_Empresa()
        {
            InitializeComponent();
        }
        public void agregarCEL()
        {
            if (string.IsNullOrWhiteSpace(txt_cel_Gestor.Text))
            {
                MessageBox.Show("Digite un numero de telefono para poder agregarlo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                 
               
            }
        }
        public void mostrarCEL()
        {
            dgvContactos.DataSource = control_empresa.mostrar_cel();
        }
        public void limpiar()
        {
            txt_cel_Gestor.Clear();
        }
        public void eliminar()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el numero de telefono?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                control_empresa.Eliminar_num(Convert.ToInt32(txtid_Empresa_Modificacion.Text));
            }
        }

        private void TxtEmpresa_Gestor_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Gestor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtEmpresa_Gestor.Text) || string.IsNullOrWhiteSpace(txtCorreo_Gestor.Text) || string.IsNullOrWhiteSpace(TxtNit_Gestor.Text) || string.IsNullOrWhiteSpace(TxtDireccion_Gestor.Text) || string.IsNullOrWhiteSpace(TxtLegal_Gestor.Text) || pbLogo_Gestor.Image == null)
            {
                MessageBox.Show("No puede dejar ningun campo vacio, porfavor llene los campos", "ADVERTENCIA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Constructor_empresa empresa = new Constructor_empresa();
                empresa.nombre = TxtEmpresa_Gestor.Text;
                empresa.nit = TxtNit_Gestor.Text;
                empresa.direccion = TxtDireccion_Gestor.Text;
                empresa.representante = TxtLegal_Gestor.Text;
                empresa.email = txtCorreo_Gestor.Text;
                int tipo_emp = 1;
                empresa.tipo_empresa = tipo_emp;

                MemoryStream ms = new MemoryStream();
                pbLogo_Gestor.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                string imagen = Convert.ToBase64String(aByte);
                empresa.foto_empresa = imagen;
                int retorno = control_empresa.registrarempresa(empresa);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAdministracion_Empresa_Load(object sender, EventArgs e)
        {

        }

        private void BtnExaminar_Gestor_Click(object sender, EventArgs e)
        {
            cargar_imagen.Filter = "Archivos de Imagen (.jpg)|*.jpg|Archivos de Imagen (.png)|*.png|Archivos de Imagen (.jpeg)|*.jpeg|Todos los archivos|*.*";
            DialogResult resultdo = cargar_imagen.ShowDialog();
            if (resultdo == DialogResult.OK)
            {
                pbLogo_Gestor.Image = Image.FromFile(cargar_imagen.FileName);
            }
        }


    }
}
