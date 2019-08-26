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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbProveedor_Compra = new System.Windows.Forms.ComboBox();
            this.cbCategoría_Compra = new System.Windows.Forms.ComboBox();
            this.cbProducto_Compra = new System.Windows.Forms.ComboBox();
            this.cbModelo_Compra = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtid_Compra = new System.Windows.Forms.TextBox();
            this.dtpRealización_Compra = new System.Windows.Forms.DateTimePicker();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnActualizar_Compra = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAgregarCompra = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNum_factura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtid_usuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTipo_Pago = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1044, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(148, 24);
            this.toolStripButton1.Text = "Formulario Compras";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = global::NovaInventory.Properties.Resources.undo_26px;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(149, 24);
            this.toolStripButton2.Text = "Cerrar Formulario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoría";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Precio Unitario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(330, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 7;
            // 
            // cbProveedor_Compra
            // 
            this.cbProveedor_Compra.FormattingEnabled = true;
            this.cbProveedor_Compra.Location = new System.Drawing.Point(22, 77);
            this.cbProveedor_Compra.Name = "cbProveedor_Compra";
            this.cbProveedor_Compra.Size = new System.Drawing.Size(121, 24);
            this.cbProveedor_Compra.TabIndex = 1;
            // 
            // cbCategoría_Compra
            // 
            this.cbCategoría_Compra.FormattingEnabled = true;
            this.cbCategoría_Compra.Location = new System.Drawing.Point(174, 77);
            this.cbCategoría_Compra.Name = "cbCategoría_Compra";
            this.cbCategoría_Compra.Size = new System.Drawing.Size(121, 24);
            this.cbCategoría_Compra.TabIndex = 2;
            // 
            // cbProducto_Compra
            // 
            this.cbProducto_Compra.FormattingEnabled = true;
            this.cbProducto_Compra.Location = new System.Drawing.Point(330, 77);
            this.cbProducto_Compra.Name = "cbProducto_Compra";
            this.cbProducto_Compra.Size = new System.Drawing.Size(121, 24);
            this.cbProducto_Compra.TabIndex = 3;
            // 
            // cbModelo_Compra
            // 
            this.cbModelo_Compra.FormattingEnabled = true;
            this.cbModelo_Compra.Location = new System.Drawing.Point(490, 77);
            this.cbModelo_Compra.Name = "cbModelo_Compra";
            this.cbModelo_Compra.Size = new System.Drawing.Size(121, 24);
            this.cbModelo_Compra.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(22, 140);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(721, 77);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // txtid_Compra
            // 
            this.txtid_Compra.Location = new System.Drawing.Point(963, 33);
            this.txtid_Compra.Name = "txtid_Compra";
            this.txtid_Compra.Size = new System.Drawing.Size(27, 22);
            this.txtid_Compra.TabIndex = 0;
            this.txtid_Compra.Visible = false;
            // 
            // dtpRealización_Compra
            // 
            this.dtpRealización_Compra.Location = new System.Drawing.Point(996, 33);
            this.dtpRealización_Compra.Name = "dtpRealización_Compra";
            this.dtpRealización_Compra.Size = new System.Drawing.Size(27, 22);
            this.dtpRealización_Compra.TabIndex = 0;
            this.dtpRealización_Compra.Visible = false;
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(31, 333);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowTemplate.Height = 24;
            this.dgvCompras.Size = new System.Drawing.Size(980, 299);
            this.dgvCompras.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "Mostrar Compras";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnActualizar_Compra
            // 
            this.btnActualizar_Compra.Location = new System.Drawing.Point(367, 239);
            this.btnActualizar_Compra.Name = "btnActualizar_Compra";
            this.btnActualizar_Compra.Size = new System.Drawing.Size(141, 45);
            this.btnActualizar_Compra.TabIndex = 11;
            this.btnActualizar_Compra.Text = "Actualizar Compra";
            this.btnActualizar_Compra.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(539, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 45);
            this.button4.TabIndex = 12;
            this.button4.Text = "Ver Kardex";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.Location = new System.Drawing.Point(45, 239);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(130, 45);
            this.btnAgregarCompra.TabIndex = 9;
            this.btnAgregarCompra.Text = "Hacer Compra";
            this.btnAgregarCompra.UseVisualStyleBackColor = true;
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(490, 140);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(205, 78);
            this.textBox3.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Descripción";
            // 
            // txtNum_factura
            // 
            this.txtNum_factura.Enabled = false;
            this.txtNum_factura.Location = new System.Drawing.Point(22, 198);
            this.txtNum_factura.Name = "txtNum_factura";
            this.txtNum_factura.Size = new System.Drawing.Size(121, 22);
            this.txtNum_factura.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Numero de Factura";
            // 
            // txtid_usuario
            // 
            this.txtid_usuario.Location = new System.Drawing.Point(931, 33);
            this.txtid_usuario.Name = "txtid_usuario";
            this.txtid_usuario.Size = new System.Drawing.Size(26, 22);
            this.txtid_usuario.TabIndex = 0;
            this.txtid_usuario.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tipo de Pago";
            // 
            // txtTipo_Pago
            // 
            this.txtTipo_Pago.Location = new System.Drawing.Point(174, 198);
            this.txtTipo_Pago.Name = "txtTipo_Pago";
            this.txtTipo_Pago.Size = new System.Drawing.Size(121, 22);
            this.txtTipo_Pago.TabIndex = 19;
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 665);
            this.Controls.Add(this.txtTipo_Pago);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtid_usuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNum_factura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnAgregarCompra);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnActualizar_Compra);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.dtpRealización_Compra);
            this.Controls.Add(this.txtid_Compra);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbModelo_Compra);
            this.Controls.Add(this.cbProducto_Compra);
            this.Controls.Add(this.cbCategoría_Compra);
            this.Controls.Add(this.cbProveedor_Compra);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompra";
            this.Text = "frmCompra";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbProveedor_Compra;
        private System.Windows.Forms.ComboBox cbCategoría_Compra;
        private System.Windows.Forms.ComboBox cbProducto_Compra;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ComboBox cbModelo_Compra;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtid_Compra;
        private System.Windows.Forms.DateTimePicker dtpRealización_Compra;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnActualizar_Compra;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAgregarCompra;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNum_factura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtid_usuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTipo_Pago;
    }
}