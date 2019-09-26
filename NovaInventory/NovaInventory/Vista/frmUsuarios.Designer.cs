namespace NovaInventory.Vista
{
    partial class frmUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tsAdmin_Usuarios = new System.Windows.Forms.ToolStrip();
            this.btnCerrar_AdminUsuarios = new System.Windows.Forms.ToolStripButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombres_Usuario = new System.Windows.Forms.TextBox();
            this.txtApellidos_Usuario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreo_Usuario = new System.Windows.Forms.TextBox();
            this.txtTelefono_Usuario = new System.Windows.Forms.MaskedTextBox();
            this.txtNIT_Usuario = new System.Windows.Forms.MaskedTextBox();
            this.cbEstado_Usuario = new System.Windows.Forms.ComboBox();
            this.txtDUI_Usuario = new System.Windows.Forms.MaskedTextBox();
            this.dgvMostrar_Usuarios = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtpFechaCreación_Usuario = new System.Windows.Forms.DateTimePicker();
            this.txtid_Usuario = new System.Windows.Forms.TextBox();
            this.cbTipo_Usuario = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSeleccionarFoto_Usuario = new System.Windows.Forms.Button();
            this.pbFoto_Usuario = new System.Windows.Forms.PictureBox();
            this.CargarImagen = new System.Windows.Forms.OpenFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_emp = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tsAdmin_Usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración de Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres del Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos del Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Foto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correo:";
            // 
            // tsAdmin_Usuarios
            // 
            this.tsAdmin_Usuarios.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsAdmin_Usuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCerrar_AdminUsuarios});
            this.tsAdmin_Usuarios.Location = new System.Drawing.Point(0, 0);
            this.tsAdmin_Usuarios.Name = "tsAdmin_Usuarios";
            this.tsAdmin_Usuarios.Size = new System.Drawing.Size(783, 27);
            this.tsAdmin_Usuarios.TabIndex = 7;
            this.tsAdmin_Usuarios.Text = "toolStrip1";
            // 
            // btnCerrar_AdminUsuarios
            // 
            this.btnCerrar_AdminUsuarios.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrar_AdminUsuarios.Image = global::NovaInventory.Properties.Resources.close_window_80px;
            this.btnCerrar_AdminUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar_AdminUsuarios.Name = "btnCerrar_AdminUsuarios";
            this.btnCerrar_AdminUsuarios.Size = new System.Drawing.Size(124, 24);
            this.btnCerrar_AdminUsuarios.Text = "Cerrar Formulario";
            this.btnCerrar_AdminUsuarios.Click += new System.EventHandler(this.btnCerrar_AdminUsuarios_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(208, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "DUI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(208, 171);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "NIT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(211, 216);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Estado:";
            // 
            // txtNombres_Usuario
            // 
            this.txtNombres_Usuario.Location = new System.Drawing.Point(20, 86);
            this.txtNombres_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres_Usuario.MaxLength = 50;
            this.txtNombres_Usuario.Name = "txtNombres_Usuario";
            this.txtNombres_Usuario.ShortcutsEnabled = false;
            this.txtNombres_Usuario.Size = new System.Drawing.Size(157, 20);
            this.txtNombres_Usuario.TabIndex = 1;
            // 
            // txtApellidos_Usuario
            // 
            this.txtApellidos_Usuario.Location = new System.Drawing.Point(20, 138);
            this.txtApellidos_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos_Usuario.MaxLength = 50;
            this.txtApellidos_Usuario.Name = "txtApellidos_Usuario";
            this.txtApellidos_Usuario.ShortcutsEnabled = false;
            this.txtApellidos_Usuario.Size = new System.Drawing.Size(156, 20);
            this.txtApellidos_Usuario.TabIndex = 2;
            this.txtApellidos_Usuario.TextChanged += new System.EventHandler(this.txtApellidos_Usuario_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(19, 192);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.MaxLength = 25;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ShortcutsEnabled = false;
            this.txtUsuario.Size = new System.Drawing.Size(157, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtCorreo_Usuario
            // 
            this.txtCorreo_Usuario.Location = new System.Drawing.Point(214, 86);
            this.txtCorreo_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo_Usuario.MaxLength = 150;
            this.txtCorreo_Usuario.Name = "txtCorreo_Usuario";
            this.txtCorreo_Usuario.ShortcutsEnabled = false;
            this.txtCorreo_Usuario.Size = new System.Drawing.Size(142, 20);
            this.txtCorreo_Usuario.TabIndex = 5;
            // 
            // txtTelefono_Usuario
            // 
            this.txtTelefono_Usuario.Location = new System.Drawing.Point(20, 247);
            this.txtTelefono_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono_Usuario.Mask = "0000-0000";
            this.txtTelefono_Usuario.Name = "txtTelefono_Usuario";
            this.txtTelefono_Usuario.Size = new System.Drawing.Size(111, 20);
            this.txtTelefono_Usuario.TabIndex = 4;
            // 
            // txtNIT_Usuario
            // 
            this.txtNIT_Usuario.Location = new System.Drawing.Point(214, 192);
            this.txtNIT_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNIT_Usuario.Mask = "0000-000000-000-0";
            this.txtNIT_Usuario.Name = "txtNIT_Usuario";
            this.txtNIT_Usuario.ShortcutsEnabled = false;
            this.txtNIT_Usuario.Size = new System.Drawing.Size(134, 20);
            this.txtNIT_Usuario.TabIndex = 7;
            // 
            // cbEstado_Usuario
            // 
            this.cbEstado_Usuario.FormattingEnabled = true;
            this.cbEstado_Usuario.Location = new System.Drawing.Point(211, 237);
            this.cbEstado_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.cbEstado_Usuario.Name = "cbEstado_Usuario";
            this.cbEstado_Usuario.Size = new System.Drawing.Size(128, 21);
            this.cbEstado_Usuario.TabIndex = 8;
            this.cbEstado_Usuario.SelectedIndexChanged += new System.EventHandler(this.cbEstado_Usuario_SelectedIndexChanged);
            // 
            // txtDUI_Usuario
            // 
            this.txtDUI_Usuario.Location = new System.Drawing.Point(214, 138);
            this.txtDUI_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtDUI_Usuario.Mask = "00000000-0";
            this.txtDUI_Usuario.Name = "txtDUI_Usuario";
            this.txtDUI_Usuario.ShortcutsEnabled = false;
            this.txtDUI_Usuario.Size = new System.Drawing.Size(134, 20);
            this.txtDUI_Usuario.TabIndex = 6;
            // 
            // dgvMostrar_Usuarios
            // 
            this.dgvMostrar_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar_Usuarios.Location = new System.Drawing.Point(416, 65);
            this.dgvMostrar_Usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMostrar_Usuarios.Name = "dgvMostrar_Usuarios";
            this.dgvMostrar_Usuarios.RowTemplate.Height = 24;
            this.dgvMostrar_Usuarios.Size = new System.Drawing.Size(348, 332);
            this.dgvMostrar_Usuarios.TabIndex = 21;
            this.dgvMostrar_Usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar_Usuarios_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(52, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar Usuario";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(228, 457);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Mostrar Usuario";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(416, 457);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 41);
            this.button3.TabIndex = 13;
            this.button3.Text = "Actualizar Usuario";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(592, 457);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 41);
            this.button4.TabIndex = 14;
            this.button4.Text = "Eliminar Usuario";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtpFechaCreación_Usuario
            // 
            this.dtpFechaCreación_Usuario.Location = new System.Drawing.Point(604, 36);
            this.dtpFechaCreación_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaCreación_Usuario.Name = "dtpFechaCreación_Usuario";
            this.dtpFechaCreación_Usuario.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaCreación_Usuario.TabIndex = 26;
            this.dtpFechaCreación_Usuario.Visible = false;
            // 
            // txtid_Usuario
            // 
            this.txtid_Usuario.Location = new System.Drawing.Point(740, 36);
            this.txtid_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtid_Usuario.Name = "txtid_Usuario";
            this.txtid_Usuario.Size = new System.Drawing.Size(26, 20);
            this.txtid_Usuario.TabIndex = 27;
            this.txtid_Usuario.Visible = false;
            // 
            // cbTipo_Usuario
            // 
            this.cbTipo_Usuario.FormattingEnabled = true;
            this.cbTipo_Usuario.Location = new System.Drawing.Point(211, 285);
            this.cbTipo_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipo_Usuario.Name = "cbTipo_Usuario";
            this.cbTipo_Usuario.Size = new System.Drawing.Size(126, 21);
            this.cbTipo_Usuario.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(209, 263);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Tipo de Usuario:";
            // 
            // btnSeleccionarFoto_Usuario
            // 
            this.btnSeleccionarFoto_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSeleccionarFoto_Usuario.Location = new System.Drawing.Point(211, 357);
            this.btnSeleccionarFoto_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarFoto_Usuario.Name = "btnSeleccionarFoto_Usuario";
            this.btnSeleccionarFoto_Usuario.Size = new System.Drawing.Size(128, 41);
            this.btnSeleccionarFoto_Usuario.TabIndex = 10;
            this.btnSeleccionarFoto_Usuario.Text = "Seleccionar Foto";
            this.btnSeleccionarFoto_Usuario.UseVisualStyleBackColor = false;
            this.btnSeleccionarFoto_Usuario.Click += new System.EventHandler(this.btnSeleccionarFoto_Usuario_Click);
            // 
            // pbFoto_Usuario
            // 
            this.pbFoto_Usuario.Location = new System.Drawing.Point(20, 298);
            this.pbFoto_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.pbFoto_Usuario.Name = "pbFoto_Usuario";
            this.pbFoto_Usuario.Size = new System.Drawing.Size(160, 99);
            this.pbFoto_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto_Usuario.TabIndex = 16;
            this.pbFoto_Usuario.TabStop = false;
            // 
            // CargarImagen
            // 
            this.CargarImagen.FileName = "openFileDialog1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(209, 310);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "Empresa:";
            // 
            // cmb_emp
            // 
            this.cmb_emp.FormattingEnabled = true;
            this.cmb_emp.Location = new System.Drawing.Point(211, 332);
            this.cmb_emp.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_emp.Name = "cmb_emp";
            this.cmb_emp.Size = new System.Drawing.Size(126, 21);
            this.cmb_emp.TabIndex = 30;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.Location = new System.Drawing.Point(668, 401);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 41);
            this.button5.TabIndex = 32;
            this.button5.Text = "Generar Reporte";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 540);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmb_emp);
            this.Controls.Add(this.btnSeleccionarFoto_Usuario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbTipo_Usuario);
            this.Controls.Add(this.txtid_Usuario);
            this.Controls.Add(this.dtpFechaCreación_Usuario);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvMostrar_Usuarios);
            this.Controls.Add(this.txtDUI_Usuario);
            this.Controls.Add(this.cbEstado_Usuario);
            this.Controls.Add(this.txtNIT_Usuario);
            this.Controls.Add(this.pbFoto_Usuario);
            this.Controls.Add(this.txtTelefono_Usuario);
            this.Controls.Add(this.txtCorreo_Usuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtApellidos_Usuario);
            this.Controls.Add(this.txtNombres_Usuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tsAdmin_Usuarios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.tsAdmin_Usuarios.ResumeLayout(false);
            this.tsAdmin_Usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto_Usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip tsAdmin_Usuarios;
        private System.Windows.Forms.ToolStripButton btnCerrar_AdminUsuarios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombres_Usuario;
        private System.Windows.Forms.TextBox txtApellidos_Usuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCorreo_Usuario;
        private System.Windows.Forms.MaskedTextBox txtTelefono_Usuario;
        private System.Windows.Forms.PictureBox pbFoto_Usuario;
        private System.Windows.Forms.MaskedTextBox txtNIT_Usuario;
        private System.Windows.Forms.ComboBox cbEstado_Usuario;
        private System.Windows.Forms.MaskedTextBox txtDUI_Usuario;
        private System.Windows.Forms.DataGridView dgvMostrar_Usuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dtpFechaCreación_Usuario;
        private System.Windows.Forms.TextBox txtid_Usuario;
        private System.Windows.Forms.ComboBox cbTipo_Usuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSeleccionarFoto_Usuario;
        private System.Windows.Forms.OpenFileDialog CargarImagen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_emp;
        private System.Windows.Forms.Button button5;
    }
}