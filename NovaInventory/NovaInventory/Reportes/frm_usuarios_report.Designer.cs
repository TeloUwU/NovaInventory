namespace NovaInventory.Reportes
{
    partial class frm_usuarios_report
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
            this.data_usu = new NovaInventory.Reportes.data_usu();
            this.DataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableTableAdapter = new NovaInventory.Reportes.data_usuTableAdapters.DataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.data_usu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "usuario_report";
            reportDataSource1.Value = this.DataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NovaInventory.Reportes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(961, 504);
            this.reportViewer1.TabIndex = 0;
            // 
            // data_usu
            // 
            this.data_usu.DataSetName = "data_usu";
            this.data_usu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableBindingSource
            // 
            this.DataTableBindingSource.DataMember = "DataTable";
            this.DataTableBindingSource.DataSource = this.data_usu;
            // 
            // DataTableTableAdapter
            // 
            this.DataTableTableAdapter.ClearBeforeFill = true;
            // 
            // frm_usuarios_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 510);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_usuarios_report";
            this.Text = "frm_usuarios_report";
            this.Load += new System.EventHandler(this.frm_usuarios_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_usu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableBindingSource;
        private data_usu data_usu;
        private data_usuTableAdapters.DataTableTableAdapter DataTableTableAdapter;
    }
}