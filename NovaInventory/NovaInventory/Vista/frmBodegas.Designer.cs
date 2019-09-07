namespace NovaInventory.Vista
{
    partial class frmBodegas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBodegas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId_Bodega = new System.Windows.Forms.TextBox();
            this.txtNombre_Bodega = new System.Windows.Forms.TextBox();
            this.txtCodigo_Bodega = new System.Windows.Forms.TextBox();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.dtpAltaBaja = new System.Windows.Forms.DateTimePicker();
            this.dtpBodegaCreación = new System.Windows.Forms.DateTimePicker();
            this.cbEstado_Bodega = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAltaOBaja = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvBodegas = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodegas)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1044, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(166, 27);
            this.toolStripButton1.Text = "Gestion de Bodegas";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::NovaInventory.Properties.Resources.undo_26px;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(172, 27);
            this.toolStripButton2.Text = "Cerrar Formulario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(708, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dirección";
            // 
            // txtId_Bodega
            // 
            this.txtId_Bodega.Location = new System.Drawing.Point(1011, 33);
            this.txtId_Bodega.Name = "txtId_Bodega";
            this.txtId_Bodega.Size = new System.Drawing.Size(26, 22);
            this.txtId_Bodega.TabIndex = 0;
            this.txtId_Bodega.Visible = false;
            // 
            // txtNombre_Bodega
            // 
            this.txtNombre_Bodega.Location = new System.Drawing.Point(73, 172);
            this.txtNombre_Bodega.Name = "txtNombre_Bodega";
            this.txtNombre_Bodega.Size = new System.Drawing.Size(233, 22);
            this.txtNombre_Bodega.TabIndex = 2;
            // 
            // txtCodigo_Bodega
            // 
            this.txtCodigo_Bodega.Location = new System.Drawing.Point(73, 86);
            this.txtCodigo_Bodega.Name = "txtCodigo_Bodega";
            this.txtCodigo_Bodega.Size = new System.Drawing.Size(233, 22);
            this.txtCodigo_Bodega.TabIndex = 1;
            // 
            // txtDirección
            // 
            this.txtDirección.Location = new System.Drawing.Point(712, 86);
            this.txtDirección.Multiline = true;
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(233, 110);
            this.txtDirección.TabIndex = 5;
            // 
            // dtpAltaBaja
            // 
            this.dtpAltaBaja.Location = new System.Drawing.Point(952, 33);
            this.dtpAltaBaja.Name = "dtpAltaBaja";
            this.dtpAltaBaja.Size = new System.Drawing.Size(53, 22);
            this.dtpAltaBaja.TabIndex = 0;
            this.dtpAltaBaja.Visible = false;
            // 
            // dtpBodegaCreación
            // 
            this.dtpBodegaCreación.Location = new System.Drawing.Point(893, 33);
            this.dtpBodegaCreación.Name = "dtpBodegaCreación";
            this.dtpBodegaCreación.Size = new System.Drawing.Size(53, 22);
            this.dtpBodegaCreación.TabIndex = 0;
            this.dtpBodegaCreación.Visible = false;
            // 
            // cbEstado_Bodega
            // 
            this.cbEstado_Bodega.FormattingEnabled = true;
            this.cbEstado_Bodega.Location = new System.Drawing.Point(397, 86);
            this.cbEstado_Bodega.Name = "cbEstado_Bodega";
            this.cbEstado_Bodega.Size = new System.Drawing.Size(233, 24);
            this.cbEstado_Bodega.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo de Bodega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // cbAltaOBaja
            // 
            this.cbAltaOBaja.FormattingEnabled = true;
            this.cbAltaOBaja.Location = new System.Drawing.Point(397, 172);
            this.cbAltaOBaja.Name = "cbAltaOBaja";
            this.cbAltaOBaja.Size = new System.Drawing.Size(233, 24);
            this.cbAltaOBaja.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Uso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar Bodega";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 65);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ver Bodega";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(521, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 65);
            this.button3.TabIndex = 9;
            this.button3.Text = "Actualizar Bodega";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(758, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 65);
            this.button4.TabIndex = 10;
            this.button4.Text = "Eliminar Bodega";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvBodegas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBodegas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBodegas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBodegas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBodegas.Location = new System.Drawing.Point(27, 310);
            this.dgvBodegas.Name = "dgvBodegas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBodegas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBodegas.RowTemplate.Height = 24;
            this.dgvBodegas.Size = new System.Drawing.Size(991, 328);
            this.dgvBodegas.TabIndex = 6;
            // 
            // frmBodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 665);
            this.Controls.Add(this.dgvBodegas);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAltaOBaja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEstado_Bodega);
            this.Controls.Add(this.dtpBodegaCreación);
            this.Controls.Add(this.dtpAltaBaja);
            this.Controls.Add(this.txtDirección);
            this.Controls.Add(this.txtCodigo_Bodega);
            this.Controls.Add(this.txtNombre_Bodega);
            this.Controls.Add(this.txtId_Bodega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBodegas";
            this.Text = "frmBodegas";
            this.Load += new System.EventHandler(this.frmBodegas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodegas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId_Bodega;
        private System.Windows.Forms.TextBox txtNombre_Bodega;
        private System.Windows.Forms.TextBox txtCodigo_Bodega;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.DateTimePicker dtpAltaBaja;
        private System.Windows.Forms.DateTimePicker dtpBodegaCreación;
        private System.Windows.Forms.ComboBox cbEstado_Bodega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAltaOBaja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvBodegas;
    }
}