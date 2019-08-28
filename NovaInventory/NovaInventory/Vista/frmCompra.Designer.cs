namespace NovaInventory.Vista
{
    partial class frmCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompra));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio_Unitario = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbProveedor_Compra = new System.Windows.Forms.ComboBox();
            this.cbCategoría_Compra = new System.Windows.Forms.ComboBox();
            this.cbProducto_Compra = new System.Windows.Forms.ComboBox();
            this.cbModelo_Compra = new System.Windows.Forms.ComboBox();
            this.nUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnActualizar_Compra = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAgregarCompra = new System.Windows.Forms.Button();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNum_factura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtid_Compra = new System.Windows.Forms.TextBox();
            this.dtpRealización_Compra = new System.Windows.Forms.DateTimePicker();
            this.txtid_usuario = new System.Windows.Forms.TextBox();
            this.cbTipo_Pago = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(811, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(120, 24);
            this.toolStripButton1.Text = "Formulario Compras";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = global::NovaInventory.Properties.Resources.undo_26px;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(124, 24);
            this.toolStripButton2.Text = "Cerrar Formulario";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoría";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Producto";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Precio Unitario";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total";
            // 
            // txtPrecio_Unitario
            // 
            this.txtPrecio_Unitario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrecio_Unitario.Location = new System.Drawing.Point(130, 114);
            this.txtPrecio_Unitario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio_Unitario.Name = "txtPrecio_Unitario";
            this.txtPrecio_Unitario.ShortcutsEnabled = false;
            this.txtPrecio_Unitario.Size = new System.Drawing.Size(92, 20);
            this.txtPrecio_Unitario.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(248, 114);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ShortcutsEnabled = false;
            this.txtTotal.Size = new System.Drawing.Size(92, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // cbProveedor_Compra
            // 
            this.cbProveedor_Compra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbProveedor_Compra.FormattingEnabled = true;
            this.cbProveedor_Compra.Location = new System.Drawing.Point(16, 63);
            this.cbProveedor_Compra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProveedor_Compra.Name = "cbProveedor_Compra";
            this.cbProveedor_Compra.Size = new System.Drawing.Size(92, 21);
            this.cbProveedor_Compra.TabIndex = 1;
            // 
            // cbCategoría_Compra
            // 
            this.cbCategoría_Compra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCategoría_Compra.FormattingEnabled = true;
            this.cbCategoría_Compra.Location = new System.Drawing.Point(130, 63);
            this.cbCategoría_Compra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategoría_Compra.Name = "cbCategoría_Compra";
            this.cbCategoría_Compra.Size = new System.Drawing.Size(92, 21);
            this.cbCategoría_Compra.TabIndex = 2;
            // 
            // cbProducto_Compra
            // 
            this.cbProducto_Compra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbProducto_Compra.FormattingEnabled = true;
            this.cbProducto_Compra.Location = new System.Drawing.Point(248, 63);
            this.cbProducto_Compra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProducto_Compra.Name = "cbProducto_Compra";
            this.cbProducto_Compra.Size = new System.Drawing.Size(92, 21);
            this.cbProducto_Compra.TabIndex = 3;
            // 
            // cbModelo_Compra
            // 
            this.cbModelo_Compra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbModelo_Compra.FormattingEnabled = true;
            this.cbModelo_Compra.Location = new System.Drawing.Point(368, 63);
            this.cbModelo_Compra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbModelo_Compra.Name = "cbModelo_Compra";
            this.cbModelo_Compra.Size = new System.Drawing.Size(92, 21);
            this.cbModelo_Compra.TabIndex = 4;
            // 
            // nUDCantidad
            // 
            this.nUDCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nUDCantidad.Location = new System.Drawing.Point(16, 114);
            this.nUDCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nUDCantidad.Name = "nUDCantidad";
            this.nUDCantidad.Size = new System.Drawing.Size(91, 20);
            this.nUDCantidad.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthCalendar1.Location = new System.Drawing.Point(541, 63);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // dgvCompras
            // 
            this.dgvCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(34, 271);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowTemplate.Height = 24;
            this.dgvCompras.Size = new System.Drawing.Size(735, 243);
            this.dgvCompras.TabIndex = 11;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMostrar.Location = new System.Drawing.Point(158, 194);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(98, 37);
            this.btnMostrar.TabIndex = 13;
            this.btnMostrar.Text = "Mostrar Compras";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar_Compra
            // 
            this.btnActualizar_Compra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizar_Compra.Location = new System.Drawing.Point(275, 194);
            this.btnActualizar_Compra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizar_Compra.Name = "btnActualizar_Compra";
            this.btnActualizar_Compra.Size = new System.Drawing.Size(106, 37);
            this.btnActualizar_Compra.TabIndex = 14;
            this.btnActualizar_Compra.Text = "Actualizar Compra";
            this.btnActualizar_Compra.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.Location = new System.Drawing.Point(404, 194);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 37);
            this.button4.TabIndex = 15;
            this.button4.Text = "Ver Kardex";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarCompra.Location = new System.Drawing.Point(34, 194);
            this.btnAgregarCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(98, 37);
            this.btnAgregarCompra.TabIndex = 12;
            this.btnAgregarCompra.Text = "Hacer Compra";
            this.btnAgregarCompra.UseVisualStyleBackColor = true;
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // txtDescripción
            // 
            this.txtDescripción.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescripción.Location = new System.Drawing.Point(368, 114);
            this.txtDescripción.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripción.Multiline = true;
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.ShortcutsEnabled = false;
            this.txtDescripción.Size = new System.Drawing.Size(155, 64);
            this.txtDescripción.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Descripción";
            // 
            // txtNum_factura
            // 
            this.txtNum_factura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNum_factura.Enabled = false;
            this.txtNum_factura.Location = new System.Drawing.Point(16, 161);
            this.txtNum_factura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNum_factura.Name = "txtNum_factura";
            this.txtNum_factura.ShortcutsEnabled = false;
            this.txtNum_factura.Size = new System.Drawing.Size(92, 20);
            this.txtNum_factura.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Numero de Factura";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(128, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tipo de Pago";
            // 
            // txtid_Compra
            // 
            this.txtid_Compra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtid_Compra.Location = new System.Drawing.Point(722, 27);
            this.txtid_Compra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtid_Compra.Name = "txtid_Compra";
            this.txtid_Compra.Size = new System.Drawing.Size(21, 20);
            this.txtid_Compra.TabIndex = 0;
            this.txtid_Compra.Visible = false;
            // 
            // dtpRealización_Compra
            // 
            this.dtpRealización_Compra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpRealización_Compra.CustomFormat = "yyyy-MM-dd";
            this.dtpRealización_Compra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRealización_Compra.Location = new System.Drawing.Point(606, 27);
            this.dtpRealización_Compra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpRealización_Compra.Name = "dtpRealización_Compra";
            this.dtpRealización_Compra.Size = new System.Drawing.Size(89, 20);
            this.dtpRealización_Compra.TabIndex = 0;
            this.dtpRealización_Compra.Visible = false;
            // 
            // txtid_usuario
            // 
            this.txtid_usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtid_usuario.Location = new System.Drawing.Point(698, 27);
            this.txtid_usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtid_usuario.Name = "txtid_usuario";
            this.txtid_usuario.Size = new System.Drawing.Size(20, 20);
            this.txtid_usuario.TabIndex = 0;
            this.txtid_usuario.Visible = false;
            // 
            // cbTipo_Pago
            // 
            this.cbTipo_Pago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTipo_Pago.FormattingEnabled = true;
            this.cbTipo_Pago.Location = new System.Drawing.Point(130, 158);
            this.cbTipo_Pago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipo_Pago.Name = "cbTipo_Pago";
            this.cbTipo_Pago.Size = new System.Drawing.Size(92, 21);
            this.cbTipo_Pago.TabIndex = 19;
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 540);
            this.Controls.Add(this.cbTipo_Pago);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtid_usuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNum_factura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.btnAgregarCompra);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnActualizar_Compra);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.dtpRealización_Compra);
            this.Controls.Add(this.txtid_Compra);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.nUDCantidad);
            this.Controls.Add(this.cbModelo_Compra);
            this.Controls.Add(this.cbProducto_Compra);
            this.Controls.Add(this.cbCategoría_Compra);
            this.Controls.Add(this.cbProveedor_Compra);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPrecio_Unitario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCompra";
            this.Text = "frmCompra";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio_Unitario;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cbProveedor_Compra;
        private System.Windows.Forms.ComboBox cbCategoría_Compra;
        private System.Windows.Forms.ComboBox cbProducto_Compra;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ComboBox cbModelo_Compra;
        private System.Windows.Forms.NumericUpDown nUDCantidad;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnActualizar_Compra;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAgregarCompra;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNum_factura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtid_Compra;
        private System.Windows.Forms.DateTimePicker dtpRealización_Compra;
        private System.Windows.Forms.TextBox txtid_usuario;
        private System.Windows.Forms.ComboBox cbTipo_Pago;
    }
}