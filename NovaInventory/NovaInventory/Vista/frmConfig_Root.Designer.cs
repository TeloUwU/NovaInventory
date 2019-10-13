namespace NovaInventory.Vista
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
            this.btnCambiar_clave = new System.Windows.Forms.Button();
            this.txt_cel_Root = new System.Windows.Forms.MaskedTextBox();
            this.BtnCargarImagen_Root = new System.Windows.Forms.Button();
            this.cmbEstado_Root = new System.Windows.Forms.ComboBox();
            this.cmbEmpresa_Root = new System.Windows.Forms.ComboBox();
            this.dtNacimiento_Root = new System.Windows.Forms.DateTimePicker();
            this.maskDui_Root = new System.Windows.Forms.MaskedTextBox();
            this.txtConfClave_Root = new System.Windows.Forms.TextBox();
            this.txtApellidos_Root = new System.Windows.Forms.TextBox();
            this.txtEmail_Root = new System.Windows.Forms.TextBox();
            this.txtUsuario_Root = new System.Windows.Forms.TextBox();
            this.txtClave_Root = new System.Windows.Forms.TextBox();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.txtNombre_Root = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.button_actualizar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_regresar = new System.Windows.Forms.ToolStripButton();
            this.pbFoto_Root = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto_Root)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCambiar_clave
            // 
            this.btnCambiar_clave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCambiar_clave.BackColor = System.Drawing.Color.Green;
            this.btnCambiar_clave.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar_clave.ForeColor = System.Drawing.Color.White;
            this.btnCambiar_clave.Location = new System.Drawing.Point(424, 411);
            this.btnCambiar_clave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCambiar_clave.Name = "btnCambiar_clave";
            this.btnCambiar_clave.Size = new System.Drawing.Size(323, 62);
            this.btnCambiar_clave.TabIndex = 14;
            this.btnCambiar_clave.Text = "Cambiar Clave";
            this.btnCambiar_clave.UseVisualStyleBackColor = false;
            this.btnCambiar_clave.Click += new System.EventHandler(this.btnSobreescribir_Root_Click);
            // 
            // txt_cel_Root
            // 
            this.txt_cel_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_cel_Root.Location = new System.Drawing.Point(432, 220);
            this.txt_cel_Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cel_Root.Mask = " 0000-0000";
            this.txt_cel_Root.Name = "txt_cel_Root";
            this.txt_cel_Root.ShortcutsEnabled = false;
            this.txt_cel_Root.Size = new System.Drawing.Size(312, 22);
            this.txt_cel_Root.TabIndex = 6;
            // 
            // BtnCargarImagen_Root
            // 
            this.BtnCargarImagen_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCargarImagen_Root.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCargarImagen_Root.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnCargarImagen_Root.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargarImagen_Root.ForeColor = System.Drawing.Color.White;
            this.BtnCargarImagen_Root.Location = new System.Drawing.Point(816, 353);
            this.BtnCargarImagen_Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCargarImagen_Root.Name = "BtnCargarImagen_Root";
            this.BtnCargarImagen_Root.Size = new System.Drawing.Size(188, 39);
            this.BtnCargarImagen_Root.TabIndex = 10;
            this.BtnCargarImagen_Root.Text = "Cargar Imagen";
            this.BtnCargarImagen_Root.UseVisualStyleBackColor = false;
            this.BtnCargarImagen_Root.Click += new System.EventHandler(this.BtnCargarImagen_Root_Click);
            // 
            // cmbEstado_Root
            // 
            this.cmbEstado_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEstado_Root.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado_Root.FormattingEnabled = true;
            this.cmbEstado_Root.Location = new System.Drawing.Point(53, 353);
            this.cmbEstado_Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstado_Root.Name = "cmbEstado_Root";
            this.cmbEstado_Root.Size = new System.Drawing.Size(308, 24);
            this.cmbEstado_Root.TabIndex = 9;
            this.cmbEstado_Root.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_Root_SelectedIndexChanged);
            // 
            // cmbEmpresa_Root
            // 
            this.cmbEmpresa_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEmpresa_Root.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa_Root.FormattingEnabled = true;
            this.cmbEmpresa_Root.Location = new System.Drawing.Point(56, 220);
            this.cmbEmpresa_Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmpresa_Root.Name = "cmbEmpresa_Root";
            this.cmbEmpresa_Root.Size = new System.Drawing.Size(313, 24);
            this.cmbEmpresa_Root.TabIndex = 5;
            this.cmbEmpresa_Root.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_Root_SelectedIndexChanged);
            // 
            // dtNacimiento_Root
            // 
            this.dtNacimiento_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNacimiento_Root.CustomFormat = "yyyy/MM/dd";
            this.dtNacimiento_Root.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNacimiento_Root.Location = new System.Drawing.Point(432, 156);
            this.dtNacimiento_Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNacimiento_Root.Name = "dtNacimiento_Root";
            this.dtNacimiento_Root.Size = new System.Drawing.Size(312, 22);
            this.dtNacimiento_Root.TabIndex = 4;
            // 
            // maskDui_Root
            // 
            this.maskDui_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskDui_Root.Location = new System.Drawing.Point(53, 153);
            this.maskDui_Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskDui_Root.Mask = "00000000-0";
            this.maskDui_Root.Name = "maskDui_Root";
            this.maskDui_Root.ShortcutsEnabled = false;
            this.maskDui_Root.Size = new System.Drawing.Size(311, 22);
            this.maskDui_Root.TabIndex = 3;
            // 
            // txtConfClave_Root
            // 
            this.txtConfClave_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConfClave_Root.Location = new System.Drawing.Point(433, 540);
            this.txtConfClave_Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfClave_Root.MaxLength = 50;
            this.txtConfClave_Root.Name = "txtConfClave_Root";
            this.txtConfClave_Root.PasswordChar = '*';
            this.txtConfClave_Root.ShortcutsEnabled = false;
            this.txtConfClave_Root.Size = new System.Drawing.Size(312, 22);
            this.txtConfClave_Root.TabIndex = 13;
            // 
            // txtApellidos_Root
            // 
            this.txtApellidos_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellidos_Root.Location = new System.Drawing.Point(432, 89);
            this.txtApellidos_Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidos_Root.MaxLength = 50;
            this.txtApellidos_Root.Name = "txtApellidos_Root";
            this.txtApellidos_Root.ShortcutsEnabled = false;
            this.txtApellidos_Root.Size = new System.Drawing.Size(312, 22);
            this.txtApellidos_Root.TabIndex = 2;
            // 
            // txtEmail_Root
            // 
            this.txtEmail_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail_Root.Location = new System.Drawing.Point(55, 292);
            this.txtEmail_Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail_Root.MaxLength = 150;
            this.txtEmail_Root.Name = "txtEmail_Root";
            this.txtEmail_Root.ShortcutsEnabled = false;
            this.txtEmail_Root.Size = new System.Drawing.Size(312, 22);
            this.txtEmail_Root.TabIndex = 7;
            // 
            // txtUsuario_Root
            // 
            this.txtUsuario_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario_Root.Location = new System.Drawing.Point(432, 292);
            this.txtUsuario_Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario_Root.MaxLength = 25;
            this.txtUsuario_Root.Name = "txtUsuario_Root";
            this.txtUsuario_Root.ShortcutsEnabled = false;
            this.txtUsuario_Root.Size = new System.Drawing.Size(312, 22);
            this.txtUsuario_Root.TabIndex = 8;
            // 
            // txtClave_Root
            // 
            this.txtClave_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClave_Root.Location = new System.Drawing.Point(57, 540);
            this.txtClave_Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClave_Root.MaxLength = 50;
            this.txtClave_Root.Name = "txtClave_Root";
            this.txtClave_Root.PasswordChar = '*';
            this.txtClave_Root.ShortcutsEnabled = false;
            this.txtClave_Root.Size = new System.Drawing.Size(311, 22);
            this.txtClave_Root.TabIndex = 12;
            this.txtClave_Root.TextChanged += new System.EventHandler(this.txtClave_Root_TextChanged_1);
            // 
            // txtCarne
            // 
            this.txtCarne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCarne.Location = new System.Drawing.Point(53, 153);
            this.txtCarne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarne.MaxLength = 8;
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(311, 22);
            this.txtCarne.TabIndex = 103;
            // 
            // txtNombre_Root
            // 
            this.txtNombre_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre_Root.Location = new System.Drawing.Point(55, 89);
            this.txtNombre_Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre_Root.MaxLength = 50;
            this.txtNombre_Root.Name = "txtNombre_Root";
            this.txtNombre_Root.ShortcutsEnabled = false;
            this.txtNombre_Root.Size = new System.Drawing.Size(311, 22);
            this.txtNombre_Root.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(429, 517);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 23);
            this.label9.TabIndex = 104;
            this.label9.Text = "Confirmar clave:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 517);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 23);
            this.label11.TabIndex = 108;
            this.label11.Text = "Clave:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(429, 199);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 23);
            this.label15.TabIndex = 105;
            this.label15.Text = "Numero Telefonico:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 332);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 98;
            this.label7.Text = "Estado:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(53, 270);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 23);
            this.label14.TabIndex = 106;
            this.label14.Text = "Correo electrónico:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 107;
            this.label3.Text = "Usuario:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 23);
            this.label6.TabIndex = 97;
            this.label6.Text = "Empresa a la que pertenece:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 100;
            this.label5.Text = "Nacimiento:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 99;
            this.label4.Text = "Documento:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(837, 89);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 23);
            this.label12.TabIndex = 102;
            this.label12.Text = "Foto de perfil:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 101;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 95;
            this.label1.Text = "Nombres:";
            // 
            // txtid_Root
            // 
            this.txtid_Root.Location = new System.Drawing.Point(992, 49);
            this.txtid_Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid_Root.Name = "txtid_Root";
            this.txtid_Root.Size = new System.Drawing.Size(28, 22);
            this.txtid_Root.TabIndex = 110;
            this.txtid_Root.Visible = false;
            // 
            // openCargarImagen
            // 
            this.openCargarImagen.FileName = "openCargarImagen";
            // 
            // button_actualizar
            // 
            this.button_actualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_actualizar.BackColor = System.Drawing.Color.Green;
            this.button_actualizar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualizar.ForeColor = System.Drawing.Color.White;
            this.button_actualizar.Location = new System.Drawing.Point(48, 411);
            this.button_actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(323, 62);
            this.button_actualizar.TabIndex = 11;
            this.button_actualizar.Text = "Actualizar Datos";
            this.button_actualizar.UseVisualStyleBackColor = false;
            this.button_actualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton_regresar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1044, 27);
            this.toolStrip1.TabIndex = 114;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(159, 24);
            this.toolStripLabel1.Text = "Configuracion de Root";
            // 
            // toolStripButton_regresar
            // 
            this.toolStripButton_regresar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_regresar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_regresar.Image = global::NovaInventory.Properties.Resources.back_arrow;
            this.toolStripButton_regresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_regresar.Name = "toolStripButton_regresar";
            this.toolStripButton_regresar.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_regresar.Text = "Regresar";
            this.toolStripButton_regresar.Click += new System.EventHandler(this.toolStripButton_regresar_Click);
            // 
            // pbFoto_Root
            // 
            this.pbFoto_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbFoto_Root.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbFoto_Root.Location = new System.Drawing.Point(839, 153);
            this.pbFoto_Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFoto_Root.Name = "pbFoto_Root";
            this.pbFoto_Root.Size = new System.Drawing.Size(140, 177);
            this.pbFoto_Root.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto_Root.TabIndex = 109;
            this.pbFoto_Root.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(639, 619);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(366, 17);
            this.linkLabel1.TabIndex = 115;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "La contraseña debe de tener un maximo de 8 caracteres";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(856, 411);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 21);
            this.checkBox1.TabIndex = 116;
            this.checkBox1.Text = "English";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmConfig_Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 665);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.txtid_Root);
            this.Controls.Add(this.btnCambiar_clave);
            this.Controls.Add(this.txt_cel_Root);
            this.Controls.Add(this.BtnCargarImagen_Root);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConfig_Root";
            this.Text = "frmConfig_Root";
            this.Load += new System.EventHandler(this.frmConfig_Root_Load_2);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto_Root)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCambiar_clave;
        private System.Windows.Forms.MaskedTextBox txt_cel_Root;
        private System.Windows.Forms.Button BtnCargarImagen_Root;
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
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton_regresar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        //private Bunifu.Framework.UI.BunifuFlatButton Guardar;
    }
}