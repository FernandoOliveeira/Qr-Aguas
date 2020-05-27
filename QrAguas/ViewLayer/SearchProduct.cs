using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrAguas.ViewLayer
{
    public partial class SearchProduct : Form
    {
        public SearchProduct()
        {
            InitializeComponent();
        }

        private void SearchProduct_Load(object sender, EventArgs e)
        {
            // Tamanho minimo do form
            this.MinimumSize = new Size(1050, 500);

            // Insere os dados no DGVProdutos
            this.searchProductDGVProdutosTableAdapter.Fill(this.qrAguasRemoteDBDataSet.SearchProductDGVProdutos);
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            // Realiza a busca e exibe os produtos no DataGrigView com base no que foi digitado pelo usuário
            this.searchProductDGVProdutosTableAdapter.FillByNomeProduto(this.qrAguasRemoteDBDataSet.SearchProductDGVProdutos, "%" + txtFornecedor.Text.Trim() + "%");
        }
    }
}
