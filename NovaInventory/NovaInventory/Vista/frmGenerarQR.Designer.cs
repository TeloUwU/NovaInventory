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
            this.pbmostrararchivo.Location = new System.Drawing.Point(523, 92);
            this.pbmostrararchivo.Name = "pbmostrararchivo";
            this.pbmostrararchivo.Size = new System.Drawing.Size(183, 180);
            this.pbmostrararchivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbmostrararchivo.TabIndex = 1;
            this.pbmostrararchivo.TabStop = false;
            // 
            // pbgenerar
            // 
            this.pbgenerar.Location = new System.Drawing.Point(31, 92);
            this.pbgenerar.Name = "pbgenerar";
            this.pbgenerar.Size = new System.Drawing.Size(183, 180);
            this.pbgenerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbgenerar.TabIndex = 2;
            this.pbgenerar.TabStop = false;
            // 
            // txtmostrar
            // 
            this.txtmostrar.Location = new System.Drawing.Point(523, 292);
            this.txtmostrar.Name = "txtmostrar";
            this.txtmostrar.Size = new System.Drawing.Size(183, 20);
            this.txtmostrar.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(31, 292);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(183, 20);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged_1);
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(523, 63);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(75, 23);
            this.btnabrir.TabIndex = 5;
            this.btnabrir.Text = "Abrir";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click_1);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(31, 330);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // frmGenerarQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 453);
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
    }
}