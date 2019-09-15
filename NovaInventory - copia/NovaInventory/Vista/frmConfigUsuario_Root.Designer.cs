namespace NovaInventory.Vista
{
    partial class frmConfigUsuario_Root
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigUsuario_Root));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCerrar_formulario = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.BtnExaminar = new System.Windows.Forms.Button();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.maskDui = new System.Windows.Forms.MaskedTextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.txtConfClave = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
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
            this.dgvConfig_Root = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig_Root)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCerrar_formulario,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1044, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCerrar_formulario
            // 
            this.btnCerrar_formulario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrar_formulario.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar_formulario.Image = global::NovaInventory.Properties.Resources.undo_26px;
            this.btnCerrar_formulario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar_formulario.Name = "btnCerrar_formulario";
            this.btnCerrar_formulario.Size = new System.Drawing.Size(172, 27);
            this.btnCerrar_formulario.Text = "Cerrar Formulario";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(252, 27);
            this.toolStripButton2.Text = "Configuración del Usuario Root";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(413, 152);
            this.maskedTextBox1.Mask = "(000) 0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(312, 22);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // BtnExaminar
            // 
            this.BtnExaminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnExaminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExaminar.ForeColor = System.Drawing.Color.White;
            this.BtnExaminar.Location = new System.Drawing.Point(811, 278);
            this.BtnExaminar.Name = "BtnExaminar";
            this.BtnExaminar.Size = new System.Drawing.Size(188, 40);
            this.BtnExaminar.TabIndex = 13;
            this.BtnExaminar.Text = "Cargar Imagen";
            this.BtnExaminar.UseVisualStyleBackColor = false;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(413, 200);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(312, 24);
            this.cmbTipoUsuario.TabIndex = 8;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(38, 246);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(308, 24);
            this.cmbEstado.TabIndex = 9;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(37, 151);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(313, 24);
            this.cmbEmpresa.TabIndex = 5;
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNacimiento.CustomFormat = "yyyy/MM/dd";
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNacimiento.Location = new System.Drawing.Point(413, 103);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(312, 22);
            this.dtNacimiento.TabIndex = 4;
            // 
            // maskDui
            // 
            this.maskDui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskDui.Location = new System.Drawing.Point(36, 103);
            this.maskDui.Mask = "00000000-0";
            this.maskDui.Name = "maskDui";
            this.maskDui.Size = new System.Drawing.Size(311, 22);
            this.maskDui.TabIndex = 3;
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbFoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbFoto.Location = new System.Drawing.Point(835, 71);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(140, 177);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 80;
            this.pbFoto.TabStop = false;
            // 
            // txtConfClave
            // 
            this.txtConfClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConfClave.Location = new System.Drawing.Point(413, 296);
            this.txtConfClave.Name = "txtConfClave";
            this.txtConfClave.Size = new System.Drawing.Size(312, 22);
            this.txtConfClave.TabIndex = 12;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellidos.Location = new System.Drawing.Point(413, 52);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(312, 22);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(38, 199);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.Location = new System.Drawing.Point(413, 246);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(312, 22);
            this.txtUsuario.TabIndex = 10;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClave.Location = new System.Drawing.Point(36, 296);
            this.txtClave.MaxLength = 45;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(311, 22);
            this.txtClave.TabIndex = 11;
            // 
            // txtCarne
            // 
            this.txtCarne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCarne.Location = new System.Drawing.Point(36, 103);
            this.txtCarne.MaxLength = 8;
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(311, 22);
            this.txtCarne.TabIndex = 74;
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombres.Location = new System.Drawing.Point(36, 52);
            this.txtNombres.MaxLength = 45;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(311, 22);
            this.txtNombres.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(410, 273);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 23);
            this.label9.TabIndex = 75;
            this.label9.Text = "Confirmar clave:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(410, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 67;
            this.label8.Text = "Tipo Usuario:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 272);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 23);
            this.label11.TabIndex = 79;
            this.label11.Text = "Clave:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(410, 131);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 23);
            this.label15.TabIndex = 76;
            this.label15.Text = "Numero Telefonico:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 69;
            this.label7.Text = "Estado:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 176);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 23);
            this.label14.TabIndex = 77;
            this.label14.Text = "Correo electrónico:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 78;
            this.label3.Text = "Usuario:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 23);
            this.label6.TabIndex = 68;
            this.label6.Text = "Empresa a la que pertenece:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 71;
            this.label5.Text = "Nacimiento:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 70;
            this.label4.Text = "Documento:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(845, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 23);
            this.label12.TabIndex = 73;
            this.label12.Text = "Foto de perfil:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 72;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Nombres:";
            // 
            // dgvConfig_Root
            // 
            this.dgvConfig_Root.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfig_Root.Location = new System.Drawing.Point(35, 417);
            this.dgvConfig_Root.Name = "dgvConfig_Root";
            this.dgvConfig_Root.RowTemplate.Height = 24;
            this.dgvConfig_Root.Size = new System.Drawing.Size(976, 224);
            this.dgvConfig_Root.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(397, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Actualizar Usuario Root";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmConfigUsuario_Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvConfig_Root);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.BtnExaminar);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.dtNacimiento);
            this.Controls.Add(this.maskDui);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtConfClave);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtCarne);
            this.Controls.Add(this.txtNombres);
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
            this.Name = "frmConfigUsuario_Root";
            this.Text = "frmConfigUsuario_Root";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig_Root)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCerrar_formulario;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button BtnExaminar;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.MaskedTextBox maskDui;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txtConfClave;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.TextBox txtNombres;
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
        private System.Windows.Forms.DataGridView dgvConfig_Root;
        private System.Windows.Forms.Button button1;
    }
}