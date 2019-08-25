namespace NovaInventory.Vista
{
    partial class frmLogin
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIniciar_Sesion = new System.Windows.Forms.Button();
            this.lklRecuperar_Contraseña = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCerrar_Login = new System.Windows.Forms.ToolStripButton();
            this.btnMaximizar_Login = new System.Windows.Forms.ToolStripButton();
            this.btnVentana_Login = new System.Windows.Forms.ToolStripButton();
            this.btnMinmizar_Login = new System.Windows.Forms.ToolStripButton();
            this.pbLogo_Login = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.Location = new System.Drawing.Point(576, 261);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContraseña.Location = new System.Drawing.Point(576, 298);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(132, 22);
            this.txtContraseña.TabIndex = 2;
            // 
            // btnIniciar_Sesion
            // 
            this.btnIniciar_Sesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIniciar_Sesion.BackColor = System.Drawing.Color.Green;
            this.btnIniciar_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar_Sesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciar_Sesion.Location = new System.Drawing.Point(431, 345);
            this.btnIniciar_Sesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciar_Sesion.Name = "btnIniciar_Sesion";
            this.btnIniciar_Sesion.Size = new System.Drawing.Size(197, 54);
            this.btnIniciar_Sesion.TabIndex = 3;
            this.btnIniciar_Sesion.Text = "Iniciar Sesión";
            this.btnIniciar_Sesion.UseVisualStyleBackColor = false;
            this.btnIniciar_Sesion.Click += new System.EventHandler(this.btnIniciar_Sesion_Click);
            // 
            // lklRecuperar_Contraseña
            // 
            this.lklRecuperar_Contraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lklRecuperar_Contraseña.AutoSize = true;
            this.lklRecuperar_Contraseña.Location = new System.Drawing.Point(451, 414);
            this.lklRecuperar_Contraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklRecuperar_Contraseña.Name = "lklRecuperar_Contraseña";
            this.lklRecuperar_Contraseña.Size = new System.Drawing.Size(159, 17);
            this.lklRecuperar_Contraseña.TabIndex = 4;
            this.lklRecuperar_Contraseña.TabStop = true;
            this.lklRecuperar_Contraseña.Text = "¿Olvide Mi Contraseña?";
            this.lklRecuperar_Contraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklRecuperar_Contraseña_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inicia Sesión";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCerrar_Login,
            this.btnMaximizar_Login,
            this.btnVentana_Login,
            this.btnMinmizar_Login});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCerrar_Login
            // 
            this.btnCerrar_Login.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrar_Login.Image = global::NovaInventory.Properties.Resources.close_window_80px;
            this.btnCerrar_Login.Name = "btnCerrar_Login";
            this.btnCerrar_Login.Size = new System.Drawing.Size(24, 24);
            this.btnCerrar_Login.Click += new System.EventHandler(this.btnCerrar_Login_Click_1);
            // 
            // btnMaximizar_Login
            // 
            this.btnMaximizar_Login.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMaximizar_Login.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMaximizar_Login.Image = global::NovaInventory.Properties.Resources.maximize_window_26px;
            this.btnMaximizar_Login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMaximizar_Login.Name = "btnMaximizar_Login";
            this.btnMaximizar_Login.Size = new System.Drawing.Size(24, 24);
            this.btnMaximizar_Login.Text = "toolStripButton2";
            this.btnMaximizar_Login.Click += new System.EventHandler(this.btnMaximizar_Login_Click);
            // 
            // btnVentana_Login
            // 
            this.btnVentana_Login.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnVentana_Login.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVentana_Login.Image = global::NovaInventory.Properties.Resources.restore_window_26px;
            this.btnVentana_Login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVentana_Login.Name = "btnVentana_Login";
            this.btnVentana_Login.Size = new System.Drawing.Size(24, 24);
            this.btnVentana_Login.Text = "toolStripButton3";
            this.btnVentana_Login.Visible = false;
            this.btnVentana_Login.Click += new System.EventHandler(this.btnVentana_Login_Click);
            // 
            // btnMinmizar_Login
            // 
            this.btnMinmizar_Login.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMinmizar_Login.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMinmizar_Login.Image = global::NovaInventory.Properties.Resources.minimize_window_26px;
            this.btnMinmizar_Login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMinmizar_Login.Name = "btnMinmizar_Login";
            this.btnMinmizar_Login.Size = new System.Drawing.Size(24, 24);
            this.btnMinmizar_Login.Text = "toolStripButton4";
            this.btnMinmizar_Login.Click += new System.EventHandler(this.btnMinmizar_Login_Click);
            // 
            // pbLogo_Login
            // 
            this.pbLogo_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogo_Login.Location = new System.Drawing.Point(407, 97);
            this.pbLogo_Login.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo_Login.Name = "pbLogo_Login";
            this.pbLogo_Login.Size = new System.Drawing.Size(243, 137);
            this.pbLogo_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo_Login.TabIndex = 6;
            this.pbLogo_Login.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(407, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 137);
            this.button1.TabIndex = 8;
            this.button1.Text = "Primera vez?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pbLogo_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lklRecuperar_Contraseña);
            this.Controls.Add(this.btnIniciar_Sesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIniciar_Sesion;
        private System.Windows.Forms.LinkLabel lklRecuperar_Contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbLogo_Login;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnVentana_Login;
        private System.Windows.Forms.ToolStripButton btnMinmizar_Login;
        private System.Windows.Forms.ToolStripButton btnCerrar_Login;
        private System.Windows.Forms.ToolStripButton btnMaximizar_Login;
        private System.Windows.Forms.Button button1;
    }
}