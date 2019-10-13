using System;
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
using NovaInventory.idioma;

namespace NovaInventory.Vista
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }
        public static int idiom;
        constructor_productos agregar = new constructor_productos();
        constructor_productos actualizar = new constructor_productos();
        costructor_categoria agre = new costructor_categoria();
        costructor_categoria actuli = new costructor_categoria();
        costructor_modelos agr = new costructor_modelos();
        costructor_modelos act = new costructor_modelos();

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void limpiar_modelo()
        {
            txtnombre.Clear();
            txt_productos.Clear();
            txt.Clear();
        }
     
        public void insertar_categoria()
        {
            agre.categoria = txtnombre.Text;
            int retorno = Crud_de_tres.agregar_categoria(agre);
            if (retorno >= 1)
            {
                cmbCategoria.DataSource = Validar_prodictos.cargar();
                cmbCategoria.DisplayMember = "categoria";
                cmbCategoria.ValueMember = "id_categoria";
                mostrar_categorias();
            }

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
            cmbCategoria.DataSource = Validar_prodictos.cargar();
            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.ValueMember = "id_categoria";
            mostrar_categorias();
        }
        public void eliminar_categoria()
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar la categoria?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Crud_de_tres.eliminar_cate(Convert.ToInt16(id_categoria.Text));
                cmbCategoria.DataSource = Validar_prodictos.cargar();
                cmbCategoria.DisplayMember = "categoria";
                cmbCategoria.ValueMember = "id_categoria";
                mostrar_categorias();
            }
        }
        public void instertar_procuctos()
        {
            agregar.producto = txt_productos.Text;
            agregar.id_categorias = Convert.ToInt16(cmbCategoria.SelectedValue);
            int retorno = Crud_de_tres.agregar_productos(agregar);
            if (retorno>=1)
            {
                groupBox3.Enabled = true;
                mostrar_modelos();
                cmbproductos.DataSource = Validar_prodictos.cargar1();
                cmbproductos.DisplayMember = "producto";
                cmbproductos.ValueMember = "id_producto";
            }
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
            mostrar_modelos();
            cmbproductos.DataSource = Validar_prodictos.cargar1();
            cmbproductos.DisplayMember = "producto";
            cmbproductos.ValueMember = "id_producto";
        }
        public void eliminar_productos()
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar la categoria?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Crud_de_tres.eliminar_productos(Convert.ToInt16(id_productos.Text));
                mostrar_modelos();
                cmbproductos.DataSource = Validar_prodictos.cargar1();
                cmbproductos.DisplayMember = "producto";
                cmbproductos.ValueMember = "id_producto";
            }
        }
        public void tocar1()
        {
            int posision;
            posision = this.dgb_categoria.CurrentRow.Index;
            id_categoria.Text = this.dgb_categoria[0, posision].Value.ToString();
            txtnombre.Text = this.dgb_categoria[1, posision].Value.ToString();
        }
        public void tocar2()
        {
            int posision;
            posision = this.dgb_productos.CurrentRow.Index;
            id_productos.Text = this.dgb_productos[0, posision].Value.ToString();
            txt_productos.Text = this.dgb_productos[1, posision].Value.ToString();
            cmbCategoria.Text = this.dgb_productos[2, posision].Value.ToString();
        }
        public void toca2()
        {
            int posision;
            posision = this.dgb_modelo.CurrentRow.Index;
            id_modelos.Text = this.dgb_modelo[0, posision].Value.ToString();
            txt.Text = this.dgb_modelo[1, posision].Value.ToString();
            cmbproductos.Text = this.dgb_modelo[2, posision].Value.ToString();
        }
        public void insertar_modelo()
        {
            agr.modelo = txt.Text;
            agr.id_producto =Convert.ToInt16( cmbproductos.SelectedValue);
            int retorno = Crud_de_tres.agregar_modelo(agr);
            mostrar_modelos();

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
            Crud_de_tres.actualizar_modelo(act);
            mostrar_modelos();
        }
        public void eliminar_modelo()
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el modelo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Crud_de_tres.eliminar_modelo(Convert.ToInt16(id_modelos.Text));
                mostrar_modelos();
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            insertar_categoria();
            mostrar_categorias();
            limpiar_modelo();
            cmbCategoria.DataSource = Validar_prodictos.cargar();
            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.ValueMember = "id_categoria";
            groupBox2.Enabled = true;
        }

        private void btn_agregar_pr_Click(object sender, EventArgs e)
        {
            instertar_procuctos();
            limpiar_modelo();
            mostrar_productos();
            cmbproductos.DataSource = Validar_prodictos.cargar1();
            cmbproductos.DisplayMember = "producto";
            cmbproductos.ValueMember = "id_producto";
            groupBox3.Enabled = true;
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            mostrar_categorias();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizar_categoria();
            limpiar_modelo();
            mostrar_categorias();
            cmbCategoria.DataSource = Validar_prodictos.cargar();
            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.ValueMember = "id_categoria";
            groupBox2.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            eliminar_categoria();
            limpiar_modelo();
            mostrar_categorias();
            cmbCategoria.DataSource = Validar_prodictos.cargar();
            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.ValueMember = "id_categoria";
            groupBox2.Enabled = true;
        }

        private void btn_mostrar_pr_Click(object sender, EventArgs e)
        {
            mostrar_productos();

        }

        private void btn_actualizar_pr_Click(object sender, EventArgs e)
        {
            actualizar_productos();
            limpiar_modelo();
            mostrar_productos();
            cmbproductos.DataSource = Validar_prodictos.cargar1();
            cmbproductos.DisplayMember = "producto";
            cmbproductos.ValueMember = "id_producto";
            groupBox3.Enabled = true;
        }

        private void btn_eliminar_prr_Click(object sender, EventArgs e)
        {
            eliminar_productos();
            limpiar_modelo();
            mostrar_productos();
            cmbproductos.DataSource = Validar_prodictos.cargar1();
            cmbproductos.DisplayMember = "producto";
            cmbproductos.ValueMember = "id_producto";
            groupBox3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            insertar_modelo();
            limpiar_modelo();
            mostrar_modelos();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrar_modelos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizar_modelo();
            limpiar_modelo();
            mostrar_modelos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eliminar_modelo();
            limpiar_modelo();
            mostrar_modelos();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            if (Validar_prodictos.verificar_categoria()==true)
            {
                if (Validar_prodictos.verificar_productos()==true)
                {
                    groupBox3.Enabled = true;
                    groupBox2.Enabled = true;
                }
                else
                {
                    groupBox3.Enabled = false;
                }
                groupBox3.Enabled = true;
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox3.Enabled = false;
                groupBox2.Enabled = false;
            }
            cmbCategoria.DataSource = Validar_prodictos.cargar();
            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.ValueMember = "id_categoria";
            mostrar_modelos();
            mostrar_productos();
            mostrar_categorias();
            cmbproductos.DataSource = Validar_prodictos.cargar1();
            cmbproductos.DisplayMember = "producto";
            cmbproductos.ValueMember = "id_producto";
        }

        private void dgb_categoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tocar1();
        }

        private void dgb_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tocar2();
        }

        private void dgb_modelo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toca2();
        }
        void ingle()
        {
            if (idiom==1)
            {
                label1.Text = ingles.gabriel;
                label2.Text = ingles.daniel;
                label3.Text = ingles.mate;
                btn_agregar.Text = ingles.xd;
                btn_mostrar.Text = ingles.monti;
                btn_actualizar.Text = ingles.no;
                btn_eliminar.Text = ingles.lol;
                btn_agregar_pr.Text = ingles.xd;
                btn_mostrar_pr.Text = ingles.monti;
                btn_actualizar.Text = ingles.no;
                btn_eliminar_prr.Text = ingles.lol;
                button4.Text = ingles.xd;
                button3.Text = ingles.monti;
                button2.Text = ingles.no;
                button1.Text = ingles.lol;
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
