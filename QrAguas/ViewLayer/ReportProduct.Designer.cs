namespace QrAguas.ViewLayer
{
    partial class ReportProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportProduct));
            this.RVProdutos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qrAguasRemoteDBDataSet = new QrAguas.QrAguasRemoteDBDataSet();
            this.reportProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportProductTableAdapter = new QrAguas.QrAguasRemoteDBDataSetTableAdapters.ReportProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qrAguasRemoteDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RVProdutos
            // 
            this.RVProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RepProductDataSet";
            reportDataSource1.Value = this.reportProductBindingSource;
            this.RVProdutos.LocalReport.DataSources.Add(reportDataSource1);
            this.RVProdutos.LocalReport.ReportEmbeddedResource = "QrAguas.Reports.RepProduct.rdlc";
            this.RVProdutos.Location = new System.Drawing.Point(0, 0);
            this.RVProdutos.Name = "RVProdutos";
            this.RVProdutos.ServerReport.BearerToken = null;
            this.RVProdutos.Size = new System.Drawing.Size(1134, 512);
            this.RVProdutos.TabIndex = 1;
            // 
            // qrAguasRemoteDBDataSet
            // 
            this.qrAguasRemoteDBDataSet.DataSetName = "QrAguasRemoteDBDataSet";
            this.qrAguasRemoteDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportProductBindingSource
            // 
            this.reportProductBindingSource.DataMember = "ReportProduct";
            this.reportProductBindingSource.DataSource = this.qrAguasRemoteDBDataSet;
            // 
            // reportProductTableAdapter
            // 
            this.reportProductTableAdapter.ClearBeforeFill = true;
            // 
            // ReportProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 512);
            this.Controls.Add(this.RVProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qr Águas - Relatório de Produtos";
            this.Load += new System.EventHandler(this.ReportProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrAguasRemoteDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVProdutos;
        private QrAguasRemoteDBDataSet qrAguasRemoteDBDataSet;
        private System.Windows.Forms.BindingSource reportProductBindingSource;
        private QrAguasRemoteDBDataSetTableAdapters.ReportProductTableAdapter reportProductTableAdapter;
    }
}