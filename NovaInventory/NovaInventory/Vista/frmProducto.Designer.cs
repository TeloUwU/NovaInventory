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
            this.toolStrip1.Size = new System.Drawing.Size(767, 27);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 24);
            this.toolStripLabel1.Text = "Artículos";
            // 
            // id_proveedor
            // 
            this.id_proveedor.AutoSize = true;
            this.id_proveedor.Location = new System.Drawing.Point(38, 63);
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.Size = new System.Drawing.Size(67, 13);
            this.id_proveedor.TabIndex = 1;
            this.id_proveedor.Text = "Proveedores";
            this.id_proveedor.Click += new System.EventHandler(this.lblproducto_Click);
            // 
            // lblcodigo_producto_seriado
            // 
            this.lblcodigo_producto_seriado.AutoSize = true;
            this.lblcodigo_producto_seriado.Location = new System.Drawing.Point(364, 105);
            this.lblcodigo_producto_seriado.Name = "lblcodigo_producto_seriado";
            this.lblcodigo_producto_seriado.Size = new System.Drawing.Size(49, 13);
            this.lblcodigo_producto_seriado.TabIndex = 2;
            this.lblcodigo_producto_seriado.Text = "Bodegas";
            // 
            // lblproveedores
            // 
            this.lblproveedores.AutoSize = true;
            this.lblproveedores.Location = new System.Drawing.Point(333, 160);
            this.lblproveedores.Name = "lblproveedores";
            this.lblproveedores.Size = new System.Drawing.Size(80, 13);
            this.lblproveedores.TabIndex = 3;
            this.lblproveedores.Text = "Codigo_articulo";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(369, 60);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(44, 13);
            this.lblfecha.TabIndex = 4;
            this.lblfecha.Text = "estados";
            this.lblfecha.Click += new System.EventHandler(this.lblfecha_Click);
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(58, 207);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(47, 13);
            this.lblprecio.TabIndex = 5;
            this.lblprecio.Text = "Modelos";
            this.lblprecio.Click += new System.EventHandler(this.lblprecio_Click);
            // 
            // lblforma_de_pago
            // 
            this.lblforma_de_pago.AutoSize = true;
            this.lblforma_de_pago.Location = new System.Drawing.Point(50, 116);
            this.lblforma_de_pago.Name = "lblforma_de_pago";
            this.lblforma_de_pago.Size = new System.Drawing.Size(55, 13);
            this.lblforma_de_pago.TabIndex = 6;
            this.lblforma_de_pago.Text = "Productos";
            // 
            // id_categoria
            // 
            this.id_categoria.AutoSize = true;
            this.id_categoria.Location = new System.Drawing.Point(53, 160);
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.Size = new System.Drawing.Size(52, 13);
            this.id_categoria.TabIndex = 7;
            this.id_categoria.Text = "Categoria";
            // 
            // txt_codigo_art
            // 
            this.txt_codigo_art.Location = new System.Drawing.Point(418, 157);
            this.txt_codigo_art.Name = "txt_codigo_art";
            this.txt_codigo_art.Size = new System.Drawing.Size(171, 20);
            this.txt_codigo_art.TabIndex = 3;
            // 
            // dgvproducto
            // 
            this.dgvproducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Location = new System.Drawing.Point(12, 303);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.Size = new System.Drawing.Size(727, 174);
            this.dgvproducto.TabIndex = 15;
            this.dgvproducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproducto_CellClick);
            this.dgvproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproducto_CellContentClick);
            // 
            // btnAgregar_producto
            // 
            this.btnAgregar_producto.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar_producto.Location = new System.Drawing.Point(622, 54);
            this.btnAgregar_producto.Name = "btnAgregar_producto";
            this.btnAgregar_producto.Size = new System.Drawing.Size(109, 31);
            this.btnAgregar_producto.TabIndex = 7;
            this.btnAgregar_producto.Text = "Agregar Artículo";
            this.btnAgregar_producto.UseVisualStyleBackColor = false;
            this.btnAgregar_producto.Click += new System.EventHandler(this.btnAgregar_producto_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_mostrar.Location = new System.Drawing.Point(622, 105);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(109, 24);
            this.btn_mostrar.TabIndex = 8;
            this.btn_mostrar.Text = "Mostrar Artículo";
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btnactualizar_producto
            // 
            this.btnactualizar_producto.BackColor = System.Drawing.SystemColors.Control;
            this.btnactualizar_producto.Location = new System.Drawing.Point(622, 145);
            this.btnactualizar_producto.Name = "btnactualizar_producto";
            this.btnactualizar_producto.Size = new System.Drawing.Size(110, 27);
            this.btnactualizar_producto.TabIndex = 9;
            this.btnactualizar_producto.Text = "Actualizar Articulo";
            this.btnactualizar_producto.UseVisualStyleBackColor = false;
            this.btnactualizar_producto.Click += new System.EventHandler(this.btnactualizar_producto_Click);
            // 
            // btneliminar_producto
            // 
            this.btneliminar_producto.BackColor = System.Drawing.SystemColors.Control;
            this.btneliminar_producto.Location = new System.Drawing.Point(622, 195);
            this.btneliminar_producto.Name = "btneliminar_producto";
            this.btneliminar_producto.Size = new System.Drawing.Size(109, 29);
            this.btneliminar_producto.TabIndex = 10;
            this.btneliminar_producto.Text = "Eliminar Articulo";
            this.btneliminar_producto.UseVisualStyleBackColor = false;
            this.btneliminar_producto.Click += new System.EventHandler(this.btneliminar_producto_Click);
            // 
            // id_articulo
            // 
            this.id_articulo.Location = new System.Drawing.Point(87, 7);
            this.id_articulo.Name = "id_articulo";
            this.id_articulo.Size = new System.Drawing.Size(68, 20);
            this.id_articulo.TabIndex = 21;
            this.id_articulo.Visible = false;
            // 
            // cmb_estados
            // 
            this.cmb_estados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estados.FormattingEnabled = true;
            this.cmb_estados.Location = new System.Drawing.Point(418, 54);
            this.cmb_estados.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_estados.Name = "cmb_estados";
            this.cmb_estados.Size = new System.Drawing.Size(171, 21);
            this.cmb_estados.TabIndex = 4;
            //this.cmb_estados.SelectedIndexChanged += new System.EventHandler(this.combxmarca_SelectedIndexChanged);
            // 
            // cmb_productos
            // 
            this.cmb_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_productos.FormattingEnabled = true;
            this.cmb_productos.Location = new System.Drawing.Point(130, 108);
            this.cmb_productos.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_productos.Name = "cmb_productos";
            this.cmb_productos.Size = new System.Drawing.Size(171, 21);
            this.cmb_productos.TabIndex = 6;
            this.cmb_productos.SelectedIndexChanged += new System.EventHandler(this.combxforma_de_pago_SelectedIndexChanged);
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Location = new System.Drawing.Point(130, 60);
            this.cmb_proveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Size = new System.Drawing.Size(171, 21);
            this.cmb_proveedor.TabIndex = 1;
            //this.cmb_proveedor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Cmb_bodegas
            // 
            this.Cmb_bodegas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_bodegas.FormattingEnabled = true;
            this.Cmb_bodegas.Location = new System.Drawing.Point(418, 102);
            this.Cmb_bodegas.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_bodegas.Name = "Cmb_bodegas";
            this.Cmb_bodegas.Size = new System.Drawing.Size(171, 21);
            this.Cmb_bodegas.TabIndex = 22;
            // 
            // txt_serie
            // 
            this.txt_serie.Location = new System.Drawing.Point(345, 252);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(171, 20);
            this.txt_serie.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Seriado";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(418, 207);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(171, 20);
            this.txt_marca.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Marca";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 203);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(130, 152);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 21);
            this.comboBox2.TabIndex = 28;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 501);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}