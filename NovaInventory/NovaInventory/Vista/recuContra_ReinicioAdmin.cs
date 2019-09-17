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
using NovaInventory.Controlador;
using NovaInventory.Vista;
using NovaInventory.Config;

namespace NovaInventory.Vista
{
    public partial class recuContra_ReinicioAdmin : Form
    {
        public recuContra_ReinicioAdmin()
        {
            InitializeComponent();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            string clave =  txtUsuario.Text + 2019;
            clave = Validaciones.md5(clave);
            constructor_primer_usuario actualizar = new constructor_primer_usuario();
            actualizar.contraseña_usuario = clave;

        }
        public void mostrar()
        {
            dgvMostrar_Usuarios.DataSource = Funciones_usuarios.mostrar_usu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
