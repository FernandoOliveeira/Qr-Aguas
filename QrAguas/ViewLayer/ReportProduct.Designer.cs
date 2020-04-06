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
            this.qraguasDataSet = new QrAguas.qraguasDataSet();
            this.relatorioProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorio_ProdutosTableAdapter = new QrAguas.qraguasDataSetTableAdapters.Relatorio_ProdutosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qraguasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioProdutosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RVProdutos
            // 
            this.RVProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RepProductDataSet";
            reportDataSource1.Value = this.relatorioProdutosBindingSource;
            this.RVProdutos.LocalReport.DataSources.Add(reportDataSource1);
            this.RVProdutos.LocalReport.ReportEmbeddedResource = "QrAguas.Reports.RepProduct.rdlc";
            this.RVProdutos.Location = new System.Drawing.Point(0, 0);
            this.RVProdutos.Name = "RVProdutos";
            this.RVProdutos.ServerReport.BearerToken = null;
            this.RVProdutos.Size = new System.Drawing.Size(1134, 512);
            this.RVProdutos.TabIndex = 1;
            // 
            // qraguasDataSet
            // 
            this.qraguasDataSet.DataSetName = "qraguasDataSet";
            this.qraguasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorioProdutosBindingSource
            // 
            this.relatorioProdutosBindingSource.DataMember = "Relatorio_Produtos";
            this.relatorioProdutosBindingSource.DataSource = this.qraguasDataSet;
            // 
            // relatorio_ProdutosTableAdapter
            // 
            this.relatorio_ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // ReportProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 512);
            this.Controls.Add(this.RVProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qr Águas - Relatório de Produtos";
            this.Load += new System.EventHandler(this.ReportProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qraguasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioProdutosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVProdutos;
        private qraguasDataSet qraguasDataSet;
        private System.Windows.Forms.BindingSource relatorioProdutosBindingSource;
        private qraguasDataSetTableAdapters.Relatorio_ProdutosTableAdapter relatorio_ProdutosTableAdapter;
    }
}