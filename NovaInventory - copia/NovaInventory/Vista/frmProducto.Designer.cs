﻿namespace NovaInventory.Vista
{
    partial class frmProducto
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblproducto = new System.Windows.Forms.Label();
            this.lblcodigo_producto_seriado = new System.Windows.Forms.Label();
            this.lblproveedores = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblforma_de_pago = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.txtcodigo_producto = new System.Windows.Forms.TextBox();
            this.txtproveedores = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.btnAgregar_producto = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btnactualizar_producto = new System.Windows.Forms.Button();
            this.btneliminar_producto = new System.Windows.Forms.Button();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.id_producto = new System.Windows.Forms.TextBox();
            this.combxmarca = new System.Windows.Forms.ComboBox();
            this.combxforma_de_pago = new System.Windows.Forms.ComboBox();
            this.combx_producto = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1023, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::NovaInventory.Properties.Resources.cancel_button;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(75, 24);
            this.toolStripLabel1.Text = "Productos";
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Location = new System.Drawing.Point(51, 76);
            this.lblproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(65, 17);
            this.lblproducto.TabIndex = 1;
            this.lblproducto.Text = "Producto";
            this.lblproducto.Click += new System.EventHandler(this.lblproducto_Click);
            // 
            // lblcodigo_producto_seriado
            // 
            this.lblcodigo_producto_seriado.AutoSize = true;
            this.lblcodigo_producto_seriado.Location = new System.Drawing.Point(51, 150);
            this.lblcodigo_producto_seriado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigo_producto_seriado.Name = "lblcodigo_producto_seriado";
            this.lblcodigo_producto_seriado.Size = new System.Drawing.Size(113, 17);
            this.lblcodigo_producto_seriado.TabIndex = 2;
            this.lblcodigo_producto_seriado.Text = "Codigo Producto";
            // 
            // lblproveedores
            // 
            this.lblproveedores.AutoSize = true;
            this.lblproveedores.Location = new System.Drawing.Point(51, 217);
            this.lblproveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproveedores.Name = "lblproveedores";
            this.lblproveedores.Size = new System.Drawing.Size(89, 17);
            this.lblproveedores.TabIndex = 3;
            this.lblproveedores.Text = "Proveedores";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(425, 76);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(47, 17);
            this.lblfecha.TabIndex = 4;
            this.lblfecha.Text = "Fecha";
            this.lblfecha.Click += new System.EventHandler(this.lblfecha_Click);
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(425, 150);
            this.lblprecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(48, 17);
            this.lblprecio.TabIndex = 5;
            this.lblprecio.Text = "Precio";
            this.lblprecio.Click += new System.EventHandler(this.lblprecio_Click);
            // 
            // lblforma_de_pago
            // 
            this.lblforma_de_pago.AutoSize = true;
            this.lblforma_de_pago.Location = new System.Drawing.Point(425, 220);
            this.lblforma_de_pago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblforma_de_pago.Name = "lblforma_de_pago";
            this.lblforma_de_pago.Size = new System.Drawing.Size(105, 17);
            this.lblforma_de_pago.TabIndex = 6;
            this.lblforma_de_pago.Text = "Forma de Pago";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(71, 293);
            this.lblcategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(47, 17);
            this.lblcategoria.TabIndex = 7;
            this.lblcategoria.Text = "Marca";
            // 
            // txtcodigo_producto
            // 
            this.txtcodigo_producto.Location = new System.Drawing.Point(173, 146);
            this.txtcodigo_producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigo_producto.Name = "txtcodigo_producto";
            this.txtcodigo_producto.Size = new System.Drawing.Size(227, 22);
            this.txtcodigo_producto.TabIndex = 2;
            // 
            // txtproveedores
            // 
            this.txtproveedores.Location = new System.Drawing.Point(173, 220);
            this.txtproveedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtproveedores.Name = "txtproveedores";
            this.txtproveedores.Size = new System.Drawing.Size(227, 22);
            this.txtproveedores.TabIndex = 3;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(539, 146);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(244, 22);
            this.txt_precio.TabIndex = 5;
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            // 
            // dgvproducto
            // 
            this.dgvproducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Location = new System.Drawing.Point(16, 347);
            this.dgvproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.Size = new System.Drawing.Size(969, 240);
            this.dgvproducto.TabIndex = 15;
            this.dgvproducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproducto_CellClick);
            this.dgvproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproducto_CellContentClick);
            // 
            // btnAgregar_producto
            // 
            this.btnAgregar_producto.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar_producto.Location = new System.Drawing.Point(829, 66);
            this.btnAgregar_producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar_producto.Name = "btnAgregar_producto";
            this.btnAgregar_producto.Size = new System.Drawing.Size(145, 38);
            this.btnAgregar_producto.TabIndex = 7;
            this.btnAgregar_producto.Text = "Agregar Producto";
            this.btnAgregar_producto.UseVisualStyleBackColor = false;
            this.btnAgregar_producto.Click += new System.EventHandler(this.btnAgregar_producto_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_mostrar.Location = new System.Drawing.Point(829, 129);
            this.btn_mostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(145, 30);
            this.btn_mostrar.TabIndex = 8;
            this.btn_mostrar.Text = "Mostrar Producto";
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btnactualizar_producto
            // 
            this.btnactualizar_producto.BackColor = System.Drawing.SystemColors.Control;
            this.btnactualizar_producto.Location = new System.Drawing.Point(829, 178);
            this.btnactualizar_producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnactualizar_producto.Name = "btnactualizar_producto";
            this.btnactualizar_producto.Size = new System.Drawing.Size(147, 33);
            this.btnactualizar_producto.TabIndex = 9;
            this.btnactualizar_producto.Text = "Actualizar Producto";
            this.btnactualizar_producto.UseVisualStyleBackColor = false;
            this.btnactualizar_producto.Click += new System.EventHandler(this.btnactualizar_producto_Click);
            // 
            // btneliminar_producto
            // 
            this.btneliminar_producto.BackColor = System.Drawing.SystemColors.Control;
            this.btneliminar_producto.Location = new System.Drawing.Point(829, 240);
            this.btneliminar_producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneliminar_producto.Name = "btneliminar_producto";
            this.btneliminar_producto.Size = new System.Drawing.Size(145, 36);
            this.btneliminar_producto.TabIndex = 10;
            this.btneliminar_producto.Text = "Eliminar Producto";
            this.btneliminar_producto.UseVisualStyleBackColor = false;
            this.btneliminar_producto.Click += new System.EventHandler(this.btneliminar_producto_Click);
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(537, 69);
            this.dateTimePicker_fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker_fecha.TabIndex = 20;
            this.dateTimePicker_fecha.ValueChanged += new System.EventHandler(this.dateTimePicker_fecha_ValueChanged);
            // 
            // id_producto
            // 
            this.id_producto.Location = new System.Drawing.Point(465, 284);
            this.id_producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_producto.Name = "id_producto";
            this.id_producto.Size = new System.Drawing.Size(89, 22);
            this.id_producto.TabIndex = 21;
            this.id_producto.Visible = false;
            // 
            // combxmarca
            // 
            this.combxmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combxmarca.FormattingEnabled = true;
            this.combxmarca.Location = new System.Drawing.Point(173, 293);
            this.combxmarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combxmarca.Name = "combxmarca";
            this.combxmarca.Size = new System.Drawing.Size(227, 24);
            this.combxmarca.TabIndex = 4;
            this.combxmarca.SelectedIndexChanged += new System.EventHandler(this.combxmarca_SelectedIndexChanged);
            // 
            // combxforma_de_pago
            // 
            this.combxforma_de_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combxforma_de_pago.FormattingEnabled = true;
            this.combxforma_de_pago.Location = new System.Drawing.Point(537, 213);
            this.combxforma_de_pago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combxforma_de_pago.Name = "combxforma_de_pago";
            this.combxforma_de_pago.Size = new System.Drawing.Size(245, 24);
            this.combxforma_de_pago.TabIndex = 6;
            this.combxforma_de_pago.SelectedIndexChanged += new System.EventHandler(this.combxforma_de_pago_SelectedIndexChanged);
            // 
            // combx_producto
            // 
            this.combx_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combx_producto.FormattingEnabled = true;
            this.combx_producto.Location = new System.Drawing.Point(173, 74);
            this.combx_producto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combx_producto.Name = "combx_producto";
            this.combx_producto.Size = new System.Drawing.Size(227, 24);
            this.combx_producto.TabIndex = 1;
            this.combx_producto.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 617);
            this.Controls.Add(this.combx_producto);
            this.Controls.Add(this.combxforma_de_pago);
            this.Controls.Add(this.combxmarca);
            this.Controls.Add(this.id_producto);
            this.Controls.Add(this.dateTimePicker_fecha);
            this.Controls.Add(this.btneliminar_producto);
            this.Controls.Add(this.btnactualizar_producto);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btnAgregar_producto);
            this.Controls.Add(this.dgvproducto);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txtproveedores);
            this.Controls.Add(this.txtcodigo_producto);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lblforma_de_pago);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblproveedores);
            this.Controls.Add(this.lblcodigo_producto_seriado);
            this.Controls.Add(this.lblproducto);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.Label lblcodigo_producto_seriado;
        private System.Windows.Forms.Label lblproveedores;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblforma_de_pago;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.TextBox txtcodigo_producto;
        private System.Windows.Forms.TextBox txtproveedores;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.DataGridView dgvproducto;
        private System.Windows.Forms.Button btnAgregar_producto;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btnactualizar_producto;
        private System.Windows.Forms.Button btneliminar_producto;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
        private System.Windows.Forms.TextBox id_producto;
        private System.Windows.Forms.ComboBox combxmarca;
        private System.Windows.Forms.ComboBox combxforma_de_pago;
        private System.Windows.Forms.ComboBox combx_producto;
    }
}