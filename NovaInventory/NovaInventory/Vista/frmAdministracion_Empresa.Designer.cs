namespace NovaInventory.Vista
{
    partial class frmAdministracion_Empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministracion_Empresa));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtid_Empresa_Modificacion = new System.Windows.Forms.TextBox();
            this.BtnGuardar_Gestor = new System.Windows.Forms.Button();
            this.BtnExaminar_Gestor = new System.Windows.Forms.Button();
            this.pbLogo_Gestor = new System.Windows.Forms.PictureBox();
            this.TxtDireccion_Gestor = new System.Windows.Forms.TextBox();
            this.TxtLegal_Gestor = new System.Windows.Forms.TextBox();
            this.TxtNit_Gestor = new System.Windows.Forms.TextBox();
            this.txtCorreo_Gestor = new System.Windows.Forms.TextBox();
            this.TxtEmpresa_Gestor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinalizar_Gestor = new System.Windows.Forms.Button();
            this.btnEliminarTelefono_Gestor = new System.Windows.Forms.Button();
            this.btnAgregarTelefono_Gestor = new System.Windows.Forms.Button();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.txt_cel_Gestor = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cargar_imagen = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Gestor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1044, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(176, 27);
            this.toolStripButton1.Text = "Gestion de Empresas";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::NovaInventory.Properties.Resources.undo_26px;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(172, 27);
            this.toolStripButton2.Text = "Cerrar Formulario";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.txtid_Empresa_Modificacion);
            this.panel2.Controls.Add(this.BtnGuardar_Gestor);
            this.panel2.Controls.Add(this.BtnExaminar_Gestor);
            this.panel2.Controls.Add(this.pbLogo_Gestor);
            this.panel2.Controls.Add(this.TxtDireccion_Gestor);
            this.panel2.Controls.Add(this.TxtLegal_Gestor);
            this.panel2.Controls.Add(this.TxtNit_Gestor);
            this.panel2.Controls.Add(this.txtCorreo_Gestor);
            this.panel2.Controls.Add(this.TxtEmpresa_Gestor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 573);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtid_Empresa_Modificacion
            // 
            this.txtid_Empresa_Modificacion.Location = new System.Drawing.Point(683, 16);
            this.txtid_Empresa_Modificacion.Name = "txtid_Empresa_Modificacion";
            this.txtid_Empresa_Modificacion.Size = new System.Drawing.Size(39, 22);
            this.txtid_Empresa_Modificacion.TabIndex = 70;
            this.txtid_Empresa_Modificacion.Visible = false;
            // 
            // BtnGuardar_Gestor
            // 
            this.BtnGuardar_Gestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnGuardar_Gestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGuardar_Gestor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnGuardar_Gestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar_Gestor.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar_Gestor.Location = new System.Drawing.Point(284, 502);
            this.BtnGuardar_Gestor.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGuardar_Gestor.Name = "BtnGuardar_Gestor";
            this.BtnGuardar_Gestor.Size = new System.Drawing.Size(249, 47);
            this.BtnGuardar_Gestor.TabIndex = 7;
            this.BtnGuardar_Gestor.Text = "Guardar y Continuar";
            this.BtnGuardar_Gestor.UseVisualStyleBackColor = false;
            this.BtnGuardar_Gestor.Click += new System.EventHandler(this.BtnGuardar_Gestor_Click);
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
            this.BtnExaminar_Gestor.Click += new System.EventHandler(this.BtnExaminar_Gestor_Click);
            // 
            // pbLogo_Gestor
            // 
            this.pbLogo_Gestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogo_Gestor.BackColor = System.Drawing.Color.White;
            this.pbLogo_Gestor.Location = new System.Drawing.Point(540, 122);
            this.pbLogo_Gestor.Margin = new System.Windows.Forms.Padding(5);
            this.pbLogo_Gestor.Name = "pbLogo_Gestor";
            this.pbLogo_Gestor.Size = new System.Drawing.Size(168, 225);
            this.pbLogo_Gestor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo_Gestor.TabIndex = 65;
            this.pbLogo_Gestor.TabStop = false;
            // 
            // TxtDireccion_Gestor
            // 
            this.TxtDireccion_Gestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtDireccion_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion_Gestor.Location = new System.Drawing.Point(8, 282);
            this.TxtDireccion_Gestor.Margin = new System.Windows.Forms.Padding(5);
            this.TxtDireccion_Gestor.MaxLength = 150;
            this.TxtDireccion_Gestor.Multiline = true;
            this.TxtDireccion_Gestor.Name = "TxtDireccion_Gestor";
            this.TxtDireccion_Gestor.Size = new System.Drawing.Size(494, 79);
            this.TxtDireccion_Gestor.TabIndex = 4;
            // 
            // TxtLegal_Gestor
            // 
            this.TxtLegal_Gestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtLegal_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLegal_Gestor.Location = new System.Drawing.Point(10, 407);
            this.TxtLegal_Gestor.Margin = new System.Windows.Forms.Padding(5);
            this.TxtLegal_Gestor.MaxLength = 75;
            this.TxtLegal_Gestor.Name = "TxtLegal_Gestor";
            this.TxtLegal_Gestor.Size = new System.Drawing.Size(494, 26);
            this.TxtLegal_Gestor.TabIndex = 5;
            // 
            // TxtNit_Gestor
            // 
            this.TxtNit_Gestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNit_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNit_Gestor.Location = new System.Drawing.Point(14, 203);
            this.TxtNit_Gestor.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNit_Gestor.MaxLength = 17;
            this.TxtNit_Gestor.Name = "TxtNit_Gestor";
            this.TxtNit_Gestor.Size = new System.Drawing.Size(494, 26);
            this.TxtNit_Gestor.TabIndex = 3;
            // 
            // txtCorreo_Gestor
            // 
            this.txtCorreo_Gestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCorreo_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo_Gestor.Location = new System.Drawing.Point(14, 122);
            this.txtCorreo_Gestor.Margin = new System.Windows.Forms.Padding(5);
            this.txtCorreo_Gestor.MaxLength = 45;
            this.txtCorreo_Gestor.Name = "txtCorreo_Gestor";
            this.txtCorreo_Gestor.Size = new System.Drawing.Size(494, 26);
            this.txtCorreo_Gestor.TabIndex = 2;
            // 
            // TxtEmpresa_Gestor
            // 
            this.TxtEmpresa_Gestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtEmpresa_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpresa_Gestor.Location = new System.Drawing.Point(13, 37);
            this.TxtEmpresa_Gestor.Margin = new System.Windows.Forms.Padding(5);
            this.TxtEmpresa_Gestor.MaxLength = 45;
            this.TxtEmpresa_Gestor.Name = "TxtEmpresa_Gestor";
            this.TxtEmpresa_Gestor.Size = new System.Drawing.Size(494, 26);
            this.TxtEmpresa_Gestor.TabIndex = 1;
            this.TxtEmpresa_Gestor.TextChanged += new System.EventHandler(this.TxtEmpresa_Gestor_TextChanged);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFinalizar_Gestor);
            this.panel1.Controls.Add(this.btnEliminarTelefono_Gestor);
            this.panel1.Controls.Add(this.btnAgregarTelefono_Gestor);
            this.panel1.Controls.Add(this.dgvContactos);
            this.panel1.Controls.Add(this.txt_cel_Gestor);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(781, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 573);
            this.panel1.TabIndex = 3;
            // 
            // btnFinalizar_Gestor
            // 
            this.btnFinalizar_Gestor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFinalizar_Gestor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalizar_Gestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar_Gestor.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar_Gestor.Location = new System.Drawing.Point(18, 502);
            this.btnFinalizar_Gestor.Margin = new System.Windows.Forms.Padding(5);
            this.btnFinalizar_Gestor.Name = "btnFinalizar_Gestor";
            this.btnFinalizar_Gestor.Size = new System.Drawing.Size(214, 47);
            this.btnFinalizar_Gestor.TabIndex = 11;
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
            this.btnEliminarTelefono_Gestor.Location = new System.Drawing.Point(142, 100);
            this.btnEliminarTelefono_Gestor.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminarTelefono_Gestor.Name = "btnEliminarTelefono_Gestor";
            this.btnEliminarTelefono_Gestor.Size = new System.Drawing.Size(90, 47);
            this.btnEliminarTelefono_Gestor.TabIndex = 10;
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
            this.btnAgregarTelefono_Gestor.Location = new System.Drawing.Point(18, 101);
            this.btnAgregarTelefono_Gestor.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarTelefono_Gestor.Name = "btnAgregarTelefono_Gestor";
            this.btnAgregarTelefono_Gestor.Size = new System.Drawing.Size(90, 47);
            this.btnAgregarTelefono_Gestor.TabIndex = 9;
            this.btnAgregarTelefono_Gestor.Text = "Agregar";
            this.btnAgregarTelefono_Gestor.UseVisualStyleBackColor = false;
            // 
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(18, 187);
            this.dgvContactos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Size = new System.Drawing.Size(214, 273);
            this.dgvContactos.TabIndex = 65;
            // 
            // txt_cel_Gestor
            // 
            this.txt_cel_Gestor.Location = new System.Drawing.Point(18, 57);
            this.txt_cel_Gestor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cel_Gestor.Mask = "0000-0000";
            this.txt_cel_Gestor.Name = "txt_cel_Gestor";
            this.txt_cel_Gestor.Size = new System.Drawing.Size(214, 22);
            this.txt_cel_Gestor.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "Numeros Telefonicos:";
            // 
            // frmAdministracion_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdministracion_Empresa";
            this.Text = "frmAdministracion_Empresa";
            this.Load += new System.EventHandler(this.frmAdministracion_Empresa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Gestor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnGuardar_Gestor;
        private System.Windows.Forms.Button BtnExaminar_Gestor;
        private System.Windows.Forms.PictureBox pbLogo_Gestor;
        private System.Windows.Forms.TextBox TxtDireccion_Gestor;
        private System.Windows.Forms.TextBox TxtLegal_Gestor;
        private System.Windows.Forms.TextBox TxtNit_Gestor;
        private System.Windows.Forms.TextBox txtCorreo_Gestor;
        private System.Windows.Forms.TextBox TxtEmpresa_Gestor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFinalizar_Gestor;
        private System.Windows.Forms.Button btnEliminarTelefono_Gestor;
        private System.Windows.Forms.Button btnAgregarTelefono_Gestor;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.MaskedTextBox txt_cel_Gestor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtid_Empresa_Modificacion;
        private System.Windows.Forms.OpenFileDialog cargar_imagen;
    }
}