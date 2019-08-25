namespace NovaInventory.Vista
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtid_Venta = new System.Windows.Forms.TextBox();
            this.txtProducto_Venta = new System.Windows.Forms.TextBox();
            this.txtCategoria_Venta = new System.Windows.Forms.TextBox();
            this.txtPrecio_Unitario_Venta = new System.Windows.Forms.TextBox();
            this.txtModelo_Venta = new System.Windows.Forms.TextBox();
            this.txtTotal_Venta = new System.Windows.Forms.TextBox();
            this.btnAgregar_Venta = new System.Windows.Forms.Button();
            this.btnMostrar_Factura_Venta = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nUdCantidad_Productos_Venta = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUdCantidad_Productos_Venta)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1280, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(128, 24);
            this.toolStripLabel1.Text = "Formulario Ventas";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(149, 24);
            this.toolStripButton1.Text = "Cerrar Formulario";
            // 
            // txtid_Venta
            // 
            this.txtid_Venta.Location = new System.Drawing.Point(1229, 30);
            this.txtid_Venta.Name = "txtid_Venta";
            this.txtid_Venta.Size = new System.Drawing.Size(29, 22);
            this.txtid_Venta.TabIndex = 1;
            this.txtid_Venta.Visible = false;
            // 
            // txtProducto_Venta
            // 
            this.txtProducto_Venta.Location = new System.Drawing.Point(92, 94);
            this.txtProducto_Venta.Name = "txtProducto_Venta";
            this.txtProducto_Venta.Size = new System.Drawing.Size(275, 22);
            this.txtProducto_Venta.TabIndex = 1;
            // 
            // txtCategoria_Venta
            // 
            this.txtCategoria_Venta.Location = new System.Drawing.Point(514, 94);
            this.txtCategoria_Venta.Name = "txtCategoria_Venta";
            this.txtCategoria_Venta.Size = new System.Drawing.Size(275, 22);
            this.txtCategoria_Venta.TabIndex = 3;
            // 
            // txtPrecio_Unitario_Venta
            // 
            this.txtPrecio_Unitario_Venta.Enabled = false;
            this.txtPrecio_Unitario_Venta.Location = new System.Drawing.Point(514, 177);
            this.txtPrecio_Unitario_Venta.Name = "txtPrecio_Unitario_Venta";
            this.txtPrecio_Unitario_Venta.Size = new System.Drawing.Size(275, 22);
            this.txtPrecio_Unitario_Venta.TabIndex = 0;
            // 
            // txtModelo_Venta
            // 
            this.txtModelo_Venta.Location = new System.Drawing.Point(912, 94);
            this.txtModelo_Venta.Name = "txtModelo_Venta";
            this.txtModelo_Venta.Size = new System.Drawing.Size(275, 22);
            this.txtModelo_Venta.TabIndex = 4;
            // 
            // txtTotal_Venta
            // 
            this.txtTotal_Venta.Enabled = false;
            this.txtTotal_Venta.Location = new System.Drawing.Point(912, 177);
            this.txtTotal_Venta.Name = "txtTotal_Venta";
            this.txtTotal_Venta.Size = new System.Drawing.Size(275, 22);
            this.txtTotal_Venta.TabIndex = 0;
            // 
            // btnAgregar_Venta
            // 
            this.btnAgregar_Venta.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar_Venta.Location = new System.Drawing.Point(301, 231);
            this.btnAgregar_Venta.Name = "btnAgregar_Venta";
            this.btnAgregar_Venta.Size = new System.Drawing.Size(243, 77);
            this.btnAgregar_Venta.TabIndex = 6;
            this.btnAgregar_Venta.Text = "Agregar Factura";
            this.btnAgregar_Venta.UseVisualStyleBackColor = true;
            // 
            // btnMostrar_Factura_Venta
            // 
            this.btnMostrar_Factura_Venta.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar_Factura_Venta.Location = new System.Drawing.Point(750, 231);
            this.btnMostrar_Factura_Venta.Name = "btnMostrar_Factura_Venta";
            this.btnMostrar_Factura_Venta.Size = new System.Drawing.Size(243, 77);
            this.btnMostrar_Factura_Venta.TabIndex = 7;
            this.btnMostrar_Factura_Venta.Text = "Mostrar Factura";
            this.btnMostrar_Factura_Venta.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(74, 341);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(1128, 350);
            this.dgvVentas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Categoría";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Precio Unitario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(906, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(906, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total";
            // 
            // nUdCantidad_Productos_Venta
            // 
            this.nUdCantidad_Productos_Venta.Location = new System.Drawing.Point(92, 178);
            this.nUdCantidad_Productos_Venta.Name = "nUdCantidad_Productos_Venta";
            this.nUdCantidad_Productos_Venta.Size = new System.Drawing.Size(275, 22);
            this.nUdCantidad_Productos_Venta.TabIndex = 2;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.nUdCantidad_Productos_Venta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnMostrar_Factura_Venta);
            this.Controls.Add(this.btnAgregar_Venta);
            this.Controls.Add(this.txtTotal_Venta);
            this.Controls.Add(this.txtModelo_Venta);
            this.Controls.Add(this.txtPrecio_Unitario_Venta);
            this.Controls.Add(this.txtCategoria_Venta);
            this.Controls.Add(this.txtProducto_Venta);
            this.Controls.Add(this.txtid_Venta);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUdCantidad_Productos_Venta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txtid_Venta;
        private System.Windows.Forms.TextBox txtProducto_Venta;
        private System.Windows.Forms.TextBox txtCategoria_Venta;
        private System.Windows.Forms.TextBox txtPrecio_Unitario_Venta;
        private System.Windows.Forms.TextBox txtModelo_Venta;
        private System.Windows.Forms.TextBox txtTotal_Venta;
        private System.Windows.Forms.Button btnAgregar_Venta;
        private System.Windows.Forms.Button btnMostrar_Factura_Venta;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nUdCantidad_Productos_Venta;
    }
}