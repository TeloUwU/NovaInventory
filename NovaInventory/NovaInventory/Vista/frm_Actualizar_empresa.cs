using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NovaInventory.Config;
using NovaInventory.Controlador;

namespace NovaInventory.Vista
{
    public partial class frm_Actualizar_empresa : Form
    {
        public frm_Actualizar_empresa()
        {
            InitializeComponent();
        }

        private void TxtEditar_Empresa_TextChanged(object sender, EventArgs e)
        {

        }
        constructor_para_celulares agregar = new constructor_para_celulares();
        public void agregarCEL()
        {
            if (string.IsNullOrWhiteSpace(txtEditar_cel.Text))
            {
                MessageBox.Show("Digite un numero de telefono para poder agregarlo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                agregar.numeros_tel = txtEditar_cel.Text;
                int id = control_empresa.Id(agregar);
                agregar.empresas = id;
                int datos = control_empresa.Agregar_tel(agregar);
            }
        }

        public void mostrarCEL()
        {
            dgv_Contactos.DataSource = control_empresa.mostrar_cel();
        }
        public void limpiar()
        {
            txtEditar_cel.Clear();
        }
        private void btnAgregarTelefono_Gestor_Click(object sender, EventArgs e)
        {
            if (txtEditar_cel.Text == "    -    ")
            {
                MessageBox.Show("Llena los campos de telefono", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                agregarCEL();
                mostrarCEL();
                txtEditar_cel.Clear();
            }

        }
        
        public void eliminar()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el numero de telefono?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                control_empresa.Eliminar_num(Convert.ToInt32(txtEditar_cel.Text));
            }
        }


        private void btnEliminarTelefono_Gestor_Click(object sender, EventArgs e)
        {

            eliminar();
            mostrarCEL();
            mostrarCEL();
            txtEditar_cel.Clear();
            txtEditar_cel.Clear();
        }
    }
}
