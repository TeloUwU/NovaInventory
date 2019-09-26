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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtid_Empresa_Modificacion = new System.Windows.Forms.TextBox();
            this.BtnExaminar_Gestor = new System.Windows.Forms.Button();
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
            this.pbLogo_Gestor = new System.Windows.Forms.PictureBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Gestor)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(783, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtid_Empresa_Modificacion);
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
            this.panel2.Location = new System.Drawing.Point(9, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 466);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(278, 393);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Modificar Empresa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(45, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Revisar Empresa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtid_Empresa_Modificacion
            // 
            this.txtid_Empresa_Modificacion.Location = new System.Drawing.Point(512, 13);
            this.txtid_Empresa_Modificacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtid_Empresa_Modificacion.Name = "txtid_Empresa_Modificacion";
            this.txtid_Empresa_Modificacion.Size = new System.Drawing.Size(30, 20);
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
            this.BtnExaminar_Gestor.Location = new System.Drawing.Point(408, 314);
            this.BtnExaminar_Gestor.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExaminar_Gestor.Name = "BtnExaminar_Gestor";
            this.BtnExaminar_Gestor.Size = new System.Drawing.Size(123, 38);
            this.BtnExaminar_Gestor.TabIndex = 6;
            this.BtnExaminar_Gestor.Text = "Examinar";
            this.BtnExaminar_Gestor.UseVisualStyleBackColor = false;
            this.BtnExaminar_Gestor.Click += new System.EventHandler(this.BtnExaminar_Gestor_Click);
            // 
            // TxtDireccion_Gestor
            // 
            this.TxtDireccion_Gestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtDireccion_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion_Gestor.Location = new System.Drawing.Point(10, 229);
            this.TxtDireccion_Gestor.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDireccion_Gestor.MaxLength = 3;
            this.TxtDireccion_Gestor.Multiline = true;
            this.TxtDireccion_Gestor.Name = "TxtDireccion_Gestor";
            this.TxtDireccion_Gestor.Size = new System.Drawing.Size(367, 65);
            this.TxtDireccion_Gestor.TabIndex = 4;
            // 
            // TxtLegal_Gestor
            // 
            this.TxtLegal_Gestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtLegal_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLegal_Gestor.Location = new System.Drawing.Point(10, 331);
            this.TxtLegal_Gestor.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLegal_Gestor.MaxLength = 4;
            this.TxtLegal_Gestor.Name = "TxtLegal_Gestor";
            this.TxtLegal_Gestor.Size = new System.Drawing.Size(368, 22);
            this.TxtLegal_Gestor.TabIndex = 5;
            // 
            // TxtNit_Gestor
            // 
            this.TxtNit_Gestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNit_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNit_Gestor.Location = new System.Drawing.Point(10, 165);
            this.TxtNit_Gestor.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNit_Gestor.MaxLength = 2;
            this.TxtNit_Gestor.Name = "TxtNit_Gestor";
            this.TxtNit_Gestor.Size = new System.Drawing.Size(372, 22);
            this.TxtNit_Gestor.TabIndex = 3;
            this.TxtNit_Gestor.TextChanged += new System.EventHandler(this.TxtNit_Gestor_TextChanged);
            // 
            // txtCorreo_Gestor
            // 
            this.txtCorreo_Gestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCorreo_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo_Gestor.Location = new System.Drawing.Point(10, 99);
            this.txtCorreo_Gestor.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo_Gestor.MaxLength = 1;
            this.txtCorreo_Gestor.Name = "txtCorreo_Gestor";
            this.txtCorreo_Gestor.ShortcutsEnabled = false;
            this.txtCorreo_Gestor.Size = new System.Drawing.Size(372, 22);
            this.txtCorreo_Gestor.TabIndex = 2;
            // 
            // TxtEmpresa_Gestor
            // 
            this.TxtEmpresa_Gestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtEmpresa_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpresa_Gestor.Location = new System.Drawing.Point(10, 30);
            this.TxtEmpresa_Gestor.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmpresa_Gestor.MaxLength = 45;
            this.TxtEmpresa_Gestor.Name = "TxtEmpresa_Gestor";
            this.TxtEmpresa_Gestor.ShortcutsEnabled = false;
            this.TxtEmpresa_Gestor.Size = new System.Drawing.Size(372, 22);
            this.TxtEmpresa_Gestor.TabIndex = 1;
            this.TxtEmpresa_Gestor.TextChanged += new System.EventHandler(this.TxtEmpresa_Gestor_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Dirección: * ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Representante Legal: * ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Numero de Identificacion Tributario: * ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "Correo Institucional:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(426, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 60;
            this.label10.Text = "Logo Empresa";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
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
            this.panel1.Location = new System.Drawing.Point(586, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 466);
            this.panel1.TabIndex = 3;
            // 
            // btnFinalizar_Gestor
            // 
            this.btnFinalizar_Gestor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFinalizar_Gestor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalizar_Gestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar_Gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar_Gestor.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar_Gestor.Location = new System.Drawing.Point(14, 408);
            this.btnFinalizar_Gestor.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar_Gestor.Name = "btnFinalizar_Gestor";
            this.btnFinalizar_Gestor.Size = new System.Drawing.Size(160, 38);
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
            this.btnEliminarTelefono_Gestor.Location = new System.Drawing.Point(106, 81);
            this.btnEliminarTelefono_Gestor.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarTelefono_Gestor.Name = "btnEliminarTelefono_Gestor";
            this.btnEliminarTelefono_Gestor.Size = new System.Drawing.Size(68, 38);
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
            this.btnAgregarTelefono_Gestor.Location = new System.Drawing.Point(14, 82);
            this.btnAgregarTelefono_Gestor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTelefono_Gestor.Name = "btnAgregarTelefono_Gestor";
            this.btnAgregarTelefono_Gestor.Size = new System.Drawing.Size(68, 38);
            this.btnAgregarTelefono_Gestor.TabIndex = 12;
            this.btnAgregarTelefono_Gestor.Text = "Agregar";
            this.btnAgregarTelefono_Gestor.UseVisualStyleBackColor = false;
            // 
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(14, 152);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Size = new System.Drawing.Size(160, 222);
            this.dgvContactos.TabIndex = 15;
            // 
            // txt_cel_Gestor
            // 
            this.txt_cel_Gestor.Location = new System.Drawing.Point(14, 46);
            this.txt_cel_Gestor.Mask = "0000-0000";
            this.txt_cel_Gestor.Name = "txt_cel_Gestor";
            this.txt_cel_Gestor.Size = new System.Drawing.Size(162, 20);
            this.txt_cel_Gestor.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Numeros Telefonicos:";
            // 
            // pbLogo_Gestor
            // 
            this.pbLogo_Gestor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogo_Gestor.BackColor = System.Drawing.Color.White;
            this.pbLogo_Gestor.Location = new System.Drawing.Point(405, 99);
            this.pbLogo_Gestor.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo_Gestor.Name = "pbLogo_Gestor";
            this.pbLogo_Gestor.Size = new System.Drawing.Size(126, 183);
            this.pbLogo_Gestor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo_Gestor.TabIndex = 65;
            this.pbLogo_Gestor.TabStop = false;
            this.pbLogo_Gestor.Click += new System.EventHandler(this.pbLogo_Gestor_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(140, 24);
            this.toolStripButton1.Text = "Gestion de Empresas";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::NovaInventory.Properties.Resources.undo_26px;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(141, 24);
            this.toolStripButton2.Text = "Cerrar Formulario";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frmAdministracion_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdministracion_Empresa";
            this.Text = "frmAdministracion_Empresa";
            this.Load += new System.EventHandler(this.frmAdministracion_Empresa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Gestor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}