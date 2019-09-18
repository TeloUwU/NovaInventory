namespace NovaInventory.Reportes
{
    partial class reportes_prov
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbproveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_proveedor = new NovaInventory.Reportes.DataSet_proveedor();
            this.dataSet_proveedor1 = new NovaInventory.Reportes.DataSet_proveedor();
            this.tbproveedorTableAdapter = new NovaInventory.Reportes.DataSet_proveedorTableAdapters.tbproveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbproveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_proveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_proveedor1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbproveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NovaInventory.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(862, 475);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbproveedorBindingSource
            // 
            this.tbproveedorBindingSource.DataMember = "tbproveedor";
            this.tbproveedorBindingSource.DataSource = this.DataSet_proveedor;
            // 
            // DataSet_proveedor
            // 
            this.DataSet_proveedor.DataSetName = "DataSet_proveedor";
            this.DataSet_proveedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet_proveedor1
            // 
            this.dataSet_proveedor1.DataSetName = "DataSet_proveedor";
            this.dataSet_proveedor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbproveedorTableAdapter
            // 
            this.tbproveedorTableAdapter.ClearBeforeFill = true;
            // 
            // reportes_prov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 475);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportes_prov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reportes_prov";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reportes_prov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbproveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_proveedor1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet_proveedor dataSet_proveedor1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbproveedorBindingSource;
        private DataSet_proveedor DataSet_proveedor;
        private DataSet_proveedorTableAdapters.tbproveedorTableAdapter tbproveedorTableAdapter;
    }
}