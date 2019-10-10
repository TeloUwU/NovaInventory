namespace NovaInventory.Vista
{
    partial class frmPreguntaSeguridad_RecuContra
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nuevacontra = new System.Windows.Forms.Label();
            this.lblREpeatcontra = new System.Windows.Forms.Label();
            this.Recuperarcontraseña = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.me = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtUsuarios.Location = new System.Drawing.Point(356, 91);
            this.txtUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(233, 46);
            this.txtUsuarios.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.textBox1.Location = new System.Drawing.Point(356, 156);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 46);
            this.textBox1.TabIndex = 9;
            // 
            // nuevacontra
            // 
            this.nuevacontra.AutoSize = true;
            this.nuevacontra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevacontra.Location = new System.Drawing.Point(64, 91);
            this.nuevacontra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nuevacontra.Name = "nuevacontra";
            this.nuevacontra.Size = new System.Drawing.Size(244, 24);
            this.nuevacontra.TabIndex = 10;
            this.nuevacontra.Text = "Ingrese nueva contraseña**";
            // 
            // lblREpeatcontra
            // 
            this.lblREpeatcontra.AutoSize = true;
            this.lblREpeatcontra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREpeatcontra.Location = new System.Drawing.Point(64, 156);
            this.lblREpeatcontra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblREpeatcontra.Name = "lblREpeatcontra";
            this.lblREpeatcontra.Size = new System.Drawing.Size(182, 24);
            this.lblREpeatcontra.TabIndex = 11;
            this.lblREpeatcontra.Text = "Repita contraseña**";
            // 
            // Recuperarcontraseña
            // 
            this.Recuperarcontraseña.AutoSize = true;
            this.Recuperarcontraseña.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recuperarcontraseña.Location = new System.Drawing.Point(64, 30);
            this.Recuperarcontraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Recuperarcontraseña.Name = "Recuperarcontraseña";
            this.Recuperarcontraseña.Size = new System.Drawing.Size(233, 24);
            this.Recuperarcontraseña.TabIndex = 12;
            this.Recuperarcontraseña.Text = "RECUPERAR CONTRASEÑA:";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(317, 30);
            this.lb_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(75, 24);
            this.lb_usuario.TabIndex = 13;
            this.lb_usuario.Text = "Usuario";
            // 
            // me
            // 
            this.me.AutoSize = true;
            this.me.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.me.Location = new System.Drawing.Point(64, 231);
            this.me.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.me.Name = "me";
            this.me.Size = new System.Drawing.Size(202, 24);
            this.me.TabIndex = 14;
            this.me.Text = "**Campos obligatorios";
            // 
            // frmPreguntaSeguridad_RecuContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 327);
            this.Controls.Add(this.me);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.Recuperarcontraseña);
            this.Controls.Add(this.lblREpeatcontra);
            this.Controls.Add(this.nuevacontra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPreguntaSeguridad_RecuContra";
            this.Text = "Recuperar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nuevacontra;
        private System.Windows.Forms.Label lblREpeatcontra;
        private System.Windows.Forms.Label Recuperarcontraseña;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label me;
    }
}