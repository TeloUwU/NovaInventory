namespace NovaInventory.Vista
{
    partial class frmNuevaContraseña
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnviar_Contra = new System.Windows.Forms.Button();
            this.panelUsuario_Root = new System.Windows.Forms.Panel();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCorreoVolver_Recu = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panelUsuario_Root.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 52);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cambie su contraseña";
            // 
            // btnEnviar_Contra
            // 
            this.btnEnviar_Contra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnviar_Contra.BackColor = System.Drawing.Color.Green;
            this.btnEnviar_Contra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar_Contra.Location = new System.Drawing.Point(180, 379);
            this.btnEnviar_Contra.Name = "btnEnviar_Contra";
            this.btnEnviar_Contra.Size = new System.Drawing.Size(171, 42);
            this.btnEnviar_Contra.TabIndex = 10;
            this.btnEnviar_Contra.Text = "Comprobar";
            this.btnEnviar_Contra.UseVisualStyleBackColor = false;
            this.btnEnviar_Contra.Click += new System.EventHandler(this.btnEnviar_Contra_Click);
            // 
            // panelUsuario_Root
            // 
            this.panelUsuario_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelUsuario_Root.Controls.Add(this.labelMensaje);
            this.panelUsuario_Root.Controls.Add(this.label1);
            this.panelUsuario_Root.Controls.Add(this.txtContraseña);
            this.panelUsuario_Root.Controls.Add(this.txtUsuario);
            this.panelUsuario_Root.Controls.Add(this.label2);
            this.panelUsuario_Root.Location = new System.Drawing.Point(12, 50);
            this.panelUsuario_Root.Name = "panelUsuario_Root";
            this.panelUsuario_Root.Size = new System.Drawing.Size(512, 309);
            this.panelUsuario_Root.TabIndex = 8;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.ForeColor = System.Drawing.Color.Red;
            this.labelMensaje.Location = new System.Drawing.Point(232, 52);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(0, 25);
            this.labelMensaje.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese El Usuario:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtContraseña.Location = new System.Drawing.Point(190, 191);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(123, 20);
            this.txtContraseña.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUsuario.Location = new System.Drawing.Point(190, 138);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(123, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reestablezca contraseña:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCorreoVolver_Recu,
            this.btnCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(554, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCorreoVolver_Recu
            // 
            this.btnCorreoVolver_Recu.Name = "btnCorreoVolver_Recu";
            this.btnCorreoVolver_Recu.Size = new System.Drawing.Size(23, 22);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrar.Image = global::NovaInventory.Properties.Resources.cancel_button;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 22);
            this.btnCerrar.Text = "toolStripButton1";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmNuevaContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnviar_Contra);
            this.Controls.Add(this.panelUsuario_Root);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevaContraseña";
            this.Text = "frmNuevaContraseña";
            this.Load += new System.EventHandler(this.frmNuevaContraseña_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelUsuario_Root.ResumeLayout(false);
            this.panelUsuario_Root.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnviar_Contra;
        private System.Windows.Forms.Panel panelUsuario_Root;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCorreoVolver_Recu;
        private System.Windows.Forms.ToolStripButton btnCerrar;
    }
}