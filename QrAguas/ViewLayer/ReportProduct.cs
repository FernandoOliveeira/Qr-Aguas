using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace QrAguas.ViewLayer
{
    public partial class ReportProduct : Form
    {
        public ReportProduct()
        {
            InitializeComponent();
        }

        private void ReportProduct_Load(object sender, EventArgs e)
        {
            // Insere os dados dentro do ReportViewer
            this.relatorio_ProdutosTableAdapter.FillRepProduct(this.qraguasDataSet.Relatorio_Produtos);

            // Atribui o valor mínimo para o form
            this.MinimumSize = new Size(700, 300);

            // Faz com que o ReportViewer encontre o relatório 
            RVProdutos.LocalReport.ReportEmbeddedResource = "QrAguas.Reports.RepProduct.rdlc";

            // Atribui o zoom ao abrir o relatório
            RVProdutos.ZoomMode = ZoomMode.Percent;

            // Desabiliata a opção de exportar para PDF
            DesabilitarFormatoExportacao(RVProdutos, "PDF");

            // Atualiza o relatório
            this.RVProdutos.RefreshReport();
        }

        private void DesabilitarFormatoExportacao(ReportViewer ReportViewerID, string nomeFormato)
        {
            FieldInfo info;

            foreach (RenderingExtension extension in ReportViewerID.LocalReport.ListRenderingExtensions())
            {
                if (extension.Name.Equals(nomeFormato))
                {
                    info = extension.GetType().GetField("m_isVisible", BindingFlags.Instance | BindingFlags.NonPublic);
                    info.SetValue(extension, false);

                }
            }
        }

    }
}
