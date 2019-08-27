﻿namespace NovaInventory.Vista
{
    partial class frmConfig_Root
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig_Root));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnCambiar_clave = new System.Windows.Forms.Button();
            this.txt_cel_Root = new System.Windows.Forms.MaskedTextBox();
            this.BtnExaminar_Root = new System.Windows.Forms.Button();
            this.cmbTipoUsuario_Root = new System.Windows.Forms.ComboBox();
            this.cmbEstado_Root = new System.Windows.Forms.ComboBox();
            this.cmbEmpresa_Root = new System.Windows.Forms.ComboBox();
            this.dtNacimiento_Root = new System.Windows.Forms.DateTimePicker();
            this.maskDui_Root = new System.Windows.Forms.MaskedTextBox();
            this.pbFoto_Root = new System.Windows.Forms.PictureBox();
            this.txtConfClave_Root = new System.Windows.Forms.TextBox();
            this.txtApellidos_Root = new System.Windows.Forms.TextBox();
            this.txtEmail_Root = new System.Windows.Forms.TextBox();
            this.txtUsuario_Root = new System.Windows.Forms.TextBox();
            this.txtClave_Root = new System.Windows.Forms.TextBox();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.txtNombre_Root = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid_Root = new System.Windows.Forms.TextBox();
            this.openCargarImagen = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtclave_anterior_root = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto_Root)).BeginInit();
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(174, 24);
            this.toolStripButton1.Text = "Configuración de Usuario Root";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = global::NovaInventory.Properties.Resources.undo_26px;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(124, 24);
            this.toolStripButton2.Text = "Cerrar Formulario";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnCambiar_clave
            // 
            this.btnCambiar_clave.BackColor = System.Drawing.Color.Green;
            this.btnCambiar_clave.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar_clave.ForeColor = System.Drawing.Color.White;
            this.btnCambiar_clave.Location = new System.Drawing.Point(325, 344);
            this.btnCambiar_clave.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiar_clave.Name = "btnCambiar_clave";
            this.btnCambiar_clave.Size = new System.Drawing.Size(242, 50);
            this.btnCambiar_clave.TabIndex = 14;
            this.btnCambiar_clave.Text = "Cambiar Clave";
            this.btnCambiar_clave.UseVisualStyleBackColor = false;
            this.btnCambiar_clave.Click += new System.EventHandler(this.btnSobreescribir_Root_Click);
            // 
            // txt_cel_Root
            // 
            this.txt_cel_Root.Location = new System.Drawing.Point(324, 179);
            this.txt_cel_Root.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cel_Root.Mask = "(000) 0000-0000";
            this.txt_cel_Root.Name = "txt_cel_Root";
            this.txt_cel_Root.Size = new System.Drawing.Size(235, 20);
            this.txt_cel_Root.TabIndex = 6;
            // 
            // BtnExaminar_Root
            // 
            this.BtnExaminar_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnExaminar_Root.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnExaminar_Root.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnExaminar_Root.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExaminar_Root.ForeColor = System.Drawing.Color.White;
            this.BtnExaminar_Root.Location = new System.Drawing.Point(617, 318);
            this.BtnExaminar_Root.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExaminar_Root.Name = "BtnExaminar_Root";
            this.BtnExaminar_Root.Size = new System.Drawing.Size(141, 32);
            this.BtnExaminar_Root.TabIndex = 13;
            this.BtnExaminar_Root.Text = "Cargar Imagen";
            this.BtnExaminar_Root.UseVisualStyleBackColor = false;
            // 
            // cmbTipoUsuario_Root
            // 
            this.cmbTipoUsuario_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTipoUsuario_Root.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario_Root.FormattingEnabled = true;
            this.cmbTipoUsuario_Root.Location = new System.Drawing.Point(325, 236);
            this.cmbTipoUsuario_Root.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoUsuario_Root.Name = "cmbTipoUsuario_Root";
            this.cmbTipoUsuario_Root.Size = new System.Drawing.Size(235, 21);
            this.cmbTipoUsuario_Root.TabIndex = 8;
            // 
            // cmbEstado_Root
            // 
            this.cmbEstado_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEstado_Root.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado_Root.FormattingEnabled = true;
            this.cmbEstado_Root.Location = new System.Drawing.Point(40, 287);
            this.cmbEstado_Root.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado_Root.Name = "cmbEstado_Root";
            this.cmbEstado_Root.Size = new System.Drawing.Size(232, 21);
            this.cmbEstado_Root.TabIndex = 9;
            // 
            // cmbEmpresa_Root
            // 
            this.cmbEmpresa_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEmpresa_Root.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa_Root.FormattingEnabled = true;
            this.cmbEmpresa_Root.Location = new System.Drawing.Point(42, 179);
            this.cmbEmpresa_Root.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmpresa_Root.Name = "cmbEmpresa_Root";
            this.cmbEmpresa_Root.Size = new System.Drawing.Size(236, 21);
            this.cmbEmpresa_Root.TabIndex = 5;
            // 
            // dtNacimiento_Root
            // 
            this.dtNacimiento_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNacimiento_Root.CustomFormat = "yyyy/MM/dd";
            this.dtNacimiento_Root.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNacimiento_Root.Location = new System.Drawing.Point(324, 127);
            this.dtNacimiento_Root.Margin = new System.Windows.Forms.Padding(2);
            this.dtNacimiento_Root.Name = "dtNacimiento_Root";
            this.dtNacimiento_Root.Size = new System.Drawing.Size(235, 20);
            this.dtNacimiento_Root.TabIndex = 4;
            // 
            // maskDui_Root
            // 
            this.maskDui_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskDui_Root.Location = new System.Drawing.Point(40, 124);
            this.maskDui_Root.Margin = new System.Windows.Forms.Padding(2);
            this.maskDui_Root.Mask = "00000000-0";
            this.maskDui_Root.Name = "maskDui_Root";
            this.maskDui_Root.Size = new System.Drawing.Size(234, 20);
            this.maskDui_Root.TabIndex = 3;
            // 
            // pbFoto_Root
            // 
            this.pbFoto_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbFoto_Root.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbFoto_Root.Location = new System.Drawing.Point(629, 124);
            this.pbFoto_Root.Margin = new System.Windows.Forms.Padding(2);
            this.pbFoto_Root.Name = "pbFoto_Root";
            this.pbFoto_Root.Size = new System.Drawing.Size(105, 144);
            this.pbFoto_Root.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto_Root.TabIndex = 109;
            this.pbFoto_Root.TabStop = false;
            // 
            // txtConfClave_Root
            // 
            this.txtConfClave_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConfClave_Root.Location = new System.Drawing.Point(324, 478);
            this.txtConfClave_Root.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfClave_Root.Name = "txtConfClave_Root";
            this.txtConfClave_Root.Size = new System.Drawing.Size(235, 20);
            this.txtConfClave_Root.TabIndex = 12;
            // 
            // txtApellidos_Root
            // 
            this.txtApellidos_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellidos_Root.Location = new System.Drawing.Point(324, 72);
            this.txtApellidos_Root.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos_Root.Name = "txtApellidos_Root";
            this.txtApellidos_Root.Size = new System.Drawing.Size(235, 20);
            this.txtApellidos_Root.TabIndex = 2;
            // 
            // txtEmail_Root
            // 
            this.txtEmail_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail_Root.Location = new System.Drawing.Point(41, 237);
            this.txtEmail_Root.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail_Root.Name = "txtEmail_Root";
            this.txtEmail_Root.Size = new System.Drawing.Size(235, 20);
            this.txtEmail_Root.TabIndex = 7;
            // 
            // txtUsuario_Root
            // 
            this.txtUsuario_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario_Root.Location = new System.Drawing.Point(325, 287);
            this.txtUsuario_Root.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario_Root.Name = "txtUsuario_Root";
            this.txtUsuario_Root.Size = new System.Drawing.Size(235, 20);
            this.txtUsuario_Root.TabIndex = 10;
            // 
            // txtClave_Root
            // 
            this.txtClave_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClave_Root.Location = new System.Drawing.Point(42, 478);
            this.txtClave_Root.Margin = new System.Windows.Forms.Padding(2);
            this.txtClave_Root.MaxLength = 45;
            this.txtClave_Root.Name = "txtClave_Root";
            this.txtClave_Root.Size = new System.Drawing.Size(234, 20);
            this.txtClave_Root.TabIndex = 11;
            // 
            // txtCarne
            // 
            this.txtCarne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCarne.Location = new System.Drawing.Point(40, 124);
            this.txtCarne.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarne.MaxLength = 8;
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(234, 20);
            this.txtCarne.TabIndex = 103;
            // 
            // txtNombre_Root
            // 
            this.txtNombre_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre_Root.Location = new System.Drawing.Point(41, 72);
            this.txtNombre_Root.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre_Root.MaxLength = 45;
            this.txtNombre_Root.Name = "txtNombre_Root";
            this.txtNombre_Root.Size = new System.Drawing.Size(234, 20);
            this.txtNombre_Root.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(321, 459);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 18);
            this.label9.TabIndex = 104;
            this.label9.Text = "Confirmar clave:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(322, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 96;
            this.label8.Text = "Tipo Usuario:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 459);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 18);
            this.label11.TabIndex = 108;
            this.label11.Text = "Clave:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(322, 162);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 18);
            this.label15.TabIndex = 105;
            this.label15.Text = "Numero Telefonico:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 98;
            this.label7.Text = "Estado:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(40, 219);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 18);
            this.label14.TabIndex = 106;
            this.label14.Text = "Correo electrónico:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 107;
            this.label3.Text = "Usuario:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 18);
            this.label6.TabIndex = 97;
            this.label6.Text = "Empresa a la que pertenece:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 100;
            this.label5.Text = "Nacimiento:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 99;
            this.label4.Text = "Documento:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(638, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 18);
            this.label12.TabIndex = 102;
            this.label12.Text = "Foto de perfil:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 101;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 95;
            this.label1.Text = "Nombres:";
            // 
            // txtid_Root
            // 
            this.txtid_Root.Location = new System.Drawing.Point(744, 40);
            this.txtid_Root.Margin = new System.Windows.Forms.Padding(2);
            this.txtid_Root.Name = "txtid_Root";
            this.txtid_Root.Size = new System.Drawing.Size(22, 20);
            this.txtid_Root.TabIndex = 110;
            this.txtid_Root.Visible = false;
            // 
            // openCargarImagen
            // 
            this.openCargarImagen.FileName = "openCargarImagen";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(45, 344);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 50);
            this.button1.TabIndex = 111;
            this.button1.Text = "Actualizar Datos";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtclave_anterior_root
            // 
            this.txtclave_anterior_root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtclave_anterior_root.Location = new System.Drawing.Point(42, 430);
            this.txtclave_anterior_root.Margin = new System.Windows.Forms.Padding(2);
            this.txtclave_anterior_root.MaxLength = 45;
            this.txtclave_anterior_root.Name = "txtclave_anterior_root";
            this.txtclave_anterior_root.Size = new System.Drawing.Size(234, 20);
            this.txtclave_anterior_root.TabIndex = 112;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 411);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 18);
            this.label10.TabIndex = 113;
            this.label10.Text = "Clave anterior:";
            // 
            // frmConfig_Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 540);
            this.Controls.Add(this.txtclave_anterior_root);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtid_Root);
            this.Controls.Add(this.btnCambiar_clave);
            this.Controls.Add(this.txt_cel_Root);
            this.Controls.Add(this.BtnExaminar_Root);
            this.Controls.Add(this.cmbTipoUsuario_Root);
            this.Controls.Add(this.cmbEstado_Root);
            this.Controls.Add(this.cmbEmpresa_Root);
            this.Controls.Add(this.dtNacimiento_Root);
            this.Controls.Add(this.maskDui_Root);
            this.Controls.Add(this.pbFoto_Root);
            this.Controls.Add(this.txtConfClave_Root);
            this.Controls.Add(this.txtApellidos_Root);
            this.Controls.Add(this.txtEmail_Root);
            this.Controls.Add(this.txtUsuario_Root);
            this.Controls.Add(this.txtClave_Root);
            this.Controls.Add(this.txtCarne);
            this.Controls.Add(this.txtNombre_Root);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConfig_Root";
            this.Text = "frmConfig_Root";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto_Root)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button btnCambiar_clave;
        private System.Windows.Forms.MaskedTextBox txt_cel_Root;
        private System.Windows.Forms.Button BtnExaminar_Root;
        private System.Windows.Forms.ComboBox cmbTipoUsuario_Root;
        private System.Windows.Forms.ComboBox cmbEstado_Root;
        private System.Windows.Forms.ComboBox cmbEmpresa_Root;
        private System.Windows.Forms.DateTimePicker dtNacimiento_Root;
        private System.Windows.Forms.MaskedTextBox maskDui_Root;
        private System.Windows.Forms.PictureBox pbFoto_Root;
        private System.Windows.Forms.TextBox txtConfClave_Root;
        private System.Windows.Forms.TextBox txtApellidos_Root;
        private System.Windows.Forms.TextBox txtEmail_Root;
        private System.Windows.Forms.TextBox txtUsuario_Root;
        private System.Windows.Forms.TextBox txtClave_Root;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.TextBox txtNombre_Root;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid_Root;
        private System.Windows.Forms.OpenFileDialog openCargarImagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtclave_anterior_root;
        private System.Windows.Forms.Label label10;
        //private Bunifu.Framework.UI.BunifuFlatButton Guardar;
    }
}