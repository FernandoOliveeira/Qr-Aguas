using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace QrAguas.View_Layer
{
    public partial class ProductReport : Form
    {
        public ProductReport()
        {
            InitializeComponent();
        }

        private void ProductReport_Load(object sender, EventArgs e)
        {
            // Insere os dados dentro do ReportViewer
            this.relatorio_ProdutosTableAdapter.FillRepProduct(this.qraguasDataSet.Relatorio_Produtos);

            // Atribui o valor mínimo para o form
            this.MinimumSize = new Size(700, 300);

            // Faz com que o ReportViewer encontre o relatório 
            RVProdutos.LocalReport.ReportEmbeddedResource = "QrAguas.Reports.RepProduct.rdlc";

            // Atribui o zoom para Tela Inteira ao abrir o relatório
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
