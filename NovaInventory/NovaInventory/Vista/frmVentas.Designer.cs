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
            this.txtid_Venta = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario_Venta = new System.Windows.Forms.TextBox();
            this.txtTotal_Venta = new System.Windows.Forms.TextBox();
            this.cbProducto_Venta = new System.Windows.Forms.ComboBox();
            this.cbModelo_Venta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCategoría_Venta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nUDCantidadArticulos_Venta = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpfecha_Venta = new System.Windows.Forms.DateTimePicker();
            this.mCVer_fecha_Venta = new System.Windows.Forms.MonthCalendar();
            this.dgvMostrarVentas = new System.Windows.Forms.DataGridView();
            this.btnAgregar_Venta = new System.Windows.Forms.Button();
            this.btnMostrar_Ventas = new System.Windows.Forms.Button();
            this.btnVer_Kardex_Ventas = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidadArticulos_Venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1044, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Formulario Ventas";
            // 
            // txtid_Venta
            // 
            this.txtid_Venta.Location = new System.Drawing.Point(991, 30);
            this.txtid_Venta.Name = "txtid_Venta";
            this.txtid_Venta.Size = new System.Drawing.Size(26, 22);
            this.txtid_Venta.TabIndex = 2;
            // 
            // txtPrecioUnitario_Venta
            // 
            this.txtPrecioUnitario_Venta.Enabled = false;
            this.txtPrecioUnitario_Venta.Location = new System.Drawing.Point(213, 152);
            this.txtPrecioUnitario_Venta.Name = "txtPrecioUnitario_Venta";
            this.txtPrecioUnitario_Venta.Size = new System.Drawing.Size(155, 22);
            this.txtPrecioUnitario_Venta.TabIndex = 4;
            // 
            // txtTotal_Venta
            // 
            this.txtTotal_Venta.Enabled = false;
            this.txtTotal_Venta.Location = new System.Drawing.Point(416, 150);
            this.txtTotal_Venta.Name = "txtTotal_Venta";
            this.txtTotal_Venta.Size = new System.Drawing.Size(189, 22);
            this.txtTotal_Venta.TabIndex = 5;
            // 
            // cbProducto_Venta
            // 
            this.cbProducto_Venta.FormattingEnabled = true;
            this.cbProducto_Venta.Location = new System.Drawing.Point(350, 87);
            this.cbProducto_Venta.Name = "cbProducto_Venta";
            this.cbProducto_Venta.Size = new System.Drawing.Size(124, 24);
            this.cbProducto_Venta.TabIndex = 6;
            // 
            // cbModelo_Venta
            // 
            this.cbModelo_Venta.FormattingEnabled = true;
            this.cbModelo_Venta.Location = new System.Drawing.Point(511, 87);
            this.cbModelo_Venta.Name = "cbModelo_Venta";
            this.cbModelo_Venta.Size = new System.Drawing.Size(123, 24);
            this.cbModelo_Venta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio Unitario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total";
            // 
            // cbCategoría_Venta
            // 
            this.cbCategoría_Venta.FormattingEnabled = true;
            this.cbCategoría_Venta.Location = new System.Drawing.Point(201, 87);
            this.cbCategoría_Venta.Name = "cbCategoría_Venta";
            this.cbCategoría_Venta.Size = new System.Drawing.Size(121, 24);
            this.cbCategoría_Venta.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Categoría";
            // 
            // nUDCantidadArticulos_Venta
            // 
            this.nUDCantidadArticulos_Venta.Location = new System.Drawing.Point(46, 150);
            this.nUDCantidadArticulos_Venta.Name = "nUDCantidadArticulos_Venta";
            this.nUDCantidadArticulos_Venta.Size = new System.Drawing.Size(121, 22);
            this.nUDCantidadArticulos_Venta.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cliente";
            // 
            // dtpfecha_Venta
            // 
            this.dtpfecha_Venta.Location = new System.Drawing.Point(959, 30);
            this.dtpfecha_Venta.Name = "dtpfecha_Venta";
            this.dtpfecha_Venta.Size = new System.Drawing.Size(26, 22);
            this.dtpfecha_Venta.TabIndex = 20;
            // 
            // mCVer_fecha_Venta
            // 
            this.mCVer_fecha_Venta.Location = new System.Drawing.Point(708, 75);
            this.mCVer_fecha_Venta.Name = "mCVer_fecha_Venta";
            this.mCVer_fecha_Venta.TabIndex = 21;
            // 
            // dgvMostrarVentas
            // 
            this.dgvMostrarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarVentas.Location = new System.Drawing.Point(24, 306);
            this.dgvMostrarVentas.Name = "dgvMostrarVentas";
            this.dgvMostrarVentas.RowTemplate.Height = 24;
            this.dgvMostrarVentas.Size = new System.Drawing.Size(993, 337);
            this.dgvMostrarVentas.TabIndex = 22;
            // 
            // btnAgregar_Venta
            // 
            this.btnAgregar_Venta.Location = new System.Drawing.Point(65, 219);
            this.btnAgregar_Venta.Name = "btnAgregar_Venta";
            this.btnAgregar_Venta.Size = new System.Drawing.Size(150, 40);
            this.btnAgregar_Venta.TabIndex = 23;
            this.btnAgregar_Venta.Text = "Hacer Venta";
            this.btnAgregar_Venta.UseVisualStyleBackColor = true;
            // 
            // btnMostrar_Ventas
            // 
            this.btnMostrar_Ventas.Location = new System.Drawing.Point(265, 219);
            this.btnMostrar_Ventas.Name = "btnMostrar_Ventas";
            this.btnMostrar_Ventas.Size = new System.Drawing.Size(150, 40);
            this.btnMostrar_Ventas.TabIndex = 24;
            this.btnMostrar_Ventas.Text = "Mostrar Ventas";
            this.btnMostrar_Ventas.UseVisualStyleBackColor = true;
            // 
            // btnVer_Kardex_Ventas
            // 
            this.btnVer_Kardex_Ventas.Location = new System.Drawing.Point(465, 219);
            this.btnVer_Kardex_Ventas.Name = "btnVer_Kardex_Ventas";
            this.btnVer_Kardex_Ventas.Size = new System.Drawing.Size(150, 40);
            this.btnVer_Kardex_Ventas.TabIndex = 25;
            this.btnVer_Kardex_Ventas.Text = "Ver Kardex";
            this.btnVer_Kardex_Ventas.UseVisualStyleBackColor = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::NovaInventory.Properties.Resources.undo_26px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(149, 24);
            this.toolStripButton1.Text = "Cerrar Formulario";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(132, 24);
            this.toolStripButton2.Text = "Formulario Ventas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 26;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 665);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnVer_Kardex_Ventas);
            this.Controls.Add(this.btnMostrar_Ventas);
            this.Controls.Add(this.btnAgregar_Venta);
            this.Controls.Add(this.dgvMostrarVentas);
            this.Controls.Add(this.mCVer_fecha_Venta);
            this.Controls.Add(this.dtpfecha_Venta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nUDCantidadArticulos_Venta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCategoría_Venta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbModelo_Venta);
            this.Controls.Add(this.cbProducto_Venta);
            this.Controls.Add(this.txtTotal_Venta);
            this.Controls.Add(this.txtPrecioUnitario_Venta);
            this.Controls.Add(this.txtid_Venta);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidadArticulos_Venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TextBox txtid_Venta;
        private System.Windows.Forms.TextBox txtPrecioUnitario_Venta;
        private System.Windows.Forms.TextBox txtTotal_Venta;
        private System.Windows.Forms.ComboBox cbProducto_Venta;
        private System.Windows.Forms.ComboBox cbModelo_Venta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCategoría_Venta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nUDCantidadArticulos_Venta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpfecha_Venta;
        private System.Windows.Forms.MonthCalendar mCVer_fecha_Venta;
        private System.Windows.Forms.DataGridView dgvMostrarVentas;
        private System.Windows.Forms.Button btnAgregar_Venta;
        private System.Windows.Forms.Button btnMostrar_Ventas;
        private System.Windows.Forms.Button btnVer_Kardex_Ventas;
        private System.Windows.Forms.TextBox textBox1;
    }
}