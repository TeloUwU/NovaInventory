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
            this.cbEstado_Bodega = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvBodegas = new System.Windows.Forms.DataGridView();
            this.dtpBodegaCreación = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fecha = new System.Windows.Forms.Label();
            this.txt_creado_por = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
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
            this.toolStrip1.Size = new System.Drawing.Size(783, 27);
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
            this.toolStripButton1.Size = new System.Drawing.Size(133, 24);
            this.toolStripButton1.Text = "Gestion de Bodegas";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::NovaInventory.Properties.Resources.undo_26px;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(141, 24);
            this.toolStripButton2.Text = "Cerrar Formulario";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dirección";
            // 
            // txtId_Bodega
            // 
            this.txtId_Bodega.Location = new System.Drawing.Point(758, 27);
            this.txtId_Bodega.Margin = new System.Windows.Forms.Padding(2);
            this.txtId_Bodega.Name = "txtId_Bodega";
            this.txtId_Bodega.Size = new System.Drawing.Size(20, 20);
            this.txtId_Bodega.TabIndex = 0;
            this.txtId_Bodega.Visible = false;
            // 
            // txtNombre_Bodega
            // 
            this.txtNombre_Bodega.Location = new System.Drawing.Point(55, 140);
            this.txtNombre_Bodega.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre_Bodega.MaxLength = 15;
            this.txtNombre_Bodega.Name = "txtNombre_Bodega";
            this.txtNombre_Bodega.Size = new System.Drawing.Size(176, 20);
            this.txtNombre_Bodega.TabIndex = 2;
            // 
            // txtCodigo_Bodega
            // 
            this.txtCodigo_Bodega.Location = new System.Drawing.Point(55, 70);
            this.txtCodigo_Bodega.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo_Bodega.MaxLength = 5;
            this.txtCodigo_Bodega.Name = "txtCodigo_Bodega";
            this.txtCodigo_Bodega.Size = new System.Drawing.Size(176, 20);
            this.txtCodigo_Bodega.TabIndex = 1;
            this.txtCodigo_Bodega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_Bodega_KeyPress);
            // 
            // txtDirección
            // 
            this.txtDirección.Location = new System.Drawing.Point(546, 84);
            this.txtDirección.Margin = new System.Windows.Forms.Padding(2);
            this.txtDirección.MaxLength = 20;
            this.txtDirección.Multiline = true;
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(200, 76);
            this.txtDirección.TabIndex = 5;
            // 
            // cbEstado_Bodega
            // 
            this.cbEstado_Bodega.FormattingEnabled = true;
            this.cbEstado_Bodega.Location = new System.Drawing.Point(287, 70);
            this.cbEstado_Bodega.Margin = new System.Windows.Forms.Padding(2);
            this.cbEstado_Bodega.Name = "cbEstado_Bodega";
            this.cbEstado_Bodega.Size = new System.Drawing.Size(176, 21);
            this.cbEstado_Bodega.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo de Bodega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 181);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar Bodega";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 181);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ver Bodega";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(407, 181);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 53);
            this.button3.TabIndex = 9;
            this.button3.Text = "Actualizar Bodega";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(584, 181);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 53);
            this.button4.TabIndex = 10;
            this.button4.Text = "Eliminar Bodega";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.dgvBodegas.Location = new System.Drawing.Point(20, 252);
            this.dgvBodegas.Margin = new System.Windows.Forms.Padding(2);
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
            this.dgvBodegas.Size = new System.Drawing.Size(743, 266);
            this.dgvBodegas.TabIndex = 6;
            this.dgvBodegas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBodegas_CellClick);
            // 
            // dtpBodegaCreación
            // 
            this.dtpBodegaCreación.Location = new System.Drawing.Point(670, 27);
            this.dtpBodegaCreación.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBodegaCreación.Name = "dtpBodegaCreación";
            this.dtpBodegaCreación.Size = new System.Drawing.Size(41, 20);
            this.dtpBodegaCreación.TabIndex = 0;
            this.dtpBodegaCreación.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(614, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(293, 110);
            this.fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(78, 19);
            this.fecha.TabIndex = 12;
            this.fecha.Text = "creado por";
            // 
            // txt_creado_por
            // 
            this.txt_creado_por.Enabled = false;
            this.txt_creado_por.Location = new System.Drawing.Point(287, 140);
            this.txt_creado_por.Margin = new System.Windows.Forms.Padding(2);
            this.txt_creado_por.Name = "txt_creado_por";
            this.txt_creado_por.Size = new System.Drawing.Size(176, 20);
            this.txt_creado_por.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(420, 27);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 26);
            this.button5.TabIndex = 14;
            this.button5.Text = "reporte";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmBodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 540);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txt_creado_por);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvBodegas);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEstado_Bodega);
            this.Controls.Add(this.txtDirección);
            this.Controls.Add(this.txtCodigo_Bodega);
            this.Controls.Add(this.txtNombre_Bodega);
            this.Controls.Add(this.txtId_Bodega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ComboBox cbEstado_Bodega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvBodegas;
        private System.Windows.Forms.DateTimePicker dtpBodegaCreación;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.TextBox txt_creado_por;
        private System.Windows.Forms.Button button5;
    }
}