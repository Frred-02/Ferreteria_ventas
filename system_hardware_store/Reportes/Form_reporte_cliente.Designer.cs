namespace system_hardware_store
{
    partial class Form_reporte_cliente
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
            this.buscarcliente_apellidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarcliente_apellidosTableAdapter = new system_hardware_store.DatosprincipalTableAdapters.buscarcliente_apellidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Datosprincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarcliente_apellidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.buscarcliente_apellidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "system_hardware_store.Reportes.Reporte_cliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1613, 828);
            this.reportViewer1.TabIndex = 0;
            // 
            // Datosprincipal
            // 
            this.Datosprincipal.DataSetName = "Datosprincipal";
            this.Datosprincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarcliente_apellidosBindingSource
            // 
            this.buscarcliente_apellidosBindingSource.DataMember = "buscarcliente_apellidos";
            this.buscarcliente_apellidosBindingSource.DataSource = this.Datosprincipal;
            // 
            // buscarcliente_apellidosTableAdapter
            // 
            this.buscarcliente_apellidosTableAdapter.ClearBeforeFill = true;
            // 
            // Form_reporte_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 828);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_reporte_cliente";
            this.Text = "Form_reporte_cliente";
            this.Load += new System.EventHandler(this.Form_reporte_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datosprincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarcliente_apellidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource buscarcliente_apellidosBindingSource;
        private Datosprincipal Datosprincipal;
        private DatosprincipalTableAdapters.buscarcliente_apellidosTableAdapter buscarcliente_apellidosTableAdapter;
    }
}