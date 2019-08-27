namespace NovaInventory.Vista
{
    partial class FrmPrincipal
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.PanelSidebar = new System.Windows.Forms.Panel();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNombres_Usuario = new System.Windows.Forms.Label();
            this.lblApellidos_Usuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodosLosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDeNavegaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosYReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCatalogoDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar_Principal = new System.Windows.Forms.ToolStripButton();
            this.btnMaximizar_Principal = new System.Windows.Forms.ToolStripButton();
            this.btnVentana_Principal = new System.Windows.Forms.ToolStripButton();
            this.btnMinimizar_Principal = new System.Windows.Forms.ToolStripButton();
            this.button7 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.PanelSidebar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnCerrar_Principal,
            this.btnMaximizar_Principal,
            this.btnVentana_Principal,
            this.btnMinimizar_Principal});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1280, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 24);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.PanelContenedor);
            this.panelMain.Controls.Add(this.PanelSidebar);
            this.panelMain.Controls.Add(this.menuStrip1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1280, 693);
            this.panelMain.TabIndex = 2;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Controls.Add(this.pictureBox2);
            this.PanelContenedor.Controls.Add(this.lblNombres_Usuario);
            this.PanelContenedor.Controls.Add(this.lblApellidos_Usuario);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(236, 24);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1044, 669);
            this.PanelContenedor.TabIndex = 2;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint_1);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(0, 253);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(236, 36);
            this.button10.TabIndex = 12;
            this.button10.Text = "Artículos";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(0, 465);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(236, 36);
            this.button9.TabIndex = 11;
            this.button9.Text = "Proveedor";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 361);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(236, 36);
            this.button8.TabIndex = 10;
            this.button8.Text = "Bodega";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ver Kardex";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Compras";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ventas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "Ver Existencias";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 568);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(236, 36);
            this.button6.TabIndex = 9;
            this.button6.Text = "Configuración Usuario Root";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 516);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 36);
            this.button5.TabIndex = 8;
            this.button5.Text = "Administración de Empresas";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // PanelSidebar
            // 
            this.PanelSidebar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelSidebar.Controls.Add(this.button7);
            this.PanelSidebar.Controls.Add(this.button6);
            this.PanelSidebar.Controls.Add(this.button9);
            this.PanelSidebar.Controls.Add(this.button5);
            this.PanelSidebar.Controls.Add(this.button10);
            this.PanelSidebar.Controls.Add(this.button8);
            this.PanelSidebar.Controls.Add(this.lblNivel);
            this.PanelSidebar.Controls.Add(this.button1);
            this.PanelSidebar.Controls.Add(this.button4);
            this.PanelSidebar.Controls.Add(this.lblEstado);
            this.PanelSidebar.Controls.Add(this.pictureBox1);
            this.PanelSidebar.Controls.Add(this.button2);
            this.PanelSidebar.Controls.Add(this.button3);
            this.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSidebar.Location = new System.Drawing.Point(0, 24);
            this.PanelSidebar.Name = "PanelSidebar";
            this.PanelSidebar.Size = new System.Drawing.Size(236, 669);
            this.PanelSidebar.TabIndex = 1;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(146, 41);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(42, 17);
            this.lblNivel.TabIndex = 14;
            this.lblNivel.Text = "label2";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(146, 98);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 17);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "En Línea";
            // 
            // lblNombres_Usuario
            // 
            this.lblNombres_Usuario.AutoSize = true;
            this.lblNombres_Usuario.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres_Usuario.Location = new System.Drawing.Point(201, 110);
            this.lblNombres_Usuario.Name = "lblNombres_Usuario";
            this.lblNombres_Usuario.Size = new System.Drawing.Size(87, 32);
            this.lblNombres_Usuario.TabIndex = 1;
            this.lblNombres_Usuario.Text = "label1";
            this.lblNombres_Usuario.Click += new System.EventHandler(this.lblNombres_Usuario_Click);
            // 
            // lblApellidos_Usuario
            // 
            this.lblApellidos_Usuario.AutoSize = true;
            this.lblApellidos_Usuario.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos_Usuario.Location = new System.Drawing.Point(201, 154);
            this.lblApellidos_Usuario.Name = "lblApellidos_Usuario";
            this.lblApellidos_Usuario.Size = new System.Drawing.Size(87, 32);
            this.lblApellidos_Usuario.TabIndex = 2;
            this.lblApellidos_Usuario.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.verToolStripMenuItem,
            this.gráficosYReportesToolStripMenuItem,
            this.facturaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem1,
            this.agregarProductoToolStripMenuItem,
            this.agregarProveedorToolStripMenuItem});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.buscarToolStripMenuItem.Text = "Editar";
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.proveedorToolStripMenuItem});
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.buscarToolStripMenuItem1.Text = "Buscar";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            // 
            // agregarProveedorToolStripMenuItem
            // 
            this.agregarProveedorToolStripMenuItem.Name = "agregarProveedorToolStripMenuItem";
            this.agregarProveedorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.agregarProveedorToolStripMenuItem.Text = "Agregar Proveedor";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioGeneralToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // inventarioGeneralToolStripMenuItem
            // 
            this.inventarioGeneralToolStripMenuItem.Name = "inventarioGeneralToolStripMenuItem";
            this.inventarioGeneralToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.inventarioGeneralToolStripMenuItem.Text = "Inventario General";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlDeUsuariosToolStripMenuItem,
            this.controlDeProductosToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // controlDeUsuariosToolStripMenuItem
            // 
            this.controlDeUsuariosToolStripMenuItem.Name = "controlDeUsuariosToolStripMenuItem";
            this.controlDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.controlDeUsuariosToolStripMenuItem.Text = "Control de usuarios";
            // 
            // controlDeProductosToolStripMenuItem
            // 
            this.controlDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoProductoToolStripMenuItem,
            this.mostrarTodosLosProductosToolStripMenuItem});
            this.controlDeProductosToolStripMenuItem.Name = "controlDeProductosToolStripMenuItem";
            this.controlDeProductosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.controlDeProductosToolStripMenuItem.Text = "Productos";
            // 
            // ingresarNuevoProductoToolStripMenuItem
            // 
            this.ingresarNuevoProductoToolStripMenuItem.Name = "ingresarNuevoProductoToolStripMenuItem";
            this.ingresarNuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ingresarNuevoProductoToolStripMenuItem.Text = "Ingresar nuevo producto";
            // 
            // mostrarTodosLosProductosToolStripMenuItem
            // 
            this.mostrarTodosLosProductosToolStripMenuItem.Name = "mostrarTodosLosProductosToolStripMenuItem";
            this.mostrarTodosLosProductosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.mostrarTodosLosProductosToolStripMenuItem.Text = "Mostrar Inventario";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelDeNavegaciónToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // panelDeNavegaciónToolStripMenuItem
            // 
            this.panelDeNavegaciónToolStripMenuItem.Name = "panelDeNavegaciónToolStripMenuItem";
            this.panelDeNavegaciónToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.panelDeNavegaciónToolStripMenuItem.Text = "Mostar panel de Navegación";
            this.panelDeNavegaciónToolStripMenuItem.Click += new System.EventHandler(this.panelDeNavegaciónToolStripMenuItem_Click);
            // 
            // gráficosYReportesToolStripMenuItem
            // 
            this.gráficosYReportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporesToolStripMenuItem,
            this.gráficosToolStripMenuItem});
            this.gráficosYReportesToolStripMenuItem.Name = "gráficosYReportesToolStripMenuItem";
            this.gráficosYReportesToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gráficosYReportesToolStripMenuItem.Text = "Gráficos y Reportes";
            // 
            // reporesToolStripMenuItem
            // 
            this.reporesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.ventasToolStripMenuItem1});
            this.reporesToolStripMenuItem.Name = "reporesToolStripMenuItem";
            this.reporesToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.reporesToolStripMenuItem.Text = "Repotres";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ventasToolStripMenuItem.Text = "Compras";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // gráficosToolStripMenuItem
            // 
            this.gráficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem2,
            this.ventasToolStripMenuItem3});
            this.gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
            this.gráficosToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.gráficosToolStripMenuItem.Text = "Gráficos";
            // 
            // ventasToolStripMenuItem2
            // 
            this.ventasToolStripMenuItem2.Name = "ventasToolStripMenuItem2";
            this.ventasToolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.ventasToolStripMenuItem2.Text = "Compras";
            // 
            // ventasToolStripMenuItem3
            // 
            this.ventasToolStripMenuItem3.Name = "ventasToolStripMenuItem3";
            this.ventasToolStripMenuItem3.Size = new System.Drawing.Size(122, 22);
            this.ventasToolStripMenuItem3.Text = "Ventas";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCatalogoDeFacturasToolStripMenuItem,
            this.nuevaVentaToolStripMenuItem,
            this.nuevaCompraToolStripMenuItem});
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // verCatalogoDeFacturasToolStripMenuItem
            // 
            this.verCatalogoDeFacturasToolStripMenuItem.Name = "verCatalogoDeFacturasToolStripMenuItem";
            this.verCatalogoDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.verCatalogoDeFacturasToolStripMenuItem.Text = "Ver catalogo de facturas";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // nuevaCompraToolStripMenuItem
            // 
            this.nuevaCompraToolStripMenuItem.Name = "nuevaCompraToolStripMenuItem";
            this.nuevaCompraToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.nuevaCompraToolStripMenuItem.Text = "Nueva Compra";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NovaInventory.Properties.Resources.round_account_button_with_user_inside1;
            this.pictureBox2.Location = new System.Drawing.Point(318, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NovaInventory.Properties.Resources.framed_portrait;
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar_Principal
            // 
            this.btnCerrar_Principal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrar_Principal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrar_Principal.Image = global::NovaInventory.Properties.Resources.close_window_80px;
            this.btnCerrar_Principal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar_Principal.Name = "btnCerrar_Principal";
            this.btnCerrar_Principal.Size = new System.Drawing.Size(24, 24);
            this.btnCerrar_Principal.Text = "Salir";
            this.btnCerrar_Principal.Click += new System.EventHandler(this.btnCerrar_Principal_Click);
            // 
            // btnMaximizar_Principal
            // 
            this.btnMaximizar_Principal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMaximizar_Principal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMaximizar_Principal.Image = global::NovaInventory.Properties.Resources.maximize_window_26px;
            this.btnMaximizar_Principal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMaximizar_Principal.Name = "btnMaximizar_Principal";
            this.btnMaximizar_Principal.Size = new System.Drawing.Size(24, 24);
            this.btnMaximizar_Principal.Text = "Maximizar";
            this.btnMaximizar_Principal.Click += new System.EventHandler(this.btnMaximizar_Principal_Click);
            // 
            // btnVentana_Principal
            // 
            this.btnVentana_Principal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnVentana_Principal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVentana_Principal.Image = global::NovaInventory.Properties.Resources.restore_window_26px;
            this.btnVentana_Principal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVentana_Principal.Name = "btnVentana_Principal";
            this.btnVentana_Principal.Size = new System.Drawing.Size(24, 24);
            this.btnVentana_Principal.Text = "Restaurar a tamaño normal";
            this.btnVentana_Principal.Visible = false;
            this.btnVentana_Principal.Click += new System.EventHandler(this.btnVentana_Principal_Click);
            // 
            // btnMinimizar_Principal
            // 
            this.btnMinimizar_Principal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMinimizar_Principal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMinimizar_Principal.Image = global::NovaInventory.Properties.Resources.minimize_window_26px;
            this.btnMinimizar_Principal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMinimizar_Principal.Name = "btnMinimizar_Principal";
            this.btnMinimizar_Principal.Size = new System.Drawing.Size(24, 24);
            this.btnMinimizar_Principal.Text = "Minimizar";
            this.btnMinimizar_Principal.Click += new System.EventHandler(this.btnMinimizar_Principal_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 621);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(236, 36);
            this.button7.TabIndex = 15;
            this.button7.Text = "Generar Factura";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            this.PanelSidebar.ResumeLayout(false);
            this.PanelSidebar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel PanelSidebar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelDeNavegaciónToolStripMenuItem;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.ToolStripButton btnCerrar_Principal;
        private System.Windows.Forms.ToolStripButton btnMaximizar_Principal;
        private System.Windows.Forms.ToolStripButton btnVentana_Principal;
        private System.Windows.Forms.ToolStripButton btnMinimizar_Principal;
        private System.Windows.Forms.ToolStripMenuItem gráficosYReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodosLosProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCatalogoDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNombres_Usuario;
        private System.Windows.Forms.Label lblApellidos_Usuario;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCompraToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button7;
    }
}