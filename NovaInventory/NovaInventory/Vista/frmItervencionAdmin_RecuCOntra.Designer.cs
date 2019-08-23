namespace NovaInventory.Vista
{
    partial class frmItervencionAdmin_RecuContra
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario_Root = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña_Root = new System.Windows.Forms.TextBox();
            this.panelUsuario_Root = new System.Windows.Forms.Panel();
            this.panelUsuario_Recu = new System.Windows.Forms.Panel();
            this.cbUsuario_Cambiar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtConfirmar_Contraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnviar_Contra = new System.Windows.Forms.Button();
            this.btnCorreoVolver_Recu = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panelUsuario_Root.SuspendLayout();
            this.panelUsuario_Recu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCorreoVolver_Recu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(450, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese El Usuario Administrador :";
            // 
            // txtUsuario_Root
            // 
            this.txtUsuario_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario_Root.Location = new System.Drawing.Point(121, 49);
            this.txtUsuario_Root.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario_Root.Name = "txtUsuario_Root";
            this.txtUsuario_Root.Size = new System.Drawing.Size(163, 22);
            this.txtUsuario_Root.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese su Contraseña:";
            // 
            // txtContraseña_Root
            // 
            this.txtContraseña_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContraseña_Root.Location = new System.Drawing.Point(119, 130);
            this.txtContraseña_Root.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraseña_Root.Name = "txtContraseña_Root";
            this.txtContraseña_Root.Size = new System.Drawing.Size(163, 22);
            this.txtContraseña_Root.TabIndex = 2;
            // 
            // panelUsuario_Root
            // 
            this.panelUsuario_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelUsuario_Root.Controls.Add(this.label1);
            this.panelUsuario_Root.Controls.Add(this.txtContraseña_Root);
            this.panelUsuario_Root.Controls.Add(this.txtUsuario_Root);
            this.panelUsuario_Root.Controls.Add(this.label2);
            this.panelUsuario_Root.Location = new System.Drawing.Point(17, 36);
            this.panelUsuario_Root.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelUsuario_Root.Name = "panelUsuario_Root";
            this.panelUsuario_Root.Size = new System.Drawing.Size(417, 171);
            this.panelUsuario_Root.TabIndex = 5;
            this.panelUsuario_Root.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUsuario_Root_Paint);
            // 
            // panelUsuario_Recu
            // 
            this.panelUsuario_Recu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelUsuario_Recu.Controls.Add(this.cbUsuario_Cambiar);
            this.panelUsuario_Recu.Controls.Add(this.label3);
            this.panelUsuario_Recu.Location = new System.Drawing.Point(17, 226);
            this.panelUsuario_Recu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelUsuario_Recu.Name = "panelUsuario_Recu";
            this.panelUsuario_Recu.Size = new System.Drawing.Size(417, 121);
            this.panelUsuario_Recu.TabIndex = 6;
            // 
            // cbUsuario_Cambiar
            // 
            this.cbUsuario_Cambiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbUsuario_Cambiar.FormattingEnabled = true;
            this.cbUsuario_Cambiar.Location = new System.Drawing.Point(121, 64);
            this.cbUsuario_Cambiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUsuario_Cambiar.Name = "cbUsuario_Cambiar";
            this.cbUsuario_Cambiar.Size = new System.Drawing.Size(163, 24);
            this.cbUsuario_Cambiar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario A Modificar:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(17, 401);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 4;
            // 
            // txtConfirmar_Contraseña
            // 
            this.txtConfirmar_Contraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConfirmar_Contraseña.Location = new System.Drawing.Point(269, 403);
            this.txtConfirmar_Contraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmar_Contraseña.Name = "txtConfirmar_Contraseña";
            this.txtConfirmar_Contraseña.Size = new System.Drawing.Size(160, 22);
            this.txtConfirmar_Contraseña.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nueva Contraseña:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 363);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confirmar Contraseña:";
            // 
            // btnEnviar_Contra
            // 
            this.btnEnviar_Contra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnviar_Contra.BackColor = System.Drawing.Color.Green;
            this.btnEnviar_Contra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar_Contra.Location = new System.Drawing.Point(105, 442);
            this.btnEnviar_Contra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviar_Contra.Name = "btnEnviar_Contra";
            this.btnEnviar_Contra.Size = new System.Drawing.Size(228, 52);
            this.btnEnviar_Contra.TabIndex = 6;
            this.btnEnviar_Contra.Text = "Enviar Contraseña Nueva";
            this.btnEnviar_Contra.UseVisualStyleBackColor = false;
            // 
            // btnCorreoVolver_Recu
            // 
            this.btnCorreoVolver_Recu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCorreoVolver_Recu.Image = global::NovaInventory.Properties.Resources.undo_26px;
            this.btnCorreoVolver_Recu.Name = "btnCorreoVolver_Recu";
            this.btnCorreoVolver_Recu.Size = new System.Drawing.Size(183, 24);
            this.btnCorreoVolver_Recu.Text = "Cambiar Recuperación";
            // 
            // frmItervencionAdmin_RecuContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 511);
            this.Controls.Add(this.btnEnviar_Contra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmar_Contraseña);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelUsuario_Recu);
            this.Controls.Add(this.panelUsuario_Root);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmItervencionAdmin_RecuContra";
            this.Text = "frmItervencionAdmin_RecuCOntra";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelUsuario_Root.ResumeLayout(false);
            this.panelUsuario_Root.PerformLayout();
            this.panelUsuario_Recu.ResumeLayout(false);
            this.panelUsuario_Recu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCorreoVolver_Recu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario_Root;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña_Root;
        private System.Windows.Forms.Panel panelUsuario_Root;
        private System.Windows.Forms.Panel panelUsuario_Recu;
        private System.Windows.Forms.ComboBox cbUsuario_Cambiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtConfirmar_Contraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnviar_Contra;
    }
}