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
            this.PanelSidebar = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ingresarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioPorBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
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
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(236, 28);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1044, 665);
            this.PanelContenedor.TabIndex = 2;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // PanelSidebar
            // 
            this.PanelSidebar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSidebar.Location = new System.Drawing.Point(0, 28);
            this.PanelSidebar.Name = "PanelSidebar";
            this.PanelSidebar.Size = new System.Drawing.Size(236, 665);
            this.PanelSidebar.TabIndex = 1;
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
            this.menuStrip1.Size = new System.Drawing.Size(1280, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem1});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.buscarToolStripMenuItem.Text = "Editar";
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.bodegaToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(127, 26);
            this.buscarToolStripMenuItem1.Text = "Buscar";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.facturaToolStripMenuItem.Text = "Factura";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioGeneralToolStripMenuItem,
            this.inventarioPorBodegaToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // inventarioGeneralToolStripMenuItem
            // 
            this.inventarioGeneralToolStripMenuItem.Name = "inventarioGeneralToolStripMenuItem";
            this.inventarioGeneralToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.inventarioGeneralToolStripMenuItem.Text = "Inventario General";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlDeUsuariosToolStripMenuItem,
            this.controlDeProductosToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // controlDeUsuariosToolStripMenuItem
            // 
            this.controlDeUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarUsuarioToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem});
            this.controlDeUsuariosToolStripMenuItem.Name = "controlDeUsuariosToolStripMenuItem";
            this.controlDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.controlDeUsuariosToolStripMenuItem.Text = "Control de usuarios";
            // 
            // controlDeProductosToolStripMenuItem
            // 
            this.controlDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoProductoToolStripMenuItem,
            this.mostrarTodosLosProductosToolStripMenuItem});
            this.controlDeProductosToolStripMenuItem.Name = "controlDeProductosToolStripMenuItem";
            this.controlDeProductosToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.controlDeProductosToolStripMenuItem.Text = "Productos";
            // 
            // ingresarNuevoProductoToolStripMenuItem
            // 
            this.ingresarNuevoProductoToolStripMenuItem.Name = "ingresarNuevoProductoToolStripMenuItem";
            this.ingresarNuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.ingresarNuevoProductoToolStripMenuItem.Text = "Ingresar nuevo producto";
            // 
            // mostrarTodosLosProductosToolStripMenuItem
            // 
            this.mostrarTodosLosProductosToolStripMenuItem.Name = "mostrarTodosLosProductosToolStripMenuItem";
            this.mostrarTodosLosProductosToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.mostrarTodosLosProductosToolStripMenuItem.Text = "Mostrar Inventario";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelDeNavegaciónToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // panelDeNavegaciónToolStripMenuItem
            // 
            this.panelDeNavegaciónToolStripMenuItem.Name = "panelDeNavegaciónToolStripMenuItem";
            this.panelDeNavegaciónToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.panelDeNavegaciónToolStripMenuItem.Text = "Mostar panel de Navegación";
            this.panelDeNavegaciónToolStripMenuItem.Click += new System.EventHandler(this.panelDeNavegaciónToolStripMenuItem_Click);
            // 
            // gráficosYReportesToolStripMenuItem
            // 
            this.gráficosYReportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporesToolStripMenuItem,
            this.gráficosToolStripMenuItem});
            this.gráficosYReportesToolStripMenuItem.Name = "gráficosYReportesToolStripMenuItem";
            this.gráficosYReportesToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.gráficosYReportesToolStripMenuItem.Text = "Gráficos y Reportes";
            // 
            // reporesToolStripMenuItem
            // 
            this.reporesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.ventasToolStripMenuItem1});
            this.reporesToolStripMenuItem.Name = "reporesToolStripMenuItem";
            this.reporesToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.reporesToolStripMenuItem.Text = "Repotres";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.ventasToolStripMenuItem.Text = "Compras";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(143, 26);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // gráficosToolStripMenuItem
            // 
            this.gráficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem2,
            this.ventasToolStripMenuItem3});
            this.gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
            this.gráficosToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.gráficosToolStripMenuItem.Text = "Gráficos";
            // 
            // ventasToolStripMenuItem2
            // 
            this.ventasToolStripMenuItem2.Name = "ventasToolStripMenuItem2";
            this.ventasToolStripMenuItem2.Size = new System.Drawing.Size(143, 26);
            this.ventasToolStripMenuItem2.Text = "Compras";
            // 
            // ventasToolStripMenuItem3
            // 
            this.ventasToolStripMenuItem3.Name = "ventasToolStripMenuItem3";
            this.ventasToolStripMenuItem3.Size = new System.Drawing.Size(143, 26);
            this.ventasToolStripMenuItem3.Text = "Ventas";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCatalogoDeFacturasToolStripMenuItem,
            this.nuevaVentaToolStripMenuItem,
            this.nuevaCompraToolStripMenuItem});
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // verCatalogoDeFacturasToolStripMenuItem
            // 
            this.verCatalogoDeFacturasToolStripMenuItem.Name = "verCatalogoDeFacturasToolStripMenuItem";
            this.verCatalogoDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.verCatalogoDeFacturasToolStripMenuItem.Text = "Ver catalogo de facturas";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            // 
            // nuevaCompraToolStripMenuItem
            // 
            this.nuevaCompraToolStripMenuItem.Name = "nuevaCompraToolStripMenuItem";
            this.nuevaCompraToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.nuevaCompraToolStripMenuItem.Text = "Nueva Compra";
            // 
            // ingresarUsuarioToolStripMenuItem
            // 
            this.ingresarUsuarioToolStripMenuItem.Name = "ingresarUsuarioToolStripMenuItem";
            this.ingresarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.ingresarUsuarioToolStripMenuItem.Text = "Ingresar Usuarios";
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar Usuarios";
            // 
            // inventarioPorBodegaToolStripMenuItem
            // 
            this.inventarioPorBodegaToolStripMenuItem.Name = "inventarioPorBodegaToolStripMenuItem";
            this.inventarioPorBodegaToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.inventarioPorBodegaToolStripMenuItem.Text = "Inventario por Bodega";
            // 
            // bodegaToolStripMenuItem
            // 
            this.bodegaToolStripMenuItem.Name = "bodegaToolStripMenuItem";
            this.bodegaToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.bodegaToolStripMenuItem.Text = "Bodega";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::NovaInventory.Properties.Resources.close_window_80px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::NovaInventory.Properties.Resources.maximize_window_26px;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "Maximizar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::NovaInventory.Properties.Resources.restore_window_26px;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "Restaurar a tamaño normal";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::NovaInventory.Properties.Resources.minimize_window_26px;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "Minimizar";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
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
        private System.Windows.Forms.ToolStripMenuItem bodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioPorBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCompraToolStripMenuItem;
    }
}