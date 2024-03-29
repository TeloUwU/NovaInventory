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
using NovaInventory.Modelo;
using NovaInventory.Vista;

namespace NovaInventory.Vista
{
    public partial class frmFacturacion : Form
    {
        public static int idiom;
        public frmFacturacion()
        {
            InitializeComponent();
        }
        string jj = Constructor_login.nombre;

        private void btnCargarLista_Click(object sender, EventArgs e)
        {

        }

        public void agregar_factura()
        {


        }
     
        /// <summary>
        void mostra()
        {
            dgvLista.DataSource = control_facturacion.mostrar_fac();
        }

        public void CostoApagar()
        {
        }




        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            mostra();
            textBox3.Text = jj;
            textBox3.Enabled = false;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            
            
        }
      
        CONSTRUCTORDEFACTURA actu = new CONSTRUCTORDEFACTURA();
        void agregar()
        {
            CONSTRUCTORDEFACTURA agrega = new CONSTRUCTORDEFACTURA();

            agrega.Cantidad = txtCantidad.Text;
            agrega.CostoDetalle = textBox6.Text;
            agrega.Fecha = dtPick.Text;
            agrega.Nombre = txtNombre.Text;
            agrega.creado_por = jj;
            int retorno = control_facturacion.agregar_fac(agrega);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarLista_Click_1(object sender, EventArgs e)
        {
            double r, n1, n2;

            n1 = Convert.ToInt16(textBox6.Text);
            n2 = Convert.ToInt16(txtCantidad.Text);
            r = (n1 * n2);
            lblCostoAPagar.Text = Convert.ToString(r);

            agregar();

        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        void actualizar()
        {
            actu.id_factura = Convert.ToInt16(textBox2.Text);
            actu.Nombre = txtNombre.Text;
            actu.CostoDetalle = textBox6.Text;
            actu.Cantidad = txtCantidad.Text;
            actu.Fecha = dtPick.Text;
            actu.creado_por = textBox3.Text;
            actu.id_estado = Convert.ToInt16(cbEstado_Fac.SelectedValue);
            control_facturacion.actualizarfac(actu);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
        void toca()
        {
            int posision;
            posision = this.dgvLista.CurrentRow.Index;
            textBox2.Text = this.dgvLista[0, posision].Value.ToString();
            txtNombre.Text = this.dgvLista[1, posision].Value.ToString();
            txtCantidad.Text = this.dgvLista[3, posision].Value.ToString();
            cbEstado_Fac.Text = Convert.ToString(this.dgvLista[5, posision].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmInventarioExistencias frm = new frmInventarioExistencias();
            frm.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        void eliminar()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el detalle?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                control_facturacion.eliminar(Convert.ToInt32(txtIdArticulo.Text));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toca();
        }

        public void ingles()
        {
            if (idiom == 1)
            {
                label2.Text = idioma.ingles.nFactura;
                lblNombre.Text = idioma.ingles.Nombre_producto;
                label1.Text = idioma.ingles.id_art;
                lblCantidad.Text = idioma.ingles.cantiDAD;
                label9.Text = idioma.ingles.PrecioUnitariooooo;
                label8.Text = idioma.ingles.FACturadetallE;
                label5.Text = idioma.ingles.CREACION;
                label3.Text = idioma.ingles.Cajero;
                btnCargarLista.Text = idioma.ingles.AgrFact;
                label4.Text = idioma.ingles.DIsponibilidad;
                label7.Text = idioma.ingles.TtPagar;
                btnVender.Text = idioma.ingles.FinFact;
                button2.Text = idioma.ingles.ActuDet;
                button1.Text = idioma.ingles.EliminFact;
                button3.Text = idioma.ingles.ConsultInvent;
            }
            else
            {
                label2.Text = ("N° Factura");
                lblNombre.Text = ("Código o Nombre del producto");
                label1.Text = ("Id Artículo");
                lblCantidad.Text = ("Cantidad");
                label9.Text = ("Precio Unitario");
                label8.Text = ("Detalle de Factura:");
                label5.Text = ("Fecha");
                label3.Text = ("Cajero/a");
                btnCargarLista.Text = ("Agregar a factura");
                label4.Text = ("Disponibilidad");
                label7.Text = ("Total a pagar");
                btnVender.Text = ("Finalizar Factura");
                button2.Text = ("Actualizar detalle");
                button1.Text = ("Eliminar del detalle");
                button3.Text = ("Consultar inventario");
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

