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
using NovaInventory.Config;
using NovaInventory.Controlador;

namespace NovaInventory.Vista
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }
        constructor_productos agregar = new constructor_productos();
        constructor_productos actualizar = new constructor_productos();
        costructor_categoria agre = new costructor_categoria();
        costructor_categoria actuli = new costructor_categoria();
        costructor_modelos agr = new costructor_modelos();
        costructor_modelos act = new costructor_modelos();

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void insertar_categoria()
        {
            agre.categoria = txtnombre.Text;
            int retorno = Crud_de_tres.agregar_categoria(agre);
        }
        public void mostrar_categorias()
        {
            dgb_categoria.DataSource = Crud_de_tres.mostra_categoria();
        }
        public void actualizar_categoria()
        {
            actuli.id_categoria = Convert.ToInt32(id_categoria.Text);
            actuli.categoria = txtnombre.Text;
            Crud_de_tres.actualizar_cat(actuli);
        }
        public void eliminar_categoria()
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar la categoria?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Crud_de_tres.eliminar_cate(Convert.ToInt16(id_categoria.Text));
            }
        }
        public void instertar_procuctos()
        {
            agregar.producto = txt_productos.Text;
            agregar.id_categorias = Convert.ToInt16(cmbCategoria);
            int retorno = Crud_de_tres.agregar_productos(agregar);
        }
        public void mostrar_productos()
        {
            dgb_productos.DataSource = Crud_de_tres.mostrar_producto();
        }
        public void actualizar_productos()
        {
            actualizar.id_producto = Convert.ToInt32(id_productos.Text);
            actualizar.producto = txt_productos.Text;
            actualizar.id_categorias = Convert.ToInt32(cmbCategoria.SelectedValue);
            Crud_de_tres.actualizar_productos(actualizar);
        }
        public void eliminar_productos()
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar la categoria?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Crud_de_tres.eliminar_productos(Convert.ToInt16(id_productos.Text));
            }
        }
        public void insertar_modelo()
        {
            agr.modelo = txt.Text;
            agr.id_producto =Convert.ToInt16( cmbproductos.SelectedValue);
            
        }
        public void mostrar_modelos()
        {
            dgb_modelo.DataSource = Crud_de_tres.mostra_modelo();
        }
        public void actualizar_modelo()
        {
            act.id_modelo = Convert.ToInt16(id_modelos.Text);
            act.modelo = txt.Text;
            act.id_producto = Convert.ToInt16(cmbproductos.SelectedValue);
        }
        public void eliminar_modelo()
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el modelo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Crud_de_tres.eliminar_modelo(Convert.ToInt16(id_modelos.Text));
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            insertar_categoria();      
        }

        private void btn_agregar_pr_Click(object sender, EventArgs e)
        {
            instertar_procuctos();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            mostrar_categorias();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizar_categoria();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            eliminar_categoria();
        }

        private void btn_mostrar_pr_Click(object sender, EventArgs e)
        {
            mostrar_productos();
        }

        private void btn_actualizar_pr_Click(object sender, EventArgs e)
        {
            actualizar_productos();
        }

        private void btn_eliminar_prr_Click(object sender, EventArgs e)
        {
            eliminar_productos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            insertar_modelo();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrar_modelos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizar_modelo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eliminar_modelo();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = Validar_prodictos.cargar();
            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.ValueMember = "id_categoria";

            cmbproductos.DataSource = Validar_prodictos.cargar1();
            cmbproductos.DisplayMember = "productos";
            cmbproductos.ValueMember = "id_producto";
        }
    }
}