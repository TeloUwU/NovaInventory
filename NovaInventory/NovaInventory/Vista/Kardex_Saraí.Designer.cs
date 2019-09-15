namespace NovaInventory.Vista
{
    partial class Kardex_Saraí
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
            this.tbKardex = new System.Windows.Forms.Button();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.dgvComprasProducto = new System.Windows.Forms.DataGridView();
            this.dgvVentasProducto = new System.Windows.Forms.DataGridView();
            this.dgvExistenciasProducto = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistenciasProducto)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1044, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::NovaInventory.Properties.Resources.cancel_button1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 24);
            this.toolStripLabel1.Text = "Kardex";
            // 
            // tbKardex
            // 
            this.tbKardex.Location = new System.Drawing.Point(602, 83);
            this.tbKardex.Name = "tbKardex";
            this.tbKardex.Size = new System.Drawing.Size(221, 50);
            this.tbKardex.TabIndex = 1;
            this.tbKardex.Text = "Buscar Kardex de Producto";
            this.tbKardex.UseVisualStyleBackColor = true;
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(236, 97);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(310, 24);
            this.cbProductos.TabIndex = 2;
            // 
            // dgvComprasProducto
            // 
            this.dgvComprasProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasProducto.Location = new System.Drawing.Point(56, 167);
            this.dgvComprasProducto.Name = "dgvComprasProducto";
            this.dgvComprasProducto.RowTemplate.Height = 24;
            this.dgvComprasProducto.Size = new System.Drawing.Size(297, 374);
            this.dgvComprasProducto.TabIndex = 3;
            // 
            // dgvVentasProducto
            // 
            this.dgvVentasProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasProducto.Location = new System.Drawing.Point(357, 167);
            this.dgvVentasProducto.Name = "dgvVentasProducto";
            this.dgvVentasProducto.RowTemplate.Height = 24;
            this.dgvVentasProducto.Size = new System.Drawing.Size(297, 374);
            this.dgvVentasProducto.TabIndex = 4;
            // 
            // dgvExistenciasProducto
            // 
            this.dgvExistenciasProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistenciasProducto.Location = new System.Drawing.Point(660, 167);
            this.dgvExistenciasProducto.Name = "dgvExistenciasProducto";
            this.dgvExistenciasProducto.RowTemplate.Height = 24;
            this.dgvExistenciasProducto.Size = new System.Drawing.Size(297, 374);
            this.dgvExistenciasProducto.TabIndex = 5;
            // 
            // Kardex_Saraí
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1044, 665);
            this.Controls.Add(this.dgvExistenciasProducto);
            this.Controls.Add(this.dgvVentasProducto);
            this.Controls.Add(this.dgvComprasProducto);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.tbKardex);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Kardex_Saraí";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Kardex";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistenciasProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button tbKardex;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.DataGridView dgvComprasProducto;
        private System.Windows.Forms.DataGridView dgvVentasProducto;
        private System.Windows.Forms.DataGridView dgvExistenciasProducto;
    }
}