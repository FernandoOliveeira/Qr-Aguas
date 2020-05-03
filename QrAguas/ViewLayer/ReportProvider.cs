using Microsoft.Reporting.WinForms;
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

namespace QrAguas.ViewLayer
{
    public partial class ReportProvider : Form
    {
        public ReportProvider()
        {
            InitializeComponent();
        }

        private void ReportProvider_Load(object sender, EventArgs e)
        {
            // Insere dentro do ReportViewer
            this.reportProviderTableAdapter.FillReportProvider(this.qrAguasRemoteDBDataSet.ReportProvider);
            
            // Faz com que o ReportViewer encontre o relatório
            RVFornecedores.LocalReport.ReportEmbeddedResource = "QrAguas.Reports.RepProvider.rdlc";

            // Atribui o zoom ao abrir o relatório
            RVFornecedores.ZoomMode = ZoomMode.Percent;

            // Desabilita a opção de exportar para PDF
            DesabilitarFormatoExportacao(RVFornecedores, "PDF");

            this.RVFornecedores.RefreshReport();
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
