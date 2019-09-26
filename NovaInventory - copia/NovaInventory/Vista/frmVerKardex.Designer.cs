namespace NovaInventory.Vista
{
    partial class frmVerKardex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerKardex));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.dgvExistencias = new System.Windows.Forms.DataGridView();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).BeginInit();
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
            this.toolStripButton1.Size = new System.Drawing.Size(126, 24);
            this.toolStripButton1.Text = "Visualizar Kardex";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo";
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Location = new System.Drawing.Point(55, 130);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.RowTemplate.Height = 24;
            this.dgvEntradas.Size = new System.Drawing.Size(300, 504);
            this.dgvEntradas.TabIndex = 4;
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidas.Location = new System.Drawing.Point(361, 130);
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.RowTemplate.Height = 24;
            this.dgvSalidas.Size = new System.Drawing.Size(326, 504);
            this.dgvSalidas.TabIndex = 5;
            // 
            // dgvExistencias
            // 
            this.dgvExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistencias.Location = new System.Drawing.Point(693, 130);
            this.dgvExistencias.Name = "dgvExistencias";
            this.dgvExistencias.RowTemplate.Height = 24;
            this.dgvExistencias.Size = new System.Drawing.Size(292, 504);
            this.dgvExistencias.TabIndex = 6;
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(114, 76);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(121, 24);
            this.cbProducto.TabIndex = 8;
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(283, 76);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(121, 24);
            this.cbModelo.TabIndex = 9;
            // 
            // frmVerKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 665);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.dgvExistencias);
            this.Controls.Add(this.dgvSalidas);
            this.Controls.Add(this.dgvEntradas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerKardex";
            this.Text = "frmVerKardex";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.DataGridView dgvSalidas;
        private System.Windows.Forms.DataGridView dgvExistencias;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbModelo;
    }
}