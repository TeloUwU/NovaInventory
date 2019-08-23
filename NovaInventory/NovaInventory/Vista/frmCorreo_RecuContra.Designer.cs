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
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCambiar_Recu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(472, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCambiar_Recu
            // 
            this.btnCambiar_Recu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCambiar_Recu.Image = global::NovaInventory.Properties.Resources.undo_26px;
            this.btnCambiar_Recu.Name = "btnCambiar_Recu";
            this.btnCambiar_Recu.Size = new System.Drawing.Size(183, 24);
            this.btnCambiar_Recu.Text = "Cambiar Recuperación";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo Electronico";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa tu Coreo Electronico:";
            // 
            // txtCorreo_Recu
            // 
            this.txtCorreo_Recu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCorreo_Recu.Location = new System.Drawing.Point(40, 197);
            this.txtCorreo_Recu.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo_Recu.Name = "txtCorreo_Recu";
            this.txtCorreo_Recu.Size = new System.Drawing.Size(394, 22);
            this.txtCorreo_Recu.TabIndex = 1;
            // 
            // btenviar_Correo
            // 
            this.btenviar_Correo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btenviar_Correo.BackColor = System.Drawing.Color.Green;
            this.btenviar_Correo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btenviar_Correo.ForeColor = System.Drawing.Color.White;
            this.btenviar_Correo.Location = new System.Drawing.Point(110, 269);
            this.btenviar_Correo.Margin = new System.Windows.Forms.Padding(4);
            this.btenviar_Correo.Name = "btenviar_Correo";
            this.btenviar_Correo.Size = new System.Drawing.Size(245, 54);
            this.btenviar_Correo.TabIndex = 2;
            this.btenviar_Correo.Text = "Enviar Correo Electronico";
            this.btenviar_Correo.UseVisualStyleBackColor = false;
            // 
            // frmCorreo_RecuContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(472, 386);
            this.Controls.Add(this.btenviar_Correo);
            this.Controls.Add(this.txtCorreo_Recu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCorreo_RecuContra";
            this.Opacity = 0.75D;
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
    }
}