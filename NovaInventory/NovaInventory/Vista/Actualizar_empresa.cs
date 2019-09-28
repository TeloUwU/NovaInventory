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
    public partial class Actualizar_empresa : Form
    {
        public Actualizar_empresa()
        {
            InitializeComponent();
        }

        private void BtnExaminar_Gestor_Click(object sender, EventArgs e)
        {
            Cargar_imagen.Filter = "Archivos de Imagen (.jpg)|*.jpg|Archivos de Imagen (.png)|*.png|Archivos de Imagen (.jpeg)|*.jpeg|Todos los archivos|*.*";
            DialogResult resultdo = Cargar_imagen.ShowDialog();
            if (resultdo == DialogResult.OK)
            {
                pbLogo_Gestor.Image = Image.FromFile(Cargar_imagen.FileName);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
