namespace NovaInventory.Vista
{
    partial class frmRecuperar_Contraseña
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnVolver_Login = new System.Windows.Forms.ToolStripButton();
            this.pbIntervenciónAdmi_Recu = new System.Windows.Forms.PictureBox();
            this.pbCorreo_Recu = new System.Windows.Forms.PictureBox();
            this.pbPreguntas_Recu = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIntervenciónAdmi_Recu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorreo_Recu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreguntas_Recu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el metodo de recuperación de Contraseña que desea utilizar";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preguntas de Seguridad";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Correo Electronico";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Intervención del Administrador";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVolver_Login});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "tsRecuperar_Contraseña";
     
            // 
            // pbIntervenciónAdmi_Recu
            // 
            this.pbIntervenciónAdmi_Recu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbIntervenciónAdmi_Recu.Image = global::NovaInventory.Properties.Resources.administrator_104px;
            this.pbIntervenciónAdmi_Recu.Location = new System.Drawing.Point(579, 116);
            this.pbIntervenciónAdmi_Recu.Name = "pbIntervenciónAdmi_Recu";
            this.pbIntervenciónAdmi_Recu.Size = new System.Drawing.Size(170, 135);
            this.pbIntervenciónAdmi_Recu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIntervenciónAdmi_Recu.TabIndex = 3;
            this.pbIntervenciónAdmi_Recu.TabStop = false;
            // 
            // pbCorreo_Recu
            // 
            this.pbCorreo_Recu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbCorreo_Recu.Image = global::NovaInventory.Properties.Resources.new_post_104px;
            this.pbCorreo_Recu.Location = new System.Drawing.Point(326, 116);
            this.pbCorreo_Recu.Name = "pbCorreo_Recu";
            this.pbCorreo_Recu.Size = new System.Drawing.Size(170, 135);
            this.pbCorreo_Recu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCorreo_Recu.TabIndex = 2;
            this.pbCorreo_Recu.TabStop = false;
            this.pbCorreo_Recu.Click += new System.EventHandler(this.pbCorreo_Recu_Click);
       
            // 
            // frmRecuperar_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbIntervenciónAdmi_Recu);
            this.Controls.Add(this.pbCorreo_Recu);
            this.Controls.Add(this.pbPreguntas_Recu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecuperar_Contraseña";
            this.Text = "frmRecuperar_Contraseña";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIntervenciónAdmi_Recu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorreo_Recu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreguntas_Recu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPreguntas_Recu;
        private System.Windows.Forms.PictureBox pbCorreo_Recu;
        private System.Windows.Forms.PictureBox pbIntervenciónAdmi_Recu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnVolver_Login;
    }
}