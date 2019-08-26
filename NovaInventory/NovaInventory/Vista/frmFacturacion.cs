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

namespace NovaInventory.Vista
{
    public partial class frmFacturacion : Form
    {
        public frmFacturacion()
        {
            InitializeComponent();
        }
        string[,] ListaVenta = new string[200, 6];
        int Fila = 0;

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdArticulo.Text != "" && txtCantidad.Text != "" && txtNombre.Text != "" && txtPrecio.Text != "")
                {
                    ListaVenta[Fila, 0] = txtIdArticulo.Text;
                    ListaVenta[Fila, 1] = txtNombre.Text;
                    ListaVenta[Fila, 2] = txtPrecio.Text;
                    ListaVenta[Fila, 3] = txtCantidad.Text;
                    ListaVenta[Fila, 4] = (float.Parse(txtPrecio.Text) * float.Parse(txtCantidad.Text)).ToString();

                    dgvLista.Rows.Add(ListaVenta[Fila, 0], ListaVenta[Fila, 1], ListaVenta[Fila, 2], ListaVenta[Fila, 3], ListaVenta[Fila, 4]);
                    Fila++;
                    txtIdArticulo.Text = txtNombre.Text = txtPrecio.Text = txtCantidad.Text = "";
                    txtIdArticulo.Focus();

                }
            }
            catch
            {

            }
            CostoApagar();
        }
         public void CostoApagar()
        {
            float CostoTotal = 0;
            int Conteo = 0;

            Conteo = dgvLista.RowCount; 
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
            clsFunciones.CreaTicket Ticket1 = new clsFunciones.CreaTicket();

            Ticket1.TextoCentro("Empresa Elecnova ");
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("Dirc: San Salvador");
            Ticket1.TextoIzquierda("Tel: 7127-6891");
            Ticket1.TextoIzquierda("Rnc: xxxx");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta");
            Ticket1.TextoIzquierda("No Fac: 001");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: Andrea Turcios ");
            Ticket1.TextoIzquierda("");
            clsFunciones.CreaTicket.LineasGuion();

            clsFunciones.CreaTicket.EncabezadoVenta();
            clsFunciones.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dgvLista.Rows)
            { //                        Nombre del articulo                Precio                                   Cantidad                                SubTotal 


                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[3].Value.ToString()), int.Parse(r.Cells[2].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }
            

            clsFunciones.CreaTicket.LineasGuion();
            Ticket1.AgregaTotales("Sub-Total", double.Parse("0")); 
            Ticket1.AgregaTotales("Menos Descuento", double.Parse("0")); 
            Ticket1.AgregaTotales("Mas ITBIS", double.Parse("0")); 
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(lblCostoAPagar.Text)); 
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblDevolucion.Text));
            

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer"; 
            Ticket1.ImprimirTiket(impresora);


            Fila = 0;
            while (dgvLista.RowCount > 0)
            { dgvLista.Rows.Remove(dgvLista.CurrentRow); }
            txtIdArticulo.Text = txtNombre.Text = txtPrecio.Text = txtCantidad.Text = txtEfectivo.Text = "";
            lblCostoAPagar.Text = lblDevolucion.Text = "0.00";
        }

        private void btnCargarLista_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtIdArticulo.Text != "" && txtCantidad.Text != "")
                {


                    ListaVenta[Fila, 0] = txtIdArticulo.Text;
                    ListaVenta[Fila, 1] = txtNombre.Text;
                    ListaVenta[Fila, 2] = txtPrecio.Text;
                    ListaVenta[Fila, 3] = txtCantidad.Text;
                    ListaVenta[Fila, 4] = (float.Parse(txtPrecio.Text) * float.Parse(txtCantidad.Text)).ToString();



                    dgvLista.Rows.Add(ListaVenta[Fila, 0], ListaVenta[Fila, 1], ListaVenta[Fila, 2], ListaVenta[Fila, 3], ListaVenta[Fila, 4]);
                    Fila++;
                    txtIdArticulo.Text = txtNombre.Text = txtPrecio.Text = txtCantidad.Text = "";

                    txtIdArticulo.Focus();

                }
            }
            catch
            {

            }
            CostoApagar();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDevolucion.Text = (float.Parse(txtEfectivo.Text) - float.Parse(lblCostoAPagar.Text)).ToString();
            }
            catch 
            {

                lblDevolucion.Text = "0.00";
            }
            
    }
    }
}


