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
            this.pbPreguntas = new System.Windows.Forms.PictureBox();
            this.pbIntervenciónAdmi_Recu = new System.Windows.Forms.PictureBox();
            this.pbCorreo_Recu = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_recuperar = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreguntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIntervenciónAdmi_Recu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorreo_Recu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el metodo de recuperación de Contraseña que desea utilizar";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preguntas de Seguridad";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Correo Electronico";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(769, 367);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Intervención del Administrador";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVolver_Login});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "tsRecuperar_Contraseña";
            // 
            // btnVolver_Login
            // 
            this.btnVolver_Login.Name = "btnVolver_Login";
            this.btnVolver_Login.Size = new System.Drawing.Size(23, 22);
            // 
            // pbPreguntas
            // 
            this.pbPreguntas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbPreguntas.Image = global::NovaInventory.Properties.Resources.book_104px;
            this.pbPreguntas.Location = new System.Drawing.Point(77, 180);
            this.pbPreguntas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPreguntas.Name = "pbPreguntas";
            this.pbPreguntas.Size = new System.Drawing.Size(227, 166);
            this.pbPreguntas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreguntas.TabIndex = 9;
            this.pbPreguntas.TabStop = false;
            this.pbPreguntas.Click += new System.EventHandler(this.pbPreguntas_Click);
            // 
            // pbIntervenciónAdmi_Recu
            // 
            this.pbIntervenciónAdmi_Recu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbIntervenciónAdmi_Recu.Image = global::NovaInventory.Properties.Resources.administrator_104px;
            this.pbIntervenciónAdmi_Recu.Location = new System.Drawing.Point(755, 180);
            this.pbIntervenciónAdmi_Recu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbIntervenciónAdmi_Recu.Name = "pbIntervenciónAdmi_Recu";
            this.pbIntervenciónAdmi_Recu.Size = new System.Drawing.Size(227, 166);
            this.pbIntervenciónAdmi_Recu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIntervenciónAdmi_Recu.TabIndex = 3;
            this.pbIntervenciónAdmi_Recu.TabStop = false;
            this.pbIntervenciónAdmi_Recu.Click += new System.EventHandler(this.pbIntervenciónAdmi_Recu_Click);
            // 
            // pbCorreo_Recu
            // 
            this.pbCorreo_Recu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbCorreo_Recu.Image = global::NovaInventory.Properties.Resources.new_post_104px;
            this.pbCorreo_Recu.Location = new System.Drawing.Point(417, 180);
            this.pbCorreo_Recu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCorreo_Recu.Name = "pbCorreo_Recu";
            this.pbCorreo_Recu.Size = new System.Drawing.Size(227, 166);
            this.pbCorreo_Recu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCorreo_Recu.TabIndex = 2;
            this.pbCorreo_Recu.TabStop = false;
            this.pbCorreo_Recu.Click += new System.EventHandler(this.pbCorreo_Recu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 101);
            this.panel1.TabIndex = 10;
            // 
            // checkBox_recuperar
            // 
            this.checkBox_recuperar.AutoSize = true;
            this.checkBox_recuperar.Location = new System.Drawing.Point(920, 0);
            this.checkBox_recuperar.Name = "checkBox_recuperar";
            this.checkBox_recuperar.Size = new System.Drawing.Size(144, 21);
            this.checkBox_recuperar.TabIndex = 11;
            this.checkBox_recuperar.Text = "English Language";
            this.checkBox_recuperar.UseVisualStyleBackColor = true;
            this.checkBox_recuperar.CheckedChanged += new System.EventHandler(this.checkBox_recuperar_CheckedChanged);
            // 
            // frmRecuperar_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 455);
            this.Controls.Add(this.checkBox_recuperar);
            this.Controls.Add(this.pbPreguntas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbIntervenciónAdmi_Recu);
            this.Controls.Add(this.pbCorreo_Recu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRecuperar_Contraseña";
            this.Text = "frmRecuperar_Contraseña";
            this.Load += new System.EventHandler(this.frmRecuperar_Contraseña_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreguntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIntervenciónAdmi_Recu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorreo_Recu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCorreo_Recu;
        private System.Windows.Forms.PictureBox pbIntervenciónAdmi_Recu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnVolver_Login;
        private System.Windows.Forms.PictureBox pbPreguntas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_recuperar;
    }
}