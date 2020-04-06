namespace QrAguas.ViewLayer
{
    partial class ReportProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportProvider));
            this.relatorioFornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qraguasDataSet = new QrAguas.qraguasDataSet();
            this.RVFornecedores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relatorio_FornecedoresTableAdapter = new QrAguas.qraguasDataSetTableAdapters.Relatorio_FornecedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioFornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qraguasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // relatorioFornecedoresBindingSource
            // 
            this.relatorioFornecedoresBindingSource.DataMember = "Relatorio_Fornecedores";
            this.relatorioFornecedoresBindingSource.DataSource = this.qraguasDataSet;
            // 
            // qraguasDataSet
            // 
            this.qraguasDataSet.DataSetName = "qraguasDataSet";
            this.qraguasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RVFornecedores
            // 
            this.RVFornecedores.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RepProviderDataSet";
            reportDataSource1.Value = this.relatorioFornecedoresBindingSource;
            this.RVFornecedores.LocalReport.DataSources.Add(reportDataSource1);
            this.RVFornecedores.LocalReport.ReportEmbeddedResource = "QrAguas.Reports.RepProvider.rdlc";
            this.RVFornecedores.Location = new System.Drawing.Point(0, 0);
            this.RVFornecedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RVFornecedores.Name = "RVFornecedores";
            this.RVFornecedores.ServerReport.BearerToken = null;
            this.RVFornecedores.Size = new System.Drawing.Size(1134, 512);
            this.RVFornecedores.TabIndex = 0;
            // 
            // relatorio_FornecedoresTableAdapter
            // 
            this.relatorio_FornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // ReportProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 512);
            this.Controls.Add(this.RVFornecedores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qr Águas - Relatório de Fornecedores";
            this.Load += new System.EventHandler(this.ReportProvider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioFornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qraguasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVFornecedores;
        private qraguasDataSet qraguasDataSet;
        private System.Windows.Forms.BindingSource relatorioFornecedoresBindingSource;
        private qraguasDataSetTableAdapters.Relatorio_FornecedoresTableAdapter relatorio_FornecedoresTableAdapter;
    }
}