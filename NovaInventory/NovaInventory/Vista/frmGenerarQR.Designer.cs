namespace NovaInventory.Vista
{
    partial class frmGenerarQR
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pbmostrararchivo = new System.Windows.Forms.PictureBox();
            this.pbgenerar = new System.Windows.Forms.PictureBox();
            this.txtmostrar = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnabrir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrararchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(736, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::NovaInventory.Properties.Resources.cancel_button1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pbmostrararchivo
            // 
            this.pbmostrararchivo.Location = new System.Drawing.Point(465, 130);
            this.pbmostrararchivo.Name = "pbmostrararchivo";
            this.pbmostrararchivo.Size = new System.Drawing.Size(183, 180);
            this.pbmostrararchivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbmostrararchivo.TabIndex = 1;
            this.pbmostrararchivo.TabStop = false;
            // 
            // pbgenerar
            // 
            this.pbgenerar.Location = new System.Drawing.Point(103, 130);
            this.pbgenerar.Name = "pbgenerar";
            this.pbgenerar.Size = new System.Drawing.Size(183, 180);
            this.pbgenerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbgenerar.TabIndex = 2;
            this.pbgenerar.TabStop = false;
            // 
            // txtmostrar
            // 
            this.txtmostrar.Location = new System.Drawing.Point(465, 330);
            this.txtmostrar.Name = "txtmostrar";
            this.txtmostrar.Size = new System.Drawing.Size(183, 20);
            this.txtmostrar.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(103, 330);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(183, 20);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged_1);
            // 
            // btnabrir
            // 
            this.btnabrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnabrir.Location = new System.Drawing.Point(465, 368);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(183, 42);
            this.btnabrir.TabIndex = 5;
            this.btnabrir.Text = "Abrir";
            this.btnabrir.UseVisualStyleBackColor = false;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click_1);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnguardar.Location = new System.Drawing.Point(103, 368);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(183, 42);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Generador de Códigos QR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Generar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Abrir código QR creado previamente";
            // 
            // frmGenerarQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtmostrar);
            this.Controls.Add(this.pbgenerar);
            this.Controls.Add(this.pbmostrararchivo);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGenerarQR";
            this.Text = "frmGenerarQR";
            this.Load += new System.EventHandler(this.frmGenerarQR_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrararchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pbmostrararchivo;
        private System.Windows.Forms.PictureBox pbgenerar;
        private System.Windows.Forms.TextBox txtmostrar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}