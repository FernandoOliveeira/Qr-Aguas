namespace QrAguas.View_Layer
{
    partial class ProductReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductReport));
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._0ybkkaeekeDataSet = new QrAguas._0ybkkaeekeDataSet();
            this.produtosTableAdapter = new QrAguas._0ybkkaeekeDataSetTableAdapters.produtosTableAdapter();
            this.RVProdutos = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._0ybkkaeekeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this._0ybkkaeekeDataSet;
            // 
            // _0ybkkaeekeDataSet
            // 
            this._0ybkkaeekeDataSet.DataSetName = "_0ybkkaeekeDataSet";
            this._0ybkkaeekeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // RVProdutos
            // 
            this.RVProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RepProductDataSet";
            reportDataSource1.Value = this.produtosBindingSource;
            this.RVProdutos.LocalReport.DataSources.Add(reportDataSource1);
            this.RVProdutos.LocalReport.ReportEmbeddedResource = "QrAguas.View Layer.Reports.RepProduct.rdlc";
            this.RVProdutos.Location = new System.Drawing.Point(0, 0);
            this.RVProdutos.Name = "RVProdutos";
            this.RVProdutos.ServerReport.BearerToken = null;
            this.RVProdutos.Size = new System.Drawing.Size(804, 512);
            this.RVProdutos.TabIndex = 0;
            // 
            // ProductReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(156)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(804, 512);
            this.Controls.Add(this.RVProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qr Águas - Relatório de Produtos";
            this.Load += new System.EventHandler(this.ProductReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._0ybkkaeekeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private _0ybkkaeekeDataSet _0ybkkaeekeDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private _0ybkkaeekeDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer RVProdutos;
    }
}