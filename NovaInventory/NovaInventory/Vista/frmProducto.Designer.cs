namespace NovaInventory.Vista
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
            this.id_proveedor = new System.Windows.Forms.Label();
            this.lblcodigo_producto_seriado = new System.Windows.Forms.Label();
            this.lblproveedores = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblforma_de_pago = new System.Windows.Forms.Label();
            this.id_categoria = new System.Windows.Forms.Label();
            this.txt_codigo_art = new System.Windows.Forms.TextBox();
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.btnAgregar_producto = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btnactualizar_producto = new System.Windows.Forms.Button();
            this.btneliminar_producto = new System.Windows.Forms.Button();
            this.id_articulo = new System.Windows.Forms.TextBox();
            this.cmb_estados = new System.Windows.Forms.ComboBox();
            this.cmb_productos = new System.Windows.Forms.ComboBox();
            this.cmb_proveedor = new System.Windows.Forms.ComboBox();
            this.Cmb_bodegas = new System.Windows.Forms.ComboBox();
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.chkenglish = new System.Windows.Forms.CheckBox();
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
            this.toolStripLabel1.Size = new System.Drawing.Size(67, 24);
            this.toolStripLabel1.Text = "Artículos";
            // 
            // id_proveedor
            // 
            this.id_proveedor.AutoSize = true;
            this.id_proveedor.Location = new System.Drawing.Point(51, 78);
            this.id_proveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.Size = new System.Drawing.Size(89, 17);
            this.id_proveedor.TabIndex = 1;
            this.id_proveedor.Text = "Proveedores";
            this.id_proveedor.Click += new System.EventHandler(this.lblproducto_Click);
            // 
            // lblcodigo_producto_seriado
            // 
            this.lblcodigo_producto_seriado.AutoSize = true;
            this.lblcodigo_producto_seriado.Location = new System.Drawing.Point(485, 129);
            this.lblcodigo_producto_seriado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigo_producto_seriado.Name = "lblcodigo_producto_seriado";
            this.lblcodigo_producto_seriado.Size = new System.Drawing.Size(64, 17);
            this.lblcodigo_producto_seriado.TabIndex = 2;
            this.lblcodigo_producto_seriado.Text = "Bodegas";
            // 
            // lblproveedores
            // 
            this.lblproveedores.AutoSize = true;
            this.lblproveedores.Location = new System.Drawing.Point(444, 197);
            this.lblproveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproveedores.Name = "lblproveedores";
            this.lblproveedores.Size = new System.Drawing.Size(102, 17);
            this.lblproveedores.TabIndex = 3;
            this.lblproveedores.Text = "Codigo articulo";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(492, 74);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(58, 17);
            this.lblfecha.TabIndex = 4;
            this.lblfecha.Text = "estados";
            this.lblfecha.Click += new System.EventHandler(this.lblfecha_Click);
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(77, 255);
            this.lblprecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(61, 17);
            this.lblprecio.TabIndex = 5;
            this.lblprecio.Text = "Modelos";
            this.lblprecio.Click += new System.EventHandler(this.lblprecio_Click);
            // 
            // lblforma_de_pago
            // 
            this.lblforma_de_pago.AutoSize = true;
            this.lblforma_de_pago.Location = new System.Drawing.Point(67, 143);
            this.lblforma_de_pago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblforma_de_pago.Name = "lblforma_de_pago";
            this.lblforma_de_pago.Size = new System.Drawing.Size(72, 17);
            this.lblforma_de_pago.TabIndex = 6;
            this.lblforma_de_pago.Text = "Productos";
            // 
            // id_categoria
            // 
            this.id_categoria.AutoSize = true;
            this.id_categoria.Location = new System.Drawing.Point(71, 197);
            this.id_categoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.Size = new System.Drawing.Size(69, 17);
            this.id_categoria.TabIndex = 7;
            this.id_categoria.Text = "Categoria";
            // 
            // txt_codigo_art
            // 
            this.txt_codigo_art.Location = new System.Drawing.Point(557, 193);
            this.txt_codigo_art.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo_art.Name = "txt_codigo_art";
            this.txt_codigo_art.Size = new System.Drawing.Size(227, 22);
            this.txt_codigo_art.TabIndex = 3;
            // 
            // dgvproducto
            // 
            this.dgvproducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Location = new System.Drawing.Point(16, 373);
            this.dgvproducto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.Size = new System.Drawing.Size(969, 214);
            this.dgvproducto.TabIndex = 15;
            this.dgvproducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproducto_CellClick);
            this.dgvproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproducto_CellContentClick);
            // 
            // btnAgregar_producto
            // 
            this.btnAgregar_producto.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar_producto.Location = new System.Drawing.Point(829, 66);
            this.btnAgregar_producto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar_producto.Name = "btnAgregar_producto";
            this.btnAgregar_producto.Size = new System.Drawing.Size(145, 38);
            this.btnAgregar_producto.TabIndex = 7;
            this.btnAgregar_producto.Text = "Agregar Artículo";
            this.btnAgregar_producto.UseVisualStyleBackColor = false;
            this.btnAgregar_producto.Click += new System.EventHandler(this.btnAgregar_producto_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_mostrar.Location = new System.Drawing.Point(829, 129);
            this.btn_mostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(145, 30);
            this.btn_mostrar.TabIndex = 8;
            this.btn_mostrar.Text = "Mostrar Artículo";
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btnactualizar_producto
            // 
            this.btnactualizar_producto.BackColor = System.Drawing.SystemColors.Control;
            this.btnactualizar_producto.Location = new System.Drawing.Point(829, 178);
            this.btnactualizar_producto.Margin = new System.Windows.Forms.Padding(4);
            this.btnactualizar_producto.Name = "btnactualizar_producto";
            this.btnactualizar_producto.Size = new System.Drawing.Size(147, 33);
            this.btnactualizar_producto.TabIndex = 9;
            this.btnactualizar_producto.Text = "Actualizar Articulo";
            this.btnactualizar_producto.UseVisualStyleBackColor = false;
            this.btnactualizar_producto.Click += new System.EventHandler(this.btnactualizar_producto_Click);
            // 
            // btneliminar_producto
            // 
            this.btneliminar_producto.BackColor = System.Drawing.SystemColors.Control;
            this.btneliminar_producto.Location = new System.Drawing.Point(829, 240);
            this.btneliminar_producto.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar_producto.Name = "btneliminar_producto";
            this.btneliminar_producto.Size = new System.Drawing.Size(145, 36);
            this.btneliminar_producto.TabIndex = 10;
            this.btneliminar_producto.Text = "Eliminar Articulo";
            this.btneliminar_producto.UseVisualStyleBackColor = false;
            this.btneliminar_producto.Click += new System.EventHandler(this.btneliminar_producto_Click);
            // 
            // id_articulo
            // 
            this.id_articulo.Location = new System.Drawing.Point(116, 9);
            this.id_articulo.Margin = new System.Windows.Forms.Padding(4);
            this.id_articulo.Name = "id_articulo";
            this.id_articulo.Size = new System.Drawing.Size(89, 22);
            this.id_articulo.TabIndex = 21;
            this.id_articulo.Visible = false;
            // 
            // cmb_estados
            // 
            this.cmb_estados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estados.FormattingEnabled = true;
            this.cmb_estados.Location = new System.Drawing.Point(557, 66);
            this.cmb_estados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_estados.Name = "cmb_estados";
            this.cmb_estados.Size = new System.Drawing.Size(227, 24);
            this.cmb_estados.TabIndex = 4;
            // 
            // cmb_productos
            // 
            this.cmb_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_productos.FormattingEnabled = true;
            this.cmb_productos.Location = new System.Drawing.Point(173, 133);
            this.cmb_productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_productos.Name = "cmb_productos";
            this.cmb_productos.Size = new System.Drawing.Size(227, 24);
            this.cmb_productos.TabIndex = 6;
            this.cmb_productos.SelectedIndexChanged += new System.EventHandler(this.combxforma_de_pago_SelectedIndexChanged);
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Location = new System.Drawing.Point(173, 74);
            this.cmb_proveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Size = new System.Drawing.Size(227, 24);
            this.cmb_proveedor.TabIndex = 1;
            // 
            // Cmb_bodegas
            // 
            this.Cmb_bodegas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_bodegas.FormattingEnabled = true;
            this.Cmb_bodegas.Location = new System.Drawing.Point(557, 126);
            this.Cmb_bodegas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_bodegas.Name = "Cmb_bodegas";
            this.Cmb_bodegas.Size = new System.Drawing.Size(227, 24);
            this.Cmb_bodegas.TabIndex = 22;
            // 
            // txt_serie
            // 
            this.txt_serie.Location = new System.Drawing.Point(460, 310);
            this.txt_serie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(227, 22);
            this.txt_serie.TabIndex = 23;
            this.txt_serie.TabStop = false;
            this.txt_serie.TextChanged += new System.EventHandler(this.txt_serie_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 314);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Seriado";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(557, 255);
            this.txt_marca.Margin = new System.Windows.Forms.Padding(4);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(227, 22);
            this.txt_marca.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Marca";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 250);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 24);
            this.comboBox1.TabIndex = 27;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(173, 187);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(227, 24);
            this.comboBox2.TabIndex = 28;
            // 
            // chkenglish
            // 
            this.chkenglish.AutoSize = true;
            this.chkenglish.Location = new System.Drawing.Point(835, 12);
            this.chkenglish.Name = "chkenglish";
            this.chkenglish.Size = new System.Drawing.Size(144, 21);
            this.chkenglish.TabIndex = 29;
            this.chkenglish.Text = "English Language";
            this.chkenglish.UseVisualStyleBackColor = true;
            this.chkenglish.CheckedChanged += new System.EventHandler(this.chkenglish_CheckedChanged);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 617);
            this.Controls.Add(this.chkenglish);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_serie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_bodegas);
            this.Controls.Add(this.cmb_proveedor);
            this.Controls.Add(this.cmb_productos);
            this.Controls.Add(this.cmb_estados);
            this.Controls.Add(this.id_articulo);
            this.Controls.Add(this.btneliminar_producto);
            this.Controls.Add(this.btnactualizar_producto);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btnAgregar_producto);
            this.Controls.Add(this.dgvproducto);
            this.Controls.Add(this.txt_codigo_art);
            this.Controls.Add(this.id_categoria);
            this.Controls.Add(this.lblforma_de_pago);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblproveedores);
            this.Controls.Add(this.lblcodigo_producto_seriado);
            this.Controls.Add(this.id_proveedor);
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
        private System.Windows.Forms.Label id_proveedor;
        private System.Windows.Forms.Label lblcodigo_producto_seriado;
        private System.Windows.Forms.Label lblproveedores;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblforma_de_pago;
        private System.Windows.Forms.Label id_categoria;
        private System.Windows.Forms.TextBox txt_codigo_art;
        private System.Windows.Forms.DataGridView dgvproducto;
        private System.Windows.Forms.Button btnAgregar_producto;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btnactualizar_producto;
        private System.Windows.Forms.Button btneliminar_producto;
        private System.Windows.Forms.TextBox id_articulo;
        private System.Windows.Forms.ComboBox cmb_estados;
        private System.Windows.Forms.ComboBox cmb_productos;
        private System.Windows.Forms.ComboBox cmb_proveedor;
        private System.Windows.Forms.ComboBox Cmb_bodegas;
        private System.Windows.Forms.TextBox txt_serie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox chkenglish;
    }
}