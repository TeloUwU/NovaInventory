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
    public partial class frm_nuevo : Form
    {
        public frm_nuevo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_cont.Text == txt_contf.Text)
            {

            }
        }

        private void frm_nuevo_Load(object sender, EventArgs e)
        {
            label5.Text = Constructor_login.usuario;
        }
    }
}
