namespace NovaInventory.Reportes
{
    partial class frm_reporte_prov
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
            this.DataSet4 = new NovaInventory.Reportes.DataSet4();
            this.DataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableTableAdapter = new NovaInventory.Reportes.DataSet4TableAdapters.DataTableTableAdapter();
            this.DataSet1 = new NovaInventory.Reportes.DataSet1();
            this.tbProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProveedorTableAdapter = new NovaInventory.Reportes.DataSet1TableAdapters.tbProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbProveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NovaInventory.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(975, 498);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet4
            // 
            this.DataSet4.DataSetName = "DataSet4";
            this.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableBindingSource
            // 
            this.DataTableBindingSource.DataMember = "DataTable";
            this.DataTableBindingSource.DataSource = this.DataSet4;
            // 
            // DataTableTableAdapter
            // 
            this.DataTableTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProveedorBindingSource
            // 
            this.tbProveedorBindingSource.DataMember = "tbProveedor";
            this.tbProveedorBindingSource.DataSource = this.DataSet1;
            // 
            // tbProveedorTableAdapter
            // 
            this.tbProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // frm_reporte_prov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 497);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_reporte_prov";
            this.Text = "frm_reporte_prov";
            this.Load += new System.EventHandler(this.frm_reporte_prov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableBindingSource;
        private DataSet4 DataSet4;
        private DataSet4TableAdapters.DataTableTableAdapter DataTableTableAdapter;
        private System.Windows.Forms.BindingSource tbProveedorBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.tbProveedorTableAdapter tbProveedorTableAdapter;
    }
}