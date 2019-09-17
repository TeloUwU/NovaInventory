namespace NovaInventory.Vista
{
    partial class frmCorreo_RecuContra
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
            this.btnCambiar_Recu = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo_Recu = new System.Windows.Forms.TextBox();
            this.btenviar_Correo = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emisotr = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCambiar_Recu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(353, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCambiar_Recu
            // 
            this.btnCambiar_Recu.Name = "btnCambiar_Recu";
            this.btnCambiar_Recu.Size = new System.Drawing.Size(23, 22);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo Electronico";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa tu Coreo Electronico:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCorreo_Recu
            // 
            this.txtCorreo_Recu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCorreo_Recu.Location = new System.Drawing.Point(93, 190);
            this.txtCorreo_Recu.Name = "txtCorreo_Recu";
            this.txtCorreo_Recu.ShortcutsEnabled = false;
            this.txtCorreo_Recu.Size = new System.Drawing.Size(173, 20);
            this.txtCorreo_Recu.TabIndex = 1;
            // 
            // btenviar_Correo
            // 
            this.btenviar_Correo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btenviar_Correo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btenviar_Correo.Location = new System.Drawing.Point(91, 233);
            this.btenviar_Correo.Name = "btenviar_Correo";
            this.btenviar_Correo.Size = new System.Drawing.Size(184, 44);
            this.btenviar_Correo.TabIndex = 2;
            this.btenviar_Correo.Text = "Enviar Correo Electronico";
            this.btenviar_Correo.UseVisualStyleBackColor = true;
            this.btenviar_Correo.Click += new System.EventHandler(this.btenviar_Correo_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.Location = new System.Drawing.Point(93, 128);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ShortcutsEnabled = false;
            this.txtUsuario.Size = new System.Drawing.Size(173, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario:";
            // 
            // emisotr
            // 
            this.emisotr.AutoSize = true;
            this.emisotr.Location = new System.Drawing.Point(21, 12);
            this.emisotr.Name = "emisotr";
            this.emisotr.Size = new System.Drawing.Size(95, 13);
            this.emisotr.TabIndex = 5;
            this.emisotr.Text = "Nueva contraseña";
            this.emisotr.Visible = false;
            // 
            // frmCorreo_RecuContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 354);
            this.Controls.Add(this.emisotr);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btenviar_Correo);
            this.Controls.Add(this.txtCorreo_Recu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCorreo_RecuContra";
            this.Text = "frmCorreo_RecuContra";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo_Recu;
        private System.Windows.Forms.Button btenviar_Correo;
        private System.Windows.Forms.ToolStripButton btnCambiar_Recu;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label emisotr;
    }
}