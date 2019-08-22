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
            this.panelMain = new System.Windows.Forms.Panel();
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
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDeNavegaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.gráficosYReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodosLosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCatalogoDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1280, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.PanelContenedor);
            this.panelMain.Controls.Add(this.PanelSidebar);
            this.panelMain.Controls.Add(this.menuStrip1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1280, 695);
            this.panelMain.TabIndex = 2;
            // 
            // PanelSidebar
            // 
            this.PanelSidebar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSidebar.Location = new System.Drawing.Point(0, 24);
            this.PanelSidebar.Name = "PanelSidebar";
            this.PanelSidebar.Size = new System.Drawing.Size(236, 671);
            this.PanelSidebar.TabIndex = 1;
            // 
            // menuStrip1
            // 
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
            this.buscarToolStripMenuItem1});
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
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
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
            this.mostrarTodosLosProductosToolStripMenuItem,
            this.actualizarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem,
            this.buscarProductoToolStripMenuItem});
            this.controlDeProductosToolStripMenuItem.Name = "controlDeProductosToolStripMenuItem";
            this.controlDeProductosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.controlDeProductosToolStripMenuItem.Text = "Productos";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelDeNavegaciónToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // panelDeNavegaciónToolStripMenuItem
            // 
            this.panelDeNavegaciónToolStripMenuItem.Name = "panelDeNavegaciónToolStripMenuItem";
            this.panelDeNavegaciónToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.panelDeNavegaciónToolStripMenuItem.Text = "Mostar panel de Navegación";
            this.panelDeNavegaciónToolStripMenuItem.Click += new System.EventHandler(this.panelDeNavegaciónToolStripMenuItem_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(236, 24);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1044, 671);
            this.PanelContenedor.TabIndex = 2;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Image = global::NovaInventory.Properties.Resources.sistema;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(107, 22);
            this.toolStripLabel1.Text = "NovaInventory";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::NovaInventory.Properties.Resources.cancel_button;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Salir";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::NovaInventory.Properties.Resources.crop_button;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Maximizar";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::NovaInventory.Properties.Resources.full_screen_exit;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Restaurar a tamaño normal";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::NovaInventory.Properties.Resources.expand_button;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Minimizar";
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
            this.reporesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reporesToolStripMenuItem.Text = "Repotres";
            // 
            // gráficosToolStripMenuItem
            // 
            this.gráficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem2,
            this.ventasToolStripMenuItem3});
            this.gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
            this.gráficosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gráficosToolStripMenuItem.Text = "Gráficos";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ventasToolStripMenuItem.Text = "Compras";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // ventasToolStripMenuItem2
            // 
            this.ventasToolStripMenuItem2.Name = "ventasToolStripMenuItem2";
            this.ventasToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.ventasToolStripMenuItem2.Text = "Compras";
            // 
            // ventasToolStripMenuItem3
            // 
            this.ventasToolStripMenuItem3.Name = "ventasToolStripMenuItem3";
            this.ventasToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.ventasToolStripMenuItem3.Text = "Ventas";
            // 
            // ingresarNuevoProductoToolStripMenuItem
            // 
            this.ingresarNuevoProductoToolStripMenuItem.Name = "ingresarNuevoProductoToolStripMenuItem";
            this.ingresarNuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ingresarNuevoProductoToolStripMenuItem.Text = "Ingresar nuevo producto";
            // 
            // mostrarTodosLosProductosToolStripMenuItem
            // 
            this.mostrarTodosLosProductosToolStripMenuItem.Name = "mostrarTodosLosProductosToolStripMenuItem";
            this.mostrarTodosLosProductosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.mostrarTodosLosProductosToolStripMenuItem.Text = "Mostrar todos los productos";
            // 
            // actualizarProductoToolStripMenuItem
            // 
            this.actualizarProductoToolStripMenuItem.Name = "actualizarProductoToolStripMenuItem";
            this.actualizarProductoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.actualizarProductoToolStripMenuItem.Text = "Actualizar producto";
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            // 
            // buscarProductoToolStripMenuItem
            // 
            this.buscarProductoToolStripMenuItem.Name = "buscarProductoToolStripMenuItem";
            this.buscarProductoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.buscarProductoToolStripMenuItem.Text = "Buscar producto";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCatalogoDeFacturasToolStripMenuItem,
            this.nuevaVentaToolStripMenuItem});
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
        private System.Windows.Forms.ToolStripMenuItem actualizarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCatalogoDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
    }
}