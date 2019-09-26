using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace NovaInventory.Vista
{
    public partial class frmGenerarQR : Form
    {
        public frmGenerarQR()
        {
            InitializeComponent();
        }
        
        

        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGenerarQR_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Imagen png|*.png",
                InitialDirectory = @"C:\Users\Gepar\Desktop\Codigos barra"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pbgenerar.Image.Save(sfd.FileName);
            }
        }

        private void btnabrir_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Imagen png|*.png",
                InitialDirectory = @"C:\Users\Gepar\Desktop\Codigos barra"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbmostrararchivo.Image = Image.FromFile(ofd.FileName);
                BarcodeReader br = new BarcodeReader();
                string texto = br.Decode((Bitmap)pbmostrararchivo.Image).ToString();
                txtmostrar.Text = texto;
            }
        }

        private void txtnombre_TextChanged_1(object sender, EventArgs e)
        {
            if (txtnombre.Text != "")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write(txtnombre.Text), 300, 300);
                pbgenerar.Image = bm;
            }
        }
    }
}
