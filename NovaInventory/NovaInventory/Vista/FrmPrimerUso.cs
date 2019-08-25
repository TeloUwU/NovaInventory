using System;
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
    public partial class FrmPrimerUso : Form
    {
        constructor_para_celulares agregar = new constructor_para_celulares();
    
        public FrmPrimerUso()
        {
            InitializeComponent();
        }
        public void agregarCEL()
        {
            if (string.IsNullOrWhiteSpace(txt_cel.Text))
            {
                MessageBox.Show("Digite un numero de telefono para poder agregarlo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                agregar.numeros_tel = txt_cel.Text;
                int id = control_empresa.Id(agregar);
                agregar.empresas = id;
                int datos = control_empresa.Agregar_tel(agregar);
            }
        }
        public void mostrarCEL()
        {
            dgvContactos.DataSource = control_empresa.mostrar_cel();
        }
        public void limpiar()
        {
            txt_cel.Clear();
        }
        public void eliminar()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el numero de telefono?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                control_empresa.Eliminar_num(Convert.ToInt32(txt_id.Text));
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtEmpresa.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(TxtNit.Text) || string.IsNullOrWhiteSpace(TxtDireccion.Text) || string.IsNullOrWhiteSpace(TxtLegal.Text) || pbLogo.Image == null)
            {
                MessageBox.Show("No puede dejar ningun campo vacio, porfavor llene los campos", "ADVERTENCIA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Constructor_empresa empresa = new Constructor_empresa();
                empresa.nombre = TxtEmpresa.Text;
                empresa.nit = TxtNit.Text;
                empresa.direccion = TxtDireccion.Text;
                empresa.representante = TxtLegal.Text;
                empresa.email = txtCorreo.Text;
                int tipo_emp = 1;
                empresa.tipo_empresa = tipo_emp;

                MemoryStream ms = new MemoryStream();
                pbLogo.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                string imagen = Convert.ToBase64String(aByte);
                empresa.foto_empresa = imagen;
                int retorno = control_empresa.registrarempresa(empresa);

                if (retorno >= 1)
                {
                    grpEmpresa.Enabled = false;
                    grpContactos.Enabled = true;
                    mostrarCEL();
                }
            }
            /*Hay que validar boton para que cuando se registre la empresa
             se pueda activar el groupbox de telefono, donde inicialmente el groupbox
             de telefono estará inhabilitado.*/
            
        }

        private void FrmPrimerUso_Load(object sender, EventArgs e)
        {
            grpContactos.Enabled = false;
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            CargarImagen.Filter = "Archivos de Imagen (.jpg)|*.jpg|Archivos de Imagen (.png)|*.png|Archivos de Imagen (.jpeg)|*.jpeg|Todos los archivos|*.*";
            DialogResult resultdo = CargarImagen.ShowDialog();
            if (resultdo == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(CargarImagen.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_cel.Text == "    -    ")
            {
                MessageBox.Show("Llena los campos de telefono", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                agregarCEL();
                mostrarCEL();
                mostrarCEL();
                txt_cel.Clear();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eliminar();
            mostrarCEL();
            mostrarCEL();
            txt_cel.Clear();
            txt_id.Clear();
        }

        private void dgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int position;
            position = this.dgvContactos.CurrentRow.Index;
            txt_id.Text = this.dgvContactos[0, position].Value.ToString();
            txt_cel.Text= this.dgvContactos[1, position].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Ya has terminado re registrar tu empresa?","CONFIRMACION",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                FrmPrimerUsuario primer_usuario = new FrmPrimerUsuario();
                primer_usuario.Show();
                this.Hide();
            }

        }
    }
}
