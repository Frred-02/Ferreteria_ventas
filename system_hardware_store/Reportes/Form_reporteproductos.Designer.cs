namespace system_hardware_store
{
    partial class Form_reporteproductos
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
            this.Datosprincipal = new system_hardware_store.Datosprincipal();
            this.buscarproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarproductoTableAdapter = new system_hardware_store.DatosprincipalTableAdapters.buscarproductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Datosprincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarproductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.buscarproductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "system_hardware_store.Reportes.Reportproductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Datosprincipal
            // 
            this.Datosprincipal.DataSetName = "Datosprincipal";
            this.Datosprincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarproductoBindingSource
            // 
            this.buscarproductoBindingSource.DataMember = "buscarproducto";
            this.buscarproductoBindingSource.DataSource = this.Datosprincipal;
            // 
            // buscarproductoTableAdapter
            // 
            this.buscarproductoTableAdapter.ClearBeforeFill = true;
            // 
            // Form_reporteproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_reporteproductos";
            this.Text = "Form_reporteproductos";
            this.Load += new System.EventHandler(this.Form_reporteproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datosprincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarproductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource buscarproductoBindingSource;
        private Datosprincipal Datosprincipal;
        private DatosprincipalTableAdapters.buscarproductoTableAdapter buscarproductoTableAdapter;
    }
}