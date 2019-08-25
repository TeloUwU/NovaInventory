namespace NovaInventory.Vista
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nUdCantidad_Productos_Compra = new System.Windows.Forms.NumericUpDown();
            this.txtTotal_Compra = new System.Windows.Forms.TextBox();
            this.txtMOdelo_Compra = new System.Windows.Forms.TextBox();
            this.txtPrecio_UNidad_Compra = new System.Windows.Forms.TextBox();
            this.txtCategoría_Compra = new System.Windows.Forms.TextBox();
            this.txtProducto_Compra = new System.Windows.Forms.TextBox();
            this.btnVer_Kardex_Compra = new System.Windows.Forms.Button();
            this.btnMostrar_Factura_Compra = new System.Windows.Forms.Button();
            this.btnAgregar_Compra = new System.Windows.Forms.Button();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdCantidad_Productos_Compra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1280, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(144, 24);
            this.toolStripLabel1.Text = "Formulario Compras";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1280, 693);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvCompras);
            this.tabPage1.Controls.Add(this.btnVer_Kardex_Compra);
            this.tabPage1.Controls.Add(this.btnMostrar_Factura_Compra);
            this.tabPage1.Controls.Add(this.btnAgregar_Compra);
            this.tabPage1.Controls.Add(this.nUdCantidad_Productos_Compra);
            this.tabPage1.Controls.Add(this.txtTotal_Compra);
            this.tabPage1.Controls.Add(this.txtMOdelo_Compra);
            this.tabPage1.Controls.Add(this.txtPrecio_UNidad_Compra);
            this.tabPage1.Controls.Add(this.txtCategoría_Compra);
            this.tabPage1.Controls.Add(this.txtProducto_Compra);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1272, 664);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(896, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 37);
            this.label6.TabIndex = 24;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(896, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 37);
            this.label5.TabIndex = 23;
            this.label5.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 37);
            this.label4.TabIndex = 22;
            this.label4.Text = "Precio Unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Producto";
            // 
            // nUdCantidad_Productos_Compra
            // 
            this.nUdCantidad_Productos_Compra.Location = new System.Drawing.Point(50, 150);
            this.nUdCantidad_Productos_Compra.Name = "nUdCantidad_Productos_Compra";
            this.nUdCantidad_Productos_Compra.Size = new System.Drawing.Size(275, 22);
            this.nUdCantidad_Productos_Compra.TabIndex = 2;
            // 
            // txtTotal_Compra
            // 
            this.txtTotal_Compra.Enabled = false;
            this.txtTotal_Compra.Location = new System.Drawing.Point(902, 149);
            this.txtTotal_Compra.Name = "txtTotal_Compra";
            this.txtTotal_Compra.Size = new System.Drawing.Size(275, 22);
            this.txtTotal_Compra.TabIndex = 25;
            // 
            // txtMOdelo_Compra
            // 
            this.txtMOdelo_Compra.Location = new System.Drawing.Point(902, 66);
            this.txtMOdelo_Compra.Name = "txtMOdelo_Compra";
            this.txtMOdelo_Compra.Size = new System.Drawing.Size(275, 22);
            this.txtMOdelo_Compra.TabIndex = 4;
            // 
            // txtPrecio_UNidad_Compra
            // 
            this.txtPrecio_UNidad_Compra.Location = new System.Drawing.Point(492, 149);
            this.txtPrecio_UNidad_Compra.Name = "txtPrecio_UNidad_Compra";
            this.txtPrecio_UNidad_Compra.Size = new System.Drawing.Size(275, 22);
            this.txtPrecio_UNidad_Compra.TabIndex = 5;
            // 
            // txtCategoría_Compra
            // 
            this.txtCategoría_Compra.Location = new System.Drawing.Point(492, 66);
            this.txtCategoría_Compra.Name = "txtCategoría_Compra";
            this.txtCategoría_Compra.Size = new System.Drawing.Size(275, 22);
            this.txtCategoría_Compra.TabIndex = 3;
            // 
            // txtProducto_Compra
            // 
            this.txtProducto_Compra.Location = new System.Drawing.Point(50, 66);
            this.txtProducto_Compra.Name = "txtProducto_Compra";
            this.txtProducto_Compra.Size = new System.Drawing.Size(275, 22);
            this.txtProducto_Compra.TabIndex = 1;
            // 
            // btnVer_Kardex_Compra
            // 
            this.btnVer_Kardex_Compra.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer_Kardex_Compra.Location = new System.Drawing.Point(918, 205);
            this.btnVer_Kardex_Compra.Name = "btnVer_Kardex_Compra";
            this.btnVer_Kardex_Compra.Size = new System.Drawing.Size(243, 77);
            this.btnVer_Kardex_Compra.TabIndex = 9;
            this.btnVer_Kardex_Compra.Text = "Ver Kardex";
            this.btnVer_Kardex_Compra.UseVisualStyleBackColor = true;
            // 
            // btnMostrar_Factura_Compra
            // 
            this.btnMostrar_Factura_Compra.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar_Factura_Compra.Location = new System.Drawing.Point(510, 205);
            this.btnMostrar_Factura_Compra.Name = "btnMostrar_Factura_Compra";
            this.btnMostrar_Factura_Compra.Size = new System.Drawing.Size(243, 77);
            this.btnMostrar_Factura_Compra.TabIndex = 8;
            this.btnMostrar_Factura_Compra.Text = "Mostrar Factura";
            this.btnMostrar_Factura_Compra.UseVisualStyleBackColor = true;
            // 
            // btnAgregar_Compra
            // 
            this.btnAgregar_Compra.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar_Compra.Location = new System.Drawing.Point(71, 205);
            this.btnAgregar_Compra.Name = "btnAgregar_Compra";
            this.btnAgregar_Compra.Size = new System.Drawing.Size(243, 77);
            this.btnAgregar_Compra.TabIndex = 7;
            this.btnAgregar_Compra.Text = "Agregar Factura";
            this.btnAgregar_Compra.UseVisualStyleBackColor = true;
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(39, 307);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowTemplate.Height = 24;
            this.dgvCompras.Size = new System.Drawing.Size(1193, 336);
            this.dgvCompras.TabIndex = 6;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdCantidad_Productos_Compra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUdCantidad_Productos_Compra;
        private System.Windows.Forms.TextBox txtTotal_Compra;
        private System.Windows.Forms.TextBox txtMOdelo_Compra;
        private System.Windows.Forms.TextBox txtPrecio_UNidad_Compra;
        private System.Windows.Forms.TextBox txtCategoría_Compra;
        private System.Windows.Forms.TextBox txtProducto_Compra;
        private System.Windows.Forms.Button btnVer_Kardex_Compra;
        private System.Windows.Forms.Button btnMostrar_Factura_Compra;
        private System.Windows.Forms.Button btnAgregar_Compra;
        private System.Windows.Forms.DataGridView dgvCompras;
    }
}