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
using MySql.Data.MySqlClient;
using NovaInventory.Config;
using NovaInventory.Modelo;

namespace NovaInventory.Vista
{
    public partial class frmInventarioExistencias : Form
    {

        public static int idiom;
        public frmInventarioExistencias()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void mos()
        {
            dataGridView1.DataSource = crudCompra.Compras();
        }
        public int Producto()
        {
            string nombre = comboBox1.Text;
            int retorno = 0;
            try
            {
                MySqlCommand producto = new MySqlCommand(string.Format("SELECT id_producto FROM productos WHERE producto = '" + nombre + "';"), Conexion.obtenerconexion());
                textBox1.Text = Convert.ToString(producto.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("la compra no se ha realizado por la selección de producto, llame a un tecnico" + ex, "Carga Proveedor Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return retorno;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mos();
            Producto();
            comboBox1.DataSource = crudCompra.CargarProducto();
            comboBox1.DisplayMember = "id_producto";
            comboBox1.ValueMember = "producto";
        }

        private void frmInventarioExistencias_Load(object sender, EventArgs e)
        {
            //comboBox1.DataSource = inventario.mostrar_producto();
            //comboBox1.DisplayMember = "producto";
            //comboBox1.ValueMember = "producto1";
            //comboBox1.SelectedValue = "1";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ingles()
        {
            if (idiom == 1)
            {
                btnBuscarProducto.Text = idioma.ingles.Buscar_Producto;
                tslExisInventario.Text = idioma.ingles.Existencias_Inventario;
                tslCerrar.Text = idioma.ingles.Cerrar_Formulario;
            }
            else
            {
                btnBuscarProducto.Text = ("Buscar Producto");
                tslExisInventario.Text = ("Existencias del Inventario");
                tslCerrar.Text = ("Cerrar Formulario");
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
            ingles();
        }
    }
}
