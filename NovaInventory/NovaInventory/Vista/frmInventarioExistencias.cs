﻿using System;
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

namespace NovaInventory.Vista
{
    public partial class frmInventarioExistencias : Form
    {
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
    
        }
    }
}
