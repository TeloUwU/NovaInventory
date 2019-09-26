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
    public partial class frmFacturacion : Form
    {
        constructorFacturacion agregar = new constructorFacturacion();
        constructorFacturacion actualizar = new constructorFacturacion();
        public frmFacturacion()
        {
            InitializeComponent();
        }
        string[,] ListaVenta = new string[200, 6];
        int Fila = 0;
       

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            
        }

        public void agregar_factura()
        {
            //    agregar.Fecha = dateTimePicker1.Text;
            //    agregar.nombre_usuario = txtNombres_Usuario.Text;
            //    agregar.apellido_usuario = txtApellidos_Usuario.Text;
            //    agregar.contraseña_usuario = clave;
            //    agregar.telefono = txtTelefono_Usuario.Text;
            //    agregar.Correo = txtCorreo_Usuario.Text;
            //    agregar.dui = txtDUI_Usuario.Text;
            //    agregar.nit = txtNIT_Usuario.Text;
            //    agregar.id_estados = Convert.ToInt32(cbEstado_Usuario.SelectedValue);
            //    agregar.id_tipo_usuarios = Convert.ToInt32(cbTipo_Usuario.SelectedValue);
            //    int intentos = 1;
            //    agregar.intentos = Convert.ToString(intentos);
            //    agregar.empresa = Convert.ToInt32(cmb_emp.SelectedValue);
            //    MemoryStream ms = new MemoryStream();
            //    pbFoto_Usuario.Image.Save(ms, ImageFormat.Jpeg);
            //    byte[] aByte = ms.ToArray();
            //    string imagen = Convert.ToBase64String(aByte);
            //    agregar.Foto_usuario = imagen;
            //    int retorno = Funciones_usuarios.agregar_usu(agregar);


        }

        /// <summary>


        public void CostoApagar()
        {
            float CostoTotal = 0;
            int Conteo = 0;

            Conteo = dgvLista.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
            for (int i = 0; i < Conteo; i++)
            {

                CostoTotal += float.Parse(dgvLista.Rows[i].Cells[4].Value.ToString());



            }

            lblCostoAPagar.Text = CostoTotal.ToString();
            
        }




        private void frmFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarLista_Click_1(object sender, EventArgs e)
        {
            //agregarusu();
            //mostrar();
            //mostrar();
            //limpiar();

        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

