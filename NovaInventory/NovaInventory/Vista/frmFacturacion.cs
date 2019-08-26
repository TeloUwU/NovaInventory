using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        /// </summary>




        private void frmFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Conteo = dgvLista.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
            if (Conteo != 0)
            {

                //RegistrarCompra

                try
                {
                    ClassBT.clsVenta.Fecha = lblFecha.Text;

                    ClassBT.clsVenta.Costo = float.Parse(lblCostoAPagar.Text);

                    ClassFunciones.clsFunciones.EjecutaQuery("RV");

                    DataTable d = new DataTable();
                    d = ClassFunciones.clsFunciones.EjecutaQueryConsulta("", "IDV");

                    ClassBT.clsDetallesVenta.IdVentafk = ClassBT.clsVenta.IdVenta = int.Parse(d.Rows[0][0].ToString());


                    for (int i = 0; i < Conteo; i++)
                    {
                        ClassBT.clsDetallesVenta.idProdcutofk = int.Parse(dgvLista.Rows[i].Cells[0].Value.ToString()); ;
                        ClassBT.clsDetallesVenta.Cantidad = float.Parse(dgvLista.Rows[i].Cells[3].Value.ToString());
                        ClassBT.clsDetallesVenta.CostoDetalle = float.Parse(dgvLista.Rows[i].Cells[2].Value.ToString());

                        ClassFunciones.clsFunciones.EjecutaQuery("RDV");//registra el detalle de la venta 

                    }
                }
                catch (Exception a)
                {

                    MessageBox.Show(a.Message);
                }


                ClassFunciones.clsFunciones.CreaTicket Ticket1 = new ClassFunciones.clsFunciones.CreaTicket();

                Ticket1.TextoCentro("Empresa xxxxx "); //imprime una linea de descripcion
                Ticket1.TextoCentro("**********************************");

                Ticket1.TextoIzquierda("Dirc: xxxx");
                Ticket1.TextoIzquierda("Tel:xxxx ");
                Ticket1.TextoIzquierda("Rnc: xxxx");
                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
                Ticket1.TextoIzquierda("No Fac:" + ClassBT.clsDetallesVenta.IdVentafk.ToString());
                Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("Le Atendio: xxxx");
                Ticket1.TextoIzquierda("");
                ClassFunciones.clsFunciones.CreaTicket.LineasGuion();

                ClassFunciones.clsFunciones.CreaTicket.EncabezadoVenta();
                ClassFunciones.clsFunciones.CreaTicket.LineasGuion();
                foreach (DataGridViewRow r in dgvLista.Rows)
                {
                    // Articulo                     //Precio                                    cantidad                            Subtotal
                    Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
                }


                ClassFunciones.clsFunciones.CreaTicket.LineasGuion();
                Ticket1.AgregaTotales("Sub-Total", double.Parse("000")); // imprime linea con Subtotal
                Ticket1.AgregaTotales("Menos Descuento", double.Parse("000")); // imprime linea con decuento total
                Ticket1.AgregaTotales("Mas ITBIS", double.Parse("000")); // imprime linea con ITBis total
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Total", double.Parse(lblCostoAPagar.Text)); // imprime linea con total
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
                Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblDevolucion.Text));


                // Ticket1.LineasTotales(); // imprime linea 

                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoCentro("*     Gracias por preferirnos    *");

                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda(" ");
                string impresora = "Microsoft XPS Document Writer";
                Ticket1.ImprimirTiket(impresora);




                Fila = 0;
                while (dgvLista.RowCount > 0)//limpia el dgv
                { dgvLista.Rows.Remove(dgvLista.CurrentRow); }
                //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();

                txtIdArticulo.Text = lblNombre.Text = txtCantidad.Text = txtEfectivo.Text = "";
                lblCostoAPagar.Text = lblDevolucion.Text = lblPrecio.Text = "0";
                txtIdArticulo.Focus();
                MessageBox.Show("Gracias por preferirnos");

            }
        }
    }
}
