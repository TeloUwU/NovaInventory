﻿namespace NovaInventory.Vista
{
    partial class frmCategoria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_categoria = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgb_categoria = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.id_productos = new System.Windows.Forms.TextBox();
            this.dgb_productos = new System.Windows.Forms.DataGridView();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btn_eliminar_prr = new System.Windows.Forms.Button();
            this.btn_actualizar_pr = new System.Windows.Forms.Button();
            this.btn_mostrar_pr = new System.Windows.Forms.Button();
            this.btn_agregar_pr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_productos = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.id_modelos = new System.Windows.Forms.TextBox();
            this.dgb_modelo = new System.Windows.Forms.DataGridView();
            this.cmbproductos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_categoria)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_productos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_modelo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1076, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_categoria);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_actualizar);
            this.groupBox1.Controls.Add(this.btn_mostrar);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.dgb_categoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Location = new System.Drawing.Point(16, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(343, 567);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // id_categoria
            // 
            this.id_categoria.Location = new System.Drawing.Point(7, 17);
            this.id_categoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_categoria.MaxLength = 15;
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.Size = new System.Drawing.Size(29, 22);
            this.id_categoria.TabIndex = 33;
            this.id_categoria.Visible = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(175, 118);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(155, 33);
            this.btn_eliminar.TabIndex = 32;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(12, 118);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(155, 33);
            this.btn_actualizar.TabIndex = 31;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(175, 78);
            this.btn_mostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(155, 33);
            this.btn_mostrar.TabIndex = 30;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(12, 78);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(155, 33);
            this.btn_agregar.TabIndex = 29;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgb_categoria
            // 
            this.dgb_categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgb_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_categoria.Location = new System.Drawing.Point(12, 177);
            this.dgb_categoria.Margin = new System.Windows.Forms.Padding(4);
            this.dgb_categoria.Name = "dgb_categoria";
            this.dgb_categoria.Size = new System.Drawing.Size(317, 374);
            this.dgb_categoria.TabIndex = 28;
            this.dgb_categoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_categoria_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Categoria del producto";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(28, 47);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombre.MaxLength = 15;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(275, 22);
            this.txtnombre.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.id_productos);
            this.groupBox2.Controls.Add(this.dgb_productos);
            this.groupBox2.Controls.Add(this.cmbCategoria);
            this.groupBox2.Controls.Add(this.btn_eliminar_prr);
            this.groupBox2.Controls.Add(this.btn_actualizar_pr);
            this.groupBox2.Controls.Add(this.btn_mostrar_pr);
            this.groupBox2.Controls.Add(this.btn_agregar_pr);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_productos);
            this.groupBox2.Location = new System.Drawing.Point(367, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(339, 567);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // id_productos
            // 
            this.id_productos.Location = new System.Drawing.Point(295, 16);
            this.id_productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_productos.MaxLength = 15;
            this.id_productos.Name = "id_productos";
            this.id_productos.Size = new System.Drawing.Size(29, 22);
            this.id_productos.TabIndex = 35;
            this.id_productos.Visible = false;
            // 
            // dgb_productos
            // 
            this.dgb_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgb_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_productos.Location = new System.Drawing.Point(8, 199);
            this.dgb_productos.Margin = new System.Windows.Forms.Padding(4);
            this.dgb_productos.Name = "dgb_productos";
            this.dgb_productos.Size = new System.Drawing.Size(317, 352);
            this.dgb_productos.TabIndex = 40;
            this.dgb_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_productos_CellClick);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(25, 84);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(275, 24);
            this.cmbCategoria.TabIndex = 39;
            // 
            // btn_eliminar_prr
            // 
            this.btn_eliminar_prr.Location = new System.Drawing.Point(176, 159);
            this.btn_eliminar_prr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar_prr.Name = "btn_eliminar_prr";
            this.btn_eliminar_prr.Size = new System.Drawing.Size(155, 33);
            this.btn_eliminar_prr.TabIndex = 38;
            this.btn_eliminar_prr.Text = "Eliminar";
            this.btn_eliminar_prr.UseVisualStyleBackColor = true;
            this.btn_eliminar_prr.Click += new System.EventHandler(this.btn_eliminar_prr_Click);
            // 
            // btn_actualizar_pr
            // 
            this.btn_actualizar_pr.Location = new System.Drawing.Point(13, 159);
            this.btn_actualizar_pr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actualizar_pr.Name = "btn_actualizar_pr";
            this.btn_actualizar_pr.Size = new System.Drawing.Size(155, 33);
            this.btn_actualizar_pr.TabIndex = 37;
            this.btn_actualizar_pr.Text = "Actualizar";
            this.btn_actualizar_pr.UseVisualStyleBackColor = true;
            this.btn_actualizar_pr.Click += new System.EventHandler(this.btn_actualizar_pr_Click);
            // 
            // btn_mostrar_pr
            // 
            this.btn_mostrar_pr.Location = new System.Drawing.Point(176, 118);
            this.btn_mostrar_pr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mostrar_pr.Name = "btn_mostrar_pr";
            this.btn_mostrar_pr.Size = new System.Drawing.Size(155, 33);
            this.btn_mostrar_pr.TabIndex = 36;
            this.btn_mostrar_pr.Text = "Mostrar";
            this.btn_mostrar_pr.UseVisualStyleBackColor = true;
            this.btn_mostrar_pr.Click += new System.EventHandler(this.btn_mostrar_pr_Click);
            // 
            // btn_agregar_pr
            // 
            this.btn_agregar_pr.Location = new System.Drawing.Point(13, 118);
            this.btn_agregar_pr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar_pr.Name = "btn_agregar_pr";
            this.btn_agregar_pr.Size = new System.Drawing.Size(155, 33);
            this.btn_agregar_pr.TabIndex = 35;
            this.btn_agregar_pr.Text = "Agregar";
            this.btn_agregar_pr.UseVisualStyleBackColor = true;
            this.btn_agregar_pr.Click += new System.EventHandler(this.btn_agregar_pr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "Productos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_productos
            // 
            this.txt_productos.Location = new System.Drawing.Point(25, 47);
            this.txt_productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_productos.MaxLength = 15;
            this.txt_productos.Name = "txt_productos";
            this.txt_productos.Size = new System.Drawing.Size(275, 22);
            this.txt_productos.TabIndex = 33;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.id_modelos);
            this.groupBox3.Controls.Add(this.dgb_modelo);
            this.groupBox3.Controls.Add(this.cmbproductos);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt);
            this.groupBox3.Location = new System.Drawing.Point(713, 34);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(339, 567);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // id_modelos
            // 
            this.id_modelos.Location = new System.Drawing.Point(295, 16);
            this.id_modelos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_modelos.MaxLength = 15;
            this.id_modelos.Name = "id_modelos";
            this.id_modelos.Size = new System.Drawing.Size(29, 22);
            this.id_modelos.TabIndex = 34;
            // 
            // dgb_modelo
            // 
            this.dgb_modelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgb_modelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_modelo.Location = new System.Drawing.Point(8, 199);
            this.dgb_modelo.Margin = new System.Windows.Forms.Padding(4);
            this.dgb_modelo.Name = "dgb_modelo";
            this.dgb_modelo.Size = new System.Drawing.Size(317, 352);
            this.dgb_modelo.TabIndex = 48;
            this.dgb_modelo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_modelo_CellClick);
            // 
            // cmbproductos
            // 
            this.cmbproductos.FormattingEnabled = true;
            this.cmbproductos.Location = new System.Drawing.Point(25, 84);
            this.cmbproductos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbproductos.Name = "cmbproductos";
            this.cmbproductos.Size = new System.Drawing.Size(275, 24);
            this.cmbproductos.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 33);
            this.button1.TabIndex = 46;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 159);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 33);
            this.button2.TabIndex = 45;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 118);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 33);
            this.button3.TabIndex = 44;
            this.button3.Text = "Mostrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 118);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 33);
            this.button4.TabIndex = 43;
            this.button4.Text = "Agregar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Modelo del producto";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(25, 47);
            this.txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt.MaxLength = 15;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(275, 22);
            this.txt.TabIndex = 41;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(978, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 21);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "English";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 617);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_categoria)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_productos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_modelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgb_categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgb_productos;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btn_eliminar_prr;
        private System.Windows.Forms.Button btn_actualizar_pr;
        private System.Windows.Forms.Button btn_mostrar_pr;
        private System.Windows.Forms.Button btn_agregar_pr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_productos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgb_modelo;
        private System.Windows.Forms.ComboBox cmbproductos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox id_categoria;
        private System.Windows.Forms.TextBox id_productos;
        private System.Windows.Forms.TextBox id_modelos;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}