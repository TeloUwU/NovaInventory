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
using NovaInventory.Controlador;

namespace NovaInventory.Vista
{
    public partial class frmPreguntasSeguridad_RecuperarContra : Form
    {
        public frmPreguntasSeguridad_RecuperarContra()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmRecuperar_Contraseña Recuperar = new frmRecuperar_Contraseña();
            Recuperar.Show();
            this.Close();
        }

       

        private void frmPreguntasSeguridad_RecuperarContra_Load(object sender, EventArgs e)
        {
            cbPregunta_1.DataSource = preguntas_y_respuestas.cargar();
            cbPregunta_1.DisplayMember = "pregunta";
            cbPregunta_1.ValueMember = "id_pregunta";

            cbPregunta_2.DataSource = preguntas_y_respuestas.cargar();
            cbPregunta_2.DisplayMember = "pregunta";
            cbPregunta_2.ValueMember = "id_pregunta";

            cbPregunta_3.DataSource = preguntas_y_respuestas.cargar();
            cbPregunta_3.DisplayMember = "pregunta";
            cbPregunta_3.ValueMember = "id_pregunta";

            cbPregunta_4.DataSource = preguntas_y_respuestas.cargar();
            cbPregunta_4.DisplayMember = "pregunta";
            cbPregunta_4.ValueMember = "id_pregunta";
        }

        private void btnCambiar_Recu_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Preguntas_Click(object sender, EventArgs e)
        {
            constructor_de_respuestas resp = new constructor_de_respuestas();
            resp.Respuesta = txtRespuesta_1.Text;
            resp.preguntas =Convert.ToInt32(cbPregunta_1.SelectedIndex.ToString());
            resp.Respuesta = txtRespuesta_2.Text;
            resp.preguntas = Convert.ToInt32(cbPregunta_2.SelectedIndex.ToString());
            resp.Respuesta = txtRespuesta_3.Text;
            resp.preguntas = Convert.ToInt32(cbPregunta_3.SelectedIndex.ToString());
            resp.Respuesta = txtRepuesta_4.Text;
            resp.preguntas = Convert.ToInt32(cbPregunta_4.SelectedIndex.ToString());
        }
    }
}
