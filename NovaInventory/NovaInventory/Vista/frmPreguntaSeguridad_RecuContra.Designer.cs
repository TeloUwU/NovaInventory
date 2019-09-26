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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtUsuarios.Location = new System.Drawing.Point(267, 74);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(176, 38);
            this.txtUsuarios.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.textBox1.Location = new System.Drawing.Point(267, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 38);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese nueva contraseña**";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Repita contraseña**";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "RECUPERAR CONTRASEÑA:";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(238, 24);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(59, 19);
            this.lb_usuario.TabIndex = 13;
            this.lb_usuario.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "**Campos obligatorios";
            // 
            // frmPreguntaSeguridad_RecuContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 266);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.button1);
            this.Name = "frmPreguntaSeguridad_RecuContra";
            this.Text = "Recuperar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label label5;
    }
}