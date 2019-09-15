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
            this.btnCorreoVolver_Recu = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario_Root = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña_Root = new System.Windows.Forms.TextBox();
            this.panelUsuario_Root = new System.Windows.Forms.Panel();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.txtIdRoot = new System.Windows.Forms.TextBox();
            this.btnEnviar_Contra = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panelUsuario_Root.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCorreoVolver_Recu,
            this.btnCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(413, 25);
            this.toolStrip1.TabIndex = 0;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese El Usuario root :";
            // 
            // txtUsuario_Root
            // 
            this.txtUsuario_Root.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUsuario_Root.Location = new System.Drawing.Point(126, 129);
            this.txtUsuario_Root.Name = "txtUsuario_Root";
            this.txtUsuario_Root.ShortcutsEnabled = false;
            this.txtUsuario_Root.Size = new System.Drawing.Size(123, 20);
            this.txtUsuario_Root.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese la contraseña del root:";
            // 
            // txtContraseña_Root
            // 
            this.txtContraseña_Root.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtContraseña_Root.Location = new System.Drawing.Point(126, 184);
            this.txtContraseña_Root.Name = "txtContraseña_Root";
            this.txtContraseña_Root.ShortcutsEnabled = false;
            this.txtContraseña_Root.Size = new System.Drawing.Size(123, 20);
            this.txtContraseña_Root.TabIndex = 2;
            // 
            // panelUsuario_Root
            // 
            this.panelUsuario_Root.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelUsuario_Root.Controls.Add(this.labelMensaje);
            this.panelUsuario_Root.Controls.Add(this.txtIdRoot);
            this.panelUsuario_Root.Controls.Add(this.btnEnviar_Contra);
            this.panelUsuario_Root.Controls.Add(this.label1);
            this.panelUsuario_Root.Controls.Add(this.txtContraseña_Root);
            this.panelUsuario_Root.Controls.Add(this.txtUsuario_Root);
            this.panelUsuario_Root.Controls.Add(this.label2);
            this.panelUsuario_Root.Location = new System.Drawing.Point(12, 39);
            this.panelUsuario_Root.Name = "panelUsuario_Root";
            this.panelUsuario_Root.Size = new System.Drawing.Size(389, 332);
            this.panelUsuario_Root.TabIndex = 5;
            this.panelUsuario_Root.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUsuario_Root_Paint);
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.ForeColor = System.Drawing.Color.Red;
            this.labelMensaje.Location = new System.Drawing.Point(148, 52);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(0, 25);
            this.labelMensaje.TabIndex = 6;
            // 
            // txtIdRoot
            // 
            this.txtIdRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtIdRoot.Location = new System.Drawing.Point(364, 43);
            this.txtIdRoot.Name = "txtIdRoot";
            this.txtIdRoot.ReadOnly = true;
            this.txtIdRoot.Size = new System.Drawing.Size(22, 20);
            this.txtIdRoot.TabIndex = 5;
            this.txtIdRoot.Text = "1";
            this.txtIdRoot.Visible = false;
            // 
            // btnEnviar_Contra
            // 
            this.btnEnviar_Contra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnviar_Contra.BackColor = System.Drawing.Color.Green;
            this.btnEnviar_Contra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar_Contra.Location = new System.Drawing.Point(110, 231);
            this.btnEnviar_Contra.Name = "btnEnviar_Contra";
            this.btnEnviar_Contra.Size = new System.Drawing.Size(171, 42);
            this.btnEnviar_Contra.TabIndex = 3;
            this.btnEnviar_Contra.Text = "Comprobar";
            this.btnEnviar_Contra.UseVisualStyleBackColor = false;
            this.btnEnviar_Contra.Click += new System.EventHandler(this.btnEnviar_Contra_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(322, 24);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 52);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Comprobación del usuario root";
            // 
            // frmItervencionAdmin_RecuContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panelUsuario_Root);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItervencionAdmin_RecuContra";
            this.Text = "frmItervencionAdmin_RecuCOntra";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelUsuario_Root.ResumeLayout(false);
            this.panelUsuario_Root.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnEnviar_Contra;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtIdRoot;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMensaje;
    }
}