namespace NovaInventory.Vista
{
    partial class frm_Actualizar_empresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinalizar_Gestor = new System.Windows.Forms.Button();
            this.btnEliminarTelefono_Gestor = new System.Windows.Forms.Button();
            this.btnAgregarTelefono_Gestor = new System.Windows.Forms.Button();
            this.dgv_Contactos = new System.Windows.Forms.DataGridView();
            this.txtEditar_cel = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtid_Empresa_Modificacion = new System.Windows.Forms.TextBox();
            this.BtnExaminar_Gestor = new System.Windows.Forms.Button();
            this.TxtEditar_Direccion = new System.Windows.Forms.TextBox();
            this.TxtEditar_Legal = new System.Windows.Forms.TextBox();
            this.TxtEditar_Nit = new System.Windows.Forms.TextBox();
            this.txtEditar_Correo = new System.Windows.Forms.TextBox();
            this.TxtEditar_Empresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbEditar_Logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Contactos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFinalizar_Gestor);
            this.panel1.Controls.Add(this.btnEliminarTelefono_Gestor);
            this.panel1.Controls.Add(this.btnAgregarTelefono_Gestor);
            this.panel1.Controls.Add(this.dgv_Contactos);
            this.panel1.Controls.Add(this.txtEditar_cel);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(763, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 574);
            this.panel1.TabIndex = 5;
            // 
            // btnFinalizar_Gestor
            // 
            this.btnFinalizar_Gestor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFinalizar_Gestor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalizar_Gestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar_Gestor.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar_Gestor.Location = new System.Drawing.Point(19, 502);
            this.btnFinalizar_Gestor.Margin = new System.Windows.Forms.Padding(5);
            this.btnFinalizar_Gestor.Name = "btnFinalizar_Gestor";
            this.btnFinalizar_Gestor.Size = new System.Drawing.Size(213, 47);
            this.btnFinalizar_Gestor.TabIndex = 16;
            this.btnFinalizar_Gestor.Text = "Finalizar Registro";
            this.btnFinalizar_Gestor.UseVisualStyleBackColor = false;
            // 
            // btnEliminarTelefono_Gestor
            // 
            this.btnEliminarTelefono_Gestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarTelefono_Gestor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminarTelefono_Gestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTelefono_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTelefono_Gestor.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTelefono_Gestor.Location = new System.Drawing.Point(141, 100);
            this.btnEliminarTelefono_Gestor.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminarTelefono_Gestor.Name = "btnEliminarTelefono_Gestor";
            this.btnEliminarTelefono_Gestor.Size = new System.Drawing.Size(91, 47);
            this.btnEliminarTelefono_Gestor.TabIndex = 13;
            this.btnEliminarTelefono_Gestor.Text = "Eliminar";
            this.btnEliminarTelefono_Gestor.UseVisualStyleBackColor = false;
            // 
            // btnAgregarTelefono_Gestor
            // 
            this.btnAgregarTelefono_Gestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarTelefono_Gestor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarTelefono_Gestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTelefono_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTelefono_Gestor.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTelefono_Gestor.Location = new System.Drawing.Point(19, 101);
            this.btnAgregarTelefono_Gestor.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarTelefono_Gestor.Name = "btnAgregarTelefono_Gestor";
            this.btnAgregarTelefono_Gestor.Size = new System.Drawing.Size(91, 47);
            this.btnAgregarTelefono_Gestor.TabIndex = 12;
            this.btnAgregarTelefono_Gestor.Text = "Agregar";
            this.btnAgregarTelefono_Gestor.UseVisualStyleBackColor = false;
            // 
            // dgv_Contactos
            // 
            this.dgv_Contactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Contactos.Location = new System.Drawing.Point(19, 187);
            this.dgv_Contactos.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Contactos.Name = "dgv_Contactos";
            this.dgv_Contactos.Size = new System.Drawing.Size(213, 273);
            this.dgv_Contactos.TabIndex = 15;
            // 
            // txtEditar_cel
            // 
            this.txtEditar_cel.Location = new System.Drawing.Point(19, 57);
            this.txtEditar_cel.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditar_cel.Mask = "0000-0000";
            this.txtEditar_cel.Name = "txtEditar_cel";
            this.txtEditar_cel.Size = new System.Drawing.Size(215, 22);
            this.txtEditar_cel.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "Numeros Telefonicos:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtid_Empresa_Modificacion);
            this.panel2.Controls.Add(this.BtnExaminar_Gestor);
            this.panel2.Controls.Add(this.pbEditar_Logo);
            this.panel2.Controls.Add(this.TxtEditar_Direccion);
            this.panel2.Controls.Add(this.TxtEditar_Legal);
            this.panel2.Controls.Add(this.TxtEditar_Nit);
            this.panel2.Controls.Add(this.txtEditar_Correo);
            this.panel2.Controls.Add(this.TxtEditar_Empresa);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 22);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 574);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(371, 484);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "Modificar Empresa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(60, 484);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Revisar Empresa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtid_Empresa_Modificacion
            // 
            this.txtid_Empresa_Modificacion.Location = new System.Drawing.Point(683, 16);
            this.txtid_Empresa_Modificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid_Empresa_Modificacion.Name = "txtid_Empresa_Modificacion";
            this.txtid_Empresa_Modificacion.Size = new System.Drawing.Size(39, 22);
            this.txtid_Empresa_Modificacion.TabIndex = 70;
            this.txtid_Empresa_Modificacion.Visible = false;
            // 
            // BtnExaminar_Gestor
            // 
            this.BtnExaminar_Gestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnExaminar_Gestor.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnExaminar_Gestor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnExaminar_Gestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExaminar_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExaminar_Gestor.ForeColor = System.Drawing.Color.White;
            this.BtnExaminar_Gestor.Location = new System.Drawing.Point(544, 386);
            this.BtnExaminar_Gestor.Margin = new System.Windows.Forms.Padding(5);
            this.BtnExaminar_Gestor.Name = "BtnExaminar_Gestor";
            this.BtnExaminar_Gestor.Size = new System.Drawing.Size(164, 47);
            this.BtnExaminar_Gestor.TabIndex = 6;
            this.BtnExaminar_Gestor.Text = "Examinar";
            this.BtnExaminar_Gestor.UseVisualStyleBackColor = false;
            // 
            // TxtEditar_Direccion
            // 
            this.TxtEditar_Direccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtEditar_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEditar_Direccion.Location = new System.Drawing.Point(13, 282);
            this.TxtEditar_Direccion.Margin = new System.Windows.Forms.Padding(5);
            this.TxtEditar_Direccion.MaxLength = 3;
            this.TxtEditar_Direccion.Multiline = true;
            this.TxtEditar_Direccion.Name = "TxtEditar_Direccion";
            this.TxtEditar_Direccion.Size = new System.Drawing.Size(488, 79);
            this.TxtEditar_Direccion.TabIndex = 4;
            // 
            // TxtEditar_Legal
            // 
            this.TxtEditar_Legal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtEditar_Legal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEditar_Legal.Location = new System.Drawing.Point(13, 407);
            this.TxtEditar_Legal.Margin = new System.Windows.Forms.Padding(5);
            this.TxtEditar_Legal.MaxLength = 4;
            this.TxtEditar_Legal.Name = "TxtEditar_Legal";
            this.TxtEditar_Legal.Size = new System.Drawing.Size(489, 26);
            this.TxtEditar_Legal.TabIndex = 5;
            // 
            // TxtEditar_Nit
            // 
            this.TxtEditar_Nit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtEditar_Nit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEditar_Nit.Location = new System.Drawing.Point(13, 203);
            this.TxtEditar_Nit.Margin = new System.Windows.Forms.Padding(5);
            this.TxtEditar_Nit.MaxLength = 2;
            this.TxtEditar_Nit.Name = "TxtEditar_Nit";
            this.TxtEditar_Nit.Size = new System.Drawing.Size(495, 26);
            this.TxtEditar_Nit.TabIndex = 3;
            // 
            // txtEditar_Correo
            // 
            this.txtEditar_Correo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditar_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditar_Correo.Location = new System.Drawing.Point(13, 122);
            this.txtEditar_Correo.Margin = new System.Windows.Forms.Padding(5);
            this.txtEditar_Correo.MaxLength = 1;
            this.txtEditar_Correo.Name = "txtEditar_Correo";
            this.txtEditar_Correo.ShortcutsEnabled = false;
            this.txtEditar_Correo.Size = new System.Drawing.Size(495, 26);
            this.txtEditar_Correo.TabIndex = 2;
            // 
            // TxtEditar_Empresa
            // 
            this.TxtEditar_Empresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtEditar_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEditar_Empresa.Location = new System.Drawing.Point(13, 37);
            this.TxtEditar_Empresa.Margin = new System.Windows.Forms.Padding(5);
            this.TxtEditar_Empresa.MaxLength = 45;
            this.TxtEditar_Empresa.Name = "TxtEditar_Empresa";
            this.TxtEditar_Empresa.ShortcutsEnabled = false;
            this.TxtEditar_Empresa.Size = new System.Drawing.Size(495, 26);
            this.TxtEditar_Empresa.TabIndex = 1;
            this.TxtEditar_Empresa.TextChanged += new System.EventHandler(this.TxtEditar_Empresa_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Dirección: * ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 382);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Representante Legal: * ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Numero de Identificacion Tributario: * ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Correo Institucional:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(568, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "Logo Empresa";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nombre de la Empresa: *";
            // 
            // pbEditar_Logo
            // 
            this.pbEditar_Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbEditar_Logo.BackColor = System.Drawing.Color.White;
            this.pbEditar_Logo.Location = new System.Drawing.Point(540, 122);
            this.pbEditar_Logo.Margin = new System.Windows.Forms.Padding(5);
            this.pbEditar_Logo.Name = "pbEditar_Logo";
            this.pbEditar_Logo.Size = new System.Drawing.Size(168, 225);
            this.pbEditar_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar_Logo.TabIndex = 65;
            this.pbEditar_Logo.TabStop = false;
            // 
            // frm_Actualizar_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Actualizar_empresa";
            this.Text = "frm_Actualizar_empresa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Contactos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFinalizar_Gestor;
        private System.Windows.Forms.Button btnEliminarTelefono_Gestor;
        private System.Windows.Forms.Button btnAgregarTelefono_Gestor;
        private System.Windows.Forms.DataGridView dgv_Contactos;
        private System.Windows.Forms.MaskedTextBox txtEditar_cel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtid_Empresa_Modificacion;
        private System.Windows.Forms.Button BtnExaminar_Gestor;
        private System.Windows.Forms.PictureBox pbEditar_Logo;
        private System.Windows.Forms.TextBox TxtEditar_Direccion;
        private System.Windows.Forms.TextBox TxtEditar_Legal;
        private System.Windows.Forms.TextBox TxtEditar_Nit;
        private System.Windows.Forms.TextBox txtEditar_Correo;
        private System.Windows.Forms.TextBox TxtEditar_Empresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
    }
}