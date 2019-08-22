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
            this.pbLogo_Login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(431, 191);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(431, 221);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 2;
            // 
            // btnIniciar_Sesion
            // 
            this.btnIniciar_Sesion.BackColor = System.Drawing.Color.Green;
            this.btnIniciar_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar_Sesion.Location = new System.Drawing.Point(323, 263);
            this.btnIniciar_Sesion.Name = "btnIniciar_Sesion";
            this.btnIniciar_Sesion.Size = new System.Drawing.Size(148, 44);
            this.btnIniciar_Sesion.TabIndex = 3;
            this.btnIniciar_Sesion.Text = "Iniciar Sesión";
            this.btnIniciar_Sesion.UseVisualStyleBackColor = false;
            // 
            // lklRecuperar_Contraseña
            // 
            this.lklRecuperar_Contraseña.AutoSize = true;
            this.lklRecuperar_Contraseña.Location = new System.Drawing.Point(339, 319);
            this.lklRecuperar_Contraseña.Name = "lklRecuperar_Contraseña";
            this.lklRecuperar_Contraseña.Size = new System.Drawing.Size(114, 13);
            this.lklRecuperar_Contraseña.TabIndex = 4;
            this.lklRecuperar_Contraseña.TabStop = true;
            this.lklRecuperar_Contraseña.Text = "¿Olide Mi Contraseña?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inicia Sesión";
            // 
            // pbLogo_Login
            // 
            this.pbLogo_Login.Location = new System.Drawing.Point(323, 61);
            this.pbLogo_Login.Name = "pbLogo_Login";
            this.pbLogo_Login.Size = new System.Drawing.Size(148, 111);
            this.pbLogo_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo_Login.TabIndex = 6;
            this.pbLogo_Login.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.pbLogo_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lklRecuperar_Contraseña);
            this.Controls.Add(this.btnIniciar_Sesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
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
    }
}