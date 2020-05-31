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
    public partial class ReportSells : Form
    {
        public ReportSells()
        {
            InitializeComponent();
        }

        private void ReportSells_Load(object sender, EventArgs e)
        {
            // Tamanho mínimo do form
            this.MinimumSize = new Size(1150, 550);

            // Código para que a data final não seja menor que a data inicial
            DTPFim.MinDate = DTPInicio.Value;

            // Desabilita a navegação por páginas no ReportViewer pelo Mouse Wheel
            DisableWheelNavigation(RVVendas);

            // Faz com que o ReportViewer encontre o relatório
            RVVendas.LocalReport.ReportEmbeddedResource = "QrAguas.Reports.RepSells.rdlc";

            // Atribui o zoom ao abrir o relatório
            RVVendas.ZoomMode = ZoomMode.PageWidth;

            // Desabilita a opção de exportar para PDF
            DesabilitarFormatoExportacao(RVVendas, "PDF");

            // Atualiza o ReportViewer
            this.RVVendas.RefreshReport();
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            string dataInicio = DTPInicio.Value.Date.ToString("d") + " 00:00:00";

            string dataFim = DTPFim.Value.Date.ToString("d") + " 23:59:59";

            // Insere os dados no ReportViewer
            this.reportSellsTableAdapter.FillReportSells(this.qrAguasRemoteDBDataSet.ReportSells, DateTime.Parse(dataInicio), DateTime.Parse(dataFim));

            // Atualiza o ReportViewer
            this.RVVendas.RefreshReport();
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

        private void DTPInicio_ValueChanged(object sender, EventArgs e)
        {
            // Código para que a data final não seja menor que a data inicial
            DTPFim.MinDate = DTPInicio.Value;
        }

        #region Código para desabilitar a navegação por páginas no ReportViewer pelo Mouse Wheel
        public void DisableWheelNavigation(ReportViewer r)
        {
            bool fromToolbar = false;
            r.PageNavigation += (obj, ea) => {
                if (fromToolbar) fromToolbar = false;
                else ea.Cancel = true;
            };
            var buttons = new string[] { "firstPage", "previousPage", "nextPage", "lastPage" };
            var toolstrip = r.Controls.Find("toolStrip1", true).OfType<ToolStrip>().First();
            toolstrip.Items.OfType<ToolStripButton>()
                .Where(button => buttons.Contains(button.Name)).ToList().ForEach(item => {
                    var clickEvent = item.GetType().GetEvent("Click");
                    var removeMethod = clickEvent.GetRemoveMethod();
                    var d = Delegate.CreateDelegate(clickEvent.EventHandlerType,
                        toolstrip.Parent, "OnPageNavButtonClick");
                    removeMethod.Invoke(item, new object[] { d });
                    item.Click += (obj, ev) => {
                        var onPageNavigation = toolstrip.Parent.GetType()
                            .GetMethod("OnPageNavigation",
                        BindingFlags.NonPublic | BindingFlags.Instance);
                        Action<int> OnPageNavigation = i => {
                            fromToolbar = true;
                            onPageNavigation.Invoke(toolstrip.Parent, new object[] { i });
                        };
                        if (item.Name == "firstPage") OnPageNavigation(1);
                        else if (item.Name == "previousPage") OnPageNavigation(r.CurrentPage - 1);
                        else if (item.Name == "nextPage") OnPageNavigation(r.CurrentPage + 1);
                        else if (item.Name == "lastPage")
                        {
                            PageCountMode mode;
                            int totalPages = r.GetTotalPages(out mode);
                            if (mode != PageCountMode.Actual) OnPageNavigation(0x7fffffff);
                            else OnPageNavigation(totalPages);
                        }
                    };
                });
        }
        #endregion

    }
}
