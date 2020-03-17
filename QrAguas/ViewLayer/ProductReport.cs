using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            this.produtosTableAdapter.Fill(this._0ybkkaeekeDataSet.produtos);

            
            this.MinimumSize = new Size(700, 550);

            // Faz com que o ReportViewer encontre o relatório 
            RVProdutos.LocalReport.ReportEmbeddedResource = "QrAguas.ViewLayer.Reports.RepProduct.rdlc";

            this.RVProdutos.RefreshReport();
        }

    }
}
