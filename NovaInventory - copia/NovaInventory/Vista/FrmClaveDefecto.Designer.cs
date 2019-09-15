namespace NovaInventory.Vista
{
    partial class FrmClaveDefecto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre_Usuario = new System.Windows.Forms.Label();
            this.lblApellido_Usuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblApellido_Usuario);
            this.panel1.Controls.Add(this.lblNombre_Usuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pbUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 580);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(555, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nueva Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(555, 283);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirmar Contraseña:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, 227);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 32);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(559, 313);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(473, 32);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(714, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cambiar Clave";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pbUsuario
            // 
            this.pbUsuario.Location = new System.Drawing.Point(164, 136);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(164, 108);
            this.pbUsuario.TabIndex = 0;
            this.pbUsuario.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(160, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bienvenido usuario:";
            // 
            // lblNombre_Usuario
            // 
            this.lblNombre_Usuario.AutoSize = true;
            this.lblNombre_Usuario.ForeColor = System.Drawing.Color.Black;
            this.lblNombre_Usuario.Location = new System.Drawing.Point(151, 341);
            this.lblNombre_Usuario.Name = "lblNombre_Usuario";
            this.lblNombre_Usuario.Size = new System.Drawing.Size(61, 24);
            this.lblNombre_Usuario.TabIndex = 2;
            this.lblNombre_Usuario.Text = "label4";
            // 
            // lblApellido_Usuario
            // 
            this.lblApellido_Usuario.AutoSize = true;
            this.lblApellido_Usuario.ForeColor = System.Drawing.Color.Black;
            this.lblApellido_Usuario.Location = new System.Drawing.Point(267, 341);
            this.lblApellido_Usuario.Name = "lblApellido_Usuario";
            this.lblApellido_Usuario.Size = new System.Drawing.Size(61, 24);
            this.lblApellido_Usuario.TabIndex = 3;
            this.lblApellido_Usuario.Text = "label5";
            // 
            // FrmClaveDefecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmClaveDefecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClaveDefecto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblApellido_Usuario;
        private System.Windows.Forms.Label lblNombre_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbUsuario;
    }
}